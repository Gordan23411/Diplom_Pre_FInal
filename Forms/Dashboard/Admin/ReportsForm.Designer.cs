namespace HealthCare_Plus.Forms.Dashboard.Admin
{
    partial class ReportsForm
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.Title_label = new System.Windows.Forms.Label();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.BodyPanel = new System.Windows.Forms.Panel();
            this.reportsView = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DoctorsReportBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.PatientsReportBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.PaymentsReportBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.TopPanel.SuspendLayout();
            this.guna2GradientPanel1.SuspendLayout();
            this.BodyPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title_label
            // 
            this.Title_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Title_label.AutoSize = true;
            this.Title_label.BackColor = System.Drawing.Color.Transparent;
            this.Title_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Title_label.Location = new System.Drawing.Point(360, 9);
            this.Title_label.Name = "Title_label";
            this.Title_label.Size = new System.Drawing.Size(194, 24);
            this.Title_label.TabIndex = 1;
            this.Title_label.Text = "Создание отчётов";
            // 
            // TopPanel
            // 
            this.TopPanel.Controls.Add(this.guna2GradientPanel1);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(884, 136);
            this.TopPanel.TabIndex = 24;
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Controls.Add(this.PaymentsReportBtn);
            this.guna2GradientPanel1.Controls.Add(this.DoctorsReportBtn);
            this.guna2GradientPanel1.Controls.Add(this.PatientsReportBtn);
            this.guna2GradientPanel1.Controls.Add(this.Title_label);
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.guna2GradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(884, 136);
            this.guna2GradientPanel1.TabIndex = 0;
            // 
            // BodyPanel
            // 
            this.BodyPanel.Controls.Add(this.reportsView);
            this.BodyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BodyPanel.Location = new System.Drawing.Point(0, 136);
            this.BodyPanel.Name = "BodyPanel";
            this.BodyPanel.Size = new System.Drawing.Size(884, 375);
            this.BodyPanel.TabIndex = 25;
            // 
            // reportsView
            // 
            this.reportsView.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DoctorsDataSet";
            reportDataSource1.Value = null;
            this.reportsView.LocalReport.DataSources.Add(reportDataSource1);
            this.reportsView.LocalReport.ReportEmbeddedResource = "HealthCare_Plus.Forms.Dashboard.Reports.DoctorsReport.rdlc";
            this.reportsView.Location = new System.Drawing.Point(0, 0);
            this.reportsView.Name = "reportsView";
            this.reportsView.ServerReport.BearerToken = null;
            this.reportsView.Size = new System.Drawing.Size(884, 375);
            this.reportsView.TabIndex = 0;
            this.reportsView.Load += new System.EventHandler(this.reportsView_Load);
            // 
            // DoctorsReportBtn
            // 
            this.DoctorsReportBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DoctorsReportBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DoctorsReportBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DoctorsReportBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DoctorsReportBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DoctorsReportBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.DoctorsReportBtn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.DoctorsReportBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DoctorsReportBtn.ForeColor = System.Drawing.Color.Black;
            this.DoctorsReportBtn.Location = new System.Drawing.Point(239, 60);
            this.DoctorsReportBtn.Name = "DoctorsReportBtn";
            this.DoctorsReportBtn.Size = new System.Drawing.Size(119, 45);
            this.DoctorsReportBtn.TabIndex = 2;
            this.DoctorsReportBtn.Text = "Докторский отчет";
            this.DoctorsReportBtn.Click += new System.EventHandler(this.DoctorsReportBtn_Click_1);
            // 
            // PatientsReportBtn
            // 
            this.PatientsReportBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.PatientsReportBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.PatientsReportBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.PatientsReportBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.PatientsReportBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.PatientsReportBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.PatientsReportBtn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.PatientsReportBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PatientsReportBtn.ForeColor = System.Drawing.Color.Black;
            this.PatientsReportBtn.Location = new System.Drawing.Point(389, 60);
            this.PatientsReportBtn.Name = "PatientsReportBtn";
            this.PatientsReportBtn.Size = new System.Drawing.Size(119, 45);
            this.PatientsReportBtn.TabIndex = 3;
            this.PatientsReportBtn.Text = "Отчет о пациентах";
            this.PatientsReportBtn.Click += new System.EventHandler(this.PatientsReportBtn_Click_1);
            // 
            // PaymentsReportBtn
            // 
            this.PaymentsReportBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.PaymentsReportBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.PaymentsReportBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.PaymentsReportBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.PaymentsReportBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.PaymentsReportBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.PaymentsReportBtn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.PaymentsReportBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PaymentsReportBtn.ForeColor = System.Drawing.Color.Black;
            this.PaymentsReportBtn.Location = new System.Drawing.Point(557, 60);
            this.PaymentsReportBtn.Name = "PaymentsReportBtn";
            this.PaymentsReportBtn.Size = new System.Drawing.Size(119, 45);
            this.PaymentsReportBtn.TabIndex = 4;
            this.PaymentsReportBtn.Text = "Отчеты об оплатах";
            this.PaymentsReportBtn.Click += new System.EventHandler(this.PaymentsReportBtn_Click_1);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this.DoctorsReportBtn;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.TargetControl = this.PatientsReportBtn;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.TargetControl = this.PaymentsReportBtn;
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 511);
            this.Controls.Add(this.BodyPanel);
            this.Controls.Add(this.TopPanel);
            this.Name = "ReportsForm";
            this.Text = "Отчёты";
            this.Load += new System.EventHandler(this.ReportsForm_Load);
            this.TopPanel.ResumeLayout(false);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            this.BodyPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Title_label;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Panel BodyPanel;
        private Microsoft.Reporting.WinForms.ReportViewer reportsView;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2GradientButton DoctorsReportBtn;
        private Guna.UI2.WinForms.Guna2GradientButton PaymentsReportBtn;
        private Guna.UI2.WinForms.Guna2GradientButton PatientsReportBtn;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
    }
}