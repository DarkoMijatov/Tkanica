namespace Tkanica
{
    partial class ViewTransactionsForm
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
            this.dateTimePickerDateFrom = new System.Windows.Forms.DateTimePicker();
            this.checkBoxWallet = new System.Windows.Forms.CheckBox();
            this.labelDateTo = new System.Windows.Forms.Label();
            this.labelDateFrom = new System.Windows.Forms.Label();
            this.checkBoxBank = new System.Windows.Forms.CheckBox();
            this.checkBoxOutgoing = new System.Windows.Forms.CheckBox();
            this.checkBoxIncoming = new System.Windows.Forms.CheckBox();
            this.comboBoxTransactionType = new System.Windows.Forms.ComboBox();
            this.labelTransactionType = new System.Windows.Forms.Label();
            this.textBoxCreditor = new System.Windows.Forms.TextBox();
            this.labelCreditor = new System.Windows.Forms.Label();
            this.textBoxDebtor = new System.Windows.Forms.TextBox();
            this.labelDebtor = new System.Windows.Forms.Label();
            this.dataGridViewTransactions = new System.Windows.Forms.DataGridView();
            this.groupBoxSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransactions)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Controls.Add(this.dateTimePickerDateTo);
            this.groupBoxSearch.Controls.Add(this.dateTimePickerDateFrom);
            this.groupBoxSearch.Controls.Add(this.checkBoxWallet);
            this.groupBoxSearch.Controls.Add(this.labelDateTo);
            this.groupBoxSearch.Controls.Add(this.labelDateFrom);
            this.groupBoxSearch.Controls.Add(this.checkBoxBank);
            this.groupBoxSearch.Controls.Add(this.checkBoxOutgoing);
            this.groupBoxSearch.Controls.Add(this.checkBoxIncoming);
            this.groupBoxSearch.Controls.Add(this.comboBoxTransactionType);
            this.groupBoxSearch.Controls.Add(this.labelTransactionType);
            this.groupBoxSearch.Controls.Add(this.textBoxCreditor);
            this.groupBoxSearch.Controls.Add(this.labelCreditor);
            this.groupBoxSearch.Controls.Add(this.textBoxDebtor);
            this.groupBoxSearch.Controls.Add(this.labelDebtor);
            this.groupBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            this.groupBoxSearch.Location = new System.Drawing.Point(13, 13);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Size = new System.Drawing.Size(704, 119);
            this.groupBoxSearch.TabIndex = 0;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Pretraga";
            // 
            // dateTimePickerDateTo
            // 
            this.dateTimePickerDateTo.CustomFormat = "dd.MM.yyyy.";
            this.dateTimePickerDateTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateTimePickerDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDateTo.Location = new System.Drawing.Point(362, 83);
            this.dateTimePickerDateTo.Name = "dateTimePickerDateTo";
            this.dateTimePickerDateTo.Size = new System.Drawing.Size(139, 26);
            this.dateTimePickerDateTo.TabIndex = 13;
            this.dateTimePickerDateTo.ValueChanged += new System.EventHandler(this.dateTimePickerDateTo_ValueChanged);
            // 
            // dateTimePickerDateFrom
            // 
            this.dateTimePickerDateFrom.CustomFormat = "dd.MM.yyyy.";
            this.dateTimePickerDateFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateTimePickerDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDateFrom.Location = new System.Drawing.Point(362, 21);
            this.dateTimePickerDateFrom.Name = "dateTimePickerDateFrom";
            this.dateTimePickerDateFrom.Size = new System.Drawing.Size(139, 26);
            this.dateTimePickerDateFrom.TabIndex = 12;
            this.dateTimePickerDateFrom.Value = new System.DateTime(2019, 11, 27, 16, 18, 0, 0);
            this.dateTimePickerDateFrom.ValueChanged += new System.EventHandler(this.dateTimePickerDateFrom_ValueChanged);
            // 
            // checkBoxWallet
            // 
            this.checkBoxWallet.AutoSize = true;
            this.checkBoxWallet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.checkBoxWallet.Location = new System.Drawing.Point(615, 87);
            this.checkBoxWallet.Name = "checkBoxWallet";
            this.checkBoxWallet.Size = new System.Drawing.Size(64, 24);
            this.checkBoxWallet.TabIndex = 8;
            this.checkBoxWallet.Text = "Kasa";
            this.checkBoxWallet.UseVisualStyleBackColor = true;
            this.checkBoxWallet.CheckedChanged += new System.EventHandler(this.checkBoxWallet_CheckedChanged);
            // 
            // labelDateTo
            // 
            this.labelDateTo.AutoSize = true;
            this.labelDateTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelDateTo.Location = new System.Drawing.Point(277, 87);
            this.labelDateTo.Name = "labelDateTo";
            this.labelDateTo.Size = new System.Drawing.Size(79, 20);
            this.labelDateTo.TabIndex = 11;
            this.labelDateTo.Text = "Datum do";
            // 
            // labelDateFrom
            // 
            this.labelDateFrom.AutoSize = true;
            this.labelDateFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelDateFrom.Location = new System.Drawing.Point(277, 26);
            this.labelDateFrom.Name = "labelDateFrom";
            this.labelDateFrom.Size = new System.Drawing.Size(79, 20);
            this.labelDateFrom.TabIndex = 10;
            this.labelDateFrom.Text = "Datum od";
            // 
            // checkBoxBank
            // 
            this.checkBoxBank.AutoSize = true;
            this.checkBoxBank.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.checkBoxBank.Location = new System.Drawing.Point(534, 87);
            this.checkBoxBank.Name = "checkBoxBank";
            this.checkBoxBank.Size = new System.Drawing.Size(74, 24);
            this.checkBoxBank.TabIndex = 9;
            this.checkBoxBank.Text = "Banka";
            this.checkBoxBank.UseVisualStyleBackColor = true;
            this.checkBoxBank.CheckedChanged += new System.EventHandler(this.checkBoxBank_CheckedChanged);
            // 
            // checkBoxOutgoing
            // 
            this.checkBoxOutgoing.AutoSize = true;
            this.checkBoxOutgoing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.checkBoxOutgoing.Location = new System.Drawing.Point(615, 25);
            this.checkBoxOutgoing.Name = "checkBoxOutgoing";
            this.checkBoxOutgoing.Size = new System.Drawing.Size(76, 24);
            this.checkBoxOutgoing.TabIndex = 7;
            this.checkBoxOutgoing.Text = "Isplate";
            this.checkBoxOutgoing.UseVisualStyleBackColor = true;
            this.checkBoxOutgoing.CheckedChanged += new System.EventHandler(this.checkBoxOutgoing_CheckedChanged);
            // 
            // checkBoxIncoming
            // 
            this.checkBoxIncoming.AutoSize = true;
            this.checkBoxIncoming.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.checkBoxIncoming.Location = new System.Drawing.Point(534, 25);
            this.checkBoxIncoming.Name = "checkBoxIncoming";
            this.checkBoxIncoming.Size = new System.Drawing.Size(75, 24);
            this.checkBoxIncoming.TabIndex = 6;
            this.checkBoxIncoming.Text = "Uplate";
            this.checkBoxIncoming.UseVisualStyleBackColor = true;
            this.checkBoxIncoming.CheckedChanged += new System.EventHandler(this.checkBoxIncoming_CheckedChanged);
            // 
            // comboBoxTransactionType
            // 
            this.comboBoxTransactionType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxTransactionType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxTransactionType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBoxTransactionType.FormattingEnabled = true;
            this.comboBoxTransactionType.Items.AddRange(new object[] {
            "Izaberite namenu",
            "članarina",
            "putni troškovi",
            "donacija",
            "priliv sredstava",
            "isplata zarade",
            "kupovina sredstava",
            "kotizacija",
            "ostalo"});
            this.comboBoxTransactionType.Location = new System.Drawing.Point(83, 85);
            this.comboBoxTransactionType.Name = "comboBoxTransactionType";
            this.comboBoxTransactionType.Size = new System.Drawing.Size(188, 28);
            this.comboBoxTransactionType.TabIndex = 5;
            this.comboBoxTransactionType.Text = "Izaberite namenu";
            this.comboBoxTransactionType.SelectedValueChanged += new System.EventHandler(this.comboBoxTransactionType_SelectedValueChanged);
            // 
            // labelTransactionType
            // 
            this.labelTransactionType.AutoSize = true;
            this.labelTransactionType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelTransactionType.Location = new System.Drawing.Point(8, 88);
            this.labelTransactionType.Name = "labelTransactionType";
            this.labelTransactionType.Size = new System.Drawing.Size(69, 20);
            this.labelTransactionType.TabIndex = 4;
            this.labelTransactionType.Text = "Namena";
            // 
            // textBoxCreditor
            // 
            this.textBoxCreditor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxCreditor.Location = new System.Drawing.Point(83, 53);
            this.textBoxCreditor.Name = "textBoxCreditor";
            this.textBoxCreditor.Size = new System.Drawing.Size(188, 26);
            this.textBoxCreditor.TabIndex = 3;
            this.textBoxCreditor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCreditor_KeyPress);
            // 
            // labelCreditor
            // 
            this.labelCreditor.AutoSize = true;
            this.labelCreditor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelCreditor.Location = new System.Drawing.Point(8, 57);
            this.labelCreditor.Name = "labelCreditor";
            this.labelCreditor.Size = new System.Drawing.Size(69, 20);
            this.labelCreditor.TabIndex = 2;
            this.labelCreditor.Text = "Primalac";
            // 
            // textBoxDebtor
            // 
            this.textBoxDebtor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxDebtor.Location = new System.Drawing.Point(83, 23);
            this.textBoxDebtor.Name = "textBoxDebtor";
            this.textBoxDebtor.Size = new System.Drawing.Size(188, 26);
            this.textBoxDebtor.TabIndex = 1;
            this.textBoxDebtor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDebtor_KeyPress);
            // 
            // labelDebtor
            // 
            this.labelDebtor.AutoSize = true;
            this.labelDebtor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelDebtor.Location = new System.Drawing.Point(7, 26);
            this.labelDebtor.Name = "labelDebtor";
            this.labelDebtor.Size = new System.Drawing.Size(70, 20);
            this.labelDebtor.TabIndex = 0;
            this.labelDebtor.Text = "Uplatilac";
            // 
            // dataGridViewTransactions
            // 
            this.dataGridViewTransactions.AllowUserToAddRows = false;
            this.dataGridViewTransactions.AllowUserToDeleteRows = false;
            this.dataGridViewTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTransactions.Location = new System.Drawing.Point(13, 138);
            this.dataGridViewTransactions.Name = "dataGridViewTransactions";
            this.dataGridViewTransactions.ReadOnly = true;
            this.dataGridViewTransactions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTransactions.Size = new System.Drawing.Size(860, 283);
            this.dataGridViewTransactions.TabIndex = 1;
            // 
            // ViewTransactionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 433);
            this.Controls.Add(this.dataGridViewTransactions);
            this.Controls.Add(this.groupBoxSearch);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ViewTransactionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pregled transakcija";
            this.Load += new System.EventHandler(this.ViewTransactionsForm_Load);
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransactions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateTo;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateFrom;
        private System.Windows.Forms.Label labelDateTo;
        private System.Windows.Forms.Label labelDateFrom;
        private System.Windows.Forms.CheckBox checkBoxBank;
        private System.Windows.Forms.CheckBox checkBoxWallet;
        private System.Windows.Forms.CheckBox checkBoxOutgoing;
        private System.Windows.Forms.CheckBox checkBoxIncoming;
        private System.Windows.Forms.ComboBox comboBoxTransactionType;
        private System.Windows.Forms.Label labelTransactionType;
        private System.Windows.Forms.TextBox textBoxCreditor;
        private System.Windows.Forms.Label labelCreditor;
        private System.Windows.Forms.TextBox textBoxDebtor;
        private System.Windows.Forms.Label labelDebtor;
        private System.Windows.Forms.DataGridView dataGridViewTransactions;
    }
}