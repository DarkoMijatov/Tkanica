namespace Tkanica
{
    partial class ViewClothingsForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxReserved = new System.Windows.Forms.CheckBox();
            this.comboBoxAge = new System.Windows.Forms.ComboBox();
            this.labelAge = new System.Windows.Forms.Label();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.labelGender = new System.Windows.Forms.Label();
            this.textBoxRegion = new System.Windows.Forms.TextBox();
            this.labelRegion = new System.Windows.Forms.Label();
            this.comboBoxKind = new System.Windows.Forms.ComboBox();
            this.labelKind = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.dataGridViewClothings = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClothings)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxReserved);
            this.groupBox1.Controls.Add(this.comboBoxAge);
            this.groupBox1.Controls.Add(this.labelAge);
            this.groupBox1.Controls.Add(this.comboBoxGender);
            this.groupBox1.Controls.Add(this.labelGender);
            this.groupBox1.Controls.Add(this.textBoxRegion);
            this.groupBox1.Controls.Add(this.labelRegion);
            this.groupBox1.Controls.Add(this.comboBoxKind);
            this.groupBox1.Controls.Add(this.labelKind);
            this.groupBox1.Controls.Add(this.textBoxId);
            this.groupBox1.Controls.Add(this.labelId);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(617, 138);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parametri za pretragu";
            // 
            // checkBoxReserved
            // 
            this.checkBoxReserved.AutoSize = true;
            this.checkBoxReserved.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.checkBoxReserved.Location = new System.Drawing.Point(402, 100);
            this.checkBoxReserved.Name = "checkBoxReserved";
            this.checkBoxReserved.Size = new System.Drawing.Size(135, 24);
            this.checkBoxReserved.TabIndex = 10;
            this.checkBoxReserved.Text = "Bez rezervacije";
            this.checkBoxReserved.UseVisualStyleBackColor = true;
            this.checkBoxReserved.CheckedChanged += new System.EventHandler(this.checkBoxReserved_CheckedChanged);
            // 
            // comboBoxAge
            // 
            this.comboBoxAge.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxAge.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBoxAge.FormattingEnabled = true;
            this.comboBoxAge.Items.AddRange(new object[] {
            "Izaberite uzrast",
            "odrasli",
            "deca"});
            this.comboBoxAge.Location = new System.Drawing.Point(68, 95);
            this.comboBoxAge.Name = "comboBoxAge";
            this.comboBoxAge.Size = new System.Drawing.Size(192, 28);
            this.comboBoxAge.TabIndex = 9;
            this.comboBoxAge.Text = "Izaberite uzrast";
            this.comboBoxAge.SelectedValueChanged += new System.EventHandler(this.comboBoxAge_SelectedValueChanged);
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelAge.Location = new System.Drawing.Point(6, 98);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(56, 20);
            this.labelAge.TabIndex = 8;
            this.labelAge.Text = "Uzrast";
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxGender.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Items.AddRange(new object[] {
            "Izaberite pol",
            "muški",
            "ženski"});
            this.comboBoxGender.Location = new System.Drawing.Point(351, 64);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(186, 28);
            this.comboBoxGender.TabIndex = 7;
            this.comboBoxGender.Text = "Izaberite pol";
            this.comboBoxGender.SelectedValueChanged += new System.EventHandler(this.comboBoxGender_SelectedValueChanged);
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelGender.Location = new System.Drawing.Point(314, 67);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(31, 20);
            this.labelGender.TabIndex = 6;
            this.labelGender.Text = "Pol";
            // 
            // textBoxRegion
            // 
            this.textBoxRegion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxRegion.Location = new System.Drawing.Point(68, 63);
            this.textBoxRegion.Name = "textBoxRegion";
            this.textBoxRegion.Size = new System.Drawing.Size(192, 26);
            this.textBoxRegion.TabIndex = 5;
            this.textBoxRegion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxRegion_KeyPress);
            // 
            // labelRegion
            // 
            this.labelRegion.AutoSize = true;
            this.labelRegion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelRegion.Location = new System.Drawing.Point(7, 66);
            this.labelRegion.Name = "labelRegion";
            this.labelRegion.Size = new System.Drawing.Size(55, 20);
            this.labelRegion.TabIndex = 4;
            this.labelRegion.Text = "Oblast";
            // 
            // comboBoxKind
            // 
            this.comboBoxKind.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxKind.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxKind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBoxKind.FormattingEnabled = true;
            this.comboBoxKind.Items.AddRange(new object[] {
            "Izaberite vrstu"});
            this.comboBoxKind.Location = new System.Drawing.Point(367, 31);
            this.comboBoxKind.Name = "comboBoxKind";
            this.comboBoxKind.Size = new System.Drawing.Size(170, 28);
            this.comboBoxKind.TabIndex = 3;
            this.comboBoxKind.Text = "Izaberite vrstu";
            this.comboBoxKind.SelectedValueChanged += new System.EventHandler(this.comboBoxKind_SelectedValueChanged);
            // 
            // labelKind
            // 
            this.labelKind.AutoSize = true;
            this.labelKind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelKind.Location = new System.Drawing.Point(314, 34);
            this.labelKind.Name = "labelKind";
            this.labelKind.Size = new System.Drawing.Size(47, 20);
            this.labelKind.TabIndex = 2;
            this.labelKind.Text = "Vrsta";
            // 
            // textBoxId
            // 
            this.textBoxId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxId.Location = new System.Drawing.Point(68, 31);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(100, 26);
            this.textBoxId.TabIndex = 1;
            this.textBoxId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxId_KeyPress);
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelId.Location = new System.Drawing.Point(20, 34);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(42, 20);
            this.labelId.TabIndex = 0;
            this.labelId.Text = "Šifra";
            // 
            // dataGridViewClothings
            // 
            this.dataGridViewClothings.AllowUserToAddRows = false;
            this.dataGridViewClothings.AllowUserToDeleteRows = false;
            this.dataGridViewClothings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewClothings.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewClothings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClothings.Location = new System.Drawing.Point(13, 158);
            this.dataGridViewClothings.Name = "dataGridViewClothings";
            this.dataGridViewClothings.ReadOnly = true;
            this.dataGridViewClothings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewClothings.Size = new System.Drawing.Size(617, 294);
            this.dataGridViewClothings.TabIndex = 1;
            // 
            // ViewClothingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 464);
            this.Controls.Add(this.dataGridViewClothings);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ViewClothingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pregled podataka o nošnji";
            this.Load += new System.EventHandler(this.ViewClothingsForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClothings)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.CheckBox checkBoxReserved;
        private System.Windows.Forms.ComboBox comboBoxAge;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.TextBox textBoxRegion;
        private System.Windows.Forms.Label labelRegion;
        private System.Windows.Forms.ComboBox comboBoxKind;
        private System.Windows.Forms.Label labelKind;
        private System.Windows.Forms.DataGridView dataGridViewClothings;
    }
}