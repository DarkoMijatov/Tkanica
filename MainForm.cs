using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tkanica.Classes;
using Tkanica.Helpers;

namespace Tkanica
{
    public partial class MainForm : Form
    {
        public string userName;
        public MainForm(string userName)
        {
            this.userName = userName;
            Program.sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlConnection"].ConnectionString);
            InitializeComponent();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            timerCurrentTime.Stop();
            this.Hide();
            LogHelper.PostLog(userName, "Korisnik " + userName + " je odjavljen");
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
            this.Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            timerCurrentTime.Start();
            User user = UsersHelper.GetUsers().Where(users => users.UserName == this.userName).First();
            labelWelcome.Text = "Dobrodošli, " + user.FirstName + " " + user.LastName;
            labelDateTime.Text = "Datum i vreme: " + DateTime.Now.ToString("dd.MM.yyyy. HH:mm:ss");
            if (user.UserType == "upravnik")
            {
                adminMenuItem.Visible = false;
                viewUsersMenuItem.Visible = false;
                formsMenuItem.Visible = false;
            }
            if(user.UserType == "pregledač")
            {
                adminMenuItem.Visible = false;
                viewUsersMenuItem.Visible = false;
                incomingTransactionsMenuItem.Visible = false;
                outgoingTransactionsMenuItem.Visible = false;
                newClothingMenuItem.Visible = false;
                newReservationMenuItem.Visible = false;
                deleteReservationMenuItem.Visible = false;
                newMemberMenuItem.Visible = false;
                changeMemberMenuItem.Visible = false;
                newMemberGroupMenuItem.Visible = false;
                newMembershipFeeMenuItem.Visible = false;
                changeMembershipFeeMenuItem.Visible = false;
                formsMenuItem.Visible = false;
            }
            if (user.UserType == "admin" || user.UserType == "upravnik")
            {
                int day = DateTime.Now.Day;
                int month = DateTime.Now.Month;
                int year = DateTime.Now.Year;
                if(day >= 20 && !TransactionsHelper.CheckIfDebtIsUpdated(month, year) && month!= 7 && month!=8)
                {
                    DialogResult result = MessageBox.Show("Da li želite da ažurirate dugovanja za članarinu za tekući mesec aktivnim članovima?", "Članarine", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        TransactionsHelper.IncreaseDebt(month,year);
                        string monthName;
                        switch (month)
                        {
                            case 1:
                                monthName = "januar";
                                break;
                            case 2:
                                monthName = "februar";
                                break;
                            case 3:
                                monthName = "mart";
                                break;
                            case 4:
                                monthName = "april";
                                break;
                            case 5:
                                monthName = "maj";
                                break;
                            case 6:
                                monthName = "jun";
                                break;
                            case 9:
                                monthName = "septembar";
                                break;
                            case 10:
                                monthName = "oktobar";
                                break;
                            case 11:
                                monthName = "novembar";
                                break;
                            default:
                                monthName = "decembar";
                                break;
                        }
                        LogHelper.PostLog(userName, "Ažurirana dugovanja za članarinu za " + monthName + " " + year.ToString());
                        MessageBox.Show("Uspešno su ažurirana dugovanja za ovaj mesec.", "Uspeh");
                    }
                }
            }
        }

