namespace Tkanica
{
    partial class NewReservationForm
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
            this.labelMember = new System.Windows.Forms.Label();
            this.comboBoxMember = new System.Windows.Forms.ComboBox();
            this.labelClothingsSearch = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.listBoxAvailable = new System.Windows.Forms.ListBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.listBoxSelected = new System.Windows.Forms.ListBox();
            this.buttonAddAll = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonRemoveAll = new System.Windows.Forms.Button();
            this.buttonReserve = new System.Windows.Forms.Button();
            this.labelAvailable = new System.Windows.Forms.Label();
            this.labelSelected = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelMember
            // 
            this.labelMember.AutoSize = true;
            this.labelMember.Location = new System.Drawing.Point(93, 15);
            this.labelMember.Name = "labelMember";
            this.labelMember.Size = new System.Drawing.Size(41, 20);
            this.labelMember.TabIndex = 0;
            this.labelMember.Text = "Član";
            // 
            // comboBoxMember
            // 
            this.comboBoxMember.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxMember.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxMember.FormattingEnabled = true;
            this.comboBoxMember.Items.AddRange(new object[] {
            "Izaberite člana"});
            this.comboBoxMember.Location = new System.Drawing.Point(140, 12);
            this.comboBoxMember.Name = "comboBoxMember";
            this.comboBoxMember.Size = new System.Drawing.Size(199, 28);
            this.comboBoxMember.TabIndex = 1;
            this.comboBoxMember.Text = "Izaberite člana";
            // 
            // labelClothingsSearch
            // 
            this.labelClothingsSearch.AutoSize = true;
            this.labelClothingsSearch.Location = new System.Drawing.Point(13, 49);
            this.labelClothingsSearch.Name = "labelClothingsSearch";
            this.labelClothingsSearch.Size = new System.Drawing.Size(121, 20);
            this.labelClothingsSearch.TabIndex = 2;
            this.labelClothingsSearch.Text = "Pretraga nošnje";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(140, 46);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(199, 26);
            this.textBoxSearch.TabIndex = 3;
            this.textBoxSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSearch_KeyPress);
            // 
            // listBoxAvailable
            // 
            this.listBoxAvailable.FormattingEnabled = true;
            this.listBoxAvailable.ItemHeight = 20;
            this.listBoxAvailable.Location = new System.Drawing.Point(17, 109);
            this.listBoxAvailable.Name = "listBoxAvailable";
            this.listBoxAvailable.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxAvailable.Size = new System.Drawing.Size(241, 244);
            this.listBoxAvailable.TabIndex = 4;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(264, 159);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 32);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = ">";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // listBoxSelected
            // 
            this.listBoxSelected.FormattingEnabled = true;
            this.listBoxSelected.ItemHeight = 20;
            this.listBoxSelected.Location = new System.Drawing.Point(345, 109);
            this.listBoxSelected.Name = "listBoxSelected";
            this.listBoxSelected.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxSelected.Size = new System.Drawing.Size(241, 244);
            this.listBoxSelected.TabIndex = 9;
            // 
            // buttonAddAll
            // 
            this.buttonAddAll.Location = new System.Drawing.Point(264, 197);
            this.buttonAddAll.Name = "buttonAddAll";
            this.buttonAddAll.Size = new System.Drawing.Size(75, 32);
            this.buttonAddAll.TabIndex = 10;
            this.buttonAddAll.Text = ">>";
            this.buttonAddAll.UseVisualStyleBackColor = true;
            this.buttonAddAll.Click += new System.EventHandler(this.buttonAddAll_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(264, 235);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(75, 32);
            this.buttonRemove.TabIndex = 11;
            this.buttonRemove.Text = "<";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonRemoveAll
            // 
            this.buttonRemoveAll.Location = new System.Drawing.Point(264, 273);
            this.buttonRemoveAll.Name = "buttonRemoveAll";
            this.buttonRemoveAll.Size = new System.Drawing.Size(75, 32);
            this.buttonRemoveAll.TabIndex = 12;
            this.buttonRemoveAll.Text = "<<";
            this.buttonRemoveAll.UseVisualStyleBackColor = true;
            this.buttonRemoveAll.Click += new System.EventHandler(this.buttonRemoveAll_Click);
            // 
            // buttonReserve
            // 
            this.buttonReserve.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.buttonReserve.Location = new System.Drawing.Point(445, 37);
            this.buttonReserve.Name = "buttonReserve";
            this.buttonReserve.Size = new System.Drawing.Size(141, 32);
            this.buttonReserve.TabIndex = 13;
            this.buttonReserve.Text = "Rezervišite";
            this.buttonReserve.UseVisualStyleBackColor = true;
            this.buttonReserve.Click += new System.EventHandler(this.buttonReserve_Click);
            // 
            // labelAvailable
            // 
            this.labelAvailable.AutoSize = true;
            this.labelAvailable.Location = new System.Drawing.Point(68, 86);
            this.labelAvailable.Name = "labelAvailable";
            this.labelAvailable.Size = new System.Drawing.Size(130, 20);
            this.labelAvailable.TabIndex = 14;
            this.labelAvailable.Text = "Dostupna nošnja";
            // 
            // labelSelected
            // 
            this.labelSelected.AutoSize = true;
            this.labelSelected.Location = new System.Drawing.Point(396, 86);
            this.labelSelected.Name = "labelSelected";
            this.labelSelected.Size = new System.Drawing.Size(131, 20);
            this.labelSelected.TabIndex = 15;
            this.labelSelected.Text = "Odabrana nošnja";
            // 
            // NewReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 363);
            this.Controls.Add(this.labelSelected);
            this.Controls.Add(this.labelAvailable);
            this.Controls.Add(this.buttonReserve);
            this.Controls.Add(this.buttonRemoveAll);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonAddAll);
            this.Controls.Add(this.listBoxSelected);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listBoxAvailable);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.labelClothingsSearch);
            this.Controls.Add(this.comboBoxMember);
            this.Controls.Add(this.labelMember);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "NewReservationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nova rezervacija nošnje";
            this.Load += new System.EventHandler(this.NewReservationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMember;
        private System.Windows.Forms.ComboBox comboBoxMember;
        private System.Windows.Forms.Label labelClothingsSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.ListBox listBoxAvailable;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ListBox listBoxSelected;
        private System.Windows.Forms.Button buttonAddAll;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonRemoveAll;
        private System.Windows.Forms.Button buttonReserve;
        private System.Windows.Forms.Label labelAvailable;
        private System.Windows.Forms.Label labelSelected;
    }
}