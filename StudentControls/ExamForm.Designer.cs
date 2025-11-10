namespace FinalsProject.StudentControls
{
    partial class ExamForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_StudName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtstats = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtaverage = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Beige;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txt_StudName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(41, 276);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(399, 236);
            this.panel1.TabIndex = 10;
            // 
            // txt_StudName
            // 
            this.txt_StudName.Font = new System.Drawing.Font("Cascadia Code", 14F, System.Drawing.FontStyle.Bold);
            this.txt_StudName.Location = new System.Drawing.Point(137, 117);
            this.txt_StudName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_StudName.Name = "txt_StudName";
            this.txt_StudName.Size = new System.Drawing.Size(211, 35);
            this.txt_StudName.TabIndex = 1;
            this.txt_StudName.Text = "StudentName";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Geoform", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Name";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Beige;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(483, 276);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(414, 236);
            this.panel2.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Cascadia Code", 14F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(184, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "40";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Geoform", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(102, 29);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 60);
            this.label3.TabIndex = 0;
            this.label3.Text = "Questions";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Beige;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txtstats);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(945, 276);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(414, 236);
            this.panel3.TabIndex = 12;
            // 
            // txtstats
            // 
            this.txtstats.Font = new System.Drawing.Font("Cascadia Code", 14F, System.Drawing.FontStyle.Bold);
            this.txtstats.Location = new System.Drawing.Point(96, 119);
            this.txtstats.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtstats.Name = "txtstats";
            this.txtstats.Size = new System.Drawing.Size(256, 66);
            this.txtstats.TabIndex = 1;
            this.txtstats.Text = "Not Yet Taken";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Geoform", 20F);
            this.label5.Location = new System.Drawing.Point(62, 31);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(311, 64);
            this.label5.TabIndex = 0;
            this.label5.Text = "Exams Status";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Beige;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.txtaverage);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Location = new System.Drawing.Point(1407, 276);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(414, 236);
            this.panel4.TabIndex = 13;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // txtaverage
            // 
            this.txtaverage.Font = new System.Drawing.Font("Cascadia Code", 14F, System.Drawing.FontStyle.Bold);
            this.txtaverage.Location = new System.Drawing.Point(179, 115);
            this.txtaverage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtaverage.Name = "txtaverage";
            this.txtaverage.Size = new System.Drawing.Size(183, 35);
            this.txtaverage.TabIndex = 1;
            this.txtaverage.Text = "null";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Geoform", 20F);
            this.label7.Location = new System.Drawing.Point(126, 31);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(183, 64);
            this.label7.TabIndex = 0;
            this.label7.Text = "Average";
            // 
            // ExamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ExamForm";
            this.Size = new System.Drawing.Size(1850, 805);
            this.Load += new System.EventHandler(this.ExamForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label txt_StudName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label txtstats;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label txtaverage;
        private System.Windows.Forms.Label label7;
    }
}
