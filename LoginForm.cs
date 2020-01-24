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
using Tkanica.Helpers;
using Tkanica.Classes;

namespace Tkanica
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            Program.sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlConnection"].ConnectionString);
            InitializeComponent();
        }

        private void buttonPrijava_Click(object sender, EventArgs e)
        {
            if(UsersHelper.CheckUserCredentials(textBoxUserName.Text, textBoxPassword.Text) == false)
            {
                MessageBox.Show("Pogrešno uneti podaci za prijavljivanje!", "Greška");
                textBoxUserName.Clear();
                textBoxPassword.Clear();
                textBoxUserName.Focus();
            }
            else
            {
                LogHelper.PostLog(textBoxUserName.Text, "Korisnik je prijavljen");
                this.Hide();
                MainForm mainForm = new MainForm(textBoxUserName.Text);
                mainForm.ShowDialog();
                this.Close();
            }
        }

        private void textBoxLozinka_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                if (UsersHelper.CheckUserCredentials(textBoxUserName.Text, textBoxPassword.Text) == false)
                {
                    MessageBox.Show("Pogrešno uneti podaci za prijavljivanje!", "Greška");
                    textBoxUserName.Clear();
                    textBoxPassword.Clear();
                    textBoxUserName.Focus();
                }
                else
                {
                    LogHelper.PostLog(textBoxUserName.Text, "Korisnik je prijavljen");
                    this.Hide();
                    MainForm mainForm = new MainForm(textBoxUserName.Text);
                    mainForm.ShowDialog();
                    this.Close();
                }
            }
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            NewUserForm newUserForm = new NewUserForm();
            newUserForm.ShowDialog();
        }
    }
}
