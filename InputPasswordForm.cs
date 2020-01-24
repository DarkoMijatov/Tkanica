using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tkanica.Helpers;

namespace Tkanica
{
    public partial class InputPasswordForm : Form
    {
        private string userName;
        public bool confirmed;
        public InputPasswordForm(string userName)
        {
            this.userName = userName;
            InitializeComponent();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            string password = textBoxPassword.Text;
            if (UsersHelper.CheckUserCredentials(userName, password))
            {
                confirmed = true;
            }
            else
            {
                confirmed = false;
            }
            this.Hide();
        }

        private void textBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(Convert.ToInt32(e.KeyChar)==13)
            {
                string password = textBoxPassword.Text;
                if (UsersHelper.CheckUserCredentials(userName, password))
                {
                    confirmed = true;
                }
                else
                {
                    confirmed = false;
                }
                this.Hide();
            }
        }
    }
}
