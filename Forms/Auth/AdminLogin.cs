using HealthCare_Plus.Forms.Dashboard.Admin;
using HealthCare_Plus.Models;
using HealthCare_Plus.Utils;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace HealthCare_Plus.Forms.Auth
{
    public partial class AdminLoginForm : Form
    {
        private string EmailAddress = null;
        private string Password = null;

        public AdminLoginForm()
        {
            InitializeComponent();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            EmailAddress = email_input.Text;
            Password = password_input.Text;

            // USER INPUT VALIDATON AND SHOW ERRORS
            string validation = FormValidate(EmailAddress, Password);
            if (validation != "valid")
            {
                MessageBox.Show(validation, "Ошибка", default, MessageBoxIcon.Error);
            }

            if (validation == "valid")
            {
                //DB CONECTION
                DBCon dBCon = new DBCon();
                SqlConnection sqlCon = dBCon.SqlConnection;
                try
                {
                    sqlCon.Open();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    MessageBox.Show("Сервер отдыхает", "Ошибка", default, MessageBoxIcon.Error);
                    return;
                }

                //SEARCH USER
                string query = "SELECT first_name,email,password,role FROM Users WHERE email=@email";
                SqlCommand cmd = new SqlCommand(query, sqlCon);
                cmd.Parameters.AddWithValue("@email", EmailAddress);
                SqlDataReader dataReader = cmd.ExecuteReader();

                if (dataReader.Read())
                {
                    string dbpassword = dataReader["password"].ToString();
                    string role = dataReader["role"].ToString();
                    Hash passwordHash = new Hash();
                    bool isValid = passwordHash.VerifyPassword(Password, dbpassword);

                    //CHECK FOR AUTHORIZTION {ROLE}
                    if (role != "admin")
                    {
                        MessageBox.Show("You don't have access!", "Unauthorized", default, MessageBoxIcon.Error);
                        return;
                    }

                    if (isValid)
                    {
                        // SAVE AUTH MODAL
                        var authUser = AuthUser.Instance;
                        authUser.Email = EmailAddress;
                        authUser.FirstName = dataReader["first_name"].ToString();
                        authUser.role = role;

                        //SHOW STAFF DASHBOARD ON LOGIN SUCCESS
                        AdminDashboard adminDashboard = new AdminDashboard();
                        this.Hide();
                        adminDashboard.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Credentials", "Login Faild", default, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Credentials", "Login Faild", default, MessageBoxIcon.Error);
                }
            }
        }

        private void back_to_home_lable_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();
        }

        //VALIDATE LOGIN FORM INPUTS
        private string FormValidate(string email, string password)
        {
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                return "Email and password is required";
            }

            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex regex = new Regex(emailPattern);
            if (!regex.IsMatch(email))
            {
                return "Invalid email address";
            }

            return "valid";
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            EmailAddress = email_input.Text;
            Password = password_input.Text;

            // USER INPUT VALIDATON AND SHOW ERRORS
            string validation = FormValidate(EmailAddress, Password);
            if (validation != "valid")
            {
                panel1.Visible = true;
                label1.ForeColor = Color.Red;
                label1.Text = "Неправильный логин или пароль.";
                email_input.BorderColor = Color.Red;
                password_input.BorderColor = Color.Red;
            }

            if (validation == "valid")
            {
                //DB CONECTION
                DBCon dBCon = new DBCon();
                SqlConnection sqlCon = dBCon.SqlConnection;
                try
                {
                    sqlCon.Open();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    MessageBox.Show("Сервер отдыхает", "Ошибка", default, MessageBoxIcon.Error);
                    return;
                }

                //SEARCH USER
                string query = "SELECT first_name,email,password,role FROM Users WHERE email=@email";
                SqlCommand cmd = new SqlCommand(query, sqlCon);
                cmd.Parameters.AddWithValue("@email", EmailAddress);
                SqlDataReader dataReader = cmd.ExecuteReader();

                if (dataReader.Read())
                {
                    string dbpassword = dataReader["password"].ToString();
                    string role = dataReader["role"].ToString();
                    Hash passwordHash = new Hash();
                    bool isValid = passwordHash.VerifyPassword(Password, dbpassword);

                    //CHECK FOR AUTHORIZTION {ROLE}
                    if (role != "admin")
                    {
                        MessageBox.Show("У вас нет доступа!", "Неавторизованный", default, MessageBoxIcon.Error);
                        return;
                    }

                    if (isValid)
                    {
                        // SAVE AUTH MODAL
                        var authUser = AuthUser.Instance;
                        authUser.Email = EmailAddress;
                        authUser.FirstName = dataReader["first_name"].ToString();
                        authUser.role = role;

                        //SHOW STAFF DASHBOARD ON LOGIN SUCCESS
                        AdminDashboard adminDashboard = new AdminDashboard();
                        this.Hide();
                        adminDashboard.Show();
                    }
                    else
                    {
                        MessageBox.Show("Неверные учетные данные", "ошибка входа", default, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Неверные учетные данные", "ошибка входа", default, MessageBoxIcon.Error);
                }
            }
        }

        private void back_to_home_lable_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();
        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
