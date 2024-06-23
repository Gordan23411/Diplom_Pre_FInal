namespace HealthCare_Plus.Forms.Dashboard.Admin
{
    partial class DoctorsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataPanel = new System.Windows.Forms.Panel();
            this.doctorsDataGridView = new System.Windows.Forms.DataGridView();
            this.crudPanel = new System.Windows.Forms.Panel();
            this.reset_btn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.update_doc_btn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.delete_btn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.add_doc_btn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.location_input = new Guna.UI2.WinForms.Guna2ComboBox();
            this.qualification_input = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Specialization_combobox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.home_address_input = new Guna.UI2.WinForms.Guna2TextBox();
            this.password_input = new Guna.UI2.WinForms.Guna2TextBox();
            this.last_name_input = new Guna.UI2.WinForms.Guna2TextBox();
            this.hospital_address_input = new Guna.UI2.WinForms.Guna2TextBox();
            this.phone_no_input = new Guna.UI2.WinForms.Guna2TextBox();
            this.email_input = new Guna.UI2.WinForms.Guna2TextBox();
            this.first_name_input = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.email_address_label = new System.Windows.Forms.Label();
            this.phone_no_label = new System.Windows.Forms.Label();
            this.hospital_address_label = new System.Windows.Forms.Label();
            this.last_name_label = new System.Windows.Forms.Label();
            this.location_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.home_address_label = new System.Windows.Forms.Label();
            this.Specialization_label = new System.Windows.Forms.Label();
            this.qualification_label = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse5 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse6 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse7 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse8 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse9 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse10 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse11 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse12 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse13 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse14 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.healthcareplusDataSet = new HealthCare_Plus.HealthcareplusDataSet();
            this.doctorProfilesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doctorProfilesTableAdapter = new HealthCare_Plus.HealthcareplusDataSetTableAdapters.DoctorProfilesTableAdapter();
            this.healthcareplusDataSet1 = new HealthCare_Plus.HealthcareplusDataSet1();
            this.doctorProfilesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.doctorProfilesTableAdapter1 = new HealthCare_Plus.HealthcareplusDataSet1TableAdapters.DoctorProfilesTableAdapter();
            this.dataPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsDataGridView)).BeginInit();
            this.crudPanel.SuspendLayout();
            this.guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.healthcareplusDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorProfilesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.healthcareplusDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorProfilesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataPanel
            // 
            this.dataPanel.Controls.Add(this.doctorsDataGridView);
            this.dataPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataPanel.Location = new System.Drawing.Point(0, 260);
            this.dataPanel.Name = "dataPanel";
            this.dataPanel.Size = new System.Drawing.Size(800, 190);
            this.dataPanel.TabIndex = 1;
            // 
            // doctorsDataGridView
            // 
            this.doctorsDataGridView.AllowUserToAddRows = false;
            this.doctorsDataGridView.AllowUserToDeleteRows = false;
            this.doctorsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.doctorsDataGridView.BackgroundColor = System.Drawing.Color.LightGray;
            this.doctorsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.doctorsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.doctorsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.doctorsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.doctorsDataGridView.EnableHeadersVisualStyles = false;
            this.doctorsDataGridView.GridColor = System.Drawing.Color.Black;
            this.doctorsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.doctorsDataGridView.MultiSelect = false;
            this.doctorsDataGridView.Name = "doctorsDataGridView";
            this.doctorsDataGridView.ReadOnly = true;
            this.doctorsDataGridView.Size = new System.Drawing.Size(800, 190);
            this.doctorsDataGridView.TabIndex = 0;
            this.doctorsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.doctorsDataGridView_CellContentClick);
            this.doctorsDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnCellDoubleClick);
            // 
            // crudPanel
            // 
            this.crudPanel.Controls.Add(this.reset_btn);
            this.crudPanel.Controls.Add(this.update_doc_btn);
            this.crudPanel.Controls.Add(this.delete_btn);
            this.crudPanel.Controls.Add(this.add_doc_btn);
            this.crudPanel.Controls.Add(this.location_input);
            this.crudPanel.Controls.Add(this.qualification_input);
            this.crudPanel.Controls.Add(this.Specialization_combobox);
            this.crudPanel.Controls.Add(this.home_address_input);
            this.crudPanel.Controls.Add(this.password_input);
            this.crudPanel.Controls.Add(this.last_name_input);
            this.crudPanel.Controls.Add(this.hospital_address_input);
            this.crudPanel.Controls.Add(this.phone_no_input);
            this.crudPanel.Controls.Add(this.email_input);
            this.crudPanel.Controls.Add(this.first_name_input);
            this.crudPanel.Controls.Add(this.guna2GradientPanel1);
            this.crudPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.crudPanel.Location = new System.Drawing.Point(0, 0);
            this.crudPanel.Name = "crudPanel";
            this.crudPanel.Size = new System.Drawing.Size(800, 260);
            this.crudPanel.TabIndex = 0;
            // 
            // reset_btn
            // 
            this.reset_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.reset_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.reset_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.reset_btn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.reset_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.reset_btn.FillColor = System.Drawing.Color.DarkGray;
            this.reset_btn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.reset_btn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reset_btn.ForeColor = System.Drawing.Color.Black;
            this.reset_btn.Location = new System.Drawing.Point(669, 195);
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.Size = new System.Drawing.Size(118, 45);
            this.reset_btn.TabIndex = 5;
            this.reset_btn.Text = "Сброс";
            this.reset_btn.Click += new System.EventHandler(this.reset_btn_Click_1);
            // 
            // update_doc_btn
            // 
            this.update_doc_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.update_doc_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.update_doc_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.update_doc_btn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.update_doc_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.update_doc_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.update_doc_btn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.update_doc_btn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.update_doc_btn.ForeColor = System.Drawing.Color.Black;
            this.update_doc_btn.Location = new System.Drawing.Point(669, 134);
            this.update_doc_btn.Name = "update_doc_btn";
            this.update_doc_btn.Size = new System.Drawing.Size(119, 45);
            this.update_doc_btn.TabIndex = 33;
            this.update_doc_btn.Text = "Обнавить данные";
            this.update_doc_btn.Click += new System.EventHandler(this.update_doc_btn_Click_2);
            // 
            // delete_btn
            // 
            this.delete_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.delete_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.delete_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.delete_btn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.delete_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.delete_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.delete_btn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.delete_btn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delete_btn.ForeColor = System.Drawing.Color.Black;
            this.delete_btn.Location = new System.Drawing.Point(531, 195);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(119, 45);
            this.delete_btn.TabIndex = 32;
            this.delete_btn.Text = "Удалить";
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click_2);
            // 
            // add_doc_btn
            // 
            this.add_doc_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.add_doc_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.add_doc_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.add_doc_btn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.add_doc_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.add_doc_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.add_doc_btn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.add_doc_btn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_doc_btn.ForeColor = System.Drawing.Color.Black;
            this.add_doc_btn.Location = new System.Drawing.Point(531, 134);
            this.add_doc_btn.Name = "add_doc_btn";
            this.add_doc_btn.Size = new System.Drawing.Size(119, 45);
            this.add_doc_btn.TabIndex = 31;
            this.add_doc_btn.Text = "Добавить доктора";
            this.add_doc_btn.Click += new System.EventHandler(this.add_doc_btn_Click_2);
            // 
            // location_input
            // 
            this.location_input.BackColor = System.Drawing.Color.Transparent;
            this.location_input.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.location_input.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.location_input.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.location_input.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.location_input.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.location_input.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.location_input.ItemHeight = 30;
            this.location_input.Items.AddRange(new object[] {
            "Бульвар Ломоносова, 83",
            "пр. Косиора, 46",
            "пл. Чехова, 28",
            "шоссе Бухарестская, 10"});
            this.location_input.Location = new System.Drawing.Point(531, 91);
            this.location_input.Name = "location_input";
            this.location_input.Size = new System.Drawing.Size(140, 36);
            this.location_input.TabIndex = 10;
            // 
            // qualification_input
            // 
            this.qualification_input.BackColor = System.Drawing.Color.Transparent;
            this.qualification_input.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.qualification_input.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.qualification_input.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.qualification_input.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.qualification_input.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.qualification_input.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.qualification_input.ItemHeight = 30;
            this.qualification_input.Items.AddRange(new object[] {
            "Первая ",
            "Вторая",
            "Высшая"});
            this.qualification_input.Location = new System.Drawing.Point(529, 28);
            this.qualification_input.Name = "qualification_input";
            this.qualification_input.Size = new System.Drawing.Size(140, 36);
            this.qualification_input.TabIndex = 20;
            // 
            // Specialization_combobox
            // 
            this.Specialization_combobox.BackColor = System.Drawing.Color.Transparent;
            this.Specialization_combobox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Specialization_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Specialization_combobox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Specialization_combobox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Specialization_combobox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Specialization_combobox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.Specialization_combobox.ItemHeight = 30;
            this.Specialization_combobox.Items.AddRange(new object[] {
            "Невролог",
            "Уролог",
            "Семейная медицина",
            "Психиатр",
            "Дерматолог",
            "Ортопед",
            "Кардиолог",
            "Гастроэнтеролог",
            "Нейрохирург"});
            this.Specialization_combobox.Location = new System.Drawing.Point(270, 218);
            this.Specialization_combobox.Name = "Specialization_combobox";
            this.Specialization_combobox.Size = new System.Drawing.Size(140, 36);
            this.Specialization_combobox.TabIndex = 22;
            // 
            // home_address_input
            // 
            this.home_address_input.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.home_address_input.DefaultText = "";
            this.home_address_input.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.home_address_input.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.home_address_input.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.home_address_input.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.home_address_input.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.home_address_input.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.home_address_input.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.home_address_input.Location = new System.Drawing.Point(270, 153);
            this.home_address_input.Name = "home_address_input";
            this.home_address_input.PasswordChar = '\0';
            this.home_address_input.PlaceholderText = "";
            this.home_address_input.SelectedText = "";
            this.home_address_input.Size = new System.Drawing.Size(200, 36);
            this.home_address_input.TabIndex = 10;
            // 
            // password_input
            // 
            this.password_input.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.password_input.DefaultText = "";
            this.password_input.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.password_input.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.password_input.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.password_input.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.password_input.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.password_input.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.password_input.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.password_input.Location = new System.Drawing.Point(270, 91);
            this.password_input.Name = "password_input";
            this.password_input.PasswordChar = '\0';
            this.password_input.PlaceholderText = "";
            this.password_input.SelectedText = "";
            this.password_input.Size = new System.Drawing.Size(200, 36);
            this.password_input.TabIndex = 9;
            // 
            // last_name_input
            // 
            this.last_name_input.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.last_name_input.DefaultText = "";
            this.last_name_input.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.last_name_input.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.last_name_input.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.last_name_input.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.last_name_input.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.last_name_input.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.last_name_input.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.last_name_input.Location = new System.Drawing.Point(270, 28);
            this.last_name_input.Name = "last_name_input";
            this.last_name_input.PasswordChar = '\0';
            this.last_name_input.PlaceholderText = "";
            this.last_name_input.SelectedText = "";
            this.last_name_input.Size = new System.Drawing.Size(200, 36);
            this.last_name_input.TabIndex = 8;
            // 
            // hospital_address_input
            // 
            this.hospital_address_input.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.hospital_address_input.DefaultText = "";
            this.hospital_address_input.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.hospital_address_input.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.hospital_address_input.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.hospital_address_input.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.hospital_address_input.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.hospital_address_input.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.hospital_address_input.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.hospital_address_input.Location = new System.Drawing.Point(18, 215);
            this.hospital_address_input.Name = "hospital_address_input";
            this.hospital_address_input.PasswordChar = '\0';
            this.hospital_address_input.PlaceholderText = "";
            this.hospital_address_input.SelectedText = "";
            this.hospital_address_input.Size = new System.Drawing.Size(200, 36);
            this.hospital_address_input.TabIndex = 10;
            // 
            // phone_no_input
            // 
            this.phone_no_input.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.phone_no_input.DefaultText = "";
            this.phone_no_input.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.phone_no_input.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.phone_no_input.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.phone_no_input.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.phone_no_input.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.phone_no_input.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.phone_no_input.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.phone_no_input.Location = new System.Drawing.Point(17, 153);
            this.phone_no_input.Name = "phone_no_input";
            this.phone_no_input.PasswordChar = '\0';
            this.phone_no_input.PlaceholderText = "";
            this.phone_no_input.SelectedText = "";
            this.phone_no_input.Size = new System.Drawing.Size(200, 36);
            this.phone_no_input.TabIndex = 11;
            this.phone_no_input.TextChanged += new System.EventHandler(this.phone_no_input_TextChanged);
            // 
            // email_input
            // 
            this.email_input.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.email_input.DefaultText = "";
            this.email_input.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.email_input.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.email_input.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.email_input.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.email_input.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.email_input.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.email_input.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.email_input.Location = new System.Drawing.Point(17, 91);
            this.email_input.Name = "email_input";
            this.email_input.PasswordChar = '\0';
            this.email_input.PlaceholderText = "";
            this.email_input.SelectedText = "";
            this.email_input.Size = new System.Drawing.Size(200, 36);
            this.email_input.TabIndex = 12;
            // 
            // first_name_input
            // 
            this.first_name_input.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.first_name_input.DefaultText = "";
            this.first_name_input.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.first_name_input.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.first_name_input.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.first_name_input.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.first_name_input.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.first_name_input.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.first_name_input.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.first_name_input.Location = new System.Drawing.Point(15, 28);
            this.first_name_input.Name = "first_name_input";
            this.first_name_input.PasswordChar = '\0';
            this.first_name_input.PlaceholderText = "";
            this.first_name_input.SelectedText = "";
            this.first_name_input.Size = new System.Drawing.Size(200, 36);
            this.first_name_input.TabIndex = 30;
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Controls.Add(this.label1);
            this.guna2GradientPanel1.Controls.Add(this.email_address_label);
            this.guna2GradientPanel1.Controls.Add(this.phone_no_label);
            this.guna2GradientPanel1.Controls.Add(this.hospital_address_label);
            this.guna2GradientPanel1.Controls.Add(this.last_name_label);
            this.guna2GradientPanel1.Controls.Add(this.location_label);
            this.guna2GradientPanel1.Controls.Add(this.password_label);
            this.guna2GradientPanel1.Controls.Add(this.home_address_label);
            this.guna2GradientPanel1.Controls.Add(this.Specialization_label);
            this.guna2GradientPanel1.Controls.Add(this.qualification_label);
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.White;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(800, 260);
            this.guna2GradientPanel1.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 29;
            this.label1.Text = "Фамилия";
            // 
            // email_address_label
            // 
            this.email_address_label.AutoSize = true;
            this.email_address_label.BackColor = System.Drawing.Color.Transparent;
            this.email_address_label.Cursor = System.Windows.Forms.Cursors.Default;
            this.email_address_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.email_address_label.Location = new System.Drawing.Point(16, 72);
            this.email_address_label.Name = "email_address_label";
            this.email_address_label.Size = new System.Drawing.Size(202, 16);
            this.email_address_label.TabIndex = 13;
            this.email_address_label.Text = "Адрес электронной почты";
            // 
            // phone_no_label
            // 
            this.phone_no_label.AutoSize = true;
            this.phone_no_label.BackColor = System.Drawing.Color.Transparent;
            this.phone_no_label.Cursor = System.Windows.Forms.Cursors.Default;
            this.phone_no_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phone_no_label.Location = new System.Drawing.Point(16, 134);
            this.phone_no_label.Name = "phone_no_label";
            this.phone_no_label.Size = new System.Drawing.Size(133, 16);
            this.phone_no_label.TabIndex = 12;
            this.phone_no_label.Text = "Номер телефона";
            // 
            // hospital_address_label
            // 
            this.hospital_address_label.AutoSize = true;
            this.hospital_address_label.BackColor = System.Drawing.Color.Transparent;
            this.hospital_address_label.Cursor = System.Windows.Forms.Cursors.Default;
            this.hospital_address_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hospital_address_label.Location = new System.Drawing.Point(16, 196);
            this.hospital_address_label.Name = "hospital_address_label";
            this.hospital_address_label.Size = new System.Drawing.Size(128, 16);
            this.hospital_address_label.TabIndex = 11;
            this.hospital_address_label.Text = "Адрес больницы";
            // 
            // last_name_label
            // 
            this.last_name_label.AutoSize = true;
            this.last_name_label.BackColor = System.Drawing.Color.Transparent;
            this.last_name_label.Cursor = System.Windows.Forms.Cursors.Default;
            this.last_name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.last_name_label.Location = new System.Drawing.Point(267, 9);
            this.last_name_label.Name = "last_name_label";
            this.last_name_label.Size = new System.Drawing.Size(36, 16);
            this.last_name_label.TabIndex = 9;
            this.last_name_label.Text = "Имя";
            // 
            // location_label
            // 
            this.location_label.AutoSize = true;
            this.location_label.BackColor = System.Drawing.Color.Transparent;
            this.location_label.Cursor = System.Windows.Forms.Cursors.Default;
            this.location_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.location_label.Location = new System.Drawing.Point(528, 72);
            this.location_label.Name = "location_label";
            this.location_label.Size = new System.Drawing.Size(63, 16);
            this.location_label.TabIndex = 11;
            this.location_label.Text = "Где он?";
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.BackColor = System.Drawing.Color.Transparent;
            this.password_label.Cursor = System.Windows.Forms.Cursors.Default;
            this.password_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password_label.Location = new System.Drawing.Point(267, 72);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(62, 16);
            this.password_label.TabIndex = 10;
            this.password_label.Text = "Пароль";
            // 
            // home_address_label
            // 
            this.home_address_label.AutoSize = true;
            this.home_address_label.BackColor = System.Drawing.Color.Transparent;
            this.home_address_label.Cursor = System.Windows.Forms.Cursors.Default;
            this.home_address_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.home_address_label.Location = new System.Drawing.Point(267, 134);
            this.home_address_label.Name = "home_address_label";
            this.home_address_label.Size = new System.Drawing.Size(146, 16);
            this.home_address_label.TabIndex = 11;
            this.home_address_label.Text = "Адрес проживания";
            // 
            // Specialization_label
            // 
            this.Specialization_label.AutoSize = true;
            this.Specialization_label.BackColor = System.Drawing.Color.Transparent;
            this.Specialization_label.Cursor = System.Windows.Forms.Cursors.Default;
            this.Specialization_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Specialization_label.Location = new System.Drawing.Point(267, 199);
            this.Specialization_label.Name = "Specialization_label";
            this.Specialization_label.Size = new System.Drawing.Size(124, 16);
            this.Specialization_label.TabIndex = 23;
            this.Specialization_label.Text = "Специализация";
            this.Specialization_label.UseMnemonic = false;
            // 
            // qualification_label
            // 
            this.qualification_label.AutoSize = true;
            this.qualification_label.BackColor = System.Drawing.Color.Transparent;
            this.qualification_label.Cursor = System.Windows.Forms.Cursors.Default;
            this.qualification_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.qualification_label.Location = new System.Drawing.Point(528, 9);
            this.qualification_label.Name = "qualification_label";
            this.qualification_label.Size = new System.Drawing.Size(116, 16);
            this.qualification_label.TabIndex = 21;
            this.qualification_label.Text = "Квалификация";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this.add_doc_btn;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.TargetControl = this.delete_btn;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.TargetControl = this.email_input;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.TargetControl = this.home_address_input;
            // 
            // guna2Elipse5
            // 
            this.guna2Elipse5.TargetControl = this.hospital_address_input;
            // 
            // guna2Elipse6
            // 
            this.guna2Elipse6.TargetControl = this.last_name_input;
            // 
            // guna2Elipse7
            // 
            this.guna2Elipse7.TargetControl = this.location_input;
            // 
            // guna2Elipse8
            // 
            this.guna2Elipse8.TargetControl = this.password_input;
            // 
            // guna2Elipse9
            // 
            this.guna2Elipse9.TargetControl = this.phone_no_input;
            // 
            // guna2Elipse10
            // 
            this.guna2Elipse10.TargetControl = this.qualification_input;
            // 
            // guna2Elipse11
            // 
            this.guna2Elipse11.TargetControl = this.reset_btn;
            // 
            // guna2Elipse12
            // 
            this.guna2Elipse12.TargetControl = this.Specialization_combobox;
            // 
            // guna2Elipse13
            // 
            this.guna2Elipse13.TargetControl = this.update_doc_btn;
            // 
            // guna2Elipse14
            // 
            this.guna2Elipse14.TargetControl = this.first_name_input;
            // 
            // healthcareplusDataSet
            // 
            this.healthcareplusDataSet.DataSetName = "HealthcareplusDataSet";
            this.healthcareplusDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // doctorProfilesBindingSource
            // 
            this.doctorProfilesBindingSource.DataMember = "DoctorProfiles";
            this.doctorProfilesBindingSource.DataSource = this.healthcareplusDataSet;
            // 
            // doctorProfilesTableAdapter
            // 
            this.doctorProfilesTableAdapter.ClearBeforeFill = true;
            // 
            // healthcareplusDataSet1
            // 
            this.healthcareplusDataSet1.DataSetName = "HealthcareplusDataSet1";
            this.healthcareplusDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // doctorProfilesBindingSource1
            // 
            this.doctorProfilesBindingSource1.DataMember = "DoctorProfiles";
            this.doctorProfilesBindingSource1.DataSource = this.healthcareplusDataSet1;
            // 
            // doctorProfilesTableAdapter1
            // 
            this.doctorProfilesTableAdapter1.ClearBeforeFill = true;
            // 
            // DoctorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataPanel);
            this.Controls.Add(this.crudPanel);
            this.Name = "DoctorsForm";
            this.Text = "Доктора";
            this.Load += new System.EventHandler(this.DoctorsForm_Load);
            this.dataPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.doctorsDataGridView)).EndInit();
            this.crudPanel.ResumeLayout(false);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.healthcareplusDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorProfilesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.healthcareplusDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorProfilesBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel dataPanel;
        private System.Windows.Forms.DataGridView doctorsDataGridView;
        private System.Windows.Forms.Panel crudPanel;
        private Guna.UI2.WinForms.Guna2ComboBox location_input;
        private System.Windows.Forms.Label location_label;
        private Guna.UI2.WinForms.Guna2ComboBox qualification_input;
        private Guna.UI2.WinForms.Guna2ComboBox Specialization_combobox;
        private System.Windows.Forms.Label qualification_label;
        private Guna.UI2.WinForms.Guna2TextBox home_address_input;
        private System.Windows.Forms.Label Specialization_label;
        private Guna.UI2.WinForms.Guna2TextBox password_input;
        private System.Windows.Forms.Label home_address_label;
        private Guna.UI2.WinForms.Guna2TextBox last_name_input;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.Label last_name_label;
        private Guna.UI2.WinForms.Guna2TextBox hospital_address_input;
        private Guna.UI2.WinForms.Guna2TextBox phone_no_input;
        private System.Windows.Forms.Label hospital_address_label;
        private Guna.UI2.WinForms.Guna2TextBox email_input;
        private System.Windows.Forms.Label phone_no_label;
        private Guna.UI2.WinForms.Guna2TextBox first_name_input;
        private System.Windows.Forms.Label email_address_label;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2GradientButton reset_btn;
        private Guna.UI2.WinForms.Guna2GradientButton update_doc_btn;
        private Guna.UI2.WinForms.Guna2GradientButton delete_btn;
        private Guna.UI2.WinForms.Guna2GradientButton add_doc_btn;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse5;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse6;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse7;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse8;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse9;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse10;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse11;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse12;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse13;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse14;
        private HealthcareplusDataSet healthcareplusDataSet;
        private System.Windows.Forms.BindingSource doctorProfilesBindingSource;
        private HealthcareplusDataSetTableAdapters.DoctorProfilesTableAdapter doctorProfilesTableAdapter;
        private HealthcareplusDataSet1 healthcareplusDataSet1;
        private System.Windows.Forms.BindingSource doctorProfilesBindingSource1;
        private HealthcareplusDataSet1TableAdapters.DoctorProfilesTableAdapter doctorProfilesTableAdapter1;
    }
}