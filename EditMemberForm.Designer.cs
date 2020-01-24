namespace Tkanica
{
    partial class EditMemberForm
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
            this.buttonSave = new System.Windows.Forms.Button();
            this.groupBoxContactInfo = new System.Windows.Forms.GroupBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelMobilePhone = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxMobilePhone = new System.Windows.Forms.TextBox();
            this.groupBoxBasicInfo = new System.Windows.Forms.GroupBox();
            this.checkBoxDiscount = new System.Windows.Forms.CheckBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
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
            this.groupBoxChoose = new System.Windows.Forms.GroupBox();
            this.comboBoxChoose = new System.Windows.Forms.ComboBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.textBoxDebtAmount = new System.Windows.Forms.TextBox();
            this.labelDebtAmount = new System.Windows.Forms.Label();
            this.labelReservations = new System.Windows.Forms.Label();
            this.textBoxReservations = new System.Windows.Forms.TextBox();
            this.groupBoxContactInfo.SuspendLayout();
            this.groupBoxBasicInfo.SuspendLayout();
            this.groupBoxChoose.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.buttonSave.Location = new System.Drawing.Point(613, 388);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(150, 38);
            this.buttonSave.TabIndex = 5;
            this.buttonSave.Text = "Sačuvaj izmene";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // groupBoxContactInfo
            // 
            this.groupBoxContactInfo.Controls.Add(this.labelEmail);
            this.groupBoxContactInfo.Controls.Add(this.labelMobilePhone);
            this.groupBoxContactInfo.Controls.Add(this.textBoxEmail);
            this.groupBoxContactInfo.Controls.Add(this.textBoxMobilePhone);
            this.groupBoxContactInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            this.groupBoxContactInfo.Location = new System.Drawing.Point(419, 81);
            this.groupBoxContactInfo.Name = "groupBoxContactInfo";
            this.groupBoxContactInfo.Size = new System.Drawing.Size(344, 99);
            this.groupBoxContactInfo.TabIndex = 4;
            this.groupBoxContactInfo.TabStop = false;
            this.groupBoxContactInfo.Text = "Kontakt podaci";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelEmail.Location = new System.Drawing.Point(64, 60);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(53, 20);
            this.labelEmail.TabIndex = 18;
            this.labelEmail.Text = "E-mail";
            // 
            // labelMobilePhone
            // 
            this.labelMobilePhone.AutoSize = true;
            this.labelMobilePhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelMobilePhone.Location = new System.Drawing.Point(6, 28);
            this.labelMobilePhone.Name = "labelMobilePhone";
            this.labelMobilePhone.Size = new System.Drawing.Size(111, 20);
            this.labelMobilePhone.TabIndex = 17;
            this.labelMobilePhone.Text = "Mobilni telefon";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxEmail.Location = new System.Drawing.Point(123, 57);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(215, 26);
            this.textBoxEmail.TabIndex = 3;
            // 
            // textBoxMobilePhone
            // 
            this.textBoxMobilePhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxMobilePhone.Location = new System.Drawing.Point(123, 25);
            this.textBoxMobilePhone.Name = "textBoxMobilePhone";
            this.textBoxMobilePhone.Size = new System.Drawing.Size(215, 26);
            this.textBoxMobilePhone.TabIndex = 2;
            this.textBoxMobilePhone.Leave += new System.EventHandler(this.textBoxMobilePhone_Leave);
            // 
            // groupBoxBasicInfo
            // 
            this.groupBoxBasicInfo.Controls.Add(this.checkBoxDiscount);
            this.groupBoxBasicInfo.Controls.Add(this.textBoxId);
            this.groupBoxBasicInfo.Controls.Add(this.labelId);
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
            this.groupBoxBasicInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            this.groupBoxBasicInfo.Location = new System.Drawing.Point(12, 81);
            this.groupBoxBasicInfo.Name = "groupBoxBasicInfo";
            this.groupBoxBasicInfo.Size = new System.Drawing.Size(401, 345);
            this.groupBoxBasicInfo.TabIndex = 3;
            this.groupBoxBasicInfo.TabStop = false;
            this.groupBoxBasicInfo.Text = "Osnovni podaci";
            // 
            // checkBoxDiscount
            // 
            this.checkBoxDiscount.AutoSize = true;
            this.checkBoxDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.checkBoxDiscount.Location = new System.Drawing.Point(160, 315);
            this.checkBoxDiscount.Name = "checkBoxDiscount";
            this.checkBoxDiscount.Size = new System.Drawing.Size(191, 24);
            this.checkBoxDiscount.TabIndex = 19;
            this.checkBoxDiscount.Text = "Članarina sa popustom";
            this.checkBoxDiscount.UseVisualStyleBackColor = true;
            // 
            // textBoxId
            // 
            this.textBoxId.BackColor = System.Drawing.Color.LightGray;
            this.textBoxId.Enabled = false;
            this.textBoxId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxId.Location = new System.Drawing.Point(160, 25);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(217, 26);
            this.textBoxId.TabIndex = 18;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelId.Location = new System.Drawing.Point(88, 28);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(68, 20);
            this.labelId.TabIndex = 17;
            this.labelId.Text = "ID člana";
            // 
            // labelMemberGroup
            // 
            this.labelMemberGroup.AutoSize = true;
            this.labelMemberGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelMemberGroup.Location = new System.Drawing.Point(35, 285);
            this.labelMemberGroup.Name = "labelMemberGroup";
            this.labelMemberGroup.Size = new System.Drawing.Size(119, 20);
            this.labelMemberGroup.TabIndex = 16;
            this.labelMemberGroup.Text = "Folklorna grupa";
            // 
            // comboBoxMemberGroup
            // 
            this.comboBoxMemberGroup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxMemberGroup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxMemberGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBoxMemberGroup.FormattingEnabled = true;
            this.comboBoxMemberGroup.Location = new System.Drawing.Point(160, 282);
            this.comboBoxMemberGroup.Name = "comboBoxMemberGroup";
            this.comboBoxMemberGroup.Size = new System.Drawing.Size(217, 28);
            this.comboBoxMemberGroup.TabIndex = 15;
            this.comboBoxMemberGroup.Text = "Izaberite grupu";
            this.comboBoxMemberGroup.Leave += new System.EventHandler(this.comboBoxMemberGroup_Leave);
            // 
            // textBoxYearsOfExperience
            // 
            this.textBoxYearsOfExperience.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxYearsOfExperience.Location = new System.Drawing.Point(160, 249);
            this.textBoxYearsOfExperience.Name = "textBoxYearsOfExperience";
            this.textBoxYearsOfExperience.Size = new System.Drawing.Size(217, 26);
            this.textBoxYearsOfExperience.TabIndex = 14;
            // 
            // labelYearsOfExperience
            // 
            this.labelYearsOfExperience.AutoSize = true;
            this.labelYearsOfExperience.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelYearsOfExperience.Location = new System.Drawing.Point(32, 252);
            this.labelYearsOfExperience.Name = "labelYearsOfExperience";
            this.labelYearsOfExperience.Size = new System.Drawing.Size(122, 20);
            this.labelYearsOfExperience.TabIndex = 13;
            this.labelYearsOfExperience.Text = "Godine iskustva";
            // 
            // dateTimePickerDateOfEntry
            // 
            this.dateTimePickerDateOfEntry.CustomFormat = "dd.MM.yyyy.";
            this.dateTimePickerDateOfEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateTimePickerDateOfEntry.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDateOfEntry.Location = new System.Drawing.Point(160, 217);
            this.dateTimePickerDateOfEntry.Name = "dateTimePickerDateOfEntry";
            this.dateTimePickerDateOfEntry.Size = new System.Drawing.Size(217, 26);
            this.dateTimePickerDateOfEntry.TabIndex = 12;
            // 
            // labelDateOfEntry
            // 
            this.labelDateOfEntry.AutoSize = true;
            this.labelDateOfEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelDateOfEntry.Location = new System.Drawing.Point(55, 222);
            this.labelDateOfEntry.Name = "labelDateOfEntry";
            this.labelDateOfEntry.Size = new System.Drawing.Size(99, 20);
            this.labelDateOfEntry.TabIndex = 11;
            this.labelDateOfEntry.Text = "Datum upisa";
            // 
            // dateTimePickerDateOfBirth
            // 
            this.dateTimePickerDateOfBirth.CustomFormat = "dd.MM.yyyy.";
            this.dateTimePickerDateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateTimePickerDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDateOfBirth.Location = new System.Drawing.Point(160, 185);
            this.dateTimePickerDateOfBirth.Name = "dateTimePickerDateOfBirth";
            this.dateTimePickerDateOfBirth.Size = new System.Drawing.Size(217, 26);
            this.dateTimePickerDateOfBirth.TabIndex = 10;
            this.dateTimePickerDateOfBirth.Leave += new System.EventHandler(this.dateTimePickerDateOfBirth_Leave);
            // 
            // labelDateOfBirth
            // 
            this.labelDateOfBirth.AutoSize = true;
            this.labelDateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelDateOfBirth.Location = new System.Drawing.Point(40, 190);
            this.labelDateOfBirth.Name = "labelDateOfBirth";
            this.labelDateOfBirth.Size = new System.Drawing.Size(114, 20);
            this.labelDateOfBirth.TabIndex = 8;
            this.labelDateOfBirth.Text = "Datum rođenja";
            // 
            // textBoxLocation
            // 
            this.textBoxLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxLocation.Location = new System.Drawing.Point(160, 153);
            this.textBoxLocation.Name = "textBoxLocation";
            this.textBoxLocation.Size = new System.Drawing.Size(217, 26);
            this.textBoxLocation.TabIndex = 7;
            this.textBoxLocation.Leave += new System.EventHandler(this.textBoxLocation_Leave);
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelLocation.Location = new System.Drawing.Point(101, 156);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(53, 20);
            this.labelLocation.TabIndex = 6;
            this.labelLocation.Text = "Mesto";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxAddress.Location = new System.Drawing.Point(160, 121);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(217, 26);
            this.textBoxAddress.TabIndex = 5;
            this.textBoxAddress.Leave += new System.EventHandler(this.textBoxAddress_Leave);
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelAddress.Location = new System.Drawing.Point(94, 124);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(60, 20);
            this.labelAddress.TabIndex = 4;
            this.labelAddress.Text = "Adresa";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxLastName.Location = new System.Drawing.Point(160, 89);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(217, 26);
            this.textBoxLastName.TabIndex = 3;
            this.textBoxLastName.Leave += new System.EventHandler(this.textBoxLastName_Leave);
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelLastName.Location = new System.Drawing.Point(88, 92);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(66, 20);
            this.labelLastName.TabIndex = 2;
            this.labelLastName.Text = "Prezime";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxFirstName.Location = new System.Drawing.Point(160, 57);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(217, 26);
            this.textBoxFirstName.TabIndex = 1;
            this.textBoxFirstName.Leave += new System.EventHandler(this.textBoxFirstName_Leave);
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelFirstName.Location = new System.Drawing.Point(118, 60);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(36, 20);
            this.labelFirstName.TabIndex = 0;
            this.labelFirstName.Text = "Ime";
            // 
            // groupBoxChoose
            // 
            this.groupBoxChoose.Controls.Add(this.comboBoxChoose);
            this.groupBoxChoose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            this.groupBoxChoose.Location = new System.Drawing.Point(13, 13);
            this.groupBoxChoose.Name = "groupBoxChoose";
            this.groupBoxChoose.Size = new System.Drawing.Size(400, 62);
            this.groupBoxChoose.TabIndex = 6;
            this.groupBoxChoose.TabStop = false;
            this.groupBoxChoose.Text = "Odabir člana";
            // 
            // comboBoxChoose
            // 
            this.comboBoxChoose.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxChoose.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxChoose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBoxChoose.FormattingEnabled = true;
            this.comboBoxChoose.Location = new System.Drawing.Point(43, 25);
            this.comboBoxChoose.Name = "comboBoxChoose";
            this.comboBoxChoose.Size = new System.Drawing.Size(333, 28);
            this.comboBoxChoose.TabIndex = 0;
            this.comboBoxChoose.Text = "Odaberite člana";
            this.comboBoxChoose.SelectedValueChanged += new System.EventHandler(this.comboBoxChoose_SelectedValueChanged);
            this.comboBoxChoose.Leave += new System.EventHandler(this.comboBoxChoose_Leave);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(480, 205);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(56, 20);
            this.labelStatus.TabIndex = 7;
            this.labelStatus.Text = "Status";
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "Izaberite status",
            "aktivan",
            "neaktivan",
            "obrisan"});
            this.comboBoxStatus.Location = new System.Drawing.Point(542, 202);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(215, 28);
            this.comboBoxStatus.TabIndex = 8;
            this.comboBoxStatus.SelectedValueChanged += new System.EventHandler(this.comboBoxStatus_SelectedValueChanged);
            // 
            // textBoxDebtAmount
            // 
            this.textBoxDebtAmount.Enabled = false;
            this.textBoxDebtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxDebtAmount.Location = new System.Drawing.Point(542, 234);
            this.textBoxDebtAmount.Name = "textBoxDebtAmount";
            this.textBoxDebtAmount.Size = new System.Drawing.Size(215, 26);
            this.textBoxDebtAmount.TabIndex = 19;
            // 
            // labelDebtAmount
            // 
            this.labelDebtAmount.AutoSize = true;
            this.labelDebtAmount.Location = new System.Drawing.Point(451, 237);
            this.labelDebtAmount.Name = "labelDebtAmount";
            this.labelDebtAmount.Size = new System.Drawing.Size(85, 20);
            this.labelDebtAmount.TabIndex = 20;
            this.labelDebtAmount.Text = "Dugovanje";
            // 
            // labelReservations
            // 
            this.labelReservations.AutoSize = true;
            this.labelReservations.Location = new System.Drawing.Point(445, 271);
            this.labelReservations.Name = "labelReservations";
            this.labelReservations.Size = new System.Drawing.Size(91, 20);
            this.labelReservations.TabIndex = 22;
            this.labelReservations.Text = "Rezervacije";
            // 
            // textBoxReservations
            // 
            this.textBoxReservations.Enabled = false;
            this.textBoxReservations.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxReservations.Location = new System.Drawing.Point(542, 268);
            this.textBoxReservations.Name = "textBoxReservations";
            this.textBoxReservations.Size = new System.Drawing.Size(215, 26);
            this.textBoxReservations.TabIndex = 21;
            // 
            // EditMemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 444);
            this.Controls.Add(this.labelReservations);
            this.Controls.Add(this.textBoxReservations);
            this.Controls.Add(this.labelDebtAmount);
            this.Controls.Add(this.textBoxDebtAmount);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.groupBoxChoose);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.groupBoxContactInfo);
            this.Controls.Add(this.groupBoxBasicInfo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EditMemberForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Promena podataka o članu";
            this.Load += new System.EventHandler(this.EditMemberForm_Load);
            this.groupBoxContactInfo.ResumeLayout(false);
            this.groupBoxContactInfo.PerformLayout();
            this.groupBoxBasicInfo.ResumeLayout(false);
            this.groupBoxBasicInfo.PerformLayout();
            this.groupBoxChoose.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.GroupBox groupBoxContactInfo;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelMobilePhone;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxMobilePhone;
        private System.Windows.Forms.GroupBox groupBoxBasicInfo;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelMemberGroup;
        private System.Windows.Forms.ComboBox comboBoxMemberGroup;
        private System.Windows.Forms.TextBox textBoxYearsOfExperience;
        private System.Windows.Forms.Label labelYearsOfExperience;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateOfEntry;
        private System.Windows.Forms.Label labelDateOfEntry;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateOfBirth;
        private System.Windows.Forms.Label labelDateOfBirth;
        private System.Windows.Forms.TextBox textBoxLocation;
        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.GroupBox groupBoxChoose;
        private System.Windows.Forms.ComboBox comboBoxChoose;
        private System.Windows.Forms.CheckBox checkBoxDiscount;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.TextBox textBoxDebtAmount;
        private System.Windows.Forms.Label labelDebtAmount;
        private System.Windows.Forms.Label labelReservations;
        private System.Windows.Forms.TextBox textBoxReservations;
    }
}