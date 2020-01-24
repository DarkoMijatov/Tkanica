namespace Tkanica
{
    partial class NewMemberGroupForm
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
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelMemberGroupName = new System.Windows.Forms.Label();
            this.textBoxMemberGroupName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.buttonSave.Location = new System.Drawing.Point(228, 54);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(193, 34);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.Text = "Dodaj novu grupu";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelMemberGroupName
            // 
            this.labelMemberGroupName.AutoSize = true;
            this.labelMemberGroupName.Location = new System.Drawing.Point(25, 25);
            this.labelMemberGroupName.Name = "labelMemberGroupName";
            this.labelMemberGroupName.Size = new System.Drawing.Size(150, 20);
            this.labelMemberGroupName.TabIndex = 1;
            this.labelMemberGroupName.Text = "Naziv grupe članova";
            // 
            // textBoxMemberGroupName
            // 
            this.textBoxMemberGroupName.Location = new System.Drawing.Point(181, 22);
            this.textBoxMemberGroupName.Name = "textBoxMemberGroupName";
            this.textBoxMemberGroupName.Size = new System.Drawing.Size(240, 26);
            this.textBoxMemberGroupName.TabIndex = 2;
            this.textBoxMemberGroupName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMemberGroupName_KeyPress);
            // 
            // NewMemberGroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 114);
            this.Controls.Add(this.textBoxMemberGroupName);
            this.Controls.Add(this.labelMemberGroupName);
            this.Controls.Add(this.buttonSave);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "NewMemberGroupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nova grupa članova";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelMemberGroupName;
        private System.Windows.Forms.TextBox textBoxMemberGroupName;
    }
}