namespace Tkanica
{
    partial class BalancesViewForm
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
            this.labelBank = new System.Windows.Forms.Label();
            this.labelBankAmount = new System.Windows.Forms.Label();
            this.labelWalletAmount = new System.Windows.Forms.Label();
            this.labelWallet = new System.Windows.Forms.Label();
            this.buttonIncoming = new System.Windows.Forms.Button();
            this.buttonOutgoing = new System.Windows.Forms.Button();
            this.labelTotalAmount = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelLine = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelBank
            // 
            this.labelBank.AutoSize = true;
            this.labelBank.Location = new System.Drawing.Point(13, 13);
            this.labelBank.Name = "labelBank";
            this.labelBank.Size = new System.Drawing.Size(189, 20);
            this.labelBank.TabIndex = 0;
            this.labelBank.Text = "Stanje na računu u banci:";
            // 
            // labelBankAmount
            // 
            this.labelBankAmount.AutoSize = true;
            this.labelBankAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.labelBankAmount.Location = new System.Drawing.Point(208, 13);
            this.labelBankAmount.Name = "labelBankAmount";
            this.labelBankAmount.Size = new System.Drawing.Size(57, 20);
            this.labelBankAmount.TabIndex = 1;
            this.labelBankAmount.Text = "label2";
            // 
            // labelWalletAmount
            // 
            this.labelWalletAmount.AutoSize = true;
            this.labelWalletAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.labelWalletAmount.Location = new System.Drawing.Point(208, 54);
            this.labelWalletAmount.Name = "labelWalletAmount";
            this.labelWalletAmount.Size = new System.Drawing.Size(57, 20);
            this.labelWalletAmount.TabIndex = 3;
            this.labelWalletAmount.Text = "label3";
            // 
            // labelWallet
            // 
            this.labelWallet.AutoSize = true;
            this.labelWallet.Location = new System.Drawing.Point(98, 54);
            this.labelWallet.Name = "labelWallet";
            this.labelWallet.Size = new System.Drawing.Size(104, 20);
            this.labelWallet.TabIndex = 2;
            this.labelWallet.Text = "Stanje u kasi:";
            // 
            // buttonIncoming
            // 
            this.buttonIncoming.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.buttonIncoming.Location = new System.Drawing.Point(80, 151);
            this.buttonIncoming.Name = "buttonIncoming";
            this.buttonIncoming.Size = new System.Drawing.Size(122, 35);
            this.buttonIncoming.TabIndex = 4;
            this.buttonIncoming.Text = "Izvrši uplatu";
            this.buttonIncoming.UseVisualStyleBackColor = true;
            this.buttonIncoming.Click += new System.EventHandler(this.buttonIncoming_Click);
            // 
            // buttonOutgoing
            // 
            this.buttonOutgoing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.buttonOutgoing.Location = new System.Drawing.Point(212, 151);
            this.buttonOutgoing.Name = "buttonOutgoing";
            this.buttonOutgoing.Size = new System.Drawing.Size(117, 35);
            this.buttonOutgoing.TabIndex = 5;
            this.buttonOutgoing.Text = "Izvrši isplatu";
            this.buttonOutgoing.UseVisualStyleBackColor = true;
            this.buttonOutgoing.Click += new System.EventHandler(this.buttonOutgoing_Click);
            // 
            // labelTotalAmount
            // 
            this.labelTotalAmount.AutoSize = true;
            this.labelTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.labelTotalAmount.Location = new System.Drawing.Point(208, 116);
            this.labelTotalAmount.Name = "labelTotalAmount";
            this.labelTotalAmount.Size = new System.Drawing.Size(57, 20);
            this.labelTotalAmount.TabIndex = 7;
            this.labelTotalAmount.Text = "label3";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(133, 116);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(69, 20);
            this.labelTotal.TabIndex = 6;
            this.labelTotal.Text = "Ukupno:";
            // 
            // labelLine
            // 
            this.labelLine.AutoSize = true;
            this.labelLine.Location = new System.Drawing.Point(13, 86);
            this.labelLine.Name = "labelLine";
            this.labelLine.Size = new System.Drawing.Size(414, 20);
            this.labelLine.TabIndex = 8;
            this.labelLine.Text = "_____________________________________________\r\n";
            // 
            // BalancesViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 206);
            this.Controls.Add(this.labelLine);
            this.Controls.Add(this.labelTotalAmount);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.buttonOutgoing);
            this.Controls.Add(this.buttonIncoming);
            this.Controls.Add(this.labelWalletAmount);
            this.Controls.Add(this.labelWallet);
            this.Controls.Add(this.labelBankAmount);
            this.Controls.Add(this.labelBank);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BalancesViewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pregled stanja";
            this.Load += new System.EventHandler(this.BalancesViewForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBank;
        private System.Windows.Forms.Label labelBankAmount;
        private System.Windows.Forms.Label labelWalletAmount;
        private System.Windows.Forms.Label labelWallet;
        private System.Windows.Forms.Button buttonIncoming;
        private System.Windows.Forms.Button buttonOutgoing;
        private System.Windows.Forms.Label labelTotalAmount;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelLine;
    }
}