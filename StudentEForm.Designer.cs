namespace FinalsProject
{
    partial class StudentEForm
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
            this.panelContainer = new System.Windows.Forms.Panel();
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_takeexam = new System.Windows.Forms.Button();
            this.btn_dashboard = new System.Windows.Forms.Button();
            this.btn_viewresults = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.Location = new System.Drawing.Point(23, 183);
            this.panelContainer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1872, 803);
            this.panelContainer.TabIndex = 7;
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.Red;
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_logout.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.ForeColor = System.Drawing.Color.White;
            this.btn_logout.Location = new System.Drawing.Point(1925, 28);
            this.btn_logout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(129, 45);
            this.btn_logout.TabIndex = 6;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_takeexam
            // 
            this.btn_takeexam.BackColor = System.Drawing.Color.Green;
            this.btn_takeexam.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_takeexam.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_takeexam.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_takeexam.ForeColor = System.Drawing.Color.Black;
            this.btn_takeexam.Location = new System.Drawing.Point(241, 93);
            this.btn_takeexam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_takeexam.Name = "btn_takeexam";
            this.btn_takeexam.Size = new System.Drawing.Size(201, 63);
            this.btn_takeexam.TabIndex = 4;
            this.btn_takeexam.Text = "Take Exam";
            this.btn_takeexam.UseVisualStyleBackColor = false;
            this.btn_takeexam.Click += new System.EventHandler(this.btn_results_Click);
            // 
            // btn_dashboard
            // 
            this.btn_dashboard.BackColor = System.Drawing.Color.Gold;
            this.btn_dashboard.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_dashboard.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dashboard.ForeColor = System.Drawing.Color.Black;
            this.btn_dashboard.Location = new System.Drawing.Point(24, 93);
            this.btn_dashboard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_dashboard.Name = "btn_dashboard";
            this.btn_dashboard.Size = new System.Drawing.Size(200, 63);
            this.btn_dashboard.TabIndex = 3;
            this.btn_dashboard.Text = "Dashboard";
            this.btn_dashboard.UseVisualStyleBackColor = false;
            this.btn_dashboard.Click += new System.EventHandler(this.btn_dashboard_Click);
            // 
            // btn_viewresults
            // 
            this.btn_viewresults.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_viewresults.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_viewresults.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_viewresults.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_viewresults.ForeColor = System.Drawing.Color.White;
            this.btn_viewresults.Location = new System.Drawing.Point(461, 93);
            this.btn_viewresults.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_viewresults.Name = "btn_viewresults";
            this.btn_viewresults.Size = new System.Drawing.Size(192, 63);
            this.btn_viewresults.TabIndex = 5;
            this.btn_viewresults.Text = "View Results";
            this.btn_viewresults.UseVisualStyleBackColor = false;
            this.btn_viewresults.Click += new System.EventHandler(this.btn_viewresults_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Cascadia Code", 10F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1737, 11);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 65);
            this.button1.TabIndex = 6;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // StudentEForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FinalsProject.Properties.Resources.student_dashoard;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Controls.Add(this.btn_viewresults);
            this.Controls.Add(this.btn_dashboard);
            this.Controls.Add(this.btn_takeexam);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_logout);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "StudentEForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentEForm";
            this.Load += new System.EventHandler(this.StudentEForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Button btn_dashboard;
        private System.Windows.Forms.Button btn_takeexam;
        private System.Windows.Forms.Button btn_viewresults;
        private System.Windows.Forms.Button button1;
    }
}