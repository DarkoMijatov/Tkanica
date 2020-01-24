namespace Tkanica
{
    partial class ViewMembersForm
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
            this.checkBoxInactive = new System.Windows.Forms.CheckBox();
            this.labelMemberGroup = new System.Windows.Forms.Label();
            this.checkBoxActive = new System.Windows.Forms.CheckBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.comboBoxMemberGroup = new System.Windows.Forms.ComboBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.labelSearch = new System.Windows.Forms.Label();
            this.dataGridViewMembers = new System.Windows.Forms.DataGridView();
            this.groupBoxSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMembers)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Controls.Add(this.checkBoxInactive);
            this.groupBoxSearch.Controls.Add(this.labelMemberGroup);
            this.groupBoxSearch.Controls.Add(this.checkBoxActive);
            this.groupBoxSearch.Controls.Add(this.textBoxSearch);
            this.groupBoxSearch.Controls.Add(this.comboBoxMemberGroup);
            this.groupBoxSearch.Controls.Add(this.buttonSearch);
            this.groupBoxSearch.Controls.Add(this.labelSearch);
            this.groupBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            this.groupBoxSearch.Location = new System.Drawing.Point(12, 12);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Size = new System.Drawing.Size(433, 138);
            this.groupBoxSearch.TabIndex = 0;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Parametri za pretragu";
            // 
            // checkBoxInactive
            // 
            this.checkBoxInactive.AutoSize = true;
            this.checkBoxInactive.Checked = true;
            this.checkBoxInactive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxInactive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.checkBoxInactive.Location = new System.Drawing.Point(142, 94);
            this.checkBoxInactive.Name = "checkBoxInactive";
            this.checkBoxInactive.Size = new System.Drawing.Size(144, 24);
            this.checkBoxInactive.TabIndex = 6;
            this.checkBoxInactive.Text = "Neaktivni članovi";
            this.checkBoxInactive.UseVisualStyleBackColor = true;
            this.checkBoxInactive.CheckedChanged += new System.EventHandler(this.checkBoxInactive_CheckedChanged);
            // 
            // labelMemberGroup
            // 
            this.labelMemberGroup.AutoSize = true;
            this.labelMemberGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelMemberGroup.Location = new System.Drawing.Point(6, 55);
            this.labelMemberGroup.Name = "labelMemberGroup";
            this.labelMemberGroup.Size = new System.Drawing.Size(189, 20);
            this.labelMemberGroup.TabIndex = 5;
            this.labelMemberGroup.Text = "Pretraga po grupi članova";
            // 
            // checkBoxActive
            // 
            this.checkBoxActive.AutoSize = true;
            this.checkBoxActive.Checked = true;
            this.checkBoxActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.checkBoxActive.Location = new System.Drawing.Point(10, 94);
            this.checkBoxActive.Name = "checkBoxActive";
            this.checkBoxActive.Size = new System.Drawing.Size(126, 24);
            this.checkBoxActive.TabIndex = 4;
            this.checkBoxActive.Text = "Aktivni članovi";
            this.checkBoxActive.UseVisualStyleBackColor = true;
            this.checkBoxActive.CheckedChanged += new System.EventHandler(this.checkBoxActive_CheckedChanged);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxSearch.Location = new System.Drawing.Point(202, 20);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(207, 26);
            this.textBoxSearch.TabIndex = 3;
            this.textBoxSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSearch_KeyPress);
            // 
            // comboBoxMemberGroup
            // 
            this.comboBoxMemberGroup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxMemberGroup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxMemberGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBoxMemberGroup.FormattingEnabled = true;
            this.comboBoxMemberGroup.Items.AddRange(new object[] {
            "Izaberite grupu"});
            this.comboBoxMemberGroup.Location = new System.Drawing.Point(202, 52);
            this.comboBoxMemberGroup.Name = "comboBoxMemberGroup";
            this.comboBoxMemberGroup.Size = new System.Drawing.Size(207, 28);
            this.comboBoxMemberGroup.TabIndex = 2;
            this.comboBoxMemberGroup.Text = "Izaberite grupu";
            this.comboBoxMemberGroup.SelectedValueChanged += new System.EventHandler(this.comboBoxMemberGroup_SelectedValueChanged);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.buttonSearch.Location = new System.Drawing.Point(292, 90);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(117, 31);
            this.buttonSearch.TabIndex = 1;
            this.buttonSearch.Text = "Pretraži";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelSearch.Location = new System.Drawing.Point(58, 23);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(139, 20);
            this.labelSearch.TabIndex = 0;
            this.labelSearch.Text = "Pretraga po imenu";
            // 
            // dataGridViewMembers
            // 
            this.dataGridViewMembers.AllowUserToAddRows = false;
            this.dataGridViewMembers.AllowUserToDeleteRows = false;
            this.dataGridViewMembers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMembers.Location = new System.Drawing.Point(13, 157);
            this.dataGridViewMembers.Name = "dataGridViewMembers";
            this.dataGridViewMembers.ReadOnly = true;
            this.dataGridViewMembers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMembers.Size = new System.Drawing.Size(829, 311);
            this.dataGridViewMembers.TabIndex = 1;
            this.dataGridViewMembers.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewMembers_MouseDoubleClick);
            // 
            // ViewMembersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(854, 477);
            this.Controls.Add(this.dataGridViewMembers);
            this.Controls.Add(this.groupBoxSearch);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ViewMembersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pregled podataka o članovima";
            this.Load += new System.EventHandler(this.ViewMembersForm_Load);
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMembers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.CheckBox checkBoxInactive;
        private System.Windows.Forms.Label labelMemberGroup;
        private System.Windows.Forms.CheckBox checkBoxActive;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.ComboBox comboBoxMemberGroup;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.DataGridView dataGridViewMembers;
    }
}