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
    public partial class ViewUsersForm : Form
    {
        private string userName;
        public ViewUsersForm(string userName)
        {
            this.userName = userName;
            InitializeComponent();
        }

        private void ViewUsersForm_Load(object sender, EventArgs e)
        {
            List<User> users = UsersHelper.GetUsers();
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add(new DataColumn("Korisničko ime"));
            dataTable.Columns.Add(new DataColumn("Ime korisnika"));
            dataTable.Columns.Add(new DataColumn("Prezime korisnika"));
            dataTable.Columns.Add(new DataColumn("Tip korisnika"));
            dataTable.Columns.Add(new DataColumn("Datum registracije"));
            foreach(User user in users)
            {
                dataTable.Rows.Add(user.UserName, user.FirstName, user.LastName, user.UserType, user.DateCreated.ToString("dd.MM.yyyy."));
            }
            dataGridViewUsers.DataSource = dataTable;
            dataGridViewUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewUsers.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewUsers.AutoSize = true;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string search = textBoxSearch.Text;
            List<User> users = UsersHelper.GetUsers();
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add(new DataColumn("Korisničko ime"));
            dataTable.Columns.Add(new DataColumn("Ime korisnika"));
            dataTable.Columns.Add(new DataColumn("Prezime korisnika"));
            dataTable.Columns.Add(new DataColumn("Tip korisnika"));
            dataTable.Columns.Add(new DataColumn("Datum registracije"));
            foreach(User user in users)
            {
                if(user.UserName.Contains(search) || user.FirstName.Contains(search) || user.LastName.Contains(search) || user.UserType.Contains(search))
                {
                    dataTable.Rows.Add(user.UserName, user.FirstName, user.LastName, user.UserType, user.DateCreated.ToString("dd.MM.yyyy."));
                }
            }
            dataGridViewUsers.DataSource = dataTable;
        }

        private void textBoxSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                string search = textBoxSearch.Text;
                List<User> users = UsersHelper.GetUsers();
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add(new DataColumn("Korisničko ime"));
                dataTable.Columns.Add(new DataColumn("Ime korisnika"));
                dataTable.Columns.Add(new DataColumn("Prezime korisnika"));
                dataTable.Columns.Add(new DataColumn("Tip korisnika"));
                dataTable.Columns.Add(new DataColumn("Datum registracije"));
                foreach (User user in users)
                {
                    if (user.UserName.Contains(search) || user.FirstName.Contains(search) || user.LastName.Contains(search) || user.UserType.Contains(search))
                    {
                        dataTable.Rows.Add(user.UserName, user.FirstName, user.LastName, user.UserType, user.DateCreated.ToString("dd.MM.yyyy."));
                    }
                }
                dataGridViewUsers.DataSource = dataTable;
            }
        }
    }
}
