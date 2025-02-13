namespace UserClient
{
    partial class UserForm
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
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtIdentification = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(12, 12);
            this.txtFullName.Size = new System.Drawing.Size(260, 20);
            this.txtFullName.Text = "ПІБ";

            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(12, 38);
            this.txtEmail.Size = new System.Drawing.Size(260, 20);
            this.txtEmail.Text = "Email"; 

            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(12, 64);
            this.txtPhone.Size = new System.Drawing.Size(260, 20);
            this.txtPhone.Text = "Контактний телефон"; 

            // 
            // txtIdentification
            // 
            this.txtIdentification.Location = new System.Drawing.Point(12, 90);
            this.txtIdentification.Size = new System.Drawing.Size(260, 20);
            this.txtIdentification.Text = "ДРФО";

            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 120);
            this.btnSave.Size = new System.Drawing.Size(260, 30);
            this.btnSave.Text = "Save";

            // 
            // UserForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtIdentification);
            this.Controls.Add(this.btnSave);
            this.Text = "Add/Edit User";
            this.ResumeLayout(false);
            this.PerformLayout();
        }


        // Form fields
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtIdentification;
        private System.Windows.Forms.Button btnSave;

        #endregion
    }
}