        private void logoutMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Da li ste sigurni da želite da se odjavite?", "Odjavljivanje", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Hide();
                MessageBox.Show("Uspešno ste se odjavili.", "Odjavljivanje");
                LogHelper.PostLog(userName, "Korisnik " + userName + " je odjavljen");
                LoginForm loginForm = new LoginForm();
                loginForm.ShowDialog();
                this.Close();
            }
        }

        private void changeUserMenuItem_Click(object sender, EventArgs e)
        {
            ChangeUserForm changeUserForm = new ChangeUserForm(userName);
            changeUserForm.ShowDialog();
        }

        private void viewUsersMenuItem_Click(object sender, EventArgs e)
        {
            ViewUsersForm viewUsersForm = new ViewUsersForm(userName);
            viewUsersForm.ShowDialog();
        }

        private void newMemberGroupMenuItem_Click(object sender, EventArgs e)
        {
            NewMemberGroupForm newMemberGroupForm = new NewMemberGroupForm(userName);
            newMemberGroupForm.ShowDialog();
        }

        private void viewMemberGroupsMenuItem_Click(object sender, EventArgs e)
        {
            MemberGroupsForm memberGroups = new MemberGroupsForm(userName);
            memberGroups.ShowDialog();
        }

        private void newMemberMenuItem_Click(object sender, EventArgs e)
        {
            NewMemberForm newMember = new NewMemberForm(userName);
            newMember.ShowDialog();
        }

        private void pregledIgracaMenuItem_Click(object sender, EventArgs e)
        {
            ViewMembersForm viewMembersForm = new ViewMembersForm(userName);
            viewMembersForm.ShowDialog();
        }

        private void changeMemberMenuItem_Click(object sender, EventArgs e)
        {
            EditMemberForm editMember = new EditMemberForm(userName, 0);
            editMember.ShowDialog();
        }

        private void timerCurrentTime_Tick(object sender, EventArgs e)
        {
            labelDateTime.Text = "Datum i vreme: " + DateTime.Now.ToString("dd.MM.yyyy. HH:mm:ss");
        }

        private void newClothingMenuItem_Click(object sender, EventArgs e)
        {
            NewClothingForm newClothing = new NewClothingForm(userName);
            newClothing.ShowDialog();
        }

        private void viewClothingMenuItem_Click(object sender, EventArgs e)
        {
            ViewClothingsForm viewClothings = new ViewClothingsForm();
            viewClothings.ShowDialog();
        }

        private void newReservationMenuItem_Click(object sender, EventArgs e)
        {
            NewReservationForm newReservation = new NewReservationForm(userName);
            newReservation.ShowDialog();
        }

        private void deleteReservationMenuItem_Click(object sender, EventArgs e)
        {
            ViewReservationsForm viewReservations = new ViewReservationsForm(userName);
            viewReservations.ShowDialog();
        }

        private void newMembershipFeeMenuItem_Click(object sender, EventArgs e)
        {
            NewMembershipFeeForm newMembershipFee = new NewMembershipFeeForm(userName);
            newMembershipFee.ShowDialog();
        }

        private void viewMembershipFeesMenuItem_Click(object sender, EventArgs e)
        {
            ViewMembershipFeesForm viewMembershipFees = new ViewMembershipFeesForm(userName);
            viewMembershipFees.ShowDialog();
        }

        private void changeMembershipFeeMenuItem_Click(object sender, EventArgs e)
        {
            EditMembershipFeeForm editMembershipFee = new EditMembershipFeeForm(userName, 0);
            editMembershipFee.ShowDialog();
        }

        private void incomingTransactionsMenuItem_Click(object sender, EventArgs e)
        {
            IncomingTransactionsForm incomingTransactions = new IncomingTransactionsForm(userName);
            incomingTransactions.ShowDialog();
        }

        private void outgoingTransactionsMenuItem_Click(object sender, EventArgs e)
        {
            OutgoingTransactionsForm outgoingTransactions = new OutgoingTransactionsForm(userName);
            outgoingTransactions.ShowDialog();
        }

        private void viewTransactionsMenuItem_Click(object sender, EventArgs e)
        {
            ViewTransactionsForm viewTransactions = new ViewTransactionsForm(userName);
            viewTransactions.ShowDialog();
        }

        private void balanceMenuItem_Click(object sender, EventArgs e)
        {
            BalancesViewForm balancesView = new BalancesViewForm(userName);
            balancesView.ShowDialog();
        }

        private void viewActivityMenuItem_Click(object sender, EventArgs e)
        {
            ViewLogsForm viewLogs = new ViewLogsForm();
            viewLogs.ShowDialog();
        }

        private void archiveDataMenuItem_Click(object sender, EventArgs e)
        {
            ArchiveDataForm archiveData = new ArchiveDataForm(userName);
            archiveData.ShowDialog();
        }

        private void viewArchivedDataMenuItem_Click(object sender, EventArgs e)
        {
            ViewArchivedDataForm viewArchivedData = new ViewArchivedDataForm();
            viewArchivedData.ShowDialog();
        }
    }
}
