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
    public partial class ViewLogsForm : Form
    {
        public ViewLogsForm()
        {
            InitializeComponent();
        }

        private void ViewLogsForm_Load(object sender, EventArgs e)
        {
            List<User> users = UsersHelper.GetUsers();
            List<Log> logs = LogHelper.GetLogs();
            foreach(User user in users)
            {
                comboBoxUser.Items.Add("[" + user.UserName + "] " + user.FirstName + " " + user.LastName);
            }
            DataTable table = new DataTable();
            table.Columns.Add("Korisnik");
            table.Columns.Add("Datum i vreme");
            table.Columns.Add("Aktivnost");
            foreach(Log log in logs)
            {
                table.Rows.Add(log.UserName, log.DateTime.ToString("dd.MM.yyyy. HH:mm:ss"), log.Activity);
            }
            dataGridViewLogs.DataSource = table;
            dataGridViewLogs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewLogs.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void comboBoxUser_SelectedValueChanged(object sender, EventArgs e)
        {
            List<Log> logs = LogHelper.GetLogs();
            if(comboBoxUser.Text != "Izaberite korisnika")
            {
                string userName = comboBoxUser.Text.Substring(1, comboBoxUser.Text.IndexOf("]") - 1);
                logs = logs.Where(log => log.UserName == userName).ToList();
            }
            if (textBoxActivity.Text.Trim() != "")
            {
                logs = logs.Where(log => log.Activity.ToLower().Contains(textBoxActivity.Text.ToLower().Trim())).ToList();
            }
            logs = logs.Where(log => log.DateTime >= dateTimePickerDateFrom.Value && log.DateTime <= dateTimePickerDateTo.Value).ToList();
            DataTable table = new DataTable();
            table.Columns.Add("Korisnik");
            table.Columns.Add("Datum i vreme");
            table.Columns.Add("Aktivnost");
            foreach (Log log in logs)
            {
                table.Rows.Add(log.UserName, log.DateTime.ToString("dd.MM.yyyy. HH:mm:ss"), log.Activity);
            }
            dataGridViewLogs.DataSource = table;
            dataGridViewLogs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewLogs.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void textBoxActivity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(Convert.ToInt32(e.KeyChar) == 13)
            {
                List<Log> logs = LogHelper.GetLogs();
                if (comboBoxUser.Text != "Izaberite korisnika")
                {
                    string userName = comboBoxUser.Text.Substring(1, comboBoxUser.Text.IndexOf("]") - 1);
                    logs = logs.Where(log => log.UserName == userName).ToList();
                }
                if (textBoxActivity.Text.Trim() != "")
                {
                    logs = logs.Where(log => log.Activity.ToLower().Contains(textBoxActivity.Text.ToLower().Trim())).ToList();
                }
                logs = logs.Where(log => log.DateTime >= dateTimePickerDateFrom.Value && log.DateTime <= dateTimePickerDateTo.Value).ToList();
                DataTable table = new DataTable();
                table.Columns.Add("Korisnik");
                table.Columns.Add("Datum i vreme");
                table.Columns.Add("Aktivnost");
                foreach (Log log in logs)
                {
                    table.Rows.Add(log.UserName, log.DateTime.ToString("dd.MM.yyyy. HH:mm:ss"), log.Activity);
                }
                dataGridViewLogs.DataSource = table;
                dataGridViewLogs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewLogs.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            }
        }

        private void dateTimePickerDateFrom_ValueChanged(object sender, EventArgs e)
        {
            List<Log> logs = LogHelper.GetLogs();
            if (comboBoxUser.Text != "Izaberite korisnika")
            {
                string userName = comboBoxUser.Text.Substring(1, comboBoxUser.Text.IndexOf("]") - 1);
                logs = logs.Where(log => log.UserName == userName).ToList();
            }
            if (textBoxActivity.Text.Trim() != "")
            {
                logs = logs.Where(log => log.Activity.ToLower().Contains(textBoxActivity.Text.ToLower().Trim())).ToList();
            }
            logs = logs.Where(log => log.DateTime >= dateTimePickerDateFrom.Value && log.DateTime <= dateTimePickerDateTo.Value).ToList();
            DataTable table = new DataTable();
            table.Columns.Add("Korisnik");
            table.Columns.Add("Datum i vreme");
            table.Columns.Add("Aktivnost");
            foreach (Log log in logs)
            {
                table.Rows.Add(log.UserName, log.DateTime.ToString("dd.MM.yyyy. HH:mm:ss"), log.Activity);
            }
            dataGridViewLogs.DataSource = table;
            dataGridViewLogs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewLogs.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void dateTimePickerDateTo_ValueChanged(object sender, EventArgs e)
        {
            List<Log> logs = LogHelper.GetLogs();
            if (comboBoxUser.Text != "Izaberite korisnika")
            {
                string userName = comboBoxUser.Text.Substring(1, comboBoxUser.Text.IndexOf("]") - 1);
                logs = logs.Where(log => log.UserName == userName).ToList();
            }
            if (textBoxActivity.Text.Trim() != "")
            {
                logs = logs.Where(log => log.Activity.ToLower().Contains(textBoxActivity.Text.ToLower().Trim())).ToList();
            }
            logs = logs.Where(log => log.DateTime >= dateTimePickerDateFrom.Value && log.DateTime <= dateTimePickerDateTo.Value).ToList();
            DataTable table = new DataTable();
            table.Columns.Add("Korisnik");
            table.Columns.Add("Datum i vreme");
            table.Columns.Add("Aktivnost");
            foreach (Log log in logs)
            {
                table.Rows.Add(log.UserName, log.DateTime.ToString("dd.MM.yyyy. HH:mm:ss"), log.Activity);
            }
            dataGridViewLogs.DataSource = table;
            dataGridViewLogs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewLogs.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }
    }
}
