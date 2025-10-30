﻿namespace FinalsProject
{
    partial class AdminForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_reports = new System.Windows.Forms.Button();
            this.btn_studentmanagement = new System.Windows.Forms.Button();
            this.btn_questionmanagement = new System.Windows.Forms.Button();
            this.btn_usermanagement = new System.Windows.Forms.Button();
            this.btn_dashboard = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dashboard";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.btn_reports);
            this.panel1.Controls.Add(this.btn_studentmanagement);
            this.panel1.Controls.Add(this.btn_questionmanagement);
            this.panel1.Controls.Add(this.btn_usermanagement);
            this.panel1.Controls.Add(this.btn_dashboard);
            this.panel1.Location = new System.Drawing.Point(0, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1017, 48);
            this.panel1.TabIndex = 1;
            // 
            // btn_reports
            // 
            this.btn_reports.BackColor = System.Drawing.Color.White;
            this.btn_reports.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btn_reports.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_reports.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reports.ForeColor = System.Drawing.Color.Black;
            this.btn_reports.Location = new System.Drawing.Point(743, 3);
            this.btn_reports.Name = "btn_reports";
            this.btn_reports.Size = new System.Drawing.Size(177, 41);
            this.btn_reports.TabIndex = 6;
            this.btn_reports.Text = "Reports";
            this.btn_reports.UseVisualStyleBackColor = false;
            this.btn_reports.Click += new System.EventHandler(this.btn_reports_Click);
            // 
            // btn_studentmanagement
            // 
            this.btn_studentmanagement.BackColor = System.Drawing.Color.White;
            this.btn_studentmanagement.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btn_studentmanagement.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_studentmanagement.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_studentmanagement.ForeColor = System.Drawing.Color.Black;
            this.btn_studentmanagement.Location = new System.Drawing.Point(560, 3);
            this.btn_studentmanagement.Name = "btn_studentmanagement";
            this.btn_studentmanagement.Size = new System.Drawing.Size(177, 41);
            this.btn_studentmanagement.TabIndex = 6;
            this.btn_studentmanagement.Text = "Student Management";
            this.btn_studentmanagement.UseVisualStyleBackColor = false;
            this.btn_studentmanagement.Click += new System.EventHandler(this.btn_studentmanagement_Click);
            // 
            // btn_questionmanagement
            // 
            this.btn_questionmanagement.BackColor = System.Drawing.Color.White;
            this.btn_questionmanagement.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btn_questionmanagement.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_questionmanagement.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_questionmanagement.ForeColor = System.Drawing.Color.Black;
            this.btn_questionmanagement.Location = new System.Drawing.Point(377, 3);
            this.btn_questionmanagement.Name = "btn_questionmanagement";
            this.btn_questionmanagement.Size = new System.Drawing.Size(177, 41);
            this.btn_questionmanagement.TabIndex = 5;
            this.btn_questionmanagement.Text = "Question Management";
            this.btn_questionmanagement.UseVisualStyleBackColor = false;
            this.btn_questionmanagement.Click += new System.EventHandler(this.btn_questionmanagement_Click);
            // 
            // btn_usermanagement
            // 
            this.btn_usermanagement.BackColor = System.Drawing.Color.White;
            this.btn_usermanagement.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_usermanagement.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_usermanagement.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_usermanagement.ForeColor = System.Drawing.Color.Black;
            this.btn_usermanagement.Location = new System.Drawing.Point(208, 3);
            this.btn_usermanagement.Name = "btn_usermanagement";
            this.btn_usermanagement.Size = new System.Drawing.Size(163, 41);
            this.btn_usermanagement.TabIndex = 4;
            this.btn_usermanagement.Text = "User Management";
            this.btn_usermanagement.UseVisualStyleBackColor = false;
            this.btn_usermanagement.Click += new System.EventHandler(this.btn_usermanagement_Click);
            // 
            // btn_dashboard
            // 
            this.btn_dashboard.BackColor = System.Drawing.Color.White;
            this.btn_dashboard.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_dashboard.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dashboard.ForeColor = System.Drawing.Color.Black;
            this.btn_dashboard.Location = new System.Drawing.Point(91, 3);
            this.btn_dashboard.Name = "btn_dashboard";
            this.btn_dashboard.Size = new System.Drawing.Size(111, 41);
            this.btn_dashboard.TabIndex = 3;
            this.btn_dashboard.Text = "Dashboard";
            this.btn_dashboard.UseVisualStyleBackColor = false;
            this.btn_dashboard.Click += new System.EventHandler(this.btn_dashboard_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.Red;
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_logout.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.ForeColor = System.Drawing.Color.White;
            this.btn_logout.Location = new System.Drawing.Point(903, 24);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(86, 29);
            this.btn_logout.TabIndex = 2;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Location = new System.Drawing.Point(0, 116);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1017, 363);
            this.panelContainer.TabIndex = 3;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1017, 477);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Button btn_reports;
        private System.Windows.Forms.Button btn_studentmanagement;
        private System.Windows.Forms.Button btn_questionmanagement;
        private System.Windows.Forms.Button btn_usermanagement;
        private System.Windows.Forms.Button btn_dashboard;
    }
}