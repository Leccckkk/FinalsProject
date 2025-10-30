﻿namespace FinalsProject.UserControls
{
    partial class StudentManagement
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
            this.label9 = new System.Windows.Forms.Label();
            this.colactions = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colscore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colexam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colemail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coluser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(13, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(990, 335);
            this.panel1.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Cascadia Code", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(42, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(185, 23);
            this.label9.TabIndex = 1;
            this.label9.Text = "Student Management";
            // 
            // colactions
            // 
            this.colactions.FillWeight = 50F;
            this.colactions.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.colactions.HeaderText = "ACTIONS";
            this.colactions.Name = "colactions";
            this.colactions.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colactions.UseColumnTextForButtonValue = true;
            // 
            // colscore
            // 
            this.colscore.HeaderText = "LAST SCORE";
            this.colscore.Name = "colscore";
            this.colscore.ReadOnly = true;
            // 
            // colexam
            // 
            this.colexam.HeaderText = "EXAM STATUS";
            this.colexam.Name = "colexam";
            this.colexam.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colexam.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colemail
            // 
            this.colemail.HeaderText = "EMAIL";
            this.colemail.Name = "colemail";
            // 
            // coluser
            // 
            this.coluser.HeaderText = "USERNAME";
            this.coluser.Name = "coluser";
            // 
            // colid
            // 
            this.colid.HeaderText = "STUDENT NUMBER";
            this.colid.Name = "colid";
            this.colid.ReadOnly = true;
            // 
            // colname
            // 
            this.colname.HeaderText = "NAME";
            this.colname.Name = "colname";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colname,
            this.colid,
            this.coluser,
            this.colemail,
            this.colexam,
            this.colscore,
            this.colactions});
            this.dataGridView1.Location = new System.Drawing.Point(0, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(990, 275);
            this.dataGridView1.TabIndex = 0;
            // 
            // StudentManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Controls.Add(this.panel1);
            this.Name = "StudentManagement";
            this.Size = new System.Drawing.Size(1017, 363);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colname;
        private System.Windows.Forms.DataGridViewTextBoxColumn colid;
        private System.Windows.Forms.DataGridViewTextBoxColumn coluser;
        private System.Windows.Forms.DataGridViewTextBoxColumn colemail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colexam;
        private System.Windows.Forms.DataGridViewTextBoxColumn colscore;
        private System.Windows.Forms.DataGridViewButtonColumn colactions;
    }
}
