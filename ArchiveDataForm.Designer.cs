namespace Tkanica
{
    partial class ArchiveDataForm
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
            this.labelData = new System.Windows.Forms.Label();
            this.comboBoxData = new System.Windows.Forms.ComboBox();
            this.labelDateFrom = new System.Windows.Forms.Label();
            this.dateTimePickerDateFrom = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDateTo = new System.Windows.Forms.DateTimePicker();
            this.labelDateTo = new System.Windows.Forms.Label();
            this.buttonArchive = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Location = new System.Drawing.Point(18, 14);
            this.labelData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(153, 20);
            this.labelData.TabIndex = 0;
            this.labelData.Text = "Podaci za arhiviranje";
            // 
            // comboBoxData
            // 
            this.comboBoxData.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxData.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxData.FormattingEnabled = true;
            this.comboBoxData.Items.AddRange(new object[] {
            "Izaberite podatke",
            "Rezervacije",
            "Transakcije"});
            this.comboBoxData.Location = new System.Drawing.Point(178, 11);
            this.comboBoxData.Name = "comboBoxData";
            this.comboBoxData.Size = new System.Drawing.Size(157, 28);
            this.comboBoxData.TabIndex = 1;
            this.comboBoxData.Text = "Izaberite podatke";
            // 
            // labelDateFrom
            // 
            this.labelDateFrom.AutoSize = true;
            this.labelDateFrom.Location = new System.Drawing.Point(92, 50);
            this.labelDateFrom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDateFrom.Name = "labelDateFrom";
            this.labelDateFrom.Size = new System.Drawing.Size(79, 20);
            this.labelDateFrom.TabIndex = 2;
            this.labelDateFrom.Text = "Datum od";
            // 
            // dateTimePickerDateFrom
            // 
            this.dateTimePickerDateFrom.CustomFormat = "dd.MM.yyyy.";
            this.dateTimePickerDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDateFrom.Location = new System.Drawing.Point(178, 45);
            this.dateTimePickerDateFrom.Name = "dateTimePickerDateFrom";
            this.dateTimePickerDateFrom.Size = new System.Drawing.Size(157, 26);
            this.dateTimePickerDateFrom.TabIndex = 3;
            this.dateTimePickerDateFrom.Value = new System.DateTime(2019, 11, 27, 0, 0, 0, 0);
            // 
            // dateTimePickerDateTo
            // 
            this.dateTimePickerDateTo.CustomFormat = "dd.MM.yyyy.";
            this.dateTimePickerDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDateTo.Location = new System.Drawing.Point(178, 77);
            this.dateTimePickerDateTo.Name = "dateTimePickerDateTo";
            this.dateTimePickerDateTo.Size = new System.Drawing.Size(157, 26);
            this.dateTimePickerDateTo.TabIndex = 5;
            // 
            // labelDateTo
            // 
            this.labelDateTo.AutoSize = true;
            this.labelDateTo.Location = new System.Drawing.Point(92, 82);
            this.labelDateTo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDateTo.Name = "labelDateTo";
            this.labelDateTo.Size = new System.Drawing.Size(79, 20);
            this.labelDateTo.TabIndex = 4;
            this.labelDateTo.Text = "Datum do";
            // 
            // buttonArchive
            // 
            this.buttonArchive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.buttonArchive.Location = new System.Drawing.Point(178, 109);
            this.buttonArchive.Name = "buttonArchive";
            this.buttonArchive.Size = new System.Drawing.Size(157, 37);
            this.buttonArchive.TabIndex = 6;
            this.buttonArchive.Text = "Arhivirajte";
            this.buttonArchive.UseVisualStyleBackColor = true;
            this.buttonArchive.Click += new System.EventHandler(this.buttonArchive_Click);
            // 
            // ArchiveDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 168);
            this.Controls.Add(this.buttonArchive);
            this.Controls.Add(this.dateTimePickerDateTo);
            this.Controls.Add(this.labelDateTo);
            this.Controls.Add(this.dateTimePickerDateFrom);
            this.Controls.Add(this.labelDateFrom);
            this.Controls.Add(this.comboBoxData);
            this.Controls.Add(this.labelData);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ArchiveDataForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Arhiviranje podataka";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.ComboBox comboBoxData;
        private System.Windows.Forms.Label labelDateFrom;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateFrom;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateTo;
        private System.Windows.Forms.Label labelDateTo;
        private System.Windows.Forms.Button buttonArchive;
    }
}