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
    public partial class NewMemberGroupForm : Form
    {
        private string userName;
        public NewMemberGroupForm(string userName)
        {
            this.userName = userName;
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string memberGroup = textBoxMemberGroupName.Text;
            bool exists = false;
            if (memberGroup == "" || memberGroup == "    ")
            {
                MessageBox.Show("Naziv grupe članova ne može biti prazan!", "Greška");
                textBoxMemberGroupName.Clear();
                textBoxMemberGroupName.Focus();
            }
            else
            {
                foreach (MemberGroup group in MemberGroupsHelper.GetMemberGroups())
                {
                    if (group.Name == memberGroup)
                    {
                        MessageBox.Show("Već postoji takva grupa članova!", "Greška");
                        textBoxMemberGroupName.Clear();
                        textBoxMemberGroupName.Focus();
                        exists = true;
                        break;
                    }
                }
                if (!exists)
                {
                    MemberGroupsHelper.PostMemberGroup(memberGroup);
                    MessageBox.Show("Uspešno je uneta nova grupa članova.", "Uspeh");
                    LogHelper.PostLog(userName, "Korisnik " + userName + " je dodao novu grupu članova " + memberGroup);
                }
                
            }
        }

        private void textBoxMemberGroupName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                string memberGroup = textBoxMemberGroupName.Text;
                bool exists = false;
                if (memberGroup == "" || memberGroup == "    ")
                {
                    MessageBox.Show("Naziv grupe članova ne može biti prazan!", "Greška");
                    textBoxMemberGroupName.Clear();
                    textBoxMemberGroupName.Focus();
                }
                else
                {
                    foreach (MemberGroup group in MemberGroupsHelper.GetMemberGroups())
                    {
                        if (group.Name == memberGroup)
                        {
                            MessageBox.Show("Već postoji takva grupa članova!", "Greška");
                            textBoxMemberGroupName.Clear();
                            textBoxMemberGroupName.Focus();
                            exists = true;
                            break;
                        }
                    }
                    if (!exists)
                    {
                        MemberGroupsHelper.PostMemberGroup(memberGroup);
                        MessageBox.Show("Uspešno je uneta nova grupa članova.", "Uspeh");
                        LogHelper.PostLog(userName, "Korisnik " + userName + " je dodao novu grupu članova " + memberGroup);
                    }

                }
            }
        }
    }
}
