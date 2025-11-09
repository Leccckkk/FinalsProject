namespace FinalsProject.UserControls
{
    partial class QuestionManagement
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_sub = new System.Windows.Forms.ComboBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txthis = new System.Windows.Forms.Label();
            this.txtsci = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txteng = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmath = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(20, 13);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.cb_sub);
            this.splitContainer1.Panel1.Controls.Add(this.btn_delete);
            this.splitContainer1.Panel1.Controls.Add(this.btn_save);
            this.splitContainer1.Panel1.Controls.Add(this.label9);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel2.Controls.Add(this.label11);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.txthis);
            this.splitContainer1.Panel2.Controls.Add(this.txtsci);
            this.splitContainer1.Panel2.Controls.Add(this.label13);
            this.splitContainer1.Panel2.Controls.Add(this.label10);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.txteng);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.txtmath);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Size = new System.Drawing.Size(1443, 182);
            this.splitContainer1.SplitterDistance = 83;
            this.splitContainer1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(248, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 23);
            this.label2.TabIndex = 14;
            this.label2.Text = "Subjects:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cb_sub
            // 
            this.cb_sub.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_sub.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold);
            this.cb_sub.FormattingEnabled = true;
            this.cb_sub.Items.AddRange(new object[] {
            "All",
            "Mathematics",
            "English",
            "Science",
            "History"});
            this.cb_sub.Location = new System.Drawing.Point(335, 28);
            this.cb_sub.Name = "cb_sub";
            this.cb_sub.Size = new System.Drawing.Size(121, 26);
            this.cb_sub.TabIndex = 7;
            this.cb_sub.SelectedIndexChanged += new System.EventHandler(this.cb_sub_SelectedIndexChanged);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Red;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_delete.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(1262, 29);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(156, 30);
            this.btn_delete.TabIndex = 5;
            this.btn_delete.Text = "Delete Question";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.Green;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_save.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(1078, 29);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(156, 30);
            this.btn_save.TabIndex = 5;
            this.btn_save.Text = "Save Changes";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Cascadia Code", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(28, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(214, 30);
            this.label9.TabIndex = 2;
            this.label9.Text = "Question Management";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label11.Location = new System.Drawing.Point(1187, 55);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 23);
            this.label11.TabIndex = 10;
            this.label11.Text = "Questions";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label7.Location = new System.Drawing.Point(861, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 23);
            this.label7.TabIndex = 13;
            this.label7.Text = "Questions";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txthis
            // 
            this.txthis.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthis.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txthis.Location = new System.Drawing.Point(1201, 34);
            this.txthis.Name = "txthis";
            this.txthis.Size = new System.Drawing.Size(50, 23);
            this.txthis.TabIndex = 9;
            this.txthis.Text = "1";
            this.txthis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtsci
            // 
            this.txtsci.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsci.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtsci.Location = new System.Drawing.Point(875, 34);
            this.txtsci.Name = "txtsci";
            this.txtsci.Size = new System.Drawing.Size(50, 23);
            this.txtsci.TabIndex = 12;
            this.txtsci.Text = "1";
            this.txtsci.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(1172, 14);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(114, 23);
            this.label13.TabIndex = 8;
            this.label13.Text = "History";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(846, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 23);
            this.label10.TabIndex = 11;
            this.label10.Text = "Science";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label4.Location = new System.Drawing.Point(486, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Questions";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txteng
            // 
            this.txteng.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txteng.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txteng.Location = new System.Drawing.Point(500, 34);
            this.txteng.Name = "txteng";
            this.txteng.Size = new System.Drawing.Size(50, 23);
            this.txteng.TabIndex = 9;
            this.txteng.Text = "1";
            this.txteng.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(471, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 23);
            this.label6.TabIndex = 8;
            this.label6.Text = "English";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label3.Location = new System.Drawing.Point(204, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Questions";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtmath
            // 
            this.txtmath.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmath.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtmath.Location = new System.Drawing.Point(218, 34);
            this.txtmath.Name = "txtmath";
            this.txtmath.Size = new System.Drawing.Size(50, 23);
            this.txtmath.TabIndex = 6;
            this.txtmath.Text = "1";
            this.txtmath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(189, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mathematics";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 201);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1443, 376);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_UserAddedRow);
            this.dataGridView1.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_UserDeletedRow);
            // 
            // QuestionManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.splitContainer1);
            this.Name = "QuestionManagement";
            this.Size = new System.Drawing.Size(1484, 591);
            this.Load += new System.EventHandler(this.QuestionManagement_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtmath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label txthis;
        private System.Windows.Forms.Label txtsci;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txteng;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_sub;
    }
}
