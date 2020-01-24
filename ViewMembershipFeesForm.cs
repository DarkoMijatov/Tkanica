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
using Tkanica.Classes;

namespace Tkanica
{
    public partial class ViewMembershipFeesForm : Form
    {
        public string userName;
        public ViewMembershipFeesForm(string userName)
        {
            this.userName = userName;
            InitializeComponent();
        }

        private void ViewMembershipFees_Load(object sender, EventArgs e)
        {
            if(UsersHelper.GetUsers().Where(user => user.UserName == userName).First().UserType == "pregledač")
            {
                buttonDelete.Visible = false;
            }
            List<MembershipFee> fees = TransactionsHelper.GetMembershipFees();
            DataTable table = new DataTable();
            table.Columns.Add("ID");
            table.Columns.Add("Folklorna grupa");
            table.Columns.Add("Popust");
            table.Columns.Add("Iznos");
            foreach(MembershipFee fee in fees)
            {
                string discount = fee.Discount ? "da" : "ne";
                table.Rows.Add(fee.Id.ToString(), fee.MemberGroup.Name, discount, fee.Amount.ToString());
            }
            dataGridViewMembershipFees.DataSource = table;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Da li ste sigurni da želite da obrišete odabranu članarinu?", "Potvrda", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                MembershipFee delFee = TransactionsHelper.GetMembershipFees().Where(f => f.Id == Convert.ToInt32(dataGridViewMembershipFees.SelectedRows[0].Cells[0].Value)).First();
                if (TransactionsHelper.GetMembershipFees().Where(f => f.MemberGroup == delFee.MemberGroup).Count() < 2)
                {
                    MessageBox.Show("Ne možete obrisati članarinu koja nema odgovarajuću zamenu!", "Greška");
                }
                else
                {
                    TransactionsHelper.DeleteMembershipFee(delFee);
                    List<Member> members = MembersHelper.GetMembers().Where(member => member.MembershipFee.Id == delFee.Id).ToList();
                    MembershipFee newFee = TransactionsHelper.GetMembershipFees().Where(f => f.MemberGroup == delFee.MemberGroup).First();
                    foreach (Member member in members)
                    {
                        member.MembershipFee = newFee;
                        MembersHelper.EditMember(member);
                        LogHelper.PostLog(userName, "Izmenjena članarina za korisnika " + member.FirstName + " " + member.LastName + ": " + newFee.MemberGroup + " " + newFee.Amount.ToString());
                    }
                    LogHelper.PostLog(userName, "Obrisana članarina: " + delFee.MemberGroup.Name + " " + delFee.Amount.ToString());
                    MessageBox.Show("Odabrana članarina je uspešno obrisana.", "Uspeh");
                    List<MembershipFee> fees = TransactionsHelper.GetMembershipFees();
                    DataTable table = new DataTable();
                    table.Columns.Add("ID");
                    table.Columns.Add("Folklorna grupa");
                    table.Columns.Add("Popust");
                    table.Columns.Add("Iznos");
                    foreach (MembershipFee fee in fees)
                    {
                        string discount = fee.Discount ? "da" : "ne";
                        table.Rows.Add(fee.Id.ToString(), fee.MemberGroup.Name, discount, fee.Amount.ToString());
                    }
                    dataGridViewMembershipFees.DataSource = table;
                }
            }
        }

        private void dataGridViewMembershipFees_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MembershipFee fee = TransactionsHelper.GetMembershipFees().Where(f => f.Id == Convert.ToInt32(dataGridViewMembershipFees.SelectedRows[0].Cells[0].Value)).First();
            EditMembershipFeeForm editMembershipFee = new EditMembershipFeeForm(userName, fee.Id);
            editMembershipFee.ShowDialog();
        }
    }
}
