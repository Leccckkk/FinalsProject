namespace FinalsProject
{
    partial class FacultyForm
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
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_dashboard = new System.Windows.Forms.Button();
            this.btn_studentmanagement = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.btn_reports = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.Maroon;
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_logout.Font = new System.Drawing.Font("Cascadia Code", 10F);
            this.btn_logout.ForeColor = System.Drawing.Color.White;
            this.btn_logout.Location = new System.Drawing.Point(1742, 14);
            this.btn_logout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(141, 56);
            this.btn_logout.TabIndex = 6;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_dashboard
            // 
            this.btn_dashboard.BackColor = System.Drawing.Color.Gold;
            this.btn_dashboard.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_dashboard.Font = new System.Drawing.Font("Geoform", 10F, System.Drawing.FontStyle.Bold);
            this.btn_dashboard.ForeColor = System.Drawing.Color.Black;
            this.btn_dashboard.Location = new System.Drawing.Point(13, 94);
            this.btn_dashboard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_dashboard.Name = "btn_dashboard";
            this.btn_dashboard.Size = new System.Drawing.Size(212, 63);
            this.btn_dashboard.TabIndex = 3;
            this.btn_dashboard.Text = "Dashboard";
            this.btn_dashboard.UseVisualStyleBackColor = false;
            this.btn_dashboard.Click += new System.EventHandler(this.btn_dashboard_Click);
            // 
            // btn_studentmanagement
            // 
            this.btn_studentmanagement.BackColor = System.Drawing.Color.Green;
            this.btn_studentmanagement.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btn_studentmanagement.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_studentmanagement.Font = new System.Drawing.Font("Geoform", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_studentmanagement.ForeColor = System.Drawing.Color.White;
            this.btn_studentmanagement.Location = new System.Drawing.Point(233, 94);
            this.btn_studentmanagement.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_studentmanagement.Name = "btn_studentmanagement";
            this.btn_studentmanagement.Size = new System.Drawing.Size(266, 63);
            this.btn_studentmanagement.TabIndex = 6;
            this.btn_studentmanagement.Text = "Student Management";
            this.btn_studentmanagement.UseVisualStyleBackColor = false;
            this.btn_studentmanagement.Click += new System.EventHandler(this.btn_studentmanagement_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Location = new System.Drawing.Point(23, 185);
            this.panelContainer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1870, 792);
            this.panelContainer.TabIndex = 7;
            // 
            // btn_reports
            // 
            this.btn_reports.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_reports.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btn_reports.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_reports.Font = new System.Drawing.Font("Geoform", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reports.ForeColor = System.Drawing.Color.White;
            this.btn_reports.Location = new System.Drawing.Point(513, 94);
            this.btn_reports.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_reports.Name = "btn_reports";
            this.btn_reports.Size = new System.Drawing.Size(256, 63);
            this.btn_reports.TabIndex = 6;
            this.btn_reports.Text = "Reports";
            this.btn_reports.UseVisualStyleBackColor = false;
            this.btn_reports.Click += new System.EventHandler(this.btn_reports_Click);
            // 
            // FacultyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FinalsProject.Properties.Resources.Faculty_Dashboard;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Controls.Add(this.btn_reports);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.btn_studentmanagement);
            this.Controls.Add(this.btn_dashboard);
            this.Controls.Add(this.btn_logout);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FacultyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FacultyForm";
            this.Load += new System.EventHandler(this.FacultyForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Button btn_dashboard;
        private System.Windows.Forms.Button btn_studentmanagement;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Button btn_reports;
    }
}