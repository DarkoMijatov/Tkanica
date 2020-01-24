namespace Tkanica
{
    partial class EditMembershipFeeForm
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
            this.groupBoxSelectFee = new System.Windows.Forms.GroupBox();
            this.comboBoxSelectFee = new System.Windows.Forms.ComboBox();
            this.groupBoxFee = new System.Windows.Forms.GroupBox();
            this.textBoxMemberGroup = new System.Windows.Forms.TextBox();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.labelAmount = new System.Windows.Forms.Label();
            this.checkBoxDiscount = new System.Windows.Forms.CheckBox();
            this.labelMemberGroup = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.groupBoxSelectFee.SuspendLayout();
            this.groupBoxFee.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxSelectFee
            // 
            this.groupBoxSelectFee.Controls.Add(this.comboBoxSelectFee);
            this.groupBoxSelectFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            this.groupBoxSelectFee.Location = new System.Drawing.Point(13, 13);
            this.groupBoxSelectFee.Name = "groupBoxSelectFee";
            this.groupBoxSelectFee.Size = new System.Drawing.Size(327, 78);
            this.groupBoxSelectFee.TabIndex = 0;
            this.groupBoxSelectFee.TabStop = false;
            this.groupBoxSelectFee.Text = "Odabir članarine";
            // 
            // comboBoxSelectFee
            // 
            this.comboBoxSelectFee.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxSelectFee.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxSelectFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBoxSelectFee.FormattingEnabled = true;
            this.comboBoxSelectFee.Items.AddRange(new object[] {
            "Odaberite članarinu"});
            this.comboBoxSelectFee.Location = new System.Drawing.Point(6, 25);
            this.comboBoxSelectFee.Name = "comboBoxSelectFee";
            this.comboBoxSelectFee.Size = new System.Drawing.Size(306, 28);
            this.comboBoxSelectFee.TabIndex = 0;
            this.comboBoxSelectFee.Text = "Odaberite članarinu";
            this.comboBoxSelectFee.SelectedValueChanged += new System.EventHandler(this.comboBoxSelectFee_SelectedValueChanged);
            // 
            // groupBoxFee
            // 
            this.groupBoxFee.Controls.Add(this.textBoxMemberGroup);
            this.groupBoxFee.Controls.Add(this.textBoxAmount);
            this.groupBoxFee.Controls.Add(this.labelAmount);
            this.groupBoxFee.Controls.Add(this.checkBoxDiscount);
            this.groupBoxFee.Controls.Add(this.labelMemberGroup);
            this.groupBoxFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            this.groupBoxFee.Location = new System.Drawing.Point(13, 98);
            this.groupBoxFee.Name = "groupBoxFee";
            this.groupBoxFee.Size = new System.Drawing.Size(327, 127);
            this.groupBoxFee.TabIndex = 1;
            this.groupBoxFee.TabStop = false;
            this.groupBoxFee.Text = "Podaci o članarini";
            // 
            // textBoxMemberGroup
            // 
            this.textBoxMemberGroup.Enabled = false;
            this.textBoxMemberGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxMemberGroup.Location = new System.Drawing.Point(120, 25);
            this.textBoxMemberGroup.Name = "textBoxMemberGroup";
            this.textBoxMemberGroup.Size = new System.Drawing.Size(192, 26);
            this.textBoxMemberGroup.TabIndex = 10;
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxAmount.Location = new System.Drawing.Point(120, 89);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(192, 26);
            this.textBoxAmount.TabIndex = 9;
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelAmount.Location = new System.Drawing.Point(66, 92);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(48, 20);
            this.labelAmount.TabIndex = 8;
            this.labelAmount.Text = "Iznos";
            // 
            // checkBoxDiscount
            // 
            this.checkBoxDiscount.AutoSize = true;
            this.checkBoxDiscount.Enabled = false;
            this.checkBoxDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.checkBoxDiscount.Location = new System.Drawing.Point(10, 59);
            this.checkBoxDiscount.Name = "checkBoxDiscount";
            this.checkBoxDiscount.Size = new System.Drawing.Size(191, 24);
            this.checkBoxDiscount.TabIndex = 7;
            this.checkBoxDiscount.Text = "Članarina sa popustom";
            this.checkBoxDiscount.UseVisualStyleBackColor = true;
            // 
            // labelMemberGroup
            // 
            this.labelMemberGroup.AutoSize = true;
            this.labelMemberGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelMemberGroup.Location = new System.Drawing.Point(6, 28);
            this.labelMemberGroup.Name = "labelMemberGroup";
            this.labelMemberGroup.Size = new System.Drawing.Size(112, 20);
            this.labelMemberGroup.TabIndex = 5;
            this.labelMemberGroup.Text = "Grupa članova";
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.buttonSave.Location = new System.Drawing.Point(133, 232);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(206, 38);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Sačuvaj izmene";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // EditMembershipFeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 282);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.groupBoxFee);
            this.Controls.Add(this.groupBoxSelectFee);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EditMembershipFeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Izmena članarine";
            this.Load += new System.EventHandler(this.EditMembershipFeeForm_Load);
            this.groupBoxSelectFee.ResumeLayout(false);
            this.groupBoxFee.ResumeLayout(false);
            this.groupBoxFee.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxSelectFee;
        private System.Windows.Forms.ComboBox comboBoxSelectFee;
        private System.Windows.Forms.GroupBox groupBoxFee;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.CheckBox checkBoxDiscount;
        private System.Windows.Forms.Label labelMemberGroup;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxMemberGroup;
    }
}