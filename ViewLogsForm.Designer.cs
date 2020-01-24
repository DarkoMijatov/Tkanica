namespace Tkanica
{
    partial class ViewLogsForm
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
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.dateTimePickerDateTo = new System.Windows.Forms.DateTimePicker();
            this.labelDateTo = new System.Windows.Forms.Label();
            this.labelDateFrom = new System.Windows.Forms.Label();
            this.dateTimePickerDateFrom = new System.Windows.Forms.DateTimePicker();
            this.textBoxActivity = new System.Windows.Forms.TextBox();
            this.labelActivity = new System.Windows.Forms.Label();
            this.comboBoxUser = new System.Windows.Forms.ComboBox();
            this.labelUser = new System.Windows.Forms.Label();
            this.dataGridViewLogs = new System.Windows.Forms.DataGridView();
            this.groupBoxSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLogs)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Controls.Add(this.dateTimePickerDateTo);
            this.groupBoxSearch.Controls.Add(this.labelDateTo);
            this.groupBoxSearch.Controls.Add(this.labelDateFrom);
            this.groupBoxSearch.Controls.Add(this.dateTimePickerDateFrom);
            this.groupBoxSearch.Controls.Add(this.textBoxActivity);
            this.groupBoxSearch.Controls.Add(this.labelActivity);
            this.groupBoxSearch.Controls.Add(this.comboBoxUser);
            this.groupBoxSearch.Controls.Add(this.labelUser);
            this.groupBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            this.groupBoxSearch.Location = new System.Drawing.Point(13, 13);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Size = new System.Drawing.Size(493, 114);
            this.groupBoxSearch.TabIndex = 0;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Pretraga";
            // 
            // dateTimePickerDateTo
            // 
            this.dateTimePickerDateTo.CustomFormat = "dd.MM.yyyy.";
            this.dateTimePickerDateTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateTimePickerDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDateTo.Location = new System.Drawing.Point(347, 67);
            this.dateTimePickerDateTo.Name = "dateTimePickerDateTo";
            this.dateTimePickerDateTo.Size = new System.Drawing.Size(129, 26);
            this.dateTimePickerDateTo.TabIndex = 7;
            this.dateTimePickerDateTo.ValueChanged += new System.EventHandler(this.dateTimePickerDateTo_ValueChanged);
            // 
            // labelDateTo
            // 
            this.labelDateTo.AutoSize = true;
            this.labelDateTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelDateTo.Location = new System.Drawing.Point(262, 72);
            this.labelDateTo.Name = "labelDateTo";
            this.labelDateTo.Size = new System.Drawing.Size(79, 20);
            this.labelDateTo.TabIndex = 6;
            this.labelDateTo.Text = "Datum do";
            // 
            // labelDateFrom
            // 
            this.labelDateFrom.AutoSize = true;
            this.labelDateFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelDateFrom.Location = new System.Drawing.Point(262, 26);
            this.labelDateFrom.Name = "labelDateFrom";
            this.labelDateFrom.Size = new System.Drawing.Size(79, 20);
            this.labelDateFrom.TabIndex = 5;
            this.labelDateFrom.Text = "Datum od";
            // 
            // dateTimePickerDateFrom
            // 
            this.dateTimePickerDateFrom.CustomFormat = "dd.MM.yyyy.";
            this.dateTimePickerDateFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateTimePickerDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDateFrom.Location = new System.Drawing.Point(347, 21);
            this.dateTimePickerDateFrom.Name = "dateTimePickerDateFrom";
            this.dateTimePickerDateFrom.Size = new System.Drawing.Size(129, 26);
            this.dateTimePickerDateFrom.TabIndex = 4;
            this.dateTimePickerDateFrom.Value = new System.DateTime(2019, 11, 27, 10, 7, 0, 0);
            this.dateTimePickerDateFrom.ValueChanged += new System.EventHandler(this.dateTimePickerDateFrom_ValueChanged);
            // 
            // textBoxActivity
            // 
            this.textBoxActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxActivity.Location = new System.Drawing.Point(87, 69);
            this.textBoxActivity.Name = "textBoxActivity";
            this.textBoxActivity.Size = new System.Drawing.Size(169, 26);
            this.textBoxActivity.TabIndex = 3;
            this.textBoxActivity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxActivity_KeyPress);
            // 
            // labelActivity
            // 
            this.labelActivity.AutoSize = true;
            this.labelActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelActivity.Location = new System.Drawing.Point(7, 72);
            this.labelActivity.Name = "labelActivity";
            this.labelActivity.Size = new System.Drawing.Size(74, 20);
            this.labelActivity.TabIndex = 2;
            this.labelActivity.Text = "Aktivnost";
            // 
            // comboBoxUser
            // 
            this.comboBoxUser.AutoCompleteCustomSource.AddRange(new string[] {
            "Izaberite korisnika"});
            this.comboBoxUser.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxUser.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBoxUser.FormattingEnabled = true;
            this.comboBoxUser.Items.AddRange(new object[] {
            "Izaberite korisnika"});
            this.comboBoxUser.Location = new System.Drawing.Point(87, 23);
            this.comboBoxUser.Name = "comboBoxUser";
            this.comboBoxUser.Size = new System.Drawing.Size(169, 28);
            this.comboBoxUser.TabIndex = 1;
            this.comboBoxUser.Text = "Izaberite korisnika";
            this.comboBoxUser.SelectedValueChanged += new System.EventHandler(this.comboBoxUser_SelectedValueChanged);
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelUser.Location = new System.Drawing.Point(17, 26);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(64, 20);
            this.labelUser.TabIndex = 0;
            this.labelUser.Text = "Korisnik";
            // 
            // dataGridViewLogs
            // 
            this.dataGridViewLogs.AllowUserToAddRows = false;
            this.dataGridViewLogs.AllowUserToDeleteRows = false;
            this.dataGridViewLogs.AllowUserToOrderColumns = true;
            this.dataGridViewLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLogs.Location = new System.Drawing.Point(13, 133);
            this.dataGridViewLogs.Name = "dataGridViewLogs";
            this.dataGridViewLogs.ReadOnly = true;
            this.dataGridViewLogs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewLogs.Size = new System.Drawing.Size(493, 215);
            this.dataGridViewLogs.TabIndex = 1;
            // 
            // ViewLogsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 360);
            this.Controls.Add(this.dataGridViewLogs);
            this.Controls.Add(this.groupBoxSearch);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ViewLogsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pregled aktivnosti";
            this.Load += new System.EventHandler(this.ViewLogsForm_Load);
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLogs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateTo;
        private System.Windows.Forms.Label labelDateTo;
        private System.Windows.Forms.Label labelDateFrom;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateFrom;
        private System.Windows.Forms.TextBox textBoxActivity;
        private System.Windows.Forms.Label labelActivity;
        private System.Windows.Forms.ComboBox comboBoxUser;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.DataGridView dataGridViewLogs;
    }
}