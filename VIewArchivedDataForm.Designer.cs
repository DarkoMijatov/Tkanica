namespace Tkanica
{
    partial class ViewArchivedDataForm
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
            this.labelDateTo = new System.Windows.Forms.Label();
            this.dateTimePickerDateFrom = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDateTo = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).BeginInit();
            this.SuspendLayout();
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Location = new System.Drawing.Point(13, 8);
            this.labelData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(57, 20);
            this.labelData.TabIndex = 0;
            this.labelData.Text = "Podaci";
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
            this.comboBoxData.Location = new System.Drawing.Point(77, 5);
            this.comboBoxData.Name = "comboBoxData";
            this.comboBoxData.Size = new System.Drawing.Size(154, 28);
            this.comboBoxData.TabIndex = 1;
            this.comboBoxData.Text = "Izaberite podatke";
            this.comboBoxData.SelectedValueChanged += new System.EventHandler(this.comboBoxData_SelectedValueChanged);
            // 
            // labelDateFrom
            // 
            this.labelDateFrom.AutoSize = true;
            this.labelDateFrom.Location = new System.Drawing.Point(238, 8);
            this.labelDateFrom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDateFrom.Name = "labelDateFrom";
            this.labelDateFrom.Size = new System.Drawing.Size(79, 20);
            this.labelDateFrom.TabIndex = 2;
            this.labelDateFrom.Text = "Datum od";
            // 
            // labelDateTo
            // 
            this.labelDateTo.AutoSize = true;
            this.labelDateTo.Location = new System.Drawing.Point(485, 8);
            this.labelDateTo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDateTo.Name = "labelDateTo";
            this.labelDateTo.Size = new System.Drawing.Size(79, 20);
            this.labelDateTo.TabIndex = 3;
            this.labelDateTo.Text = "Datum do";
            // 
            // dateTimePickerDateFrom
            // 
            this.dateTimePickerDateFrom.CustomFormat = "dd.MM.yyyy.";
            this.dateTimePickerDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDateFrom.Location = new System.Drawing.Point(324, 3);
            this.dateTimePickerDateFrom.Name = "dateTimePickerDateFrom";
            this.dateTimePickerDateFrom.Size = new System.Drawing.Size(154, 26);
            this.dateTimePickerDateFrom.TabIndex = 4;
            this.dateTimePickerDateFrom.Value = new System.DateTime(2019, 11, 27, 0, 0, 0, 0);
            this.dateTimePickerDateFrom.ValueChanged += new System.EventHandler(this.dateTimePickerDateFrom_ValueChanged);
            // 
            // dateTimePickerDateTo
            // 
            this.dateTimePickerDateTo.CustomFormat = "dd.MM.yyyy.";
            this.dateTimePickerDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDateTo.Location = new System.Drawing.Point(571, 3);
            this.dateTimePickerDateTo.Name = "dateTimePickerDateTo";
            this.dateTimePickerDateTo.Size = new System.Drawing.Size(154, 26);
            this.dateTimePickerDateTo.TabIndex = 5;
            this.dateTimePickerDateTo.ValueChanged += new System.EventHandler(this.dateTimePickerDateTo_ValueChanged);
            // 
            // dataGridViewData
            // 
            this.dataGridViewData.AllowUserToAddRows = false;
            this.dataGridViewData.AllowUserToDeleteRows = false;
            this.dataGridViewData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewData.Location = new System.Drawing.Point(12, 39);
            this.dataGridViewData.Name = "dataGridViewData";
            this.dataGridViewData.ReadOnly = true;
            this.dataGridViewData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewData.Size = new System.Drawing.Size(713, 302);
            this.dataGridViewData.TabIndex = 6;
            // 
            // ViewArchivedDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 353);
            this.Controls.Add(this.dataGridViewData);
            this.Controls.Add(this.dateTimePickerDateTo);
            this.Controls.Add(this.dateTimePickerDateFrom);
            this.Controls.Add(this.labelDateTo);
            this.Controls.Add(this.labelDateFrom);
            this.Controls.Add(this.comboBoxData);
            this.Controls.Add(this.labelData);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ViewArchivedDataForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pregled arhiviranih podataka";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.ComboBox comboBoxData;
        private System.Windows.Forms.Label labelDateFrom;
        private System.Windows.Forms.Label labelDateTo;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateFrom;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateTo;
        private System.Windows.Forms.DataGridView dataGridViewData;
    }
}