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
    public partial class NewReservationForm : Form
    {
        private string userName;
        public NewReservationForm(string userName)
        {
            this.userName = userName;
            InitializeComponent();
        }

        private void NewReservationForm_Load(object sender, EventArgs e)
        {
            List<Member> members = MembersHelper.GetMembers();
            List<Clothing> clothingsAvailable = ClothingsHelper.GetClothings().Where(clothing => clothing.Reserved == false).ToList();
            foreach(Member member in members)
            {
                comboBoxMember.Items.Add("[" + member.Id.ToString() + "] " + member.FirstName + " " + member.LastName);
            }
            foreach(Clothing clothing in clothingsAvailable)
            {
                string item = "";
                item += "[" + clothing.Id.ToString() + "] ";
                item += clothing.Kind + " ";
                item += clothing.Region + " ";
                item += clothing.Gender == ClothingGender.Male ? "muški " : "ženski ";
                item += clothing.Age == ClothingAge.Adult ? "odrasli " : "deca ";
                item += clothing.Size;
                listBoxAvailable.Items.Add(item);
            }
            listBoxSelected.Items.Clear();
        }

        private void textBoxSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(Convert.ToInt32(e.KeyChar) == 13)
            {
                string search = textBoxSearch.Text.Trim().ToLower();
                listBoxAvailable.Items.Clear();
                List<Clothing> clothingsAvailable = ClothingsHelper.GetClothings().Where(clothing => clothing.Reserved == false).ToList();
                string gender = search == "muški" ? "Male" : search == "ženski" ? "Female" : search;
                string age = search == "odrasli" ? "Adult" : search == "deca" ? "Child" : search;
                clothingsAvailable = clothingsAvailable.Where(clothing => clothing.Id.ToString() == search ||
                    clothing.Kind.ToLower().Contains(search) ||
                    clothing.Region.ToLower().Contains(search) ||
                    clothing.Gender.ToString().Equals(gender) ||
                    clothing.Age.ToString().Equals(age) ||
                    clothing.Size.ToString().ToLower().Equals(search)).ToList();
                foreach (Clothing clothing in clothingsAvailable)
                {
                    string item = "";
                    item += "[" + clothing.Id.ToString() + "] ";
                    item += clothing.Kind + " ";
                    item += clothing.Region + " ";
                    item += clothing.Gender == ClothingGender.Male ? "muški " : "ženski ";
                    item += clothing.Age == ClothingAge.Adult ? "odrasli " : "deca ";
                    item += clothing.Size;
                    listBoxAvailable.Items.Add(item);
                }
                listBoxSelected.Items.Clear();
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            foreach(var item in listBoxAvailable.SelectedItems)
            {
                if (!listBoxSelected.Items.Contains(item)) listBoxSelected.Items.Add(item);
            }
        }

        private void buttonAddAll_Click(object sender, EventArgs e)
        {
            foreach(var item in listBoxAvailable.Items)
            {
                if (!listBoxSelected.Items.Contains(item)) listBoxSelected.Items.Add(item);
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            var items = listBoxSelected.SelectedItems;
            while (items.Count > 0)
            {
                listBoxSelected.Items.Remove(items[0]);
            }
            listBoxSelected.Refresh();
        }

        private void buttonRemoveAll_Click(object sender, EventArgs e)
        {
            var items = listBoxSelected.Items;
            while (items.Count > 0)
            {
                listBoxSelected.Items.Remove(items[0]);
            }
            listBoxSelected.Refresh();
        }

        private void buttonReserve_Click(object sender, EventArgs e)
        {
            if (comboBoxMember.Text == "Izaberite člana")
            {
                MessageBox.Show("Morate da izaberete člana!", "Greška");
                comboBoxMember.Focus();
            }
            else if (listBoxSelected.Items.Count == 0)
            {
                MessageBox.Show("Morate da izaberete nošnju!", "Greška");
                listBoxAvailable.Focus();
            }
            else
            {
                int id = Convert.ToInt32(comboBoxMember.Text.Substring(1, comboBoxMember.Text.IndexOf("]") - 1));
                Member member = MembersHelper.GetMembers().Where(member1 => member1.Id == id).First();
                Reservation reservation = new Reservation();
                reservation.Member = member;
                reservation.ReservedClothings = new List<Clothing>();
                foreach (var item in listBoxSelected.Items)
                {
                    int clothingId = Convert.ToInt32(item.ToString().Substring(1, item.ToString().IndexOf("]") - 1));
                    reservation.ReservedClothings.Add(ClothingsHelper.GetClothings().Where(clothing => clothing.Id == clothingId).First());
                }
                ReservationsHelper.PostReservation(reservation);
                LogHelper.PostLog(userName, "Dodata rezervacija [" + reservation.Id.ToString() + "] članu " + member.FirstName + " " + member.LastName);
                MessageBox.Show("Uspešno rezervisana nošnja za člana: " + member.FirstName + " " + member.LastName + ".", "Uspeh");
                listBoxAvailable.Items.Clear();
                textBoxSearch.Clear();
                List<Clothing> clothingsAvailable = ClothingsHelper.GetClothings().Where(clothing => clothing.Reserved == false).ToList();
                foreach (Clothing clothing in clothingsAvailable)
                {
                    string item = "";
                    item += "[" + clothing.Id.ToString() + "] ";
                    item += clothing.Kind + " ";
                    item += clothing.Region + " ";
                    item += clothing.Gender == ClothingGender.Male ? "muški " : "ženski ";
                    item += clothing.Age == ClothingAge.Adult ? "odrasli " : "deca ";
                    item += clothing.Size;
                    listBoxAvailable.Items.Add(item);
                }
                listBoxSelected.Items.Clear();
            }
        }
    }
}
