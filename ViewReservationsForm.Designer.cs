namespace Tkanica
{
    partial class ViewReservationsForm
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
            this.checkBoxActive = new System.Windows.Forms.CheckBox();
            this.comboBoxMember = new System.Windows.Forms.ComboBox();
            this.labelMember = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.dataGridViewReservations = new System.Windows.Forms.DataGridView();
            this.groupBoxSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReservations)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Controls.Add(this.checkBoxActive);
            this.groupBoxSearch.Controls.Add(this.comboBoxMember);
            this.groupBoxSearch.Controls.Add(this.labelMember);
            this.groupBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            this.groupBoxSearch.Location = new System.Drawing.Point(13, 13);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Size = new System.Drawing.Size(446, 82);
            this.groupBoxSearch.TabIndex = 0;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Pretraga";
            // 
            // checkBoxActive
            // 
            this.checkBoxActive.AutoSize = true;
            this.checkBoxActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.checkBoxActive.Location = new System.Drawing.Point(279, 34);
            this.checkBoxActive.Name = "checkBoxActive";
            this.checkBoxActive.Size = new System.Drawing.Size(159, 24);
            this.checkBoxActive.TabIndex = 2;
            this.checkBoxActive.Text = "Aktivne rezervacije";
            this.checkBoxActive.UseVisualStyleBackColor = true;
            this.checkBoxActive.CheckedChanged += new System.EventHandler(this.checkBoxActive_CheckedChanged);
            // 
            // comboBoxMember
            // 
            this.comboBoxMember.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxMember.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBoxMember.FormattingEnabled = true;
            this.comboBoxMember.Items.AddRange(new object[] {
            "Izaberite člana"});
            this.comboBoxMember.Location = new System.Drawing.Point(53, 30);
            this.comboBoxMember.Name = "comboBoxMember";
            this.comboBoxMember.Size = new System.Drawing.Size(220, 28);
            this.comboBoxMember.TabIndex = 1;
            this.comboBoxMember.Text = "Izaberite člana";
            this.comboBoxMember.SelectedValueChanged += new System.EventHandler(this.comboBoxMember_SelectedValueChanged);
            // 
            // labelMember
            // 
            this.labelMember.AutoSize = true;
            this.labelMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelMember.Location = new System.Drawing.Point(6, 35);
            this.labelMember.Name = "labelMember";
            this.labelMember.Size = new System.Drawing.Size(41, 20);
            this.labelMember.TabIndex = 0;
            this.labelMember.Text = "Član";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.buttonDelete.Location = new System.Drawing.Point(465, 40);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(183, 37);
            this.buttonDelete.TabIndex = 1;
            this.buttonDelete.Text = "Obriši";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // dataGridViewReservations
            // 
            this.dataGridViewReservations.AllowUserToAddRows = false;
            this.dataGridViewReservations.AllowUserToDeleteRows = false;
            this.dataGridViewReservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReservations.Location = new System.Drawing.Point(13, 101);
            this.dataGridViewReservations.Name = "dataGridViewReservations";
            this.dataGridViewReservations.ReadOnly = true;
            this.dataGridViewReservations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewReservations.Size = new System.Drawing.Size(635, 251);
            this.dataGridViewReservations.TabIndex = 2;
            this.dataGridViewReservations.Sorted += new System.EventHandler(this.dataGridViewReservations_Sorted);
            // 
            // ViewReservationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 364);
            this.Controls.Add(this.dataGridViewReservations);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.groupBoxSearch);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ViewReservationsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pregled rezervacija";
            this.Load += new System.EventHandler(this.ViewReservationsForm_Load);
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReservations)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.CheckBox checkBoxActive;
        private System.Windows.Forms.ComboBox comboBoxMember;
        private System.Windows.Forms.Label labelMember;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.DataGridView dataGridViewReservations;
    }
}