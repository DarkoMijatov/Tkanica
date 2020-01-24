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
    public partial class ChangePasswordForm : Form
    {
        private string userName;
        public ChangePasswordForm(string userName)
        {
            this.userName = userName;
            InitializeComponent();
        }

        private void buttonSaveChanges_Click(object sender, EventArgs e)
        {
            string oldPassword = textBoxOldPassword.Text;
            string newPassword = textBoxNewPassword.Text;
            string confirmPassword = textBoxConfirmPassword.Text;
            if (!UsersHelper.CheckUserCredentials(userName, oldPassword))
            {
                MessageBox.Show("Pogrešna lozinka!", "Greška");
                textBoxOldPassword.Clear();
                textBoxOldPassword.Focus();
            }
            else
            {
                if (newPassword.Length < 6)
                {
                    MessageBox.Show("Nova lozinka mora imati bar 6 karaktera!", "Greška");
                    textBoxNewPassword.Clear();
                    textBoxConfirmPassword.Clear();
                    textBoxNewPassword.Focus();
                }
                else if (oldPassword == newPassword)
                {
                    MessageBox.Show("Stara i nova lozinka ne mogu biti iste!", "Greška");
                    textBoxNewPassword.Clear();
                    textBoxConfirmPassword.Clear();
                    textBoxNewPassword.Focus();
                }
                else if (newPassword != confirmPassword)
                {
                    MessageBox.Show("Nova lozinka i potvrda lozinke se ne poklapaju!", "Greška");
                    textBoxConfirmPassword.Clear();
                    textBoxConfirmPassword.Focus();
                }
                else
                {
                    UsersHelper.ChangePassword(userName, newPassword);
                    LogHelper.PostLog(userName, "Korisnik " + userName + " je promenio lozinku");
                    MessageBox.Show("Lozinka je uspešno promenjena.", "Uspeh");
                    FormCollection formCollection = Application.OpenForms;
                    foreach (Form form in formCollection)
                    {
                        if (form.Name != "LoginForm") form.Close();
                    }
                }
            }
        }

        private void textBoxConfirmPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                string oldPassword = textBoxOldPassword.Text;
                string newPassword = textBoxNewPassword.Text;
                string confirmPassword = textBoxConfirmPassword.Text;
                if (!UsersHelper.CheckUserCredentials(userName, oldPassword))
                {
                    MessageBox.Show("Pogrešna lozinka!", "Greška");
                    textBoxOldPassword.Clear();
                    textBoxOldPassword.Focus();
                }
                else
                {
                    if (newPassword.Length < 6)
                    {
                        MessageBox.Show("Nova lozinka mora imati bar 6 karaktera!", "Greška");
                        textBoxNewPassword.Clear();
                        textBoxConfirmPassword.Clear();
                        textBoxNewPassword.Focus();
                    }
                    else if (oldPassword == newPassword)
                    {
                        MessageBox.Show("Stara i nova lozinka ne mogu biti iste!", "Greška");
                        textBoxNewPassword.Clear();
                        textBoxConfirmPassword.Clear();
                        textBoxNewPassword.Focus();
                    }
                    else if (newPassword != confirmPassword)
                    {
                        MessageBox.Show("Nova lozinka i potvrda lozinke se ne poklapaju!", "Greška");
                        textBoxConfirmPassword.Clear();
                        textBoxConfirmPassword.Focus();
                    }
                    else
                    {
                        UsersHelper.ChangePassword(userName, newPassword);
                        LogHelper.PostLog(userName, "Korisnik " + userName + " je promenio lozinku");
                        MessageBox.Show("Lozinka je uspešno promenjena.", "Uspeh");
                        FormCollection formCollection = Application.OpenForms;
                        foreach (Form form in formCollection)
                        {
                            if (form.Name != "LoginForm") form.Close();
                        }
                    }
                }
            }
        }
    }
}
