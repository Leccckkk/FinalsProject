namespace FinalsProject.UserControls
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
            this.label9 = new System.Windows.Forms.Label();
            this.txtpassed = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txtave);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtfailed);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtpassed);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(22, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1446, 111);
            this.panel1.TabIndex = 0;
            // 
            // txtave
            // 
            this.txtave.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtave.ForeColor = System.Drawing.Color.Blue;
            this.txtave.Location = new System.Drawing.Point(930, 70);
            this.txtave.Name = "txtave";
            this.txtave.Size = new System.Drawing.Size(69, 23);
            this.txtave.TabIndex = 13;
            this.txtave.Text = "0%";
            this.txtave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(894, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "Average Score";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtfailed
            // 
            this.txtfailed.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfailed.ForeColor = System.Drawing.Color.Red;
            this.txtfailed.Location = new System.Drawing.Point(717, 70);
            this.txtfailed.Name = "txtfailed";
            this.txtfailed.Size = new System.Drawing.Size(50, 23);
            this.txtfailed.TabIndex = 11;
            this.txtfailed.Text = "1";
            this.txtfailed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(687, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Failed";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Cascadia Code", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(25, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(200, 23);
            this.label9.TabIndex = 9;
            this.label9.Text = "Performance Overview";
            // 
            // txtpassed
            // 
            this.txtpassed.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassed.ForeColor = System.Drawing.Color.Green;
            this.txtpassed.Location = new System.Drawing.Point(504, 70);
            this.txtpassed.Name = "txtpassed";
            this.txtpassed.Size = new System.Drawing.Size(50, 23);
            this.txtpassed.TabIndex = 8;
            this.txtpassed.Text = "1";
            this.txtpassed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(474, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Passed";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 187);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1446, 388);
            this.dataGridView1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(22, 155);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1446, 33);
            this.panel2.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Cascadia Code", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(200, 23);
            this.label7.TabIndex = 10;
            this.label7.Text = "Detailed Results";
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "Reports";
            this.Size = new System.Drawing.Size(1484, 591);
            this.Load += new System.EventHandler(this.Reports_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label txtpassed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtfailed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label txtave;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
    }
}
