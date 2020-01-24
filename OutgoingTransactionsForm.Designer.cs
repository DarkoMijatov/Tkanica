namespace Tkanica
{
    partial class OutgoingTransactionsForm
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
            this.labelCreditor = new System.Windows.Forms.Label();
            this.textBoxCreditor = new System.Windows.Forms.TextBox();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.labelAmount = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.checkBoxBankTransaction = new System.Windows.Forms.CheckBox();
            this.buttonTransfer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTransactionType
            // 
            this.labelTransactionType.AutoSize = true;
            this.labelTransactionType.Location = new System.Drawing.Point(61, 15);
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
            "isplata zarade",
            "kupovina sredstava",
            "kotizacija",
            "ostalo"});
            this.comboBoxTransactionType.Location = new System.Drawing.Point(136, 12);
            this.comboBoxTransactionType.Name = "comboBoxTransactionType";
            this.comboBoxTransactionType.Size = new System.Drawing.Size(209, 28);
            this.comboBoxTransactionType.TabIndex = 1;
            this.comboBoxTransactionType.Text = "Izaberite namenu";
            this.comboBoxTransactionType.SelectedValueChanged += new System.EventHandler(this.comboBoxTransactionType_SelectedValueChanged);
            // 
            // labelCreditor
            // 
            this.labelCreditor.AutoSize = true;
            this.labelCreditor.Location = new System.Drawing.Point(13, 49);
            this.labelCreditor.Name = "labelCreditor";
            this.labelCreditor.Size = new System.Drawing.Size(117, 20);
            this.labelCreditor.TabIndex = 2;
            this.labelCreditor.Text = "Primalac uplate";
            // 
            // textBoxCreditor
            // 
            this.textBoxCreditor.Location = new System.Drawing.Point(136, 46);
            this.textBoxCreditor.Name = "textBoxCreditor";
            this.textBoxCreditor.Size = new System.Drawing.Size(260, 26);
            this.textBoxCreditor.TabIndex = 3;
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(136, 108);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(100, 26);
            this.textBoxAmount.TabIndex = 5;
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Location = new System.Drawing.Point(82, 111);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(48, 20);
            this.labelAmount.TabIndex = 4;
            this.labelAmount.Text = "Iznos";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(136, 140);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(260, 26);
            this.textBoxDescription.TabIndex = 7;
            this.textBoxDescription.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDescription_KeyPress);
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(89, 143);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(41, 20);
            this.labelDescription.TabIndex = 6;
            this.labelDescription.Text = "Opis";
            // 
            // checkBoxBankTransaction
            // 
            this.checkBoxBankTransaction.AutoSize = true;
            this.checkBoxBankTransaction.Location = new System.Drawing.Point(17, 78);
            this.checkBoxBankTransaction.Name = "checkBoxBankTransaction";
            this.checkBoxBankTransaction.Size = new System.Drawing.Size(203, 24);
            this.checkBoxBankTransaction.TabIndex = 8;
            this.checkBoxBankTransaction.Text = "isplata sa računa u banci";
            this.checkBoxBankTransaction.UseVisualStyleBackColor = true;
            // 
            // buttonTransfer
            // 
            this.buttonTransfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.buttonTransfer.Location = new System.Drawing.Point(234, 172);
            this.buttonTransfer.Name = "buttonTransfer";
            this.buttonTransfer.Size = new System.Drawing.Size(162, 39);
            this.buttonTransfer.TabIndex = 11;
            this.buttonTransfer.Text = "Isplata";
            this.buttonTransfer.UseVisualStyleBackColor = true;
            this.buttonTransfer.Click += new System.EventHandler(this.buttonTransfer_Click);
            // 
            // OutgoingTransactionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 227);
            this.Controls.Add(this.buttonTransfer);
            this.Controls.Add(this.checkBoxBankTransaction);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.textBoxAmount);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.textBoxCreditor);
            this.Controls.Add(this.labelCreditor);
            this.Controls.Add(this.comboBoxTransactionType);
            this.Controls.Add(this.labelTransactionType);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "OutgoingTransactionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Isplata";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTransactionType;
        private System.Windows.Forms.ComboBox comboBoxTransactionType;
        private System.Windows.Forms.Label labelCreditor;
        private System.Windows.Forms.TextBox textBoxCreditor;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.CheckBox checkBoxBankTransaction;
        private System.Windows.Forms.Button buttonTransfer;
    }
}