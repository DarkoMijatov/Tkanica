namespace Tkanica
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStavke = new System.Windows.Forms.MenuStrip();
            this.membersMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newMemberMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeMemberMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledIgracaMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.memberGroupsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newMemberGroupMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMemberGroupsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.membershipFeesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newMembershipFeeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeMembershipFeeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMembershipFeesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clothingMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newClothingMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewClothingMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservationsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newReservationMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteReservationMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incomingTransactionsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outgoingTransactionsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewTransactionsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.balanceMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.archiveDataMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewArchivedDataMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewActivityMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeUserMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewUsersMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.timerCurrentTime = new System.Windows.Forms.Timer(this.components);
            this.menuStavke.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStavke
            // 
            this.menuStavke.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuStavke.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.membersMenuItem,
            this.clothingMenuItem,
            this.transactionsMenuItem,
            this.formsMenuItem,
            this.adminMenuItem,
            this.usersMenuItem});
            this.menuStavke.Location = new System.Drawing.Point(0, 0);
            this.menuStavke.Name = "menuStavke";
            this.menuStavke.Size = new System.Drawing.Size(529, 29);
            this.menuStavke.TabIndex = 1;
            this.menuStavke.Text = "Stavke";
            // 
            // membersMenuItem
            // 
            this.membersMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newMemberMenuItem,
            this.changeMemberMenuItem,
            this.pregledIgracaMenuItem,
            this.memberGroupsMenuItem,
            this.membershipFeesMenuItem});
            this.membersMenuItem.Name = "membersMenuItem";
            this.membersMenuItem.Size = new System.Drawing.Size(74, 25);
            this.membersMenuItem.Text = "Članovi";
            // 
            // newMemberMenuItem
            // 
            this.newMemberMenuItem.Name = "newMemberMenuItem";
            this.newMemberMenuItem.Size = new System.Drawing.Size(286, 26);
            this.newMemberMenuItem.Text = "Novi član";
            this.newMemberMenuItem.Click += new System.EventHandler(this.newMemberMenuItem_Click);
            // 
            // changeMemberMenuItem
            // 
            this.changeMemberMenuItem.Name = "changeMemberMenuItem";
            this.changeMemberMenuItem.Size = new System.Drawing.Size(286, 26);
            this.changeMemberMenuItem.Text = "Izmena podataka o članovima";
            this.changeMemberMenuItem.Click += new System.EventHandler(this.changeMemberMenuItem_Click);
            // 
            // pregledIgracaMenuItem
            // 
            this.pregledIgracaMenuItem.Name = "pregledIgracaMenuItem";
            this.pregledIgracaMenuItem.Size = new System.Drawing.Size(286, 26);
            this.pregledIgracaMenuItem.Text = "Pregled članova";
            this.pregledIgracaMenuItem.Click += new System.EventHandler(this.pregledIgracaMenuItem_Click);
            // 
            // memberGroupsMenuItem
            // 
            this.memberGroupsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newMemberGroupMenuItem,
            this.viewMemberGroupsMenuItem});
            this.memberGroupsMenuItem.Name = "memberGroupsMenuItem";
            this.memberGroupsMenuItem.Size = new System.Drawing.Size(286, 26);
            this.memberGroupsMenuItem.Text = "Grupe članova";
            // 
            // newMemberGroupMenuItem
            // 
            this.newMemberGroupMenuItem.Name = "newMemberGroupMenuItem";
            this.newMemberGroupMenuItem.Size = new System.Drawing.Size(235, 26);
            this.newMemberGroupMenuItem.Text = "Nova grupa članova";
            this.newMemberGroupMenuItem.Click += new System.EventHandler(this.newMemberGroupMenuItem_Click);
            // 
            // viewMemberGroupsMenuItem
            // 
            this.viewMemberGroupsMenuItem.Name = "viewMemberGroupsMenuItem";
            this.viewMemberGroupsMenuItem.Size = new System.Drawing.Size(235, 26);
            this.viewMemberGroupsMenuItem.Text = "Pregled grupa članova";
            this.viewMemberGroupsMenuItem.Click += new System.EventHandler(this.viewMemberGroupsMenuItem_Click);
            // 
            // membershipFeesMenuItem
            // 
            this.membershipFeesMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newMembershipFeeMenuItem,
            this.changeMembershipFeeMenuItem,
            this.viewMembershipFeesMenuItem});
            this.membershipFeesMenuItem.Name = "membershipFeesMenuItem";
            this.membershipFeesMenuItem.Size = new System.Drawing.Size(286, 26);
            this.membershipFeesMenuItem.Text = "Članarine";
            // 
            // newMembershipFeeMenuItem
            // 
            this.newMembershipFeeMenuItem.Name = "newMembershipFeeMenuItem";
            this.newMembershipFeeMenuItem.Size = new System.Drawing.Size(200, 26);
            this.newMembershipFeeMenuItem.Text = "Nova članarina";
            this.newMembershipFeeMenuItem.Click += new System.EventHandler(this.newMembershipFeeMenuItem_Click);
            // 
            // changeMembershipFeeMenuItem
            // 
            this.changeMembershipFeeMenuItem.Name = "changeMembershipFeeMenuItem";
            this.changeMembershipFeeMenuItem.Size = new System.Drawing.Size(200, 26);
            this.changeMembershipFeeMenuItem.Text = "Izmena članarine";
            this.changeMembershipFeeMenuItem.Click += new System.EventHandler(this.changeMembershipFeeMenuItem_Click);
            // 
            // viewMembershipFeesMenuItem
            // 
            this.viewMembershipFeesMenuItem.Name = "viewMembershipFeesMenuItem";
            this.viewMembershipFeesMenuItem.Size = new System.Drawing.Size(200, 26);
            this.viewMembershipFeesMenuItem.Text = "Pregled članarina";
            this.viewMembershipFeesMenuItem.Click += new System.EventHandler(this.viewMembershipFeesMenuItem_Click);
            // 
            // clothingMenuItem
            // 
            this.clothingMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newClothingMenuItem,
            this.viewClothingMenuItem,
            this.reservationsMenuItem});
            this.clothingMenuItem.Name = "clothingMenuItem";
            this.clothingMenuItem.Size = new System.Drawing.Size(71, 25);
            this.clothingMenuItem.Text = "Nošnja";
            // 
            // newClothingMenuItem
            // 
            this.newClothingMenuItem.Name = "newClothingMenuItem";
            this.newClothingMenuItem.Size = new System.Drawing.Size(183, 26);
            this.newClothingMenuItem.Text = "Nova nošnja";
            this.newClothingMenuItem.Click += new System.EventHandler(this.newClothingMenuItem_Click);
            // 
            // viewClothingMenuItem
            // 
            this.viewClothingMenuItem.Name = "viewClothingMenuItem";
            this.viewClothingMenuItem.Size = new System.Drawing.Size(183, 26);
            this.viewClothingMenuItem.Text = "Pregled nošnje";
            this.viewClothingMenuItem.Click += new System.EventHandler(this.viewClothingMenuItem_Click);
            // 
            // reservationsMenuItem
            // 
            this.reservationsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newReservationMenuItem,
            this.deleteReservationMenuItem});
            this.reservationsMenuItem.Name = "reservationsMenuItem";
            this.reservationsMenuItem.Size = new System.Drawing.Size(183, 26);
            this.reservationsMenuItem.Text = "Rezervacije";
            // 
            // newReservationMenuItem
            // 
            this.newReservationMenuItem.Name = "newReservationMenuItem";
            this.newReservationMenuItem.Size = new System.Drawing.Size(328, 26);
            this.newReservationMenuItem.Text = "Nova rezervacija nošnje";
            this.newReservationMenuItem.Click += new System.EventHandler(this.newReservationMenuItem_Click);
            // 
            // deleteReservationMenuItem
            // 
            this.deleteReservationMenuItem.Name = "deleteReservationMenuItem";
            this.deleteReservationMenuItem.Size = new System.Drawing.Size(328, 26);
            this.deleteReservationMenuItem.Text = "Pregled i brisanje rezervacije nošnje";
            this.deleteReservationMenuItem.Click += new System.EventHandler(this.deleteReservationMenuItem_Click);
            // 
            // transactionsMenuItem
            // 
            this.transactionsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.incomingTransactionsMenuItem,
            this.outgoingTransactionsMenuItem,
            this.viewTransactionsMenuItem,
            this.balanceMenuItem});
            this.transactionsMenuItem.Name = "transactionsMenuItem";
            this.transactionsMenuItem.Size = new System.Drawing.Size(79, 25);
            this.transactionsMenuItem.Text = "Plaćanja";
            // 
            // incomingTransactionsMenuItem
            // 
            this.incomingTransactionsMenuItem.Name = "incomingTransactionsMenuItem";
            this.incomingTransactionsMenuItem.Size = new System.Drawing.Size(211, 26);
            this.incomingTransactionsMenuItem.Text = "Uplate";
            this.incomingTransactionsMenuItem.Click += new System.EventHandler(this.incomingTransactionsMenuItem_Click);
            // 
            // outgoingTransactionsMenuItem
            // 
            this.outgoingTransactionsMenuItem.Name = "outgoingTransactionsMenuItem";
            this.outgoingTransactionsMenuItem.Size = new System.Drawing.Size(211, 26);
            this.outgoingTransactionsMenuItem.Text = "Isplate";
            this.outgoingTransactionsMenuItem.Click += new System.EventHandler(this.outgoingTransactionsMenuItem_Click);
            // 
            // viewTransactionsMenuItem
            // 
            this.viewTransactionsMenuItem.Name = "viewTransactionsMenuItem";
            this.viewTransactionsMenuItem.Size = new System.Drawing.Size(211, 26);
            this.viewTransactionsMenuItem.Text = "Pregled transakcija";
            this.viewTransactionsMenuItem.Click += new System.EventHandler(this.viewTransactionsMenuItem_Click);
            // 
            // balanceMenuItem
            // 
            this.balanceMenuItem.Name = "balanceMenuItem";
            this.balanceMenuItem.Size = new System.Drawing.Size(211, 26);
            this.balanceMenuItem.Text = "Pregled stanja";
            this.balanceMenuItem.Click += new System.EventHandler(this.balanceMenuItem_Click);
            // 
            // formsMenuItem
            // 
            this.formsMenuItem.Name = "formsMenuItem";
            this.formsMenuItem.Size = new System.Drawing.Size(75, 25);
            this.formsMenuItem.Text = "Obrasci";
            // 
            // adminMenuItem
            // 
            this.adminMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archiveDataMenuItem,
            this.viewArchivedDataMenuItem,
            this.viewActivityMenuItem});
            this.adminMenuItem.Name = "adminMenuItem";
            this.adminMenuItem.Size = new System.Drawing.Size(121, 25);
            this.adminMenuItem.Text = "Administracija";
            // 
            // archiveDataMenuItem
            // 
            this.archiveDataMenuItem.Name = "archiveDataMenuItem";
            this.archiveDataMenuItem.Size = new System.Drawing.Size(280, 26);
            this.archiveDataMenuItem.Text = "Arhiviranje podataka";
            this.archiveDataMenuItem.Click += new System.EventHandler(this.archiveDataMenuItem_Click);
            // 
            // viewArchivedDataMenuItem
            // 
            this.viewArchivedDataMenuItem.Name = "viewArchivedDataMenuItem";
            this.viewArchivedDataMenuItem.Size = new System.Drawing.Size(280, 26);
            this.viewArchivedDataMenuItem.Text = "Pregled arhiviranih podataka";
            this.viewArchivedDataMenuItem.Click += new System.EventHandler(this.viewArchivedDataMenuItem_Click);
            // 
            // viewActivityMenuItem
            // 
            this.viewActivityMenuItem.Name = "viewActivityMenuItem";
            this.viewActivityMenuItem.Size = new System.Drawing.Size(280, 26);
            this.viewActivityMenuItem.Text = "Pregled aktivnosti";
            this.viewActivityMenuItem.Click += new System.EventHandler(this.viewActivityMenuItem_Click);
            // 
            // usersMenuItem
            // 
            this.usersMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeUserMenuItem,
            this.viewUsersMenuItem,
            this.logoutMenuItem});
            this.usersMenuItem.Name = "usersMenuItem";
            this.usersMenuItem.Size = new System.Drawing.Size(81, 25);
            this.usersMenuItem.Text = "Korisnici";
            // 
            // changeUserMenuItem
            // 
            this.changeUserMenuItem.Name = "changeUserMenuItem";
            this.changeUserMenuItem.Size = new System.Drawing.Size(298, 26);
            this.changeUserMenuItem.Text = "Izmena podataka o korisniku";
            this.changeUserMenuItem.Click += new System.EventHandler(this.changeUserMenuItem_Click);
            // 
            // viewUsersMenuItem
            // 
            this.viewUsersMenuItem.Name = "viewUsersMenuItem";
            this.viewUsersMenuItem.Size = new System.Drawing.Size(298, 26);
            this.viewUsersMenuItem.Text = "Pregled podataka o korisnicima";
            this.viewUsersMenuItem.Click += new System.EventHandler(this.viewUsersMenuItem_Click);
            // 
            // logoutMenuItem
            // 
            this.logoutMenuItem.Name = "logoutMenuItem";
            this.logoutMenuItem.Size = new System.Drawing.Size(298, 26);
            this.logoutMenuItem.Text = "Odjava";
            this.logoutMenuItem.Click += new System.EventHandler(this.logoutMenuItem_Click);
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.BackColor = System.Drawing.Color.Transparent;
            this.labelWelcome.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.ForeColor = System.Drawing.Color.Red;
            this.labelWelcome.Location = new System.Drawing.Point(446, 29);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelWelcome.Size = new System.Drawing.Size(83, 20);
            this.labelWelcome.TabIndex = 2;
            this.labelWelcome.Text = "Welcome, ";
            this.labelWelcome.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // labelDateTime
            // 
            this.labelDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.BackColor = System.Drawing.Color.Transparent;
            this.labelDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelDateTime.ForeColor = System.Drawing.Color.Blue;
            this.labelDateTime.Location = new System.Drawing.Point(12, 362);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(54, 40);
            this.labelDateTime.TabIndex = 3;
            this.labelDateTime.Text = "datum\r\nvreme";
            this.labelDateTime.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // timerCurrentTime
            // 
            this.timerCurrentTime.Interval = 1000;
            this.timerCurrentTime.Tick += new System.EventHandler(this.timerCurrentTime_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tkanica.Properties.Resources.kud_pargar_logo_deblje_figure;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(529, 411);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.menuStavke);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStavke;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tkanica";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStavke.ResumeLayout(false);
            this.menuStavke.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStavke;
        private System.Windows.Forms.ToolStripMenuItem membersMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newMemberMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeMemberMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledIgracaMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clothingMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newClothingMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewClothingMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservationsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incomingTransactionsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outgoingTransactionsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewTransactionsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem balanceMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeUserMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewUsersMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutMenuItem;
        private System.Windows.Forms.ToolStripMenuItem archiveDataMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewArchivedDataMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newReservationMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteReservationMenuItem;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.ToolStripMenuItem viewActivityMenuItem;
        private System.Windows.Forms.Label labelDateTime;
        private System.Windows.Forms.ToolStripMenuItem memberGroupsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newMemberGroupMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewMemberGroupsMenuItem;
        private System.Windows.Forms.Timer timerCurrentTime;
        private System.Windows.Forms.ToolStripMenuItem membershipFeesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newMembershipFeeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewMembershipFeesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeMembershipFeeMenuItem;
    }
}

