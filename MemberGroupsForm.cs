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
    public partial class MemberGroupsForm : Form
    {
        private string userName;
        public MemberGroupsForm(string userName)
        {
            this.userName = userName;
            InitializeComponent();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string search = textBoxSearch.Text;
            List<MemberGroup> memberGroups = MemberGroupsHelper.GetMemberGroups();
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add(new DataColumn("Naziv grupe članova"));
            dataTable.Columns.Add(new DataColumn("Broj članova grupe"));
            foreach(MemberGroup group in memberGroups)
            {
                if(group.Name.Contains(search))
                {
                    dataTable.Rows.Add(group.Name, group.Count);
                }
            }
            dataGridViewMemberGroups.DataSource = dataTable;
        }

        private void MemberGroupsForm_Load(object sender, EventArgs e)
        {
            List<MemberGroup> memberGroups = MemberGroupsHelper.GetMemberGroups();
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add(new DataColumn("Naziv grupe članova"));
            dataTable.Columns.Add(new DataColumn("Broj članova grupe"));
            foreach(MemberGroup group in memberGroups)
            {
                dataTable.Rows.Add(group.Name, group.Count);
            }
            dataGridViewMemberGroups.DataSource = dataTable;
            dataGridViewMemberGroups.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewMemberGroups.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewMemberGroups.AutoSize = true;
        }

        private void textBoxSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                string search = textBoxSearch.Text;
                List<MemberGroup> memberGroups = MemberGroupsHelper.GetMemberGroups();
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add(new DataColumn("Naziv grupe članova"));
                dataTable.Columns.Add(new DataColumn("Broj članova grupe"));
                foreach (MemberGroup group in memberGroups)
                {
                    if (group.Name.Contains(search))
                    {
                        dataTable.Rows.Add(group.Name, group.Count);
                    }
                }
                dataGridViewMemberGroups.DataSource = dataTable;
            }
        }
    }
}
