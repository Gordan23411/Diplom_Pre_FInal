﻿using HealthCare_Plus.Models;
using HealthCare_Plus.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HealthCare_Plus.Forms.Dashboard.Admin
{
    public partial class DoctorsForm : Form
    {
        //VARIABLES
        Doctor doctor;
        Int64 selectedUserID;
        DBCon dBCon = new DBCon();
        bool isSelectedUser = false;

        public DoctorsForm()
        {
            InitializeComponent();
        }

        //ONLOAD FUNCTION
        private void DoctorsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "healthcareplusDataSet1.DoctorProfiles". При необходимости она может быть перемещена или удалена.
            this.doctorProfilesTableAdapter1.Fill(this.healthcareplusDataSet1.DoctorProfiles);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "healthcareplusDataSet.DoctorProfiles". При необходимости она может быть перемещена или удалена.
            this.doctorProfilesTableAdapter.Fill(this.healthcareplusDataSet.DoctorProfiles);
            LoadDoctorDataFromDB();
            update_doc_btn.Enabled = false;
            delete_btn.Enabled = false;
        }

        //LOAD DOCTOR DATA INTO DATAGRIDVIEW
        private void LoadDoctorDataFromDB()
        {
            SqlConnection sqlCon = dBCon.SqlConnection;
            try
            {
                string query =
                    "SELECT Users.id, Users.first_name, Users.last_name, Users.email, DoctorProfiles.qualification, DoctorProfiles.specialization, DoctorProfiles.contact_no, DoctorProfiles.location, DoctorProfiles.home_address,DoctorProfiles.hospital_address FROM Users INNER JOIN DoctorProfiles ON Users.id = DoctorProfiles.user_id";
                SqlDataAdapter adapter = new SqlDataAdapter(query, sqlCon);
                DataTable dataTabel = new DataTable();
                adapter.Fill(dataTabel);
                sqlCon.Close();
                doctorsDataGridView.DataSource = dataTabel;
            }
            catch (Exception ex)
            {
                sqlCon.Close();
                Console.WriteLine(ex.Message);
                return;
            }
        }

        //HANDLE ADD DOCTOR BUTTON CLICK
        private void Add_doc_btn_Click(object sender, EventArgs e)
        {
            //DOCTOR OBJECT
            doctor = new Doctor(
                first_name_input.Text,
                last_name_input.Text,
                email_input.Text,
                phone_no_input.Text,
                password_input.Text,
                home_address_input.Text,
                "doctor",
                hospital_address_input.Text,
                Specialization_combobox.Text,
                qualification_input.Text,
                location_input.Text
            );

            bool isValidationPassed = Validation();
            if (isValidationPassed)
            {
                bool sqlQueryStatus = DBQuery("INSERT");
                if (sqlQueryStatus)
                {
                    MessageBox.Show("Доктор Успешно добавил", "Успех", default, MessageBoxIcon.Information);
                    LoadDoctorDataFromDB(); // REFRESH DATA GRID VIEW
                    ResetInputs();
                }
                else
                {
                    MessageBox.Show("Что-то пошло не так", "Ошибка сервера", default, MessageBoxIcon.Error);
                }
            }
        }

        //UPDATE BUTTON CLICK HANDLER
        private void Update_doc_btn_Click(object sender, EventArgs e)
        {
            //DOCTOR OBJECT WITHOUT PASSWORD
            doctor = new Doctor(
                first_name_input.Text,
                last_name_input.Text,
                email_input.Text,
                phone_no_input.Text,
                "none",
                home_address_input.Text,
                "doctor",
                hospital_address_input.Text,
                Specialization_combobox.Text,
                qualification_input.Text,
                location_input.Text
            );

            bool isValidationPassed = Validation("UPDATE");
            if (isValidationPassed)
            {
                bool sqlQueryStatus = DBQuery("UPDATE", selectedUserID);
                if (sqlQueryStatus)
                {
                    MessageBox.Show("Доктор Успешно добавил", "Успех", default, MessageBoxIcon.Information);
                    LoadDoctorDataFromDB(); // REFRESH DATA GRID VIEW
                    isSelectedUser = false;
                    ResetInputs();
                }
                else
                {
                    MessageBox.Show("Что-то пошло не так", "Ошибка сервера", default, MessageBoxIcon.Error);
                }
            }
        }

        //DELETE BUTTON CLICK HANDLER
        private void Delete_btn_Click(object sender, EventArgs e)
        {
            if (isSelectedUser)
            {
                var confirmation = MessageBox.Show(
                    "Вы Уверены, Что Хотите Удалить Этого Врача?",
                    "Подтверждение",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );
                if (confirmation == DialogResult.Yes)
                {
                    bool sqlQueryStatus = DBDeleteQuery(selectedUserID);
                    if (sqlQueryStatus)
                    {
                        MessageBox.Show("Доктор успешно удален", "Успех", default, MessageBoxIcon.Information);
                        LoadDoctorDataFromDB(); // REFRESH DATA GRID VIEW
                        isSelectedUser = false;
                        ResetInputs();
                    }
                    else
                    {
                        MessageBox.Show("Что-то пошло не так", "Ошибка сервера", default, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void Reset_btn_ClickHandler(object sender, EventArgs e)
        {
            ResetInputs();
        }

        //INSERT AND UPDATE QUERY
        private bool DBQuery(string operation, Int64 updateID = 0)
        {
            string operationType = operation == "INSERT" ? "INSERT" : "UPDATE";
            SqlConnection sqlCon = dBCon.SqlConnection;
            SqlTransaction sqlTransaction = null;
            try
            {
                sqlCon.Open();
                sqlTransaction = sqlCon.BeginTransaction(); // TRANSACTION START

                //INSERT AND UPDATE USER TABLE QUERY
                SqlCommand userTableCmd = doctor.GetInsertCommand(sqlCon);
                if (operationType == "UPDATE")
                {
                    userTableCmd = doctor.GetUpdateCommand(sqlCon, updateID);
                }
                userTableCmd.Transaction = sqlTransaction;
                Int64 userID = Convert.ToInt64(userTableCmd.ExecuteScalar()); //EXICUTE CMD

                //INSERT AND UPDATE DOCTOR TABLE QUERY
                SqlCommand doctorTableCmd = doctor.GetDocInsertCmd(sqlCon, userID);
                if (operationType == "UPDATE")
                {
                    doctorTableCmd = doctor.GetDocUpdateCmd(sqlCon, updateID);
                }
                doctorTableCmd.Transaction = sqlTransaction;
                doctorTableCmd.ExecuteNonQuery();
                sqlTransaction.Commit(); //COMMIT
            }
            catch (Exception ex)
            {
                //ROLLBACK TRANSACTION
                if (sqlTransaction != null)
                {
                    sqlTransaction.Rollback();
                }
                sqlCon.Close();
                Console.WriteLine(ex.Message);
                // SHOW ERROR OF DUPLICATE EMAIL
                if (ex.Message.Contains("Unique_Email"))
                {
                    MessageBox.Show("Электронная почта уже существует", "Ошибка проверки", default, MessageBoxIcon.Error);
                }
                if (ex.Message.Contains("CK_Contact_No"))
                {
                    MessageBox.Show("Номер контакта Уже не существует", "Ошибка проверки", default, MessageBoxIcon.Error);
                }
                return false;
            }
            finally
            {
                //CLOSE SQL CONNECTION
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }

            return true;
        }

        //DELETE QUERY
        private bool DBDeleteQuery(Int64 id)
        {
            SqlConnection sqlConnection = dBCon.SqlConnection;
            try
            {
                sqlConnection.Open();
                Doctor doctor = new Doctor();
                SqlCommand deleteDoctor = doctor.GetDocDeleteCmd(sqlConnection, id);
                SqlCommand deleteUser = doctor.GetDeleteCommand(sqlConnection, id);
                deleteDoctor.ExecuteNonQuery();
                deleteUser.ExecuteNonQuery();
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                sqlConnection.Close();
                Console.WriteLine(ex.Message);
                return false;
            }
            return true;
        }

        //FORM VALIDATION
        private bool Validation(string operation = "INSERT")
        {
            List<string> errors = new List<string>
            {
                InputValidator.TextValidate(doctor.FirstName, "First Name"),
                InputValidator.TextValidate(doctor.LastName, "Last Name"),
                InputValidator.EmailValidate(doctor.Email),
                InputValidator.PhoneValidation(doctor.PhoneNumber),
                InputValidator.TextValidate(doctor.Address, "Home Address"),
                InputValidator.TextValidate(doctor.HospitalAddress, "Hospital Address"),
                InputValidator.TextValidate(doctor.Specialization, "Specialization"),
                InputValidator.TextValidate(doctor.Qualification, "Qualification"),
                InputValidator.TextValidate(doctor.Location, "Location")
            };
            if (operation == "INSERT")
            {
                errors.Add(InputValidator.PasswordValidate(doctor.Password));
            }

            //ACTIVE ERRORS INTO ARRAY
            string[] activeErrors = errors.FindAll(err => err != "valid").ToArray();

            if (activeErrors.Length == 0)
            {
                return true;
            }
            //SHOW ERRORS
            MessageBox.Show(string.Join("\n", activeErrors), "Ошибка проверки", default, MessageBoxIcon.Error);

            return false;
        }

        //RESET INPUTS
        private void ResetInputs()
        {
            first_name_input.Text = "";
            last_name_input.Text = "";
            email_input.Text = "";
            phone_no_input.Text = "";
            password_input.Text = "";
            home_address_input.Text = "";
            hospital_address_input.Text = "";
            Specialization_combobox.SelectedItem = null;
            qualification_input.SelectedItem = null;
            location_input.SelectedItem = null;
            password_input.Enabled = true;
            add_doc_btn.Enabled = true;
            update_doc_btn.Enabled = false;
            delete_btn.Enabled = false;
        }

        private void add_doc_btn_Click_1(object sender, EventArgs e)
        {

        }

        private void delete_btn_Click_1(object sender, EventArgs e)
        {

        }

        private void update_doc_btn_Click_1(object sender, EventArgs e)
        {

        }

        private void reset_btn_Click(object sender, EventArgs e)
        {
            first_name_input.Text = "";
            last_name_input.Text = "";
            email_input.Text = "";
            phone_no_input.Text = "";
            password_input.Text = "";
            home_address_input.Text = "";
            hospital_address_input.Text = "";
            Specialization_combobox.SelectedItem = null;
            qualification_input.SelectedItem = null;
            location_input.SelectedItem = null;
            password_input.Enabled = true;
            add_doc_btn.Enabled = true;
            update_doc_btn.Enabled = false;
            delete_btn.Enabled = false;
        }

        private void add_doc_btn_Click_2(object sender, EventArgs e)
        {
            //DOCTOR OBJECT
            doctor = new Doctor(
                first_name_input.Text,
                last_name_input.Text,
                email_input.Text,
                phone_no_input.Text,
                password_input.Text,
                home_address_input.Text,
                "doctor",
                hospital_address_input.Text,
                Specialization_combobox.Text,
                qualification_input.Text,
                location_input.Text
            );

            bool isValidationPassed = Validation();
            if (isValidationPassed)
            {
                bool sqlQueryStatus = DBQuery("INSERT");
                if (sqlQueryStatus)
                {
                    MessageBox.Show("Доктор Успешно добавлен", "Успех", default, MessageBoxIcon.Information);
                    LoadDoctorDataFromDB(); // REFRESH DATA GRID VIEW
                    ResetInputs();
                }
                else
                {
                    MessageBox.Show("Что-то пошло не так", "Ошибка сервера", default, MessageBoxIcon.Error);
                }
            }
        }

        private void delete_btn_Click_2(object sender, EventArgs e)
        {
            if (isSelectedUser)
            {
                var confirmation = MessageBox.Show(
                    "Вы точно уверены в удалении данных?",
                    "Выполнено",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );
                if (confirmation == DialogResult.Yes)
                {
                    bool sqlQueryStatus = DBDeleteQuery(selectedUserID);
                    if (sqlQueryStatus)
                    {
                        MessageBox.Show("Доктор Успешно добавлен", "Успех", default, MessageBoxIcon.Information);
                        LoadDoctorDataFromDB(); // REFRESH DATA GRID VIEW
                        isSelectedUser = false;
                        ResetInputs();
                    }
                    else
                    {
                        MessageBox.Show("Что-то пошло не так", "Ошибка сервера", default, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void update_doc_btn_Click_2(object sender, EventArgs e)
        {
            //DOCTOR OBJECT WITHOUT PASSWORD
            doctor = new Doctor(
                first_name_input.Text,
                last_name_input.Text,
                email_input.Text,
                phone_no_input.Text,
                "none",
                home_address_input.Text,
                "doctor",
                hospital_address_input.Text,
                Specialization_combobox.Text,
                qualification_input.Text,
                location_input.Text
            );

            bool isValidationPassed = Validation("UPDATE");
            if (isValidationPassed)
            {
                bool sqlQueryStatus = DBQuery("UPDATE", selectedUserID);
                if (sqlQueryStatus)
                {
                    MessageBox.Show("Обновление доктора прошло успешно", "Успех", default, MessageBoxIcon.Information);
                    LoadDoctorDataFromDB(); // REFRESH DATA GRID VIEW
                    isSelectedUser = false;
                    ResetInputs();
                }
                else
                {
                    MessageBox.Show("что-то пошло не так", "Ошибка сервера", default, MessageBoxIcon.Error);
                }
            }
        }

        private void reset_btn_Click_1(object sender, EventArgs e)
        {
            ResetInputs();
        }

        private void doctorsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void phone_no_input_TextChanged(object sender, EventArgs e)
        {

        }

        private void OnCellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
