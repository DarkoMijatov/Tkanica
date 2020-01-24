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
    public partial class EditMemberForm : Form
    {
        private string userName;
        private int editMemberId;
        public EditMemberForm(string userName,int editMemberId)
        {
            this.userName = userName;
            this.editMemberId = editMemberId;
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Member member = MembersHelper.GetMembers().Where(members => members.Id == editMemberId).First();
            string firstName = textBoxFirstName.Text.Trim();
            string lastName = textBoxLastName.Text.Trim();
            string address = textBoxAddress.Text.Trim();
            string location = textBoxLocation.Text.Trim();
            DateTime dateOfBirth = dateTimePickerDateOfBirth.Value;
            string mobilePhone = textBoxMobilePhone.Text.Trim();
            string email = textBoxEmail.Text.Trim();
            DateTime dateOfEntry = dateTimePickerDateOfEntry.Value;
            int yearsOfExperience = textBoxYearsOfExperience.Text.Trim() != "" ? Convert.ToInt32(textBoxYearsOfExperience.Text) : 0;
            string memberGroup = comboBoxMemberGroup.SelectedItem.ToString();
            string status = comboBoxStatus.Text.Trim();
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
            member.MembershipFee = TransactionsHelper.GetMembershipFees().Where(fee => fee.Discount == checkBoxDiscount.Checked && fee.MemberGroup.Name == member.Group).First();
            MembersHelper.EditMember(member);
            MessageBox.Show("Uspešno su izmeni podaci o članu.", "Uspeh");
            LogHelper.PostLog(userName, "Izmenjeni podaci o članu: " + member.FirstName + " " + member.LastName);
            this.Close();
        }

        private void EditMemberForm_Load(object sender, EventArgs e)
        {
            List<MemberGroup> groups = MemberGroupsHelper.GetMemberGroups();
            foreach (MemberGroup group in groups)
            {
                comboBoxMemberGroup.Items.Add(group.Name);
            }
            if (editMemberId != 0)
            {
                groupBoxChoose.Enabled = false;
                Member member = MembersHelper.GetMembers().Where(members => members.Id == editMemberId).First();
                textBoxId.Text = member.Id.ToString();
                textBoxFirstName.Text = member.FirstName;
                textBoxLastName.Text = member.LastName;
                textBoxAddress.Text = member.Address;
                textBoxLocation.Text = member.Location;
                dateTimePickerDateOfBirth.Value = member.DateOfBirth;
                dateTimePickerDateOfEntry.Value = member.DateOfEntry;
                textBoxYearsOfExperience.Text = member.YearsOfExperience.ToString();
                comboBoxMemberGroup.SelectedItem = member.Group;
                comboBoxMemberGroup.Text = member.Group;
                textBoxMobilePhone.Text = member.MobilePhone;
                textBoxEmail.Text = member.Email;
                checkBoxDiscount.Checked = member.MembershipFee.Discount;
                comboBoxStatus.Text = member.Status;
                textBoxDebtAmount.Text = member.DebtAmount.ToString("0.00");
                textBoxReservations.Text = member.Reservations.Count > 0 ? string.Join(",", member.Reservations) : "";
            }
            else
            {
                List<Member> members = MembersHelper.GetMembers();
                foreach(Member member in members)
                {
                    comboBoxChoose.Items.Add("[" + member.Id.ToString() + "] " + member.FirstName + " " + member.LastName + " (" + member.Group + ")");
                }
                groupBoxChoose.TabIndex = 0;
                comboBoxChoose.TabIndex = 0;
                comboBoxChoose.Focus();
            }
        }

        private void comboBoxChoose_Leave(object sender, EventArgs e)
        {
            if(comboBoxChoose.Text=="Izaberite člana")
            {
                MessageBox.Show("Morate da izaberete člana!", "Greška");
                comboBoxChoose.Focus();
            }
        }

        private void textBoxFirstName_Leave(object sender, EventArgs e)
        {
            if (textBoxFirstName.Text.Trim() == "")
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

        private void comboBoxChoose_SelectedValueChanged(object sender, EventArgs e)
        {
            editMemberId = Convert.ToInt32(comboBoxChoose.SelectedItem.ToString().Substring(1, comboBoxChoose.SelectedItem.ToString().IndexOf("]") - 1));
            Member member = MembersHelper.GetMembers().Where(members => members.Id == editMemberId).First();
            textBoxId.Text = member.Id.ToString();
            textBoxFirstName.Text = member.FirstName;
            textBoxLastName.Text = member.LastName;
            textBoxAddress.Text = member.Address;
            textBoxLocation.Text = member.Location;
            dateTimePickerDateOfBirth.Value = member.DateOfBirth;
            dateTimePickerDateOfEntry.Value = member.DateOfEntry;
            textBoxYearsOfExperience.Text = member.YearsOfExperience.ToString();
            comboBoxMemberGroup.SelectedItem = member.Group;
            comboBoxMemberGroup.Text = member.Group;
            textBoxMobilePhone.Text = member.MobilePhone;
            textBoxEmail.Text = member.Email;
            checkBoxDiscount.Checked = member.MembershipFee.Discount;
            comboBoxStatus.Text = member.Status;
            textBoxDebtAmount.Text = member.DebtAmount.ToString("0.00");
            textBoxReservations.Text = member.Reservations.Count > 0 ? string.Join(",", member.Reservations) : "";
        }

        private void comboBoxStatus_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBoxStatus.Text.Trim() == "Izaberite status")
            {
                MessageBox.Show("Morate odabrati status člana!", "Greška");
                comboBoxStatus.Focus();
            }
        }
    }
}
