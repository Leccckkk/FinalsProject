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
            this.txt_Number = new System.Windows.Forms.Label();
            this.txt_Question = new System.Windows.Forms.Label();
            this.rb_Choice1 = new System.Windows.Forms.RadioButton();
            this.rb_Choice2 = new System.Windows.Forms.RadioButton();
            this.rb_Choice3 = new System.Windows.Forms.RadioButton();
            this.rb_Choice4 = new System.Windows.Forms.RadioButton();
            this.gb_Choices.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_Choices
            // 
            this.gb_Choices.Controls.Add(this.rb_Choice4);
            this.gb_Choices.Controls.Add(this.rb_Choice3);
            this.gb_Choices.Controls.Add(this.rb_Choice2);
            this.gb_Choices.Controls.Add(this.rb_Choice1);
            this.gb_Choices.Location = new System.Drawing.Point(12, 161);
            this.gb_Choices.Name = "gb_Choices";
            this.gb_Choices.Size = new System.Drawing.Size(360, 188);
            this.gb_Choices.TabIndex = 0;
            this.gb_Choices.TabStop = false;
            this.gb_Choices.Text = "Choices";
            // 
            // txt_Number
            // 
            this.txt_Number.AutoSize = true;
            this.txt_Number.Location = new System.Drawing.Point(13, 13);
            this.txt_Number.Name = "txt_Number";
            this.txt_Number.Size = new System.Drawing.Size(19, 13);
            this.txt_Number.TabIndex = 1;
            this.txt_Number.Text = "1. ";
            // 
            // txt_Question
            // 
            this.txt_Question.AutoSize = true;
            this.txt_Question.Location = new System.Drawing.Point(164, 69);
            this.txt_Question.Name = "txt_Question";
            this.txt_Question.Size = new System.Drawing.Size(49, 13);
            this.txt_Question.TabIndex = 2;
            this.txt_Question.Text = "Question";
            // 
            // rb_Choice1
            // 
            this.rb_Choice1.AutoSize = true;
            this.rb_Choice1.Location = new System.Drawing.Point(30, 31);
            this.rb_Choice1.Name = "rb_Choice1";
            this.rb_Choice1.Size = new System.Drawing.Size(64, 17);
            this.rb_Choice1.TabIndex = 0;
            this.rb_Choice1.TabStop = true;
            this.rb_Choice1.Text = "Choice1";
            this.rb_Choice1.UseVisualStyleBackColor = true;
            // 
            // rb_Choice2
            // 
            this.rb_Choice2.AutoSize = true;
            this.rb_Choice2.Location = new System.Drawing.Point(30, 69);
            this.rb_Choice2.Name = "rb_Choice2";
            this.rb_Choice2.Size = new System.Drawing.Size(64, 17);
            this.rb_Choice2.TabIndex = 1;
            this.rb_Choice2.TabStop = true;
            this.rb_Choice2.Text = "Choice2";
            this.rb_Choice2.UseVisualStyleBackColor = true;
            // 
            // rb_Choice3
            // 
            this.rb_Choice3.AutoSize = true;
            this.rb_Choice3.Location = new System.Drawing.Point(30, 107);
            this.rb_Choice3.Name = "rb_Choice3";
            this.rb_Choice3.Size = new System.Drawing.Size(64, 17);
            this.rb_Choice3.TabIndex = 2;
            this.rb_Choice3.TabStop = true;
            this.rb_Choice3.Text = "Choice3";
            this.rb_Choice3.UseVisualStyleBackColor = true;
            // 
            // rb_Choice4
            // 
            this.rb_Choice4.AutoSize = true;
            this.rb_Choice4.Location = new System.Drawing.Point(30, 145);
            this.rb_Choice4.Name = "rb_Choice4";
            this.rb_Choice4.Size = new System.Drawing.Size(64, 17);
            this.rb_Choice4.TabIndex = 3;
            this.rb_Choice4.TabStop = true;
            this.rb_Choice4.Text = "Choice4";
            this.rb_Choice4.UseVisualStyleBackColor = true;
            // 
            // ExamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.txt_Question);
            this.Controls.Add(this.txt_Number);
            this.Controls.Add(this.gb_Choices);
            this.Name = "ExamForm";
            this.Text = "StudentExamForm";
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
        private System.Windows.Forms.Label txt_Number;
        private System.Windows.Forms.Label txt_Question;
    }
}