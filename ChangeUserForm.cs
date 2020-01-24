using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tkanica.Classes;
using Tkanica.Helpers;

namespace Tkanica
{
    public partial class ChangeUserForm : Form
    {
        private string userName;
        public ChangeUserForm(string userName)
        {
            this.userName = userName;
            InitializeComponent();
        }

        private void ChangeUserForm_Load(object sender, EventArgs e)
        {
            User user = UsersHelper.GetUsers().Where(users => users.UserName == userName).First();
            textBoxUserName.Text = user.UserName;
            textBoxFirstName.Text = user.FirstName;
            textBoxLastName.Text = user.LastName;
            if (user.UserType == "admin") radioButtonAdmin.Checked = true;
            else if (user.UserType == "upravnik") radioButtonManager.Checked = true;
            else radioButtonRegular.Checked = true;
        }

        private void textBoxUserName_Leave(object sender, EventArgs e)
        {
            if (userName != textBoxUserName.Text)
            {
                DialogResult dialogResult = MessageBox.Show("Da li ste sigurni da želite da promenite korisničko ime?", "Upozorenje", MessageBoxButtons.YesNo);
                if(dialogResult == DialogResult.Yes)
                {
                    if (textBoxUserName.Text == "")
                    {
                        MessageBox.Show("Korisničko ime ne sme ostati prazno!", "Greška");
                        textBoxUserName.Focus();
                    }
                    if (textBoxUserName.Text.Contains(" "))
                    {
                        MessageBox.Show("Korisničko ime ne sme sadržati razmake!", "Greška");
                        textBoxUserName.Clear();
                        textBoxUserName.Focus();
                    }
                }
                else
                {
                    textBoxUserName.Text = userName;
                }
            }
        }

        private void buttonChangeUserData_Click(object sender, EventArgs e)
        {
            string firstName = textBoxFirstName.Text;
            string lastName = textBoxLastName.Text;
            string changedUserName = textBoxUserName.Text;
            string userType;
            if (radioButtonAdmin.Checked) userType = "admin";
            else if (radioButtonManager.Checked) userType = "upravnik";
            else userType = "pregledač";
            User changedUser = new User { UserName = changedUserName, FirstName = firstName, LastName = lastName, UserType = userType };
            if (userType == "admin" && UsersHelper.GetUsers().Where(u => u.UserType == userType && u.UserName != userName).Count() > 0)
            {
                MessageBox.Show("Već postoji dozvoljen broj korisnika sa pravima administratora!", "Greška");
                groupBoxUserType.Focus();
            }
            else if (userType == "upravnik" && UsersHelper.GetUsers().Where(u => u.UserType == userType && u.UserName != userName).Count() > 1)
            {
                MessageBox.Show("Već postoji dozvoljen broj korisnika sa pravima upravnika!", "Greška");
                groupBoxUserType.Focus();
            }
            else
            {
                InputPasswordForm inputPassword = new InputPasswordForm(userName);
                inputPassword.ShowDialog();
                if (inputPassword.confirmed)
                {
                    UsersHelper.ChangeUser(userName, changedUser);
                    LogHelper.PostLog(userName, "Korisnik " + userName + " je promenio svoje podatke");
                    MessageBox.Show("Podaci o korisniku su uspešno promenjeni.", "Uspeh");
                    FormCollection formCollection = Application.OpenForms;
                    foreach (Form form in formCollection)
                    {
                        if (form.Name != "LoginForm") form.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Pogrešna lozinka!", "Greška");
                    inputPassword.Refresh();
                }
            }
        }

        private void buttonChangePassword_Click(object sender, EventArgs e)
        {
            ChangePasswordForm changePassword = new ChangePasswordForm(userName);
            changePassword.ShowDialog();
        }
    }
}
