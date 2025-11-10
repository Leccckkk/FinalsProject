namespace FinalsProject.FacultyControls
{
    partial class Dashboard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtnotyet = new System.Windows.Forms.Label();
            this.txtfailed = new System.Windows.Forms.Label();
            this.txtpassed = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtpassrate = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtexams = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtquestions = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtstudents = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtnotyet
            // 
            this.txtnotyet.Font = new System.Drawing.Font("Cascadia Code", 14F);
            this.txtnotyet.Location = new System.Drawing.Point(1331, 72);
            this.txtnotyet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtnotyet.Name = "txtnotyet";
            this.txtnotyet.Size = new System.Drawing.Size(183, 55);
            this.txtnotyet.TabIndex = 6;
            this.txtnotyet.Text = "1";
            // 
            // txtfailed
            // 
            this.txtfailed.Font = new System.Drawing.Font("Cascadia Code", 14F);
            this.txtfailed.ForeColor = System.Drawing.Color.Maroon;
            this.txtfailed.Location = new System.Drawing.Point(686, 71);
            this.txtfailed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtfailed.Name = "txtfailed";
            this.txtfailed.Size = new System.Drawing.Size(183, 45);
            this.txtfailed.TabIndex = 5;
            this.txtfailed.Text = "1";
            // 
            // txtpassed
            // 
            this.txtpassed.Font = new System.Drawing.Font("Cascadia Code", 14F);
            this.txtpassed.ForeColor = System.Drawing.Color.Green;
            this.txtpassed.Location = new System.Drawing.Point(36, 73);
            this.txtpassed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtpassed.Name = "txtpassed";
            this.txtpassed.Size = new System.Drawing.Size(183, 63);
            this.txtpassed.TabIndex = 4;
            this.txtpassed.Text = "1";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Geoform", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1329, 31);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(490, 35);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total Students Not Yet Taken Exam";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Geoform", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(36, 31);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(363, 35);
            this.label9.TabIndex = 0;
            this.label9.Text = "Total Students Passed";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.txtnotyet);
            this.panel5.Controls.Add(this.txtfailed);
            this.panel5.Controls.Add(this.txtpassed);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Location = new System.Drawing.Point(24, 107);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1825, 208);
            this.panel5.TabIndex = 9;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Geoform", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(686, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(327, 35);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total Students Failed";
            // 
            // txtpassrate
            // 
            this.txtpassrate.Font = new System.Drawing.Font("Cascadia Code", 15F);
            this.txtpassrate.Location = new System.Drawing.Point(-1, 108);
            this.txtpassrate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtpassrate.Name = "txtpassrate";
            this.txtpassrate.Size = new System.Drawing.Size(390, 71);
            this.txtpassrate.TabIndex = 1;
            this.txtpassrate.Text = "1";
            this.txtpassrate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Geoform", 20F);
            this.label7.Location = new System.Drawing.Point(-1, 38);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(390, 77);
            this.label7.TabIndex = 0;
            this.label7.Text = "Pass Rate";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.txtpassrate);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Location = new System.Drawing.Point(1449, 477);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(395, 220);
            this.panel4.TabIndex = 8;
            // 
            // txtexams
            // 
            this.txtexams.Font = new System.Drawing.Font("Cascadia Code", 15F);
            this.txtexams.Location = new System.Drawing.Point(-1, 113);
            this.txtexams.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtexams.Name = "txtexams";
            this.txtexams.Size = new System.Drawing.Size(395, 69);
            this.txtexams.TabIndex = 1;
            this.txtexams.Text = "1";
            this.txtexams.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txtexams);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(986, 477);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(395, 220);
            this.panel3.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Geoform", 16F);
            this.label5.Location = new System.Drawing.Point(-1, 13);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(395, 102);
            this.label5.TabIndex = 0;
            this.label5.Text = "Total Students (Completed Exam)";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtquestions
            // 
            this.txtquestions.Font = new System.Drawing.Font("Cascadia Code", 15F);
            this.txtquestions.Location = new System.Drawing.Point(-1, 114);
            this.txtquestions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtquestions.Name = "txtquestions";
            this.txtquestions.Size = new System.Drawing.Size(395, 69);
            this.txtquestions.TabIndex = 1;
            this.txtquestions.Text = "1";
            this.txtquestions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Geoform", 16F);
            this.label3.Location = new System.Drawing.Point(-1, 33);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(395, 76);
            this.label3.TabIndex = 0;
            this.label3.Text = "Questions";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtquestions);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(507, 476);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(395, 220);
            this.panel2.TabIndex = 6;
            // 
            // txtstudents
            // 
            this.txtstudents.Font = new System.Drawing.Font("Cascadia Code", 15F);
            this.txtstudents.Location = new System.Drawing.Point(-1, 117);
            this.txtstudents.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtstudents.Name = "txtstudents";
            this.txtstudents.Size = new System.Drawing.Size(395, 70);
            this.txtstudents.TabIndex = 1;
            this.txtstudents.Text = "1";
            this.txtstudents.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtstudents.Click += new System.EventHandler(this.txtstudents_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Geoform", 16F);
            this.label1.Location = new System.Drawing.Point(-1, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 70);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Students";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtstudents);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(29, 477);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(395, 220);
            this.panel1.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 25);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(718, 59);
            this.label6.TabIndex = 17;
            this.label6.Text = "OVERALL FACULTY BOARD";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(28, 403);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(718, 59);
            this.label8.TabIndex = 18;
            this.label8.Text = "RESULT";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Dashboard";
            this.Size = new System.Drawing.Size(1870, 792);
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label txtnotyet;
        private System.Windows.Forms.Label txtfailed;
        private System.Windows.Forms.Label txtpassed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtpassrate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label txtexams;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label txtquestions;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label txtstudents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
    }
}
