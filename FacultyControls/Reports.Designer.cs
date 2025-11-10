namespace FinalsProject.FacultyControls
{
    partial class Reports
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
            this.txtave = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtfailed = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtpassed = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.txtave);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtfailed);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtpassed);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(28, 87);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1822, 116);
            this.panel1.TabIndex = 4;
            // 
            // txtave
            // 
            this.txtave.Font = new System.Drawing.Font("Cascadia Code SemiBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtave.ForeColor = System.Drawing.Color.Blue;
            this.txtave.Location = new System.Drawing.Point(1316, 57);
            this.txtave.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtave.Name = "txtave";
            this.txtave.Size = new System.Drawing.Size(111, 35);
            this.txtave.TabIndex = 13;
            this.txtave.Text = "0%";
            this.txtave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Geoform", 14F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(1253, 10);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(224, 35);
            this.label6.TabIndex = 12;
            this.label6.Text = "Average Score";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtfailed
            // 
            this.txtfailed.Font = new System.Drawing.Font("Cascadia Code", 14F);
            this.txtfailed.ForeColor = System.Drawing.Color.Red;
            this.txtfailed.Location = new System.Drawing.Point(814, 62);
            this.txtfailed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtfailed.Name = "txtfailed";
            this.txtfailed.Size = new System.Drawing.Size(75, 35);
            this.txtfailed.TabIndex = 11;
            this.txtfailed.Text = "1";
            this.txtfailed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Geoform", 14F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(768, 13);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 35);
            this.label4.TabIndex = 10;
            this.label4.Text = "Failed";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtpassed
            // 
            this.txtpassed.Font = new System.Drawing.Font("Cascadia Code", 14F);
            this.txtpassed.ForeColor = System.Drawing.Color.Green;
            this.txtpassed.Location = new System.Drawing.Point(279, 62);
            this.txtpassed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtpassed.Name = "txtpassed";
            this.txtpassed.Size = new System.Drawing.Size(75, 35);
            this.txtpassed.TabIndex = 8;
            this.txtpassed.Text = "1";
            this.txtpassed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Geoform", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(234, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 35);
            this.label1.TabIndex = 7;
            this.label1.Text = "Passed";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 295);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(1822, 485);
            this.dataGridView1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Khaki;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(28, 213);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1822, 72);
            this.panel2.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(718, 59);
            this.label2.TabIndex = 16;
            this.label2.Text = "Performance Overview";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(718, 59);
            this.label3.TabIndex = 17;
            this.label3.Text = "Detailed Results";
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Reports";
            this.Size = new System.Drawing.Size(1870, 792);
            this.Load += new System.EventHandler(this.Reports_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label txtave;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label txtfailed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txtpassed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}
