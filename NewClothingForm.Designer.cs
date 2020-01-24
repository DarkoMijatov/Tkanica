namespace Tkanica
{
    partial class NewClothingForm
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
            this.groupBoxClothing = new System.Windows.Forms.GroupBox();
            this.textBoxSize = new System.Windows.Forms.TextBox();
            this.labelSize = new System.Windows.Forms.Label();
            this.comboBoxAge = new System.Windows.Forms.ComboBox();
            this.labelAge = new System.Windows.Forms.Label();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.labelGender = new System.Windows.Forms.Label();
            this.textBoxRegion = new System.Windows.Forms.TextBox();
            this.labelRegion = new System.Windows.Forms.Label();
            this.comboBoxKind = new System.Windows.Forms.ComboBox();
            this.labelKind = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.groupBoxClothing.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxClothing
            // 
            this.groupBoxClothing.Controls.Add(this.textBoxSize);
            this.groupBoxClothing.Controls.Add(this.labelSize);
            this.groupBoxClothing.Controls.Add(this.comboBoxAge);
            this.groupBoxClothing.Controls.Add(this.labelAge);
            this.groupBoxClothing.Controls.Add(this.comboBoxGender);
            this.groupBoxClothing.Controls.Add(this.labelGender);
            this.groupBoxClothing.Controls.Add(this.textBoxRegion);
            this.groupBoxClothing.Controls.Add(this.labelRegion);
            this.groupBoxClothing.Controls.Add(this.comboBoxKind);
            this.groupBoxClothing.Controls.Add(this.labelKind);
            this.groupBoxClothing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            this.groupBoxClothing.Location = new System.Drawing.Point(13, 13);
            this.groupBoxClothing.Name = "groupBoxClothing";
            this.groupBoxClothing.Size = new System.Drawing.Size(334, 214);
            this.groupBoxClothing.TabIndex = 0;
            this.groupBoxClothing.TabStop = false;
            this.groupBoxClothing.Text = "Podaci o nošnji";
            // 
            // textBoxSize
            // 
            this.textBoxSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxSize.Location = new System.Drawing.Point(110, 173);
            this.textBoxSize.Name = "textBoxSize";
            this.textBoxSize.Size = new System.Drawing.Size(204, 26);
            this.textBoxSize.TabIndex = 9;
            this.textBoxSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSize_KeyPress);
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelSize.Location = new System.Drawing.Point(40, 176);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(64, 20);
            this.labelSize.TabIndex = 8;
            this.labelSize.Text = "Veličina";
            // 
            // comboBoxAge
            // 
            this.comboBoxAge.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxAge.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBoxAge.FormattingEnabled = true;
            this.comboBoxAge.Items.AddRange(new object[] {
            "odrasli",
            "deca"});
            this.comboBoxAge.Location = new System.Drawing.Point(110, 139);
            this.comboBoxAge.Name = "comboBoxAge";
            this.comboBoxAge.Size = new System.Drawing.Size(204, 28);
            this.comboBoxAge.TabIndex = 7;
            this.comboBoxAge.Text = "Izaberite uzrast";
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelAge.Location = new System.Drawing.Point(48, 142);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(56, 20);
            this.labelAge.TabIndex = 6;
            this.labelAge.Text = "Uzrast";
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxGender.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Items.AddRange(new object[] {
            "muški",
            "ženski"});
            this.comboBoxGender.Location = new System.Drawing.Point(110, 105);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(204, 28);
            this.comboBoxGender.TabIndex = 5;
            this.comboBoxGender.Text = "Izaberite pol";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelGender.Location = new System.Drawing.Point(73, 108);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(31, 20);
            this.labelGender.TabIndex = 4;
            this.labelGender.Text = "Pol";
            // 
            // textBoxRegion
            // 
            this.textBoxRegion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxRegion.Location = new System.Drawing.Point(110, 73);
            this.textBoxRegion.Name = "textBoxRegion";
            this.textBoxRegion.Size = new System.Drawing.Size(204, 26);
            this.textBoxRegion.TabIndex = 3;
            // 
            // labelRegion
            // 
            this.labelRegion.AutoSize = true;
            this.labelRegion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelRegion.Location = new System.Drawing.Point(49, 76);
            this.labelRegion.Name = "labelRegion";
            this.labelRegion.Size = new System.Drawing.Size(55, 20);
            this.labelRegion.TabIndex = 2;
            this.labelRegion.Text = "Oblast";
            // 
            // comboBoxKind
            // 
            this.comboBoxKind.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxKind.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxKind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBoxKind.FormattingEnabled = true;
            this.comboBoxKind.Location = new System.Drawing.Point(110, 39);
            this.comboBoxKind.Name = "comboBoxKind";
            this.comboBoxKind.Size = new System.Drawing.Size(204, 28);
            this.comboBoxKind.TabIndex = 1;
            this.comboBoxKind.Text = "Izaberite vrstu";
            // 
            // labelKind
            // 
            this.labelKind.AutoSize = true;
            this.labelKind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelKind.Location = new System.Drawing.Point(6, 42);
            this.labelKind.Name = "labelKind";
            this.labelKind.Size = new System.Drawing.Size(98, 20);
            this.labelKind.TabIndex = 0;
            this.labelKind.Text = "Vrsta nošnje";
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.buttonSave.Location = new System.Drawing.Point(175, 233);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(172, 35);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Sačuvaj";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // NewClothingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 288);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.groupBoxClothing);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "NewClothingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nova nošnja";
            this.Load += new System.EventHandler(this.NewClothingForm_Load);
            this.groupBoxClothing.ResumeLayout(false);
            this.groupBoxClothing.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxClothing;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxRegion;
        private System.Windows.Forms.Label labelRegion;
        private System.Windows.Forms.ComboBox comboBoxKind;
        private System.Windows.Forms.Label labelKind;
        private System.Windows.Forms.TextBox textBoxSize;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.ComboBox comboBoxAge;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.Label labelGender;
    }
}