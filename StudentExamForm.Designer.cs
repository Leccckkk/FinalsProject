namespace FinalsProject
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gb_Choices = new System.Windows.Forms.GroupBox();
            this.rb_Choice4 = new System.Windows.Forms.RadioButton();
            this.rb_Choice3 = new System.Windows.Forms.RadioButton();
            this.rb_Choice2 = new System.Windows.Forms.RadioButton();
            this.rb_Choice1 = new System.Windows.Forms.RadioButton();
            this.txt_subject = new System.Windows.Forms.Label();
            this.btn_Next = new System.Windows.Forms.Button();
            this.txt_Question = new System.Windows.Forms.Label();
            this.txt_Number = new System.Windows.Forms.Label();
            this.btn_finish = new System.Windows.Forms.Button();
            this.gb_Choices.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_Choices
            // 
            this.gb_Choices.Controls.Add(this.rb_Choice4);
            this.gb_Choices.Controls.Add(this.rb_Choice3);
            this.gb_Choices.Controls.Add(this.rb_Choice2);
            this.gb_Choices.Controls.Add(this.rb_Choice1);
            this.gb_Choices.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Choices.Location = new System.Drawing.Point(43, 126);
            this.gb_Choices.Name = "gb_Choices";
            this.gb_Choices.Size = new System.Drawing.Size(917, 188);
            this.gb_Choices.TabIndex = 8;
            this.gb_Choices.TabStop = false;
            this.gb_Choices.Text = "Choices";
            // 
            // rb_Choice4
            // 
            this.rb_Choice4.AutoSize = true;
            this.rb_Choice4.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Choice4.Location = new System.Drawing.Point(30, 145);
            this.rb_Choice4.Name = "rb_Choice4";
            this.rb_Choice4.Size = new System.Drawing.Size(82, 21);
            this.rb_Choice4.TabIndex = 3;
            this.rb_Choice4.TabStop = true;
            this.rb_Choice4.Text = "Choice4";
            this.rb_Choice4.UseVisualStyleBackColor = true;
            // 
            // rb_Choice3
            // 
            this.rb_Choice3.AutoSize = true;
            this.rb_Choice3.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Choice3.Location = new System.Drawing.Point(30, 107);
            this.rb_Choice3.Name = "rb_Choice3";
            this.rb_Choice3.Size = new System.Drawing.Size(82, 21);
            this.rb_Choice3.TabIndex = 2;
            this.rb_Choice3.TabStop = true;
            this.rb_Choice3.Text = "Choice3";
            this.rb_Choice3.UseVisualStyleBackColor = true;
            // 
            // rb_Choice2
            // 
            this.rb_Choice2.AutoSize = true;
            this.rb_Choice2.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Choice2.Location = new System.Drawing.Point(30, 69);
            this.rb_Choice2.Name = "rb_Choice2";
            this.rb_Choice2.Size = new System.Drawing.Size(82, 21);
            this.rb_Choice2.TabIndex = 1;
            this.rb_Choice2.TabStop = true;
            this.rb_Choice2.Text = "Choice2";
            this.rb_Choice2.UseVisualStyleBackColor = true;
            // 
            // rb_Choice1
            // 
            this.rb_Choice1.AutoSize = true;
            this.rb_Choice1.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Choice1.Location = new System.Drawing.Point(30, 31);
            this.rb_Choice1.Name = "rb_Choice1";
            this.rb_Choice1.Size = new System.Drawing.Size(82, 21);
            this.rb_Choice1.TabIndex = 0;
            this.rb_Choice1.TabStop = true;
            this.rb_Choice1.Text = "Choice1";
            this.rb_Choice1.UseVisualStyleBackColor = true;
            // 
            // txt_subject
            // 
            this.txt_subject.AutoSize = true;
            this.txt_subject.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_subject.Location = new System.Drawing.Point(40, 4);
            this.txt_subject.Name = "txt_subject";
            this.txt_subject.Size = new System.Drawing.Size(64, 17);
            this.txt_subject.TabIndex = 12;
            this.txt_subject.Text = "Subject";
            // 
            // btn_Next
            // 
            this.btn_Next.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_Next.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Next.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Next.ForeColor = System.Drawing.Color.White;
            this.btn_Next.Location = new System.Drawing.Point(192, 340);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(117, 29);
            this.btn_Next.TabIndex = 9;
            this.btn_Next.Text = "Next";
            this.btn_Next.UseVisualStyleBackColor = false;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click_1);
            // 
            // txt_Question
            // 
            this.txt_Question.AutoSize = true;
            this.txt_Question.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Question.Location = new System.Drawing.Point(70, 57);
            this.txt_Question.Name = "txt_Question";
            this.txt_Question.Size = new System.Drawing.Size(72, 17);
            this.txt_Question.TabIndex = 11;
            this.txt_Question.Text = "Question";
            // 
            // txt_Number
            // 
            this.txt_Number.AutoSize = true;
            this.txt_Number.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Number.Location = new System.Drawing.Point(40, 57);
            this.txt_Number.Name = "txt_Number";
            this.txt_Number.Size = new System.Drawing.Size(32, 17);
            this.txt_Number.TabIndex = 10;
            this.txt_Number.Text = "1. ";
            // 
            // btn_finish
            // 
            this.btn_finish.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_finish.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_finish.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_finish.ForeColor = System.Drawing.Color.White;
            this.btn_finish.Location = new System.Drawing.Point(624, 340);
            this.btn_finish.Name = "btn_finish";
            this.btn_finish.Size = new System.Drawing.Size(117, 29);
            this.btn_finish.TabIndex = 13;
            this.btn_finish.Text = "Finish";
            this.btn_finish.UseVisualStyleBackColor = false;
            this.btn_finish.Click += new System.EventHandler(this.btn_finish_Click);
            // 
            // ExamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1001, 381);
            this.Controls.Add(this.btn_finish);
            this.Controls.Add(this.gb_Choices);
            this.Controls.Add(this.txt_subject);
            this.Controls.Add(this.btn_Next);
            this.Controls.Add(this.txt_Question);
            this.Controls.Add(this.txt_Number);
            this.Name = "ExamForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentExamForm";
            this.Load += new System.EventHandler(this.ExamForm_Load);
            this.gb_Choices.ResumeLayout(false);
            this.gb_Choices.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Choices;
        private System.Windows.Forms.RadioButton rb_Choice4;
        private System.Windows.Forms.RadioButton rb_Choice3;
        private System.Windows.Forms.RadioButton rb_Choice2;
        private System.Windows.Forms.RadioButton rb_Choice1;
        private System.Windows.Forms.Label txt_subject;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.Label txt_Question;
        private System.Windows.Forms.Label txt_Number;
        private System.Windows.Forms.Button btn_finish;
    }
}