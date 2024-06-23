namespace HealthCare_Plus.Forms.Dashboard.Admin
{
    partial class StaffForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Password_label = new System.Windows.Forms.Label();
            this.dataPanel = new System.Windows.Forms.Panel();
            this.StaffDataGridView = new System.Windows.Forms.DataGridView();
            this.crudPanel = new System.Windows.Forms.Panel();
            this.Password_input = new Guna.UI2.WinForms.Guna2TextBox();
            this.Address_input = new Guna.UI2.WinForms.Guna2TextBox();
            this.Phone_no_input = new Guna.UI2.WinForms.Guna2TextBox();
            this.Email_input = new Guna.UI2.WinForms.Guna2TextBox();
            this.Last_name_input = new Guna.UI2.WinForms.Guna2TextBox();
            this.First_name_input = new Guna.UI2.WinForms.Guna2TextBox();
            this.Reset_btn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.RoleComoboBox = new System.Windows.Forms.ComboBox();
            this.Delete_btn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Update_btn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Add_btn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.First_name_label = new System.Windows.Forms.Label();
            this.Role_label = new System.Windows.Forms.Label();
            this.Last_name_label = new System.Windows.Forms.Label();
            this.email_address_label = new System.Windows.Forms.Label();
            this.home_address_label = new System.Windows.Forms.Label();
            this.phone_no_label = new System.Windows.Forms.Label();
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
            this.dataPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StaffDataGridView)).BeginInit();
            this.crudPanel.SuspendLayout();
            this.guna2GradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Password_label
            // 
            this.Password_label.AutoSize = true;
            this.Password_label.BackColor = System.Drawing.Color.Transparent;
            this.Password_label.Cursor = System.Windows.Forms.Cursors.Default;
            this.Password_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Password_label.Location = new System.Drawing.Point(268, 134);
            this.Password_label.Name = "Password_label";
            this.Password_label.Size = new System.Drawing.Size(67, 18);
            this.Password_label.TabIndex = 28;
            this.Password_label.Text = "Пароль";
            this.Password_label.Click += new System.EventHandler(this.Password_label_Click);
            // 
            // dataPanel
            // 
            this.dataPanel.Controls.Add(this.StaffDataGridView);
            this.dataPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataPanel.Location = new System.Drawing.Point(0, 260);
            this.dataPanel.Name = "dataPanel";
            this.dataPanel.Size = new System.Drawing.Size(800, 190);
            this.dataPanel.TabIndex = 5;
            // 
            // StaffDataGridView
            // 
            this.StaffDataGridView.AllowUserToAddRows = false;
            this.StaffDataGridView.AllowUserToDeleteRows = false;
            this.StaffDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StaffDataGridView.BackgroundColor = System.Drawing.Color.LightGray;
            this.StaffDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(211)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StaffDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.StaffDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StaffDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StaffDataGridView.EnableHeadersVisualStyles = false;
            this.StaffDataGridView.GridColor = System.Drawing.Color.Black;
            this.StaffDataGridView.Location = new System.Drawing.Point(0, 0);
            this.StaffDataGridView.MultiSelect = false;
            this.StaffDataGridView.Name = "StaffDataGridView";
            this.StaffDataGridView.ReadOnly = true;
            this.StaffDataGridView.Size = new System.Drawing.Size(800, 190);
            this.StaffDataGridView.TabIndex = 0;
            this.StaffDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StaffDataGridView_CellContentClick);
            this.StaffDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnCellDoubleClick);
            // 
            // crudPanel
            // 
            this.crudPanel.Controls.Add(this.Password_input);
            this.crudPanel.Controls.Add(this.Address_input);
            this.crudPanel.Controls.Add(this.Phone_no_input);
            this.crudPanel.Controls.Add(this.Email_input);
            this.crudPanel.Controls.Add(this.Last_name_input);
            this.crudPanel.Controls.Add(this.First_name_input);
            this.crudPanel.Controls.Add(this.Reset_btn);
            this.crudPanel.Controls.Add(this.RoleComoboBox);
            this.crudPanel.Controls.Add(this.Delete_btn);
            this.crudPanel.Controls.Add(this.Update_btn);
            this.crudPanel.Controls.Add(this.Add_btn);
            this.crudPanel.Controls.Add(this.guna2GradientPanel1);
            this.crudPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.crudPanel.Location = new System.Drawing.Point(0, 0);
            this.crudPanel.Name = "crudPanel";
            this.crudPanel.Size = new System.Drawing.Size(800, 260);
            this.crudPanel.TabIndex = 4;
            // 
            // Password_input
            // 
            this.Password_input.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Password_input.DefaultText = "";
            this.Password_input.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Password_input.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Password_input.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Password_input.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Password_input.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Password_input.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Password_input.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Password_input.Location = new System.Drawing.Point(271, 153);
            this.Password_input.Name = "Password_input";
            this.Password_input.PasswordChar = '\0';
            this.Password_input.PlaceholderText = "";
            this.Password_input.SelectedText = "";
            this.Password_input.Size = new System.Drawing.Size(200, 36);
            this.Password_input.TabIndex = 2;
            // 
            // Address_input
            // 
            this.Address_input.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Address_input.DefaultText = "";
            this.Address_input.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Address_input.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Address_input.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Address_input.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Address_input.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Address_input.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Address_input.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Address_input.Location = new System.Drawing.Point(16, 153);
            this.Address_input.Name = "Address_input";
            this.Address_input.PasswordChar = '\0';
            this.Address_input.PlaceholderText = "";
            this.Address_input.SelectedText = "";
            this.Address_input.Size = new System.Drawing.Size(200, 36);
            this.Address_input.TabIndex = 3;
            // 
            // Phone_no_input
            // 
            this.Phone_no_input.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Phone_no_input.DefaultText = "";
            this.Phone_no_input.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Phone_no_input.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Phone_no_input.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Phone_no_input.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Phone_no_input.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Phone_no_input.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Phone_no_input.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Phone_no_input.Location = new System.Drawing.Point(270, 93);
            this.Phone_no_input.Name = "Phone_no_input";
            this.Phone_no_input.PasswordChar = '\0';
            this.Phone_no_input.PlaceholderText = "";
            this.Phone_no_input.SelectedText = "";
            this.Phone_no_input.Size = new System.Drawing.Size(200, 36);
            this.Phone_no_input.TabIndex = 4;
            // 
            // Email_input
            // 
            this.Email_input.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Email_input.DefaultText = "";
            this.Email_input.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Email_input.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Email_input.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Email_input.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Email_input.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Email_input.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Email_input.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Email_input.Location = new System.Drawing.Point(15, 93);
            this.Email_input.Name = "Email_input";
            this.Email_input.PasswordChar = '\0';
            this.Email_input.PlaceholderText = "";
            this.Email_input.SelectedText = "";
            this.Email_input.Size = new System.Drawing.Size(200, 36);
            this.Email_input.TabIndex = 5;
            // 
            // Last_name_input
            // 
            this.Last_name_input.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Last_name_input.DefaultText = "";
            this.Last_name_input.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Last_name_input.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Last_name_input.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Last_name_input.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Last_name_input.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Last_name_input.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Last_name_input.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Last_name_input.Location = new System.Drawing.Point(271, 31);
            this.Last_name_input.Name = "Last_name_input";
            this.Last_name_input.PasswordChar = '\0';
            this.Last_name_input.PlaceholderText = "";
            this.Last_name_input.SelectedText = "";
            this.Last_name_input.Size = new System.Drawing.Size(200, 36);
            this.Last_name_input.TabIndex = 6;
            // 
            // First_name_input
            // 
            this.First_name_input.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.First_name_input.DefaultText = "";
            this.First_name_input.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.First_name_input.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.First_name_input.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.First_name_input.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.First_name_input.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.First_name_input.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.First_name_input.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.First_name_input.Location = new System.Drawing.Point(16, 28);
            this.First_name_input.Name = "First_name_input";
            this.First_name_input.PasswordChar = '\0';
            this.First_name_input.PlaceholderText = "";
            this.First_name_input.SelectedText = "";
            this.First_name_input.Size = new System.Drawing.Size(200, 36);
            this.First_name_input.TabIndex = 1;
            // 
            // Reset_btn
            // 
            this.Reset_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Reset_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Reset_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Reset_btn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Reset_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Reset_btn.FillColor = System.Drawing.Color.DarkGray;
            this.Reset_btn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Reset_btn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Reset_btn.ForeColor = System.Drawing.Color.Black;
            this.Reset_btn.Location = new System.Drawing.Point(447, 199);
            this.Reset_btn.Name = "Reset_btn";
            this.Reset_btn.Size = new System.Drawing.Size(118, 45);
            this.Reset_btn.TabIndex = 37;
            this.Reset_btn.Text = "Сброс";
            this.Reset_btn.Click += new System.EventHandler(this.Reset_btn_Click_1);
            // 
            // RoleComoboBox
            // 
            this.RoleComoboBox.BackColor = System.Drawing.Color.White;
            this.RoleComoboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RoleComoboBox.ForeColor = System.Drawing.Color.Black;
            this.RoleComoboBox.FormattingEnabled = true;
            this.RoleComoboBox.Items.AddRange(new object[] {
            "Admin",
            "Staff"});
            this.RoleComoboBox.Location = new System.Drawing.Point(532, 31);
            this.RoleComoboBox.Name = "RoleComoboBox";
            this.RoleComoboBox.Size = new System.Drawing.Size(121, 21);
            this.RoleComoboBox.TabIndex = 30;
            // 
            // Delete_btn
            // 
            this.Delete_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Delete_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Delete_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Delete_btn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Delete_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Delete_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Delete_btn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Delete_btn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Delete_btn.ForeColor = System.Drawing.Color.Black;
            this.Delete_btn.Location = new System.Drawing.Point(302, 199);
            this.Delete_btn.Name = "Delete_btn";
            this.Delete_btn.Size = new System.Drawing.Size(119, 45);
            this.Delete_btn.TabIndex = 36;
            this.Delete_btn.Text = "Удалить";
            this.Delete_btn.Click += new System.EventHandler(this.Delete_btn_Click_1);
            // 
            // Update_btn
            // 
            this.Update_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Update_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Update_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Update_btn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Update_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Update_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Update_btn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Update_btn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Update_btn.ForeColor = System.Drawing.Color.Black;
            this.Update_btn.Location = new System.Drawing.Point(155, 199);
            this.Update_btn.Name = "Update_btn";
            this.Update_btn.Size = new System.Drawing.Size(119, 45);
            this.Update_btn.TabIndex = 35;
            this.Update_btn.Text = "Обнавить данные";
            this.Update_btn.Click += new System.EventHandler(this.Update_btn_Click_1);
            // 
            // Add_btn
            // 
            this.Add_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Add_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Add_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Add_btn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Add_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Add_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Add_btn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Add_btn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add_btn.ForeColor = System.Drawing.Color.Black;
            this.Add_btn.Location = new System.Drawing.Point(16, 199);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(119, 45);
            this.Add_btn.TabIndex = 3;
            this.Add_btn.Text = "Добавить пациента";
            this.Add_btn.Click += new System.EventHandler(this.Add_btn_Click_1);
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Controls.Add(this.First_name_label);
            this.guna2GradientPanel1.Controls.Add(this.Password_label);
            this.guna2GradientPanel1.Controls.Add(this.Role_label);
            this.guna2GradientPanel1.Controls.Add(this.Last_name_label);
            this.guna2GradientPanel1.Controls.Add(this.email_address_label);
            this.guna2GradientPanel1.Controls.Add(this.home_address_label);
            this.guna2GradientPanel1.Controls.Add(this.phone_no_label);
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.White;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(800, 260);
            this.guna2GradientPanel1.TabIndex = 43;
            // 
            // First_name_label
            // 
            this.First_name_label.AutoSize = true;
            this.First_name_label.BackColor = System.Drawing.Color.Transparent;
            this.First_name_label.Cursor = System.Windows.Forms.Cursors.Default;
            this.First_name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.First_name_label.Location = new System.Drawing.Point(13, 10);
            this.First_name_label.Name = "First_name_label";
            this.First_name_label.Size = new System.Drawing.Size(41, 18);
            this.First_name_label.TabIndex = 38;
            this.First_name_label.Text = "Имя";
            // 
            // Role_label
            // 
            this.Role_label.AutoSize = true;
            this.Role_label.BackColor = System.Drawing.Color.Transparent;
            this.Role_label.Cursor = System.Windows.Forms.Cursors.Default;
            this.Role_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Role_label.Location = new System.Drawing.Point(528, 9);
            this.Role_label.Name = "Role_label";
            this.Role_label.Size = new System.Drawing.Size(227, 18);
            this.Role_label.TabIndex = 29;
            this.Role_label.Text = "Какие права предоставить?";
            // 
            // Last_name_label
            // 
            this.Last_name_label.AutoSize = true;
            this.Last_name_label.BackColor = System.Drawing.Color.Transparent;
            this.Last_name_label.Cursor = System.Windows.Forms.Cursors.Default;
            this.Last_name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Last_name_label.Location = new System.Drawing.Point(268, 10);
            this.Last_name_label.Name = "Last_name_label";
            this.Last_name_label.Size = new System.Drawing.Size(80, 18);
            this.Last_name_label.TabIndex = 39;
            this.Last_name_label.Text = "Фамилия";
            // 
            // email_address_label
            // 
            this.email_address_label.AutoSize = true;
            this.email_address_label.BackColor = System.Drawing.Color.Transparent;
            this.email_address_label.Cursor = System.Windows.Forms.Cursors.Default;
            this.email_address_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.email_address_label.Location = new System.Drawing.Point(12, 73);
            this.email_address_label.Name = "email_address_label";
            this.email_address_label.Size = new System.Drawing.Size(214, 18);
            this.email_address_label.TabIndex = 40;
            this.email_address_label.Text = "Адрес электронной почты";
            // 
            // home_address_label
            // 
            this.home_address_label.AutoSize = true;
            this.home_address_label.BackColor = System.Drawing.Color.Transparent;
            this.home_address_label.Cursor = System.Windows.Forms.Cursors.Default;
            this.home_address_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.home_address_label.Location = new System.Drawing.Point(12, 134);
            this.home_address_label.Name = "home_address_label";
            this.home_address_label.Size = new System.Drawing.Size(154, 18);
            this.home_address_label.TabIndex = 42;
            this.home_address_label.Text = "Адрес проживания";
            // 
            // phone_no_label
            // 
            this.phone_no_label.AutoSize = true;
            this.phone_no_label.BackColor = System.Drawing.Color.Transparent;
            this.phone_no_label.Cursor = System.Windows.Forms.Cursors.Default;
            this.phone_no_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phone_no_label.Location = new System.Drawing.Point(266, 73);
            this.phone_no_label.Name = "phone_no_label";
            this.phone_no_label.Size = new System.Drawing.Size(143, 18);
            this.phone_no_label.TabIndex = 41;
            this.phone_no_label.Text = "Номер телефона";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this.First_name_input;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.TargetControl = this.Last_name_input;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.TargetControl = this.Email_input;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.TargetControl = this.Phone_no_input;
            // 
            // guna2Elipse5
            // 
            this.guna2Elipse5.TargetControl = this.Address_input;
            // 
            // guna2Elipse6
            // 
            this.guna2Elipse6.TargetControl = this.Password_input;
            // 
            // guna2Elipse7
            // 
            this.guna2Elipse7.TargetControl = this.RoleComoboBox;
            // 
            // guna2Elipse8
            // 
            this.guna2Elipse8.TargetControl = this.Update_btn;
            // 
            // guna2Elipse9
            // 
            this.guna2Elipse9.TargetControl = this.Delete_btn;
            // 
            // guna2Elipse10
            // 
            this.guna2Elipse10.TargetControl = this.Reset_btn;
            // 
            // guna2Elipse11
            // 
            this.guna2Elipse11.TargetControl = this.Update_btn;
            // 
            // StaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataPanel);
            this.Controls.Add(this.crudPanel);
            this.Name = "StaffForm";
            this.Text = "Персонал";
            this.Load += new System.EventHandler(this.StaffForm_Load);
            this.dataPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StaffDataGridView)).EndInit();
            this.crudPanel.ResumeLayout(false);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label Password_label;
        private System.Windows.Forms.Panel dataPanel;
        private System.Windows.Forms.DataGridView StaffDataGridView;
        private System.Windows.Forms.Panel crudPanel;
        private System.Windows.Forms.ComboBox RoleComoboBox;
        private System.Windows.Forms.Label Role_label;
        private Guna.UI2.WinForms.Guna2GradientButton Add_btn;
        private Guna.UI2.WinForms.Guna2GradientButton Update_btn;
        private Guna.UI2.WinForms.Guna2GradientButton Delete_btn;
        private Guna.UI2.WinForms.Guna2GradientButton Reset_btn;
        private System.Windows.Forms.Label First_name_label;
        private System.Windows.Forms.Label Last_name_label;
        private System.Windows.Forms.Label email_address_label;
        private System.Windows.Forms.Label phone_no_label;
        private System.Windows.Forms.Label home_address_label;
        private Guna.UI2.WinForms.Guna2TextBox Email_input;
        private Guna.UI2.WinForms.Guna2TextBox Phone_no_input;
        private Guna.UI2.WinForms.Guna2TextBox Address_input;
        private Guna.UI2.WinForms.Guna2TextBox Password_input;
        private Guna.UI2.WinForms.Guna2TextBox Last_name_input;
        private Guna.UI2.WinForms.Guna2TextBox First_name_input;
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
    }
}