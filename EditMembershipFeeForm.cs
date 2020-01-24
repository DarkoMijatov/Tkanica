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
    public partial class EditMembershipFeeForm : Form
    {
        private string userName;
        private int membershipFeeId;
        public EditMembershipFeeForm(string userName, int membershipFeeId)
        {
            this.userName = userName;
            this.membershipFeeId = membershipFeeId;
            InitializeComponent();
        }

        private void EditMembershipFeeForm_Load(object sender, EventArgs e)
        {
            List<MembershipFee> fees = TransactionsHelper.GetMembershipFees();
            foreach(MembershipFee fee in fees)
            {
                string discount = fee.Discount ? " sa popustom" : "";
                comboBoxSelectFee.Items.Add(fee.MemberGroup.Name + discount);
            }
            if(membershipFeeId != 0)
            {
                groupBoxSelectFee.Enabled = false;
                MembershipFee fee = fees.Where(f => f.Id == membershipFeeId).First();
                textBoxMemberGroup.Text = fee.MemberGroup.Name;
                checkBoxDiscount.Checked = fee.Discount;
                textBoxAmount.Text = fee.Amount.ToString();
            }
            textBoxMemberGroup.Enabled = false;
            checkBoxDiscount.Enabled = false;
        }

        private void comboBoxSelectFee_SelectedValueChanged(object sender, EventArgs e)
        {
            if(comboBoxSelectFee.Text=="Odaberite članarinu")
            {
                MessageBox.Show("Morate odabrati članarinu!", "Greška");
                textBoxMemberGroup.Clear();
                checkBoxDiscount.Checked = false;
                textBoxAmount.Clear();
                comboBoxSelectFee.Focus();
            }
            else
            {
                bool discount = comboBoxSelectFee.Text.Contains("popust");
                string memberGroup = discount ? comboBoxSelectFee.Text.Substring(0, comboBoxSelectFee.Text.IndexOf(" sa popustom")) : comboBoxSelectFee.Text;
                MembershipFee fee = TransactionsHelper.GetMembershipFees().Where(f => f.MemberGroup.Name == memberGroup && f.Discount == discount).First();
                textBoxMemberGroup.Text = fee.MemberGroup.Name;
                checkBoxDiscount.Checked = fee.Discount;
                textBoxAmount.Text = fee.Amount.ToString();
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxSelectFee.Text == "Odaberite članarinu")
                {
                    MessageBox.Show("Morate odabrati članarinu!", "Greška");
                    textBoxMemberGroup.Clear();
                    checkBoxDiscount.Checked = false;
                    textBoxAmount.Clear();
                    comboBoxSelectFee.Focus();
                }
                else
                {
                    MembershipFee fee = TransactionsHelper.GetMembershipFees().Where(f => f.MemberGroup.Name == textBoxMemberGroup.Text && f.Discount == checkBoxDiscount.Checked).First();
                    fee.Amount = Convert.ToDouble(textBoxAmount.Text);
                    TransactionsHelper.EditMembershipFee(fee);
                    string discount = fee.Discount ? " sa popustom" : "";
                    LogHelper.PostLog(userName, "Izmenjena članarina: " + fee.MemberGroup.Name + discount);
                    MessageBox.Show("Uspešno izmenjen iznos članarine.", "Uspeh");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Iznos članarine nije ispravan!", "Greška");
                textBoxAmount.Clear();
                textBoxAmount.Focus();
            }
            
        }
    }
}
