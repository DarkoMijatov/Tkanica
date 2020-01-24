namespace Tkanica
{
    partial class IncomingTransactionsForm
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
            this.labelTransactionType = new System.Windows.Forms.Label();
            this.comboBoxTransactionType = new System.Windows.Forms.ComboBox();
            this.checkBoxBankTransaction = new System.Windows.Forms.CheckBox();
            this.labelDebtor = new System.Windows.Forms.Label();
            this.comboBoxDebtor = new System.Windows.Forms.ComboBox();
            this.textBoxDebtor = new System.Windows.Forms.TextBox();
            this.labelAmount = new System.Windows.Forms.Label();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.buttonTransfer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTransactionType
            // 
            this.labelTransactionType.AutoSize = true;
            this.labelTransactionType.Location = new System.Drawing.Point(13, 13);
            this.labelTransactionType.Name = "labelTransactionType";
            this.labelTransactionType.Size = new System.Drawing.Size(69, 20);
            this.labelTransactionType.TabIndex = 0;
            this.labelTransactionType.Text = "Namena";
            // 
            // comboBoxTransactionType
            // 
            this.comboBoxTransactionType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxTransactionType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxTransactionType.FormattingEnabled = true;
            this.comboBoxTransactionType.Items.AddRange(new object[] {
            "Izaberite namenu",
            "članarina",
            "putni troškovi",
            "donacija",
            "priliv sredstava",
            "ostalo"});
            this.comboBoxTransactionType.Location = new System.Drawing.Point(88, 10);
            this.comboBoxTransactionType.Name = "comboBoxTransactionType";
            this.comboBoxTransactionType.Size = new System.Drawing.Size(207, 28);
            this.comboBoxTransactionType.TabIndex = 1;
            this.comboBoxTransactionType.Text = "Izaberite namenu";
            this.comboBoxTransactionType.SelectedValueChanged += new System.EventHandler(this.comboBoxTransactionType_SelectedValueChanged);
            // 
            // checkBoxBankTransaction
            // 
            this.checkBoxBankTransaction.AutoSize = true;
            this.checkBoxBankTransaction.Location = new System.Drawing.Point(17, 78);
            this.checkBoxBankTransaction.Name = "checkBoxBankTransaction";
            this.checkBoxBankTransaction.Size = new System.Drawing.Size(202, 24);
            this.checkBoxBankTransaction.TabIndex = 2;
            this.checkBoxBankTransaction.Text = "uplata na računu u banci";
            this.checkBoxBankTransaction.UseVisualStyleBackColor = true;
            // 
            // labelDebtor
            // 
            this.labelDebtor.AutoSize = true;
            this.labelDebtor.Location = new System.Drawing.Point(13, 47);
            this.labelDebtor.Name = "labelDebtor";
            this.labelDebtor.Size = new System.Drawing.Size(70, 20);
            this.labelDebtor.TabIndex = 3;
            this.labelDebtor.Text = "Uplatilac";
            // 
            // comboBoxDebtor
            // 
            this.comboBoxDebtor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxDebtor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxDebtor.FormattingEnabled = true;
            this.comboBoxDebtor.Items.AddRange(new object[] {
            "Izaberite uplatioca"});
            this.comboBoxDebtor.Location = new System.Drawing.Point(89, 44);
            this.comboBoxDebtor.Name = "comboBoxDebtor";
            this.comboBoxDebtor.Size = new System.Drawing.Size(206, 28);
            this.comboBoxDebtor.TabIndex = 4;
            this.comboBoxDebtor.Text = "Izaberite uplatioca";
            this.comboBoxDebtor.SelectedValueChanged += new System.EventHandler(this.comboBoxDebtor_SelectedValueChanged);
            // 
            // textBoxDebtor
            // 
            this.textBoxDebtor.Location = new System.Drawing.Point(88, 44);
            this.textBoxDebtor.Name = "textBoxDebtor";
            this.textBoxDebtor.Size = new System.Drawing.Size(289, 26);
            this.textBoxDebtor.TabIndex = 5;
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Location = new System.Drawing.Point(34, 109);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(48, 20);
            this.labelAmount.TabIndex = 6;
            this.labelAmount.Text = "Iznos";
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(88, 106);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(100, 26);
            this.textBoxAmount.TabIndex = 7;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(88, 138);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(289, 26);
            this.textBoxDescription.TabIndex = 9;
            this.textBoxDescription.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDescription_KeyPress);
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(41, 141);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(41, 20);
            this.labelDescription.TabIndex = 8;
            this.labelDescription.Text = "Opis";
            // 
            // buttonTransfer
            // 
            this.buttonTransfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.buttonTransfer.Location = new System.Drawing.Point(186, 170);
            this.buttonTransfer.Name = "buttonTransfer";
            this.buttonTransfer.Size = new System.Drawing.Size(191, 38);
            this.buttonTransfer.TabIndex = 10;
            this.buttonTransfer.Text = "Uplati";
            this.buttonTransfer.UseVisualStyleBackColor = true;
            this.buttonTransfer.Click += new System.EventHandler(this.buttonTransfer_Click);
            // 
            // IncomingTransactionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 220);
            this.Controls.Add(this.buttonTransfer);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.textBoxAmount);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.textBoxDebtor);
            this.Controls.Add(this.comboBoxDebtor);
            this.Controls.Add(this.labelDebtor);
            this.Controls.Add(this.checkBoxBankTransaction);
            this.Controls.Add(this.comboBoxTransactionType);
            this.Controls.Add(this.labelTransactionType);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "IncomingTransactionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Uplata";
            this.Load += new System.EventHandler(this.IncomingTransactionsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTransactionType;
        private System.Windows.Forms.ComboBox comboBoxTransactionType;
        private System.Windows.Forms.CheckBox checkBoxBankTransaction;
        private System.Windows.Forms.Label labelDebtor;
        private System.Windows.Forms.ComboBox comboBoxDebtor;
        private System.Windows.Forms.TextBox textBoxDebtor;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Button buttonTransfer;
    }
}