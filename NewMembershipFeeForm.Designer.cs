namespace Tkanica
{
    partial class NewMembershipFeeForm
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
            this.labelMemberGroup = new System.Windows.Forms.Label();
            this.comboBoxMemberGroup = new System.Windows.Forms.ComboBox();
            this.checkBoxDiscount = new System.Windows.Forms.CheckBox();
            this.labelAmount = new System.Windows.Forms.Label();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelMemberGroup
            // 
            this.labelMemberGroup.AutoSize = true;
            this.labelMemberGroup.Location = new System.Drawing.Point(13, 18);
            this.labelMemberGroup.Name = "labelMemberGroup";
            this.labelMemberGroup.Size = new System.Drawing.Size(112, 20);
            this.labelMemberGroup.TabIndex = 0;
            this.labelMemberGroup.Text = "Grupa članova";
            // 
            // comboBoxMemberGroup
            // 
            this.comboBoxMemberGroup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxMemberGroup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxMemberGroup.Items.AddRange(new object[] {
            "Izaberite grupu"});
            this.comboBoxMemberGroup.Location = new System.Drawing.Point(131, 15);
            this.comboBoxMemberGroup.Name = "comboBoxMemberGroup";
            this.comboBoxMemberGroup.Size = new System.Drawing.Size(192, 28);
            this.comboBoxMemberGroup.TabIndex = 1;
            this.comboBoxMemberGroup.Text = "Izaberite grupu";
            this.comboBoxMemberGroup.Leave += new System.EventHandler(this.comboBoxMemberGroup_Leave);
            // 
            // checkBoxDiscount
            // 
            this.checkBoxDiscount.AutoSize = true;
            this.checkBoxDiscount.Location = new System.Drawing.Point(17, 49);
            this.checkBoxDiscount.Name = "checkBoxDiscount";
            this.checkBoxDiscount.Size = new System.Drawing.Size(191, 24);
            this.checkBoxDiscount.TabIndex = 2;
            this.checkBoxDiscount.Text = "Članarina sa popustom";
            this.checkBoxDiscount.UseVisualStyleBackColor = true;
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Location = new System.Drawing.Point(77, 82);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(48, 20);
            this.labelAmount.TabIndex = 3;
            this.labelAmount.Text = "Iznos";
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(131, 79);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(192, 26);
            this.textBoxAmount.TabIndex = 4;
            this.textBoxAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAmount_KeyPress);
            this.textBoxAmount.Leave += new System.EventHandler(this.textBoxAmount_Leave);
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.buttonSave.Location = new System.Drawing.Point(196, 122);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(127, 35);
            this.buttonSave.TabIndex = 5;
            this.buttonSave.Text = "Sačuvaj";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // NewMembershipFeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 188);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxAmount);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.checkBoxDiscount);
            this.Controls.Add(this.comboBoxMemberGroup);
            this.Controls.Add(this.labelMemberGroup);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "NewMembershipFeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nova članarina";
            this.Load += new System.EventHandler(this.NewMembershipFeeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMemberGroup;
        private System.Windows.Forms.ComboBox comboBoxMemberGroup;
        private System.Windows.Forms.CheckBox checkBoxDiscount;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.Button buttonSave;
    }
}