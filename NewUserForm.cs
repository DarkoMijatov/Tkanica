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
    public partial class NewUserForm : Form
    {
        public NewUserForm()
        {
            Program.sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlConnection"].ConnectionString);
            InitializeComponent();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            string firstName = textBoxFirstName.Text;
            string lastName = textBoxLastName.Text;
            string userName = textBoxUserName.Text;
            string password = textBoxPassword.Text;
            string userType;
            if (radioButtonAdmin.Checked) userType = "admin";
            else if (radioButtonManager.Checked) userType = "upravnik";
            else userType = "pregledač";
            if (UsersHelper.GetUsers().Where(user => user.UserName == userName).Count() > 0)
            {
                MessageBox.Show("Već postoji korisnik sa unetim korisničkim imenom!", "Greška");
                textBoxUserName.Clear();
                textBoxUserName.Focus();
            }
            else if(UsersHelper.GetUsers().Where(user => user.UserType == userType && userType == "admin").Count() > 0)
            {
                MessageBox.Show("Već postoji dozvoljen broj korisnika sa pravima administratora!", "Greška");
                groupBoxUserType.Focus();
            }
            else if (UsersHelper.GetUsers().Where(user => user.UserType == userType && userType == "upravnik").Count() > 1)
            {
                MessageBox.Show("Već postoji dozvoljen broj korisnika sa pravima upravnika!", "Greška");
                groupBoxUserType.Focus();
            }
            else
            {
                UsersHelper.PostUser(new User() { FirstName = firstName, LastName = lastName, Password = password, UserName = userName, UserType = userType });
                LogHelper.PostLog(userName, "Dodat novi korisnik " + userName);
                MessageBox.Show("Uspešno registrovan korisnik " + userName + ".", "Uspeh");
                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.ShowDialog();
                this.Close();
            }

        }

        private void textBoxUserName_Leave(object sender, EventArgs e)
        {
            string userName = textBoxUserName.Text;
            if (userName == "")
            {
                MessageBox.Show("Korisničko ime ne sme ostati prazno!", "Greška");
                textBoxUserName.Focus();
            }
            if (userName.Contains(" "))
            {
                MessageBox.Show("Korisničko ime ne sme sadržati razmake!", "Greška");
                textBoxUserName.Clear();
                textBoxUserName.Focus();
            }
        }

        private void textBoxPassword_Leave(object sender, EventArgs e)
        {
            string password = textBoxPassword.Text;
            if (password.Contains(" "))
            {
                MessageBox.Show("Lozinka ne sme sadržati razmake!", "Greška");
                textBoxPassword.Clear();
                textBoxPassword.Focus();
            }
            if (password.Length < 6)
            {
                MessageBox.Show("Lozinka mora imati bar 6 karaktera!", "Greška");
                textBoxPassword.Clear();
                textBoxPassword.Focus();
            }
        }

    }
}
