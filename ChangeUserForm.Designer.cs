namespace Tkanica
{
    partial class ChangeUserForm
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
            this.groupBoxUserType = new System.Windows.Forms.GroupBox();
            this.radioButtonRegular = new System.Windows.Forms.RadioButton();
            this.radioButtonManager = new System.Windows.Forms.RadioButton();
            this.radioButtonAdmin = new System.Windows.Forms.RadioButton();
            this.groupBoxUserData = new System.Windows.Forms.GroupBox();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.labelUserName = new System.Windows.Forms.Label();
            this.buttonChangeUserData = new System.Windows.Forms.Button();
            this.buttonChangePassword = new System.Windows.Forms.Button();
            this.groupBoxUserType.SuspendLayout();
            this.groupBoxUserData.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxUserType
            // 
            this.groupBoxUserType.Controls.Add(this.radioButtonRegular);
            this.groupBoxUserType.Controls.Add(this.radioButtonManager);
            this.groupBoxUserType.Controls.Add(this.radioButtonAdmin);
            this.groupBoxUserType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBoxUserType.Location = new System.Drawing.Point(12, 152);
            this.groupBoxUserType.Name = "groupBoxUserType";
            this.groupBoxUserType.Size = new System.Drawing.Size(346, 66);
            this.groupBoxUserType.TabIndex = 12;
            this.groupBoxUserType.TabStop = false;
            this.groupBoxUserType.Text = "Tip korisnika";
            // 
            // radioButtonRegular
            // 
            this.radioButtonRegular.AutoSize = true;
            this.radioButtonRegular.Location = new System.Drawing.Point(227, 25);
            this.radioButtonRegular.Name = "radioButtonRegular";
            this.radioButtonRegular.Size = new System.Drawing.Size(97, 24);
            this.radioButtonRegular.TabIndex = 2;
            this.radioButtonRegular.TabStop = true;
            this.radioButtonRegular.Text = "pregledač";
            this.radioButtonRegular.UseVisualStyleBackColor = true;
            // 
            // radioButtonManager
            // 
            this.radioButtonManager.AutoSize = true;
            this.radioButtonManager.Checked = true;
            this.radioButtonManager.Location = new System.Drawing.Point(135, 25);
            this.radioButtonManager.Name = "radioButtonManager";
            this.radioButtonManager.Size = new System.Drawing.Size(86, 24);
            this.radioButtonManager.TabIndex = 1;
            this.radioButtonManager.TabStop = true;
            this.radioButtonManager.Text = "upravnik";
            this.radioButtonManager.UseVisualStyleBackColor = true;
            // 
            // radioButtonAdmin
            // 
            this.radioButtonAdmin.AutoSize = true;
            this.radioButtonAdmin.Location = new System.Drawing.Point(10, 25);
            this.radioButtonAdmin.Name = "radioButtonAdmin";
            this.radioButtonAdmin.Size = new System.Drawing.Size(119, 24);
            this.radioButtonAdmin.TabIndex = 0;
            this.radioButtonAdmin.TabStop = true;
            this.radioButtonAdmin.Text = "administrator";
            this.radioButtonAdmin.UseVisualStyleBackColor = true;
            // 
            // groupBoxUserData
            // 
            this.groupBoxUserData.Controls.Add(this.labelFirstName);
            this.groupBoxUserData.Controls.Add(this.labelLastName);
            this.groupBoxUserData.Controls.Add(this.textBoxFirstName);
            this.groupBoxUserData.Controls.Add(this.textBoxUserName);
            this.groupBoxUserData.Controls.Add(this.textBoxLastName);
            this.groupBoxUserData.Controls.Add(this.labelUserName);
            this.groupBoxUserData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            this.groupBoxUserData.Location = new System.Drawing.Point(12, 12);
            this.groupBoxUserData.Name = "groupBoxUserData";
            this.groupBoxUserData.Size = new System.Drawing.Size(346, 134);
            this.groupBoxUserData.TabIndex = 11;
            this.groupBoxUserData.TabStop = false;
            this.groupBoxUserData.Text = "Podaci o korisniku";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelFirstName.Location = new System.Drawing.Point(36, 30);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(102, 20);
            this.labelFirstName.TabIndex = 0;
            this.labelFirstName.Text = "Ime korisnika";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelLastName.Location = new System.Drawing.Point(6, 62);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(132, 20);
            this.labelLastName.TabIndex = 1;
            this.labelLastName.Text = "Prezime korisnika";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxFirstName.Location = new System.Drawing.Point(144, 27);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(158, 26);
            this.textBoxFirstName.TabIndex = 3;
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxUserName.Location = new System.Drawing.Point(144, 91);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(158, 26);
            this.textBoxUserName.TabIndex = 6;
            this.textBoxUserName.Leave += new System.EventHandler(this.textBoxUserName_Leave);
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxLastName.Location = new System.Drawing.Point(144, 59);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(158, 26);
            this.textBoxLastName.TabIndex = 4;
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelUserName.Location = new System.Drawing.Point(28, 94);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(110, 20);
            this.labelUserName.TabIndex = 5;
            this.labelUserName.Text = "Korisničko ime";
            // 
            // buttonChangeUserData
            // 
            this.buttonChangeUserData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.buttonChangeUserData.Location = new System.Drawing.Point(191, 224);
            this.buttonChangeUserData.Name = "buttonChangeUserData";
            this.buttonChangeUserData.Size = new System.Drawing.Size(167, 42);
            this.buttonChangeUserData.TabIndex = 13;
            this.buttonChangeUserData.Text = "Sačuvaj izmene";
            this.buttonChangeUserData.UseVisualStyleBackColor = true;
            this.buttonChangeUserData.Click += new System.EventHandler(this.buttonChangeUserData_Click);
            // 
            // buttonChangePassword
            // 
            this.buttonChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.buttonChangePassword.Location = new System.Drawing.Point(12, 224);
            this.buttonChangePassword.Name = "buttonChangePassword";
            this.buttonChangePassword.Size = new System.Drawing.Size(167, 42);
            this.buttonChangePassword.TabIndex = 14;
            this.buttonChangePassword.Text = "Promeni lozinku";
            this.buttonChangePassword.UseVisualStyleBackColor = true;
            this.buttonChangePassword.Click += new System.EventHandler(this.buttonChangePassword_Click);
            // 
            // ChangeUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 270);
            this.Controls.Add(this.buttonChangePassword);
            this.Controls.Add(this.buttonChangeUserData);
            this.Controls.Add(this.groupBoxUserType);
            this.Controls.Add(this.groupBoxUserData);
            this.Name = "ChangeUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Izmena podataka o korisniku";
            this.Load += new System.EventHandler(this.ChangeUserForm_Load);
            this.groupBoxUserType.ResumeLayout(false);
            this.groupBoxUserType.PerformLayout();
            this.groupBoxUserData.ResumeLayout(false);
            this.groupBoxUserData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxUserType;
        private System.Windows.Forms.RadioButton radioButtonRegular;
        private System.Windows.Forms.RadioButton radioButtonManager;
        private System.Windows.Forms.RadioButton radioButtonAdmin;
        private System.Windows.Forms.GroupBox groupBoxUserData;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Button buttonChangeUserData;
        private System.Windows.Forms.Button buttonChangePassword;
    }
}