namespace Tkanica
{
    partial class NewMemberForm
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
            this.groupBoxBasicInfo = new System.Windows.Forms.GroupBox();
            this.checkBoxDiscount = new System.Windows.Forms.CheckBox();
            this.labelMemberGroup = new System.Windows.Forms.Label();
            this.comboBoxMemberGroup = new System.Windows.Forms.ComboBox();
            this.textBoxYearsOfExperience = new System.Windows.Forms.TextBox();
            this.labelYearsOfExperience = new System.Windows.Forms.Label();
            this.dateTimePickerDateOfEntry = new System.Windows.Forms.DateTimePicker();
            this.labelDateOfEntry = new System.Windows.Forms.Label();
            this.dateTimePickerDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.labelDateOfBirth = new System.Windows.Forms.Label();
            this.textBoxLocation = new System.Windows.Forms.TextBox();
            this.labelLocation = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.groupBoxContactInfo = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelMobilePhone = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxMobilePhone = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.groupBoxBasicInfo.SuspendLayout();
            this.groupBoxContactInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxBasicInfo
            // 
            this.groupBoxBasicInfo.Controls.Add(this.checkBoxDiscount);
            this.groupBoxBasicInfo.Controls.Add(this.labelMemberGroup);
            this.groupBoxBasicInfo.Controls.Add(this.comboBoxMemberGroup);
            this.groupBoxBasicInfo.Controls.Add(this.textBoxYearsOfExperience);
            this.groupBoxBasicInfo.Controls.Add(this.labelYearsOfExperience);
            this.groupBoxBasicInfo.Controls.Add(this.dateTimePickerDateOfEntry);
            this.groupBoxBasicInfo.Controls.Add(this.labelDateOfEntry);
            this.groupBoxBasicInfo.Controls.Add(this.dateTimePickerDateOfBirth);
            this.groupBoxBasicInfo.Controls.Add(this.labelDateOfBirth);
            this.groupBoxBasicInfo.Controls.Add(this.textBoxLocation);
            this.groupBoxBasicInfo.Controls.Add(this.labelLocation);
            this.groupBoxBasicInfo.Controls.Add(this.textBoxAddress);
            this.groupBoxBasicInfo.Controls.Add(this.labelAddress);
            this.groupBoxBasicInfo.Controls.Add(this.textBoxLastName);
            this.groupBoxBasicInfo.Controls.Add(this.labelLastName);
            this.groupBoxBasicInfo.Controls.Add(this.textBoxFirstName);
            this.groupBoxBasicInfo.Controls.Add(this.labelFirstName);
            this.groupBoxBasicInfo.Location = new System.Drawing.Point(13, 13);
            this.groupBoxBasicInfo.Name = "groupBoxBasicInfo";
            this.groupBoxBasicInfo.Size = new System.Drawing.Size(401, 345);
            this.groupBoxBasicInfo.TabIndex = 0;
            this.groupBoxBasicInfo.TabStop = false;
            this.groupBoxBasicInfo.Text = "Osnovni podaci";
            // 
            // checkBoxDiscount
            // 
            this.checkBoxDiscount.AutoSize = true;
            this.checkBoxDiscount.Location = new System.Drawing.Point(165, 284);
            this.checkBoxDiscount.Name = "checkBoxDiscount";
            this.checkBoxDiscount.Size = new System.Drawing.Size(191, 24);
            this.checkBoxDiscount.TabIndex = 17;
            this.checkBoxDiscount.Text = "Članarina sa popustom";
            this.checkBoxDiscount.UseVisualStyleBackColor = true;
            // 
            // labelMemberGroup
            // 
            this.labelMemberGroup.AutoSize = true;
            this.labelMemberGroup.Location = new System.Drawing.Point(40, 253);
            this.labelMemberGroup.Name = "labelMemberGroup";
            this.labelMemberGroup.Size = new System.Drawing.Size(119, 20);
            this.labelMemberGroup.TabIndex = 16;
            this.labelMemberGroup.Text = "Folklorna grupa";
            // 
            // comboBoxMemberGroup
            // 
            this.comboBoxMemberGroup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxMemberGroup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxMemberGroup.FormattingEnabled = true;
            this.comboBoxMemberGroup.Location = new System.Drawing.Point(165, 250);
            this.comboBoxMemberGroup.Name = "comboBoxMemberGroup";
            this.comboBoxMemberGroup.Size = new System.Drawing.Size(217, 28);
            this.comboBoxMemberGroup.TabIndex = 15;
            this.comboBoxMemberGroup.Text = "Izaberite grupu";
            this.comboBoxMemberGroup.Leave += new System.EventHandler(this.comboBoxMemberGroup_Leave);
            // 
            // textBoxYearsOfExperience
            // 
            this.textBoxYearsOfExperience.Location = new System.Drawing.Point(165, 217);
            this.textBoxYearsOfExperience.Name = "textBoxYearsOfExperience";
            this.textBoxYearsOfExperience.Size = new System.Drawing.Size(217, 26);
            this.textBoxYearsOfExperience.TabIndex = 14;
            // 
            // labelYearsOfExperience
            // 
            this.labelYearsOfExperience.AutoSize = true;
            this.labelYearsOfExperience.Location = new System.Drawing.Point(37, 220);
            this.labelYearsOfExperience.Name = "labelYearsOfExperience";
            this.labelYearsOfExperience.Size = new System.Drawing.Size(122, 20);
            this.labelYearsOfExperience.TabIndex = 13;
            this.labelYearsOfExperience.Text = "Godine iskustva";
            // 
            // dateTimePickerDateOfEntry
            // 
            this.dateTimePickerDateOfEntry.CustomFormat = "dd.MM.yyyy.";
            this.dateTimePickerDateOfEntry.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDateOfEntry.Location = new System.Drawing.Point(165, 185);
            this.dateTimePickerDateOfEntry.Name = "dateTimePickerDateOfEntry";
            this.dateTimePickerDateOfEntry.Size = new System.Drawing.Size(217, 26);
            this.dateTimePickerDateOfEntry.TabIndex = 12;
            // 
            // labelDateOfEntry
            // 
            this.labelDateOfEntry.AutoSize = true;
            this.labelDateOfEntry.Location = new System.Drawing.Point(60, 190);
            this.labelDateOfEntry.Name = "labelDateOfEntry";
            this.labelDateOfEntry.Size = new System.Drawing.Size(99, 20);
            this.labelDateOfEntry.TabIndex = 11;
            this.labelDateOfEntry.Text = "Datum upisa";
            // 
            // dateTimePickerDateOfBirth
            // 
            this.dateTimePickerDateOfBirth.CustomFormat = "dd.MM.yyyy.";
            this.dateTimePickerDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDateOfBirth.Location = new System.Drawing.Point(165, 153);
            this.dateTimePickerDateOfBirth.Name = "dateTimePickerDateOfBirth";
            this.dateTimePickerDateOfBirth.Size = new System.Drawing.Size(217, 26);
            this.dateTimePickerDateOfBirth.TabIndex = 10;
            this.dateTimePickerDateOfBirth.Leave += new System.EventHandler(this.dateTimePickerDateOfBirth_Leave);
            // 
            // labelDateOfBirth
            // 
            this.labelDateOfBirth.AutoSize = true;
            this.labelDateOfBirth.Location = new System.Drawing.Point(45, 158);
            this.labelDateOfBirth.Name = "labelDateOfBirth";
            this.labelDateOfBirth.Size = new System.Drawing.Size(114, 20);
            this.labelDateOfBirth.TabIndex = 8;
            this.labelDateOfBirth.Text = "Datum rođenja";
            // 
            // textBoxLocation
            // 
            this.textBoxLocation.Location = new System.Drawing.Point(165, 121);
            this.textBoxLocation.Name = "textBoxLocation";
            this.textBoxLocation.Size = new System.Drawing.Size(217, 26);
            this.textBoxLocation.TabIndex = 7;
            this.textBoxLocation.Leave += new System.EventHandler(this.textBoxLocation_Leave);
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.Location = new System.Drawing.Point(106, 124);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(53, 20);
            this.labelLocation.TabIndex = 6;
            this.labelLocation.Text = "Mesto";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(165, 89);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(217, 26);
            this.textBoxAddress.TabIndex = 5;
            this.textBoxAddress.Leave += new System.EventHandler(this.textBoxAddress_Leave);
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(99, 92);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(60, 20);
            this.labelAddress.TabIndex = 4;
            this.labelAddress.Text = "Adresa";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(165, 57);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(217, 26);
            this.textBoxLastName.TabIndex = 3;
            this.textBoxLastName.Leave += new System.EventHandler(this.textBoxLastName_Leave);
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(93, 60);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(66, 20);
            this.labelLastName.TabIndex = 2;
            this.labelLastName.Text = "Prezime";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(165, 25);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(217, 26);
            this.textBoxFirstName.TabIndex = 1;
            this.textBoxFirstName.Leave += new System.EventHandler(this.textBoxFirstName_Leave);
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(123, 28);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(36, 20);
            this.labelFirstName.TabIndex = 0;
            this.labelFirstName.Text = "Ime";
            // 
            // groupBoxContactInfo
            // 
            this.groupBoxContactInfo.Controls.Add(this.label1);
            this.groupBoxContactInfo.Controls.Add(this.labelMobilePhone);
            this.groupBoxContactInfo.Controls.Add(this.textBoxEmail);
            this.groupBoxContactInfo.Controls.Add(this.textBoxMobilePhone);
            this.groupBoxContactInfo.Location = new System.Drawing.Point(420, 13);
            this.groupBoxContactInfo.Name = "groupBoxContactInfo";
            this.groupBoxContactInfo.Size = new System.Drawing.Size(344, 301);
            this.groupBoxContactInfo.TabIndex = 1;
            this.groupBoxContactInfo.TabStop = false;
            this.groupBoxContactInfo.Text = "Kontakt podaci";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "E-mail";
            // 
            // labelMobilePhone
            // 
            this.labelMobilePhone.AutoSize = true;
            this.labelMobilePhone.Location = new System.Drawing.Point(6, 28);
            this.labelMobilePhone.Name = "labelMobilePhone";
            this.labelMobilePhone.Size = new System.Drawing.Size(111, 20);
            this.labelMobilePhone.TabIndex = 17;
            this.labelMobilePhone.Text = "Mobilni telefon";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(123, 57);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(215, 26);
            this.textBoxEmail.TabIndex = 3;
            // 
            // textBoxMobilePhone
            // 
            this.textBoxMobilePhone.Location = new System.Drawing.Point(123, 25);
            this.textBoxMobilePhone.Name = "textBoxMobilePhone";
            this.textBoxMobilePhone.Size = new System.Drawing.Size(215, 26);
            this.textBoxMobilePhone.TabIndex = 2;
            this.textBoxMobilePhone.Leave += new System.EventHandler(this.textBoxMobilePhone_Leave);
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.buttonSave.Location = new System.Drawing.Point(638, 320);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(126, 38);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Sačuvaj";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // NewMemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 370);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.groupBoxContactInfo);
            this.Controls.Add(this.groupBoxBasicInfo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "NewMemberForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Novi član";
            this.Load += new System.EventHandler(this.NewMemberForm_Load);
            this.groupBoxBasicInfo.ResumeLayout(false);
            this.groupBoxBasicInfo.PerformLayout();
            this.groupBoxContactInfo.ResumeLayout(false);
            this.groupBoxContactInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxBasicInfo;
        private System.Windows.Forms.TextBox textBoxLocation;
        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelDateOfBirth;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateOfBirth;
        private System.Windows.Forms.Label labelMemberGroup;
        private System.Windows.Forms.ComboBox comboBoxMemberGroup;
        private System.Windows.Forms.TextBox textBoxYearsOfExperience;
        private System.Windows.Forms.Label labelYearsOfExperience;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateOfEntry;
        private System.Windows.Forms.Label labelDateOfEntry;
        private System.Windows.Forms.GroupBox groupBoxContactInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelMobilePhone;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxMobilePhone;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.CheckBox checkBoxDiscount;
    }
}