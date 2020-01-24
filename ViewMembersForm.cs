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
    public partial class ViewMembersForm : Form
    {
        private string userName;
        public ViewMembersForm(string userName)
        {
            this.userName = userName;
            InitializeComponent();
        }

        private void ViewMembersForm_Load(object sender, EventArgs e)
        {
            List<MemberGroup> groups = MemberGroupsHelper.GetMemberGroups();
            foreach(MemberGroup group in groups)
            {
                comboBoxMemberGroup.Items.Add(group.Name);
            }
            List<Member> members = MembersHelper.GetMembers();
            DataTable table = new DataTable();
            table.Columns.Add("ID");
            table.Columns.Add("Ime");
            table.Columns.Add("Prezime");
            table.Columns.Add("Adresa");
            table.Columns.Add("Mesto");
            table.Columns.Add("Telefon");
            table.Columns.Add("E-mail");
            table.Columns.Add("Datum rođenja");
            table.Columns.Add("Datum upisa");
            table.Columns.Add("Folklorna grupa");
            table.Columns.Add("Godine iskustva");
            table.Columns.Add("Broj meseci članstva");
            table.Columns.Add("Status");
            table.Columns.Add("Popust na članarinu");
            table.Columns.Add("Dugovanje");
            table.Columns.Add("Rezervacije");
            foreach(Member member in members)
            {
                string reservations = "";
                foreach(int reservation in member.Reservations)
                {
                    if (member.Reservations.Last().Equals(reservation)) reservations += reservation.ToString();
                    else reservations += reservation.ToString() + ",";
                }
                string discount = member.MembershipFee.Discount ? "da" : "ne";
                table.Rows.Add(member.Id.ToString(), member.FirstName, member.LastName, member.Address, member.Location,
                    member.MobilePhone, member.Email, member.DateOfBirth.ToString("dd.MM.yyyy."), member.DateOfEntry.ToString("dd.MM.yyyy."),
                    member.Group, member.YearsOfExperience.ToString(), member.MembershipMonths.ToString(), member.Status, discount, member.DebtAmount.ToString(), reservations);
            }
            dataGridViewMembers.DataSource = table;
            dataGridViewMembers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewMembers.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            foreach (DataGridViewRow row in dataGridViewMembers.Rows)
            {
                if (Convert.ToDouble(row.Cells["Dugovanje"].Value) > 2000.00) row.DefaultCellStyle.BackColor = Color.Yellow;
                if (row.Cells["Status"].Value.ToString() == "neaktivan") row.DefaultCellStyle.BackColor = Color.Red;
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string search = textBoxSearch.Text.Trim().ToLower();
            string memberGroup = comboBoxMemberGroup.Text != "Izaberite grupu" ? comboBoxMemberGroup.SelectedItem.ToString() : "";
            bool active = checkBoxActive.Checked;
            bool inactive = checkBoxInactive.Checked;
            List<Member> members = MembersHelper.GetMembers();
            DataTable table = new DataTable();
            table.Columns.Add("ID");
            table.Columns.Add("Ime");
            table.Columns.Add("Prezime");
            table.Columns.Add("Adresa");
            table.Columns.Add("Mesto");
            table.Columns.Add("Telefon");
            table.Columns.Add("E-mail");
            table.Columns.Add("Datum rođenja");
            table.Columns.Add("Datum upisa");
            table.Columns.Add("Folklorna grupa");
            table.Columns.Add("Godine iskustva");
            table.Columns.Add("Broj meseci članstva");
            table.Columns.Add("Status");
            table.Columns.Add("Popust na članarinu");
            table.Columns.Add("Dugovanje");
            table.Columns.Add("Rezervacije");
            if (search != "")
            {
                members = members.Where(member => String.Join(" ", member.FirstName, member.LastName).ToLower().Contains(search)).ToList();
            }
            if (memberGroup != "")
            {
                members = members.Where(member => member.Group == memberGroup).ToList();
            }
            if (active && !inactive)
            {
                members = members.Where(member => member.Status == "aktivan").ToList();
            }
            if (!active && inactive)
            {
                members = members.Where(member => member.Status == "neaktivan").ToList();
            }
            foreach (Member member in members)
            {
                string reservations = "";
                foreach (int reservation in member.Reservations)
                {
                    if (member.Reservations.Last().Equals(reservation)) reservations += reservation.ToString();
                    else reservations += reservation.ToString() + ",";
                }
                string discount = member.MembershipFee.Discount ? "da" : "ne";
                table.Rows.Add(member.Id.ToString(), member.FirstName, member.LastName, member.Address, member.Location,
                   member.MobilePhone, member.Email, member.DateOfBirth.ToString("dd.MM.yyyy."), member.DateOfEntry.ToString("dd.MM.yyyy."),
                   member.Group, member.YearsOfExperience.ToString(), member.MembershipMonths.ToString(), member.Status, discount, member.DebtAmount.ToString(), reservations);
            }
            dataGridViewMembers.DataSource = table;
            foreach (DataGridViewRow row in dataGridViewMembers.Rows)
            {
                if (Convert.ToDouble(row.Cells["Dugovanje"].Value) > 2000.00) row.DefaultCellStyle.BackColor = Color.Yellow;
                if (row.Cells["Status"].Value.ToString() == "neaktivan") row.DefaultCellStyle.BackColor = Color.Red; 
            }
        }

        private void comboBoxMemberGroup_SelectedValueChanged(object sender, EventArgs e)
        {
            string search = textBoxSearch.Text.Trim().ToLower();
             string memberGroup = comboBoxMemberGroup.Text != "Izaberite grupu" ? comboBoxMemberGroup.SelectedItem.ToString() : "";
            bool active = checkBoxActive.Checked;
            bool inactive = checkBoxInactive.Checked;
            List<Member> members = MembersHelper.GetMembers();
            DataTable table = new DataTable();
            table.Columns.Add("ID");
            table.Columns.Add("Ime");
            table.Columns.Add("Prezime");
            table.Columns.Add("Adresa");
            table.Columns.Add("Mesto");
            table.Columns.Add("Telefon");
            table.Columns.Add("E-mail");
            table.Columns.Add("Datum rođenja");
            table.Columns.Add("Datum upisa");
            table.Columns.Add("Folklorna grupa");
            table.Columns.Add("Godine iskustva");
            table.Columns.Add("Broj meseci članstva");
            table.Columns.Add("Status");
            table.Columns.Add("Popust na članarinu");
            table.Columns.Add("Dugovanje");
            table.Columns.Add("Rezervacije");
            if (search != "")
            {
                members = members.Where(member => String.Join(" ", member.FirstName, member.LastName).ToLower().Contains(search)).ToList();
            }
            if (memberGroup != "")
            {
                members = members.Where(member => member.Group == memberGroup).ToList();
            }
            if (active && !inactive)
            {
                members = members.Where(member => member.Status == "aktivan").ToList();
            }
            if (!active && inactive)
            {
                members = members.Where(member => member.Status == "neaktivan").ToList();
            }
            foreach (Member member in members)
            {
                string reservations = "";
                foreach (int reservation in member.Reservations)
                {
                    if (member.Reservations.Last().Equals(reservation)) reservations += reservation.ToString();
                    else reservations += reservation.ToString() + ",";
                }
                string discount = member.MembershipFee.Discount ? "da" : "ne";
                table.Rows.Add(member.Id.ToString(), member.FirstName, member.LastName, member.Address, member.Location,
                   member.MobilePhone, member.Email, member.DateOfBirth.ToString("dd.MM.yyyy."), member.DateOfEntry.ToString("dd.MM.yyyy."),
                   member.Group, member.YearsOfExperience.ToString(), member.MembershipMonths.ToString(), member.Status, discount, member.DebtAmount.ToString(), reservations);
            }
            dataGridViewMembers.DataSource = table;
            foreach (DataGridViewRow row in dataGridViewMembers.Rows)
            {
                if (Convert.ToDouble(row.Cells["Dugovanje"].Value) > 2000.00) row.DefaultCellStyle.BackColor = Color.Yellow;
                if (row.Cells["Status"].Value.ToString() == "neaktivan") row.DefaultCellStyle.BackColor = Color.Red;
            }
        }

        private void checkBoxActive_CheckedChanged(object sender, EventArgs e)
        {
            string search = textBoxSearch.Text.Trim().ToLower();
            string memberGroup = comboBoxMemberGroup.Text != "Izaberite grupu" ? comboBoxMemberGroup.SelectedItem.ToString() : "";
            bool active = checkBoxActive.Checked;
            bool inactive = checkBoxInactive.Checked;
            List<Member> members = MembersHelper.GetMembers();
            DataTable table = new DataTable();
            table.Columns.Add("ID");
            table.Columns.Add("Ime");
            table.Columns.Add("Prezime");
            table.Columns.Add("Adresa");
            table.Columns.Add("Mesto");
            table.Columns.Add("Telefon");
            table.Columns.Add("E-mail");
            table.Columns.Add("Datum rođenja");
            table.Columns.Add("Datum upisa");
            table.Columns.Add("Folklorna grupa");
            table.Columns.Add("Godine iskustva");
            table.Columns.Add("Broj meseci članstva");
            table.Columns.Add("Status");
            table.Columns.Add("Popust na članarinu");
            table.Columns.Add("Dugovanje");
            table.Columns.Add("Rezervacije");
            if (search != "")
            {
                members = members.Where(member => String.Join(" ", member.FirstName, member.LastName).ToLower().Contains(search)).ToList();
            }
            if (memberGroup != "")
            {
                members = members.Where(member => member.Group == memberGroup).ToList();
            }
            if (active && !inactive)
            {
                members = members.Where(member => member.Status == "aktivan").ToList();
            }
            if (!active && inactive)
            {
                members = members.Where(member => member.Status == "neaktivan").ToList();
            }
            foreach (Member member in members)
            {
                string reservations = "";
                foreach (int reservation in member.Reservations)
                {
                    if (member.Reservations.Last().Equals(reservation)) reservations += reservation.ToString();
                    else reservations += reservation.ToString() + ",";
                }
                string discount = member.MembershipFee.Discount ? "da" : "ne";
                table.Rows.Add(member.Id.ToString(), member.FirstName, member.LastName, member.Address, member.Location,
                   member.MobilePhone, member.Email, member.DateOfBirth.ToString("dd.MM.yyyy."), member.DateOfEntry.ToString("dd.MM.yyyy."),
                   member.Group, member.YearsOfExperience.ToString(), member.MembershipMonths.ToString(), member.Status, discount, member.DebtAmount.ToString(), reservations);
            }
            dataGridViewMembers.DataSource = table;
            foreach (DataGridViewRow row in dataGridViewMembers.Rows)
            {
                if (Convert.ToDouble(row.Cells["Dugovanje"].Value) > 2000.00) row.DefaultCellStyle.BackColor = Color.Yellow;
                if (row.Cells["Status"].Value.ToString() == "neaktivan") row.DefaultCellStyle.BackColor = Color.Red;
            }
        }

        private void checkBoxInactive_CheckedChanged(object sender, EventArgs e)
        {
            string search = textBoxSearch.Text.Trim().ToLower();
            string memberGroup = comboBoxMemberGroup.Text != "Izaberite grupu" ? comboBoxMemberGroup.SelectedItem.ToString() : "";
            bool active = checkBoxActive.Checked;
            bool inactive = checkBoxInactive.Checked;
            List<Member> members = MembersHelper.GetMembers();
            DataTable table = new DataTable();
            table.Columns.Add("ID");
            table.Columns.Add("Ime");
            table.Columns.Add("Prezime");
            table.Columns.Add("Adresa");
            table.Columns.Add("Mesto");
            table.Columns.Add("Telefon");
            table.Columns.Add("E-mail");
            table.Columns.Add("Datum rođenja");
            table.Columns.Add("Datum upisa");
            table.Columns.Add("Folklorna grupa");
            table.Columns.Add("Godine iskustva");
            table.Columns.Add("Broj meseci članstva");
            table.Columns.Add("Status");
            table.Columns.Add("Popust na članarinu");
            table.Columns.Add("Dugovanje");
            table.Columns.Add("Rezervacije");
            if (search != "")
            {
                members = members.Where(member => String.Join(" ", member.FirstName, member.LastName).ToLower().Contains(search)).ToList();
            }
            if (memberGroup != "")
            {
                members = members.Where(member => member.Group == memberGroup).ToList();
            }
            if (active && !inactive)
            {
                members = members.Where(member => member.Status == "aktivan").ToList();
            }
            if (!active && inactive)
            {
                members = members.Where(member => member.Status == "neaktivan").ToList();
            }
            foreach (Member member in members)
            {
                string reservations = "";
                foreach (int reservation in member.Reservations)
                {
                    if (member.Reservations.Last().Equals(reservation)) reservations += reservation.ToString();
                    else reservations += reservation.ToString() + ",";
                }
                string discount = member.MembershipFee.Discount ? "da" : "ne";
                table.Rows.Add(member.Id.ToString(), member.FirstName, member.LastName, member.Address, member.Location,
                   member.MobilePhone, member.Email, member.DateOfBirth.ToString("dd.MM.yyyy."), member.DateOfEntry.ToString("dd.MM.yyyy."),
                   member.Group, member.YearsOfExperience.ToString(), member.MembershipMonths.ToString(), member.Status, discount, member.DebtAmount.ToString(), reservations);
            }
            dataGridViewMembers.DataSource = table;
            foreach (DataGridViewRow row in dataGridViewMembers.Rows)
            {
                if (Convert.ToDouble(row.Cells["Dugovanje"].Value) > 2000.00) row.DefaultCellStyle.BackColor = Color.Yellow;
                if (row.Cells["Status"].Value.ToString() == "neaktivan") row.DefaultCellStyle.BackColor = Color.Red;
            }
        }

        private void textBoxSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                string search = textBoxSearch.Text.Trim().ToLower();
                string memberGroup = comboBoxMemberGroup.Text != "Izaberite grupu" ? comboBoxMemberGroup.SelectedItem.ToString() : "";
                bool active = checkBoxActive.Checked;
                bool inactive = checkBoxInactive.Checked;
                List<Member> members = MembersHelper.GetMembers();
                DataTable table = new DataTable();
                table.Columns.Add("ID");
                table.Columns.Add("Ime");
                table.Columns.Add("Prezime");
                table.Columns.Add("Adresa");
                table.Columns.Add("Mesto");
                table.Columns.Add("Telefon");
                table.Columns.Add("E-mail");
                table.Columns.Add("Datum rođenja");
                table.Columns.Add("Datum upisa");
                table.Columns.Add("Folklorna grupa");
                table.Columns.Add("Godine iskustva");
                table.Columns.Add("Broj meseci članstva");
                table.Columns.Add("Status");
                table.Columns.Add("Popust na članarinu");
                table.Columns.Add("Dugovanje");
                table.Columns.Add("Rezervacije");
                if (search != "")
                {
                    members = members.Where(member => String.Join(" ", member.FirstName, member.LastName).ToLower().Contains(search)).ToList();
                }
                if (memberGroup != "")
                {
                    members = members.Where(member => member.Group == memberGroup).ToList();
                }
                if (active && !inactive)
                {
                    members = members.Where(member => member.Status == "aktivan").ToList();
                }
                if (!active && inactive)
                {
                    members = members.Where(member => member.Status == "neaktivan").ToList();
                }
                foreach (Member member in members)
                {
                    string reservations = "";
                    foreach (int reservation in member.Reservations)
                    {
                        if (member.Reservations.Last().Equals(reservation)) reservations += reservation.ToString();
                        else reservations += reservation.ToString() + ",";
                    }
                    string discount = member.MembershipFee.Discount ? "da" : "ne";
                    table.Rows.Add(member.Id.ToString(), member.FirstName, member.LastName, member.Address, member.Location,
                       member.MobilePhone, member.Email, member.DateOfBirth.ToString("dd.MM.yyyy."), member.DateOfEntry.ToString("dd.MM.yyyy."),
                       member.Group, member.YearsOfExperience.ToString(), member.MembershipMonths.ToString(), member.Status, discount, member.DebtAmount.ToString(), reservations);
                }
                dataGridViewMembers.DataSource = table;
                foreach (DataGridViewRow row in dataGridViewMembers.Rows)
                {
                    if (Convert.ToDouble(row.Cells["Dugovanje"].Value) > 2000.00) row.DefaultCellStyle.BackColor = Color.Yellow;
                    if (row.Cells["Status"].Value.ToString() == "neaktivan") row.DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }

        private void dataGridViewMembers_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int editMemberId = Convert.ToInt32(dataGridViewMembers.SelectedRows[0].Cells["ID"].Value.ToString());
            EditMemberForm editMember = new EditMemberForm(userName, editMemberId);
            editMember.ShowDialog();
        }
    }
}
