namespace Tkanica
{
    partial class ViewMembershipFeesForm
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
            this.buttonDelete = new System.Windows.Forms.Button();
            this.dataGridViewMembershipFees = new System.Windows.Forms.DataGridView();
            this.labelMembershipFees = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMembershipFees)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.buttonDelete.Location = new System.Drawing.Point(280, 10);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(145, 30);
            this.buttonDelete.TabIndex = 0;
            this.buttonDelete.Text = "Obriši";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // dataGridViewMembershipFees
            // 
            this.dataGridViewMembershipFees.AllowUserToAddRows = false;
            this.dataGridViewMembershipFees.AllowUserToDeleteRows = false;
            this.dataGridViewMembershipFees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewMembershipFees.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewMembershipFees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMembershipFees.Location = new System.Drawing.Point(12, 48);
            this.dataGridViewMembershipFees.Name = "dataGridViewMembershipFees";
            this.dataGridViewMembershipFees.ReadOnly = true;
            this.dataGridViewMembershipFees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMembershipFees.Size = new System.Drawing.Size(413, 209);
            this.dataGridViewMembershipFees.TabIndex = 1;
            this.dataGridViewMembershipFees.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewMembershipFees_MouseDoubleClick);
            // 
            // labelMembershipFees
            // 
            this.labelMembershipFees.AutoSize = true;
            this.labelMembershipFees.Location = new System.Drawing.Point(12, 15);
            this.labelMembershipFees.Name = "labelMembershipFees";
            this.labelMembershipFees.Size = new System.Drawing.Size(76, 20);
            this.labelMembershipFees.TabIndex = 2;
            this.labelMembershipFees.Text = "Članarine";
            // 
            // ViewMembershipFeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 269);
            this.Controls.Add(this.labelMembershipFees);
            this.Controls.Add(this.dataGridViewMembershipFees);
            this.Controls.Add(this.buttonDelete);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ViewMembershipFeesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pregled članarina";
            this.Load += new System.EventHandler(this.ViewMembershipFees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMembershipFees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.DataGridView dataGridViewMembershipFees;
        private System.Windows.Forms.Label labelMembershipFees;
    }
}