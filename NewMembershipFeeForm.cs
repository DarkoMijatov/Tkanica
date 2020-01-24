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
    public partial class NewMembershipFeeForm : Form
    {
        private string userName;
        public NewMembershipFeeForm(string userName)
        {
            this.userName = userName;
            InitializeComponent();
        }

        private void NewMembershipFeeForm_Load(object sender, EventArgs e)
        {
            List<MemberGroup> groups = MemberGroupsHelper.GetMemberGroups();
            foreach(MemberGroup group in groups)
            {
                comboBoxMemberGroup.Items.Add(group.Name);
            }
        }

        private void comboBoxMemberGroup_Leave(object sender, EventArgs e)
        {
            if(comboBoxMemberGroup.Text=="Izaberite grupu")
            {
                MessageBox.Show("Morate izabrati grupu članova!", "Greška");
                comboBoxMemberGroup.Focus();
            }
        }

        private void textBoxAmount_Leave(object sender, EventArgs e)
        {
            if (textBoxAmount.Text.Trim() == "")
            {
                MessageBox.Show("Morate uneti iznos članarine!", "Greška");
                textBoxAmount.Focus();
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                MembershipFee fee = new MembershipFee();
                fee.MemberGroup = MemberGroupsHelper.GetMemberGroups().Where(group => group.Name == comboBoxMemberGroup.Text.Trim()).First();
                fee.Discount = checkBoxDiscount.Checked;
                fee.Amount = Convert.ToDouble(textBoxAmount.Text);
                TransactionsHelper.PostMembershipFee(fee);
                string discount = fee.Discount ? "sa popustom 50%" : "bez popusta";
                LogHelper.PostLog(userName, "Dodata nova članarina: " + fee.MemberGroup.Name + " " + discount + " " + fee.Amount.ToString());
                MessageBox.Show("Uspešno je dodata nova članarina.", "Uspeh");
            }
            catch (FormatException)
            {
                MessageBox.Show("Iznos članarine nije ispravno unet!", "Greška");
                textBoxAmount.Clear();
                textBoxAmount.Focus();
            }
        }

        private void textBoxAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(Convert.ToInt32(e.KeyChar) == 13)
            {
                if (textBoxAmount.Text.Trim() == "")
                {
                    MessageBox.Show("Morate uneti iznos članarine!", "Greška");
                    textBoxAmount.Focus();
                }
                else
                {
                    try
                    {
                        MembershipFee fee = new MembershipFee();
                        fee.MemberGroup = MemberGroupsHelper.GetMemberGroups().Where(group => group.Name == comboBoxMemberGroup.Text.Trim()).First();
                        fee.Discount = checkBoxDiscount.Checked;
                        fee.Amount = Convert.ToDouble(textBoxAmount.Text);
                        TransactionsHelper.PostMembershipFee(fee);
                        string discount = fee.Discount ? "sa popustom 50%" : "bez popusta";
                        LogHelper.PostLog(userName, "Dodata nova članarina: " + fee.MemberGroup.Name + " " + discount + " " + fee.Amount.ToString());
                        MessageBox.Show("Uspešno je dodata nova članarina.", "Uspeh");
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Iznos članarine nije ispravno unet!", "Greška");
                        textBoxAmount.Clear();
                        textBoxAmount.Focus();
                    }
                }
            }
        }
    }
}
