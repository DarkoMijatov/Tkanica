using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tkanica.Classes;
using Tkanica.Helpers;
namespace Tkanica
{
    public partial class NewMemberForm : Form
    {
        private string userName;
        public NewMemberForm(string userName)
        {
            this.userName = userName;
            InitializeComponent();
        }

        private void NewMemberForm_Load(object sender, EventArgs e)
        {
            List<MemberGroup> groups = MemberGroupsHelper.GetMemberGroups();
            foreach(MemberGroup group in groups)
            {
                comboBoxMemberGroup.Items.Add(group.Name);
            }
        }

        private void textBoxFirstName_Leave(object sender, EventArgs e)
        {
            if(textBoxFirstName.Text.Trim()=="")
            {
                MessageBox.Show("Ime člana ne može ostati prazno!", "Greška");
                textBoxFirstName.Clear();
                textBoxFirstName.Focus();
            }
        }

        private void textBoxLastName_Leave(object sender, EventArgs e)
        {
            if (textBoxLastName.Text.Trim() == "")
            {
                MessageBox.Show("Prezime člana ne može ostati prazno!", "Greška");
                textBoxLastName.Clear();
                textBoxLastName.Focus();
            }
        }

        private void textBoxAddress_Leave(object sender, EventArgs e)
        {
            if (textBoxAddress.Text.Trim() == "")
            {
                MessageBox.Show("Adresa člana ne može ostati prazna!", "Greška");
                textBoxAddress.Clear();
                textBoxAddress.Focus();
            }
        }

        private void textBoxLocation_Leave(object sender, EventArgs e)
        {
            if (textBoxLocation.Text.Trim() == "")
            {
                MessageBox.Show("Mesto člana ne može ostati prazno!", "Greška");
                textBoxLocation.Clear();
                textBoxLocation.Focus();
            }
        }

        private void dateTimePickerDateOfBirth_Leave(object sender, EventArgs e)
        {
            if (dateTimePickerDateOfBirth.Value.Equals(dateTimePickerDateOfEntry.Value))
            {
                MessageBox.Show("Datum rođenja člana ne može biti isti kao datum upisa!", "Greška");
                dateTimePickerDateOfBirth.Focus();
            }
        }

        private void comboBoxMemberGroup_Leave(object sender, EventArgs e)
        {
            if (comboBoxMemberGroup.Text.Trim() == "Izaberite grupu")
            {
                MessageBox.Show("Morate izabrati folklornu grupu!", "Greška");
                comboBoxMemberGroup.Focus();
            }
        }

        private void textBoxMobilePhone_Leave(object sender, EventArgs e)
        {
            if (textBoxMobilePhone.Text.Trim() == "")
            {
                MessageBox.Show("Kontakt telefon člana ne može ostati prazan!", "Greška");
                textBoxMobilePhone.Clear();
                textBoxMobilePhone.Focus();
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string firstName = textBoxFirstName.Text;
            string lastName = textBoxLastName.Text;
            string address = textBoxAddress.Text;
            string location = textBoxLocation.Text;
            DateTime dateOfBirth = dateTimePickerDateOfBirth.Value;
            string mobilePhone = textBoxMobilePhone.Text;
            string email = textBoxEmail.Text;
            DateTime dateOfEntry = dateTimePickerDateOfEntry.Value;
            int yearsOfExperience = textBoxYearsOfExperience.Text.Trim() != "" ? Convert.ToInt32(textBoxYearsOfExperience.Text) : 0;
            string memberGroup = comboBoxMemberGroup.SelectedItem.ToString();
            bool discount = checkBoxDiscount.Checked;
            Member member = new Member();
            member.FirstName = firstName;
            member.LastName = lastName;
            member.Address = address;
            member.Location = location;
            member.DateOfBirth = dateOfBirth;
            member.MobilePhone = mobilePhone;
            member.Email = email;
            member.DateOfEntry = dateOfEntry;
            member.YearsOfExperience = yearsOfExperience;
            member.Group = memberGroup;
            member.MembershipFee = TransactionsHelper.GetMembershipFees().Where(fee => fee.Discount == discount && fee.MemberGroup.Name == member.Group).First();
            if (MembersHelper.GetMembers().Where(members => members.FirstName == firstName && members.LastName == lastName && members.DateOfBirth.ToString("dd.MM.yyyy.") == dateOfBirth.ToString("dd.MM.yyyy.")).Any())
            {
                MessageBox.Show("Već postoji član sa unetim podacima!", "Greška");
                textBoxFirstName.Clear();
                textBoxLastName.Clear();
                textBoxAddress.Clear();
                textBoxLocation.Clear();
                textBoxYearsOfExperience.Clear();
                textBoxMobilePhone.Clear();
                textBoxEmail.Clear();
                comboBoxMemberGroup.Text = "Izaberite grupu";
                textBoxFirstName.Focus();
                checkBoxDiscount.Checked = false;
            }
            else
            {
                MembersHelper.PostMember(member);
                MessageBox.Show("Uspešno je upisan član " + member.FirstName + " " + member.LastName + ".", "Uspeh");
                LogHelper.PostLog(userName, "Dodat novi član: " + member.FirstName + " " + member.LastName);
                this.Close();
            }
        }

    }
}
