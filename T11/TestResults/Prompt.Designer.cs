namespace TestResults
{
    partial class Prompt
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.txtPercent = new System.Windows.Forms.TextBox();
            this.lblCurrentStudent = new System.Windows.Forms.Label();
            this.lbldiv = new System.Windows.Forms.Label();
            this.lblMaxStudents = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(25, 80);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(13, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(111, 13);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Ener Percentage For: ";
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Location = new System.Drawing.Point(131, 13);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(0, 13);
            this.lblStudentName.TabIndex = 2;
            // 
            // txtPercent
            // 
            this.txtPercent.Location = new System.Drawing.Point(16, 44);
            this.txtPercent.Name = "txtPercent";
            this.txtPercent.Size = new System.Drawing.Size(100, 20);
            this.txtPercent.TabIndex = 3;
            // 
            // lblCurrentStudent
            // 
            this.lblCurrentStudent.AutoSize = true;
            this.lblCurrentStudent.Location = new System.Drawing.Point(218, 13);
            this.lblCurrentStudent.Name = "lblCurrentStudent";
            this.lblCurrentStudent.Size = new System.Drawing.Size(19, 13);
            this.lblCurrentStudent.TabIndex = 4;
            this.lblCurrentStudent.Text = "10";
            // 
            // lbldiv
            // 
            this.lbldiv.AutoSize = true;
            this.lbldiv.Location = new System.Drawing.Point(237, 13);
            this.lbldiv.Name = "lbldiv";
            this.lbldiv.Size = new System.Drawing.Size(12, 13);
            this.lbldiv.TabIndex = 5;
            this.lbldiv.Text = "/";
            // 
            // lblMaxStudents
            // 
            this.lblMaxStudents.AutoSize = true;
            this.lblMaxStudents.Location = new System.Drawing.Point(246, 13);
            this.lblMaxStudents.Name = "lblMaxStudents";
            this.lblMaxStudents.Size = new System.Drawing.Size(19, 13);
            this.lblMaxStudents.TabIndex = 6;
            this.lblMaxStudents.Text = "10";
            // 
            // Prompt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 143);
            this.Controls.Add(this.lblMaxStudents);
            this.Controls.Add(this.lbldiv);
            this.Controls.Add(this.lblCurrentStudent);
            this.Controls.Add(this.txtPercent);
            this.Controls.Add(this.lblStudentName);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnSubmit);
            this.Name = "Prompt";
            this.Text = "Prompt";
            this.Load += new System.EventHandler(this.Prompt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.TextBox txtPercent;
        private System.Windows.Forms.Label lblCurrentStudent;
        private System.Windows.Forms.Label lbldiv;
        private System.Windows.Forms.Label lblMaxStudents;
    }
}