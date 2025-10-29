namespace FinalsProject
{
    partial class AdminForm
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
            this.btn_QM = new System.Windows.Forms.Button();
            this.btn_SR = new System.Windows.Forms.Button();
            this.btn_RG = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_QM
            // 
            this.btn_QM.Location = new System.Drawing.Point(63, 54);
            this.btn_QM.Name = "btn_QM";
            this.btn_QM.Size = new System.Drawing.Size(165, 40);
            this.btn_QM.TabIndex = 0;
            this.btn_QM.Text = "Question Management";
            this.btn_QM.UseVisualStyleBackColor = true;
            // 
            // btn_SR
            // 
            this.btn_SR.Location = new System.Drawing.Point(63, 115);
            this.btn_SR.Name = "btn_SR";
            this.btn_SR.Size = new System.Drawing.Size(165, 40);
            this.btn_SR.TabIndex = 1;
            this.btn_SR.Text = "Student Registration";
            this.btn_SR.UseVisualStyleBackColor = true;
            // 
            // btn_RG
            // 
            this.btn_RG.Location = new System.Drawing.Point(63, 176);
            this.btn_RG.Name = "btn_RG";
            this.btn_RG.Size = new System.Drawing.Size(165, 40);
            this.btn_RG.TabIndex = 2;
            this.btn_RG.Text = "Report Generation";
            this.btn_RG.UseVisualStyleBackColor = true;
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(12, 12);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(60, 20);
            this.btn_Back.TabIndex = 3;
            this.btn_Back.Text = "<- Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_RG);
            this.Controls.Add(this.btn_SR);
            this.Controls.Add(this.btn_QM);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_QM;
        private System.Windows.Forms.Button btn_SR;
        private System.Windows.Forms.Button btn_RG;
        private System.Windows.Forms.Button btn_Back;
    }
}