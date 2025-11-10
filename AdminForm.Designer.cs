namespace FinalsProject
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
            this.btn_reports = new System.Windows.Forms.Button();
            this.btn_studentmanagement = new System.Windows.Forms.Button();
            this.btn_questionmanagement = new System.Windows.Forms.Button();
            this.btn_usermanagement = new System.Windows.Forms.Button();
            this.btn_dashboard = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.btn_chart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_reports
            // 
            this.btn_reports.BackColor = System.Drawing.Color.DarkKhaki;
            this.btn_reports.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btn_reports.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_reports.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reports.ForeColor = System.Drawing.Color.White;
            this.btn_reports.Location = new System.Drawing.Point(25, 418);
            this.btn_reports.Name = "btn_reports";
            this.btn_reports.Size = new System.Drawing.Size(228, 66);
            this.btn_reports.TabIndex = 6;
            this.btn_reports.Text = "Reports";
            this.btn_reports.UseVisualStyleBackColor = false;
            this.btn_reports.Click += new System.EventHandler(this.btn_reports_Click);
            // 
            // btn_studentmanagement
            // 
            this.btn_studentmanagement.BackColor = System.Drawing.Color.DarkKhaki;
            this.btn_studentmanagement.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btn_studentmanagement.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_studentmanagement.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_studentmanagement.ForeColor = System.Drawing.Color.White;
            this.btn_studentmanagement.Location = new System.Drawing.Point(25, 336);
            this.btn_studentmanagement.Name = "btn_studentmanagement";
            this.btn_studentmanagement.Size = new System.Drawing.Size(228, 64);
            this.btn_studentmanagement.TabIndex = 6;
            this.btn_studentmanagement.Text = "Student Info Management";
            this.btn_studentmanagement.UseVisualStyleBackColor = false;
            this.btn_studentmanagement.Click += new System.EventHandler(this.btn_studentmanagement_Click);
            // 
            // btn_questionmanagement
            // 
            this.btn_questionmanagement.BackColor = System.Drawing.Color.DarkKhaki;
            this.btn_questionmanagement.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btn_questionmanagement.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_questionmanagement.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_questionmanagement.ForeColor = System.Drawing.Color.White;
            this.btn_questionmanagement.Location = new System.Drawing.Point(25, 253);
            this.btn_questionmanagement.Name = "btn_questionmanagement";
            this.btn_questionmanagement.Size = new System.Drawing.Size(228, 60);
            this.btn_questionmanagement.TabIndex = 5;
            this.btn_questionmanagement.Text = "Question Management";
            this.btn_questionmanagement.UseVisualStyleBackColor = false;
            this.btn_questionmanagement.Click += new System.EventHandler(this.btn_questionmanagement_Click);
            // 
            // btn_usermanagement
            // 
            this.btn_usermanagement.BackColor = System.Drawing.Color.DarkKhaki;
            this.btn_usermanagement.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_usermanagement.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_usermanagement.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_usermanagement.ForeColor = System.Drawing.Color.White;
            this.btn_usermanagement.Location = new System.Drawing.Point(25, 168);
            this.btn_usermanagement.Name = "btn_usermanagement";
            this.btn_usermanagement.Size = new System.Drawing.Size(228, 64);
            this.btn_usermanagement.TabIndex = 4;
            this.btn_usermanagement.Text = "User Management";
            this.btn_usermanagement.UseVisualStyleBackColor = false;
            this.btn_usermanagement.Click += new System.EventHandler(this.btn_usermanagement_Click);
            // 
            // btn_dashboard
            // 
            this.btn_dashboard.BackColor = System.Drawing.Color.DarkKhaki;
            this.btn_dashboard.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_dashboard.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dashboard.ForeColor = System.Drawing.Color.Transparent;
            this.btn_dashboard.Location = new System.Drawing.Point(25, 92);
            this.btn_dashboard.Name = "btn_dashboard";
            this.btn_dashboard.Size = new System.Drawing.Size(228, 65);
            this.btn_dashboard.TabIndex = 3;
            this.btn_dashboard.Text = "Dashboard";
            this.btn_dashboard.UseVisualStyleBackColor = false;
            this.btn_dashboard.Click += new System.EventHandler(this.btn_dashboard_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.Maroon;
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_logout.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.ForeColor = System.Drawing.Color.White;
            this.btn_logout.Location = new System.Drawing.Point(1133, 13);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(124, 42);
            this.btn_logout.TabIndex = 2;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Location = new System.Drawing.Point(265, 66);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1047, 702);
            this.panelContainer.TabIndex = 3;
            this.panelContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContainer_Paint);
            // 
            // btn_chart
            // 
            this.btn_chart.BackColor = System.Drawing.Color.DarkKhaki;
            this.btn_chart.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btn_chart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_chart.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_chart.ForeColor = System.Drawing.Color.White;
            this.btn_chart.Location = new System.Drawing.Point(25, 503);
            this.btn_chart.Name = "btn_chart";
            this.btn_chart.Size = new System.Drawing.Size(228, 66);
            this.btn_chart.TabIndex = 7;
            this.btn_chart.Text = "Report Chart";
            this.btn_chart.UseVisualStyleBackColor = false;
            this.btn_chart.Click += new System.EventHandler(this.btn_chart_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::FinalsProject.Properties.Resources.Dashboard_Form;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1312, 666);
            this.Controls.Add(this.btn_chart);
            this.Controls.Add(this.btn_reports);
            this.Controls.Add(this.btn_studentmanagement);
            this.Controls.Add(this.btn_questionmanagement);
            this.Controls.Add(this.btn_usermanagement);
            this.Controls.Add(this.btn_dashboard);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.btn_logout);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Button btn_reports;
        private System.Windows.Forms.Button btn_studentmanagement;
        private System.Windows.Forms.Button btn_questionmanagement;
        private System.Windows.Forms.Button btn_usermanagement;
        private System.Windows.Forms.Button btn_dashboard;
        private System.Windows.Forms.Button btn_chart;
    }
}