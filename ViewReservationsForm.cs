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
    public partial class ViewReservationsForm : Form
    {
        private string userName;
        public ViewReservationsForm(string userName)
        {
            this.userName = userName;
            InitializeComponent();
        }

        private void ViewReservationsForm_Load(object sender, EventArgs e)
        {
            List<Member> members = MembersHelper.GetMembers();
            foreach(Member member in members)
            {
                comboBoxMember.Items.Add("[" + member.Id.ToString() + "] " + member.FirstName + " " + member.LastName);
            }
            List<Reservation> reservations = ReservationsHelper.GetReservations();
            if(UsersHelper.GetUsers().Where(user => user.UserName == userName).First().UserName == "pregledač")
            {
                buttonDelete.Visible = false;
            }
            DataTable table = new DataTable();
            table.Columns.Add("Šifra");
            table.Columns.Add("Član");
            table.Columns.Add("Nošnja");
            table.Columns.Add("Datum i vreme");
            table.Columns.Add("Status");
            foreach(Reservation reservation in reservations)
            {
                List<int> reservedIds = new List<int>();
                foreach(Clothing clothing in reservation.ReservedClothings)
                {
                    reservedIds.Add(clothing.Id);
                }
                table.Rows.Add(reservation.Id.ToString(), reservation.Member.FirstName + " " + reservation.Member.LastName,
                    string.Join(",", reservedIds), reservation.ReservationDate.ToString("dd.MM.yyyy. HH:mm:ss"),
                    reservation.Status);
            }
            dataGridViewReservations.DataSource = table;
            dataGridViewReservations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewReservations.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            foreach (DataGridViewRow row in dataGridViewReservations.Rows)
            {
                if (row.Cells["Status"].Value.ToString() == "aktivna") row.DefaultCellStyle.BackColor = Color.LightGreen;
                else row.DefaultCellStyle.BackColor = Color.PaleVioletRed;
            }
        }

        private void comboBoxMember_SelectedValueChanged(object sender, EventArgs e)
        {
            List<Reservation> reservations = ReservationsHelper.GetReservations();
            if (checkBoxActive.Checked) reservations = reservations.Where(res => res.Status == "aktivna").ToList();
            if (comboBoxMember.Text != "Izaberite člana")
            {
                int id = Convert.ToInt32(comboBoxMember.Text.Substring(1, comboBoxMember.Text.IndexOf("]") - 1));
                reservations = reservations.Where(res => res.Member.Id == id).ToList();
            }
            DataTable table = new DataTable();
            table.Columns.Add("Šifra");
            table.Columns.Add("Član");
            table.Columns.Add("Nošnja");
            table.Columns.Add("Datum i vreme");
            table.Columns.Add("Status");
            foreach (Reservation reservation in reservations)
            {
                List<int> reservedIds = new List<int>();
                foreach (Clothing clothing in reservation.ReservedClothings)
                {
                    reservedIds.Add(clothing.Id);
                }
                table.Rows.Add(reservation.Id.ToString(), reservation.Member.FirstName + " " + reservation.Member.LastName,
                    string.Join(",", reservedIds), reservation.ReservationDate.ToString("dd.MM.yyyy. HH:mm:ss"),
                    reservation.Status);
            }
            dataGridViewReservations.DataSource = table;
            dataGridViewReservations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewReservations.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            foreach (DataGridViewRow row in dataGridViewReservations.Rows)
            {
                if (row.Cells["Status"].Value.ToString() == "aktivna") row.DefaultCellStyle.BackColor = Color.LightGreen;
                else row.DefaultCellStyle.BackColor = Color.PaleVioletRed;
            }
        }

        private void checkBoxActive_CheckedChanged(object sender, EventArgs e)
        {
            List<Reservation> reservations = ReservationsHelper.GetReservations();
            if (checkBoxActive.Checked) reservations = reservations.Where(res => res.Status == "aktivna").ToList();
            if (comboBoxMember.Text != "Izaberite člana")
            {
                int id = Convert.ToInt32(comboBoxMember.Text.Substring(1, comboBoxMember.Text.IndexOf("]") - 1));
                reservations = reservations.Where(res => res.Member.Id == id).ToList();
            }
            DataTable table = new DataTable();
            table.Columns.Add("Šifra");
            table.Columns.Add("Član");
            table.Columns.Add("Nošnja");
            table.Columns.Add("Datum i vreme");
            table.Columns.Add("Status");
            foreach (Reservation reservation in reservations)
            {
                List<int> reservedIds = new List<int>();
                foreach (Clothing clothing in reservation.ReservedClothings)
                {
                    reservedIds.Add(clothing.Id);
                }
                table.Rows.Add(reservation.Id.ToString(), reservation.Member.FirstName + " " + reservation.Member.LastName,
                    string.Join(",", reservedIds), reservation.ReservationDate.ToString("dd.MM.yyyy. HH:mm:ss"),
                    reservation.Status);
            }
            dataGridViewReservations.DataSource = table;
            dataGridViewReservations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewReservations.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            foreach (DataGridViewRow row in dataGridViewReservations.Rows)
            {
                if (row.Cells["Status"].Value.ToString() == "aktivna") row.DefaultCellStyle.BackColor = Color.LightGreen;
                else row.DefaultCellStyle.BackColor = Color.PaleVioletRed;
            }
        }

        private void dataGridViewReservations_Sorted(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewReservations.Rows)
            {
                if (row.Cells["Status"].Value.ToString() == "aktivna") row.DefaultCellStyle.BackColor = Color.LightGreen;
                else row.DefaultCellStyle.BackColor = Color.PaleVioletRed;
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            bool deletedSelected = false;
            for (int i = 0; i < dataGridViewReservations.SelectedRows.Count; i++)
            {
                if (dataGridViewReservations.SelectedRows[i].Cells["Status"].Value.ToString() == "obrisana")
                {
                    deletedSelected = true;
                    break;
                }
            }
            if (deletedSelected)
            {
                MessageBox.Show("Ne možete obrisati već obrisane rezervacije!", "Greška");
            }
            else if (dataGridViewReservations.SelectedRows.Count > 1)
            {
                DialogResult result = MessageBox.Show("Da li ste sigurni da želite da obrišete odabrane rezervacije?", "Brisanje rezervacija", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    for (int i = 0; i < dataGridViewReservations.SelectedRows.Count; i++)
                    {
                        int resId = Convert.ToInt32(dataGridViewReservations.SelectedRows[i].Cells[0].Value);
                        Reservation delReservation = ReservationsHelper.GetReservations().Where(res => res.Id == resId).First();
                        ReservationsHelper.DeleteReservation(delReservation);
                        LogHelper.PostLog(userName, "Obrisana rezervacija: [" + delReservation.Id + "]");
                    }
                    MessageBox.Show("Odabrane rezervacije su uspešno obrisane.", "Uspeh");
                    List<Reservation> reservations = ReservationsHelper.GetReservations();
                    if (checkBoxActive.Checked) reservations = reservations.Where(res => res.Status == "aktivna").ToList();
                    if (comboBoxMember.Text != "Izaberite člana")
                    {
                        int id = Convert.ToInt32(comboBoxMember.Text.Substring(1, comboBoxMember.Text.IndexOf("]") - 1));
                        reservations = reservations.Where(res => res.Member.Id == id).ToList();
                    }
                    DataTable table = new DataTable();
                    table.Columns.Add("Šifra");
                    table.Columns.Add("Član");
                    table.Columns.Add("Nošnja");
                    table.Columns.Add("Datum i vreme");
                    table.Columns.Add("Status");
                    foreach (Reservation reservation in reservations)
                    {
                        List<int> reservedIds = new List<int>();
                        foreach (Clothing clothing in reservation.ReservedClothings)
                        {
                            reservedIds.Add(clothing.Id);
                        }
                        table.Rows.Add(reservation.Id.ToString(), reservation.Member.FirstName + " " + reservation.Member.LastName,
                            string.Join(",", reservedIds), reservation.ReservationDate.ToString("dd.MM.yyyy. HH:mm:ss"),
                            reservation.Status);
                    }
                    dataGridViewReservations.DataSource = table;
                    dataGridViewReservations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    dataGridViewReservations.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                    foreach (DataGridViewRow row in dataGridViewReservations.Rows)
                    {
                        if (row.Cells["Status"].Value.ToString() == "aktivna") row.DefaultCellStyle.BackColor = Color.LightGreen;
                        else row.DefaultCellStyle.BackColor = Color.PaleVioletRed;
                    }
                }
            }
            else
            {
                DialogResult result = MessageBox.Show("Da li ste sigurni da želite da obrišete odabranu rezervaciju?", "Brisanje rezervacija", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    int resId = Convert.ToInt32(dataGridViewReservations.SelectedRows[0].Cells[0].Value);
                    Reservation delReservation = ReservationsHelper.GetReservations().Where(res => res.Id == resId).First();
                    ReservationsHelper.DeleteReservation(delReservation);
                    LogHelper.PostLog(userName, "Obrisana rezervacija: [" + delReservation.Id + "]");
                    MessageBox.Show("Odabrana rezervacija je uspešno obrisana.", "Uspeh");
                    List<Reservation> reservations = ReservationsHelper.GetReservations();
                    if (checkBoxActive.Checked) reservations = reservations.Where(res => res.Status == "aktivna").ToList();
                    if (comboBoxMember.Text != "Izaberite člana")
                    {
                        int id = Convert.ToInt32(comboBoxMember.Text.Substring(1, comboBoxMember.Text.IndexOf("]") - 1));
                        reservations = reservations.Where(res => res.Member.Id == id).ToList();
                    }
                    DataTable table = new DataTable();
                    table.Columns.Add("Šifra");
                    table.Columns.Add("Član");
                    table.Columns.Add("Nošnja");
                    table.Columns.Add("Datum i vreme");
                    table.Columns.Add("Status");
                    foreach (Reservation reservation in reservations)
                    {
                        List<int> reservedIds = new List<int>();
                        foreach (Clothing clothing in reservation.ReservedClothings)
                        {
                            reservedIds.Add(clothing.Id);
                        }
                        table.Rows.Add(reservation.Id.ToString(), reservation.Member.FirstName + " " + reservation.Member.LastName,
                            string.Join(",", reservedIds), reservation.ReservationDate.ToString("dd.MM.yyyy. HH:mm:ss"),
                            reservation.Status);
                    }
                    dataGridViewReservations.DataSource = table;
                    dataGridViewReservations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    dataGridViewReservations.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                    foreach (DataGridViewRow row in dataGridViewReservations.Rows)
                    {
                        if (row.Cells["Status"].Value.ToString() == "aktivna") row.DefaultCellStyle.BackColor = Color.LightGreen;
                        else row.DefaultCellStyle.BackColor = Color.PaleVioletRed;
                    }
                }
            }
        }
    }
}
