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
    public partial class ViewClothingsForm : Form
    {
        public ViewClothingsForm()
        {
            InitializeComponent();
        }

        private void ViewClothingsForm_Load(object sender, EventArgs e)
        {
            List<string> clothingKinds = ClothingsHelper.GetClothingKinds();
            foreach(string kind in clothingKinds)
            {
                comboBoxKind.Items.Add(kind);
            }
            List<Clothing> clothings = ClothingsHelper.GetClothings();
            DataTable table = new DataTable();
            table.Columns.Add("Šifra");
            table.Columns.Add("Vrsta");
            table.Columns.Add("Oblast");
            table.Columns.Add("Pol");
            table.Columns.Add("Uzrast");
            table.Columns.Add("Veličina");
            table.Columns.Add("Rezervisano");
            foreach(Clothing clothing in clothings)
            {
                string gender, age, reserved;
                if (clothing.Gender == ClothingGender.Male) gender = "muški";
                else gender = "ženski";
                if (clothing.Age == ClothingAge.Adult) age = "odrasli";
                else age = "deca";
                if (clothing.Reserved) reserved = "da";
                else reserved = "ne";
                table.Rows.Add(clothing.Id.ToString(), clothing.Kind, clothing.Region, gender, age, clothing.Size, reserved);
            }
            dataGridViewClothings.DataSource = table;
            dataGridViewClothings.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewClothings.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            foreach (DataGridViewRow row in dataGridViewClothings.Rows)
            {
                if (row.Cells["Rezervisano"].Value.ToString().Equals("da")) row.DefaultCellStyle.BackColor = Color.PaleVioletRed;
                else row.DefaultCellStyle.BackColor = Color.LightGreen;
            }
        }

        private void comboBoxKind_SelectedValueChanged(object sender, EventArgs e)
        {
            string id = textBoxId.Text.Trim();
            string kind = comboBoxKind.Text == "Izaberite vrstu" ? "" : comboBoxKind.Text;
            string region = textBoxRegion.Text.Trim();
            string genderSearch = comboBoxGender.Text == "Izaberite pol" ? "" : comboBoxGender.Text;
            string ageSearch = comboBoxAge.Text == "Izaberite uzrast" ? "" : comboBoxAge.Text;
            bool reservedSearch = checkBoxReserved.Checked;
            List<Clothing> clothings = ClothingsHelper.GetClothings();
            DataTable table = new DataTable();
            table.Columns.Add("Šifra");
            table.Columns.Add("Vrsta");
            table.Columns.Add("Oblast");
            table.Columns.Add("Pol");
            table.Columns.Add("Uzrast");
            table.Columns.Add("Veličina");
            table.Columns.Add("Rezervisano");
            if (id != "") clothings = clothings.Where(clothing => clothing.Id == Convert.ToInt32(id)).ToList();
            if (kind != "") clothings = clothings.Where(clothing => clothing.Kind.ToLower() == kind.ToLower()).ToList();
            if (region != "") clothings = clothings.Where(clothing => clothing.Region.ToLower() == region.ToLower()).ToList();
            if (genderSearch.Contains("m")) clothings = clothings.Where(clothing => clothing.Gender == ClothingGender.Male).ToList();
            if (genderSearch.Contains("ž")) clothings = clothings.Where(clothing => clothing.Gender == ClothingGender.Female).ToList();
            if (ageSearch.Contains("o")) clothings = clothings.Where(clothing => clothing.Age == ClothingAge.Adult).ToList();
            if (ageSearch.Contains("c")) clothings = clothings.Where(clothing => clothing.Age == ClothingAge.Child).ToList();
            if (reservedSearch) clothings = clothings.Where(clothing => clothing.Reserved == false).ToList();
            foreach (Clothing clothing in clothings)
            {
                string gender, age, reserved;
                if (clothing.Gender == ClothingGender.Male) gender = "muški";
                else gender = "ženski";
                if (clothing.Age == ClothingAge.Adult) age = "odrasli";
                else age = "deca";
                if (clothing.Reserved) reserved = "da";
                else reserved = "ne";
                table.Rows.Add(clothing.Id.ToString(), clothing.Kind, clothing.Region, gender, age, clothing.Size, reserved);
            }
            dataGridViewClothings.DataSource = table;
            dataGridViewClothings.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewClothings.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            foreach (DataGridViewRow row in dataGridViewClothings.Rows)
            {
                if (row.Cells["Rezervisano"].Value.ToString().Equals("da")) row.DefaultCellStyle.BackColor = Color.PaleVioletRed;
                else row.DefaultCellStyle.BackColor = Color.LightGreen;
            }
        }

        private void textBoxRegion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                string id = textBoxId.Text.Trim();
                string kind = comboBoxKind.Text == "Izaberite vrstu" ? "" : comboBoxKind.Text;
                string region = textBoxRegion.Text.Trim();
                string genderSearch = comboBoxGender.Text == "Izaberite pol" ? "" : comboBoxGender.Text;
                string ageSearch = comboBoxAge.Text == "Izaberite uzrast" ? "" : comboBoxAge.Text;
                bool reservedSearch = checkBoxReserved.Checked;
                List<Clothing> clothings = ClothingsHelper.GetClothings();
                DataTable table = new DataTable();
                table.Columns.Add("Šifra");
                table.Columns.Add("Vrsta");
                table.Columns.Add("Oblast");
                table.Columns.Add("Pol");
                table.Columns.Add("Uzrast");
                table.Columns.Add("Veličina");
                table.Columns.Add("Rezervisano");
                if (id != "") clothings = clothings.Where(clothing => clothing.Id == Convert.ToInt32(id)).ToList();
                if (kind != "") clothings = clothings.Where(clothing => clothing.Kind.ToLower() == kind.ToLower()).ToList();
                if (region != "") clothings = clothings.Where(clothing => clothing.Region.ToLower() == region.ToLower()).ToList();
                if (genderSearch.Contains("m")) clothings = clothings.Where(clothing => clothing.Gender == ClothingGender.Male).ToList();
                if (genderSearch.Contains("ž")) clothings = clothings.Where(clothing => clothing.Gender == ClothingGender.Female).ToList();
                if (ageSearch.Contains("o")) clothings = clothings.Where(clothing => clothing.Age == ClothingAge.Adult).ToList();
                if (ageSearch.Contains("c")) clothings = clothings.Where(clothing => clothing.Age == ClothingAge.Child).ToList();
                if (reservedSearch) clothings = clothings.Where(clothing => clothing.Reserved == false).ToList();
                foreach (Clothing clothing in clothings)
                {
                    string gender, age, reserved;
                    if (clothing.Gender == ClothingGender.Male) gender = "muški";
                    else gender = "ženski";
                    if (clothing.Age == ClothingAge.Adult) age = "odrasli";
                    else age = "deca";
                    if (clothing.Reserved) reserved = "da";
                    else reserved = "ne";
                    table.Rows.Add(clothing.Id.ToString(), clothing.Kind, clothing.Region, gender, age, clothing.Size, reserved);
                }
                dataGridViewClothings.DataSource = table;
                dataGridViewClothings.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewClothings.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                foreach (DataGridViewRow row in dataGridViewClothings.Rows)
                {
                    if (row.Cells["Rezervisano"].Value.ToString().Equals("da")) row.DefaultCellStyle.BackColor = Color.PaleVioletRed;
                    else row.DefaultCellStyle.BackColor = Color.LightGreen;
                }
            }
        }

        private void textBoxId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                string id = textBoxId.Text.Trim();
                string kind = comboBoxKind.Text == "Izaberite vrstu" ? "" : comboBoxKind.Text;
                string region = textBoxRegion.Text.Trim();
                string genderSearch = comboBoxGender.Text == "Izaberite pol" ? "" : comboBoxGender.Text;
                string ageSearch = comboBoxAge.Text == "Izaberite uzrast" ? "" : comboBoxAge.Text;
                bool reservedSearch = checkBoxReserved.Checked;
                List<Clothing> clothings = ClothingsHelper.GetClothings();
                DataTable table = new DataTable();
                table.Columns.Add("Šifra");
                table.Columns.Add("Vrsta");
                table.Columns.Add("Oblast");
                table.Columns.Add("Pol");
                table.Columns.Add("Uzrast");
                table.Columns.Add("Veličina");
                table.Columns.Add("Rezervisano");
                if (id != "") clothings = clothings.Where(clothing => clothing.Id == Convert.ToInt32(id)).ToList();
                if (kind != "") clothings = clothings.Where(clothing => clothing.Kind.ToLower() == kind.ToLower()).ToList();
                if (region != "") clothings = clothings.Where(clothing => clothing.Region.ToLower() == region.ToLower()).ToList();
                if (genderSearch.Contains("m")) clothings = clothings.Where(clothing => clothing.Gender == ClothingGender.Male).ToList();
                if (genderSearch.Contains("ž")) clothings = clothings.Where(clothing => clothing.Gender == ClothingGender.Female).ToList();
                if (ageSearch.Contains("o")) clothings = clothings.Where(clothing => clothing.Age == ClothingAge.Adult).ToList();
                if (ageSearch.Contains("c")) clothings = clothings.Where(clothing => clothing.Age == ClothingAge.Child).ToList();
                if (reservedSearch) clothings = clothings.Where(clothing => clothing.Reserved == false).ToList();
                foreach (Clothing clothing in clothings)
                {
                    string gender, age, reserved;
                    if (clothing.Gender == ClothingGender.Male) gender = "muški";
                    else gender = "ženski";
                    if (clothing.Age == ClothingAge.Adult) age = "odrasli";
                    else age = "deca";
                    if (clothing.Reserved) reserved = "da";
                    else reserved = "ne";
                    table.Rows.Add(clothing.Id.ToString(), clothing.Kind, clothing.Region, gender, age, clothing.Size, reserved);
                }
                dataGridViewClothings.DataSource = table;
                dataGridViewClothings.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewClothings.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                foreach (DataGridViewRow row in dataGridViewClothings.Rows)
                {
                    if (row.Cells["Rezervisano"].Value.ToString().Equals("da")) row.DefaultCellStyle.BackColor = Color.PaleVioletRed;
                    else row.DefaultCellStyle.BackColor = Color.LightGreen;
                }
            }
        }

        private void comboBoxGender_SelectedValueChanged(object sender, EventArgs e)
        {
            string id = textBoxId.Text.Trim();
            string kind = comboBoxKind.Text == "Izaberite vrstu" ? "" : comboBoxKind.Text;
            string region = textBoxRegion.Text.Trim();
            string genderSearch = comboBoxGender.Text == "Izaberite pol" ? "" : comboBoxGender.Text;
            string ageSearch = comboBoxAge.Text == "Izaberite uzrast" ? "" : comboBoxAge.Text;
            bool reservedSearch = checkBoxReserved.Checked;
            List<Clothing> clothings = ClothingsHelper.GetClothings();
            DataTable table = new DataTable();
            table.Columns.Add("Šifra");
            table.Columns.Add("Vrsta");
            table.Columns.Add("Oblast");
            table.Columns.Add("Pol");
            table.Columns.Add("Uzrast");
            table.Columns.Add("Veličina");
            table.Columns.Add("Rezervisano");
            if (id != "") clothings = clothings.Where(clothing => clothing.Id == Convert.ToInt32(id)).ToList();
            if (kind != "") clothings = clothings.Where(clothing => clothing.Kind.ToLower() == kind.ToLower()).ToList();
            if (region != "") clothings = clothings.Where(clothing => clothing.Region.ToLower() == region.ToLower()).ToList();
            if (genderSearch.Contains("m")) clothings = clothings.Where(clothing => clothing.Gender == ClothingGender.Male).ToList();
            if (genderSearch.Contains("ž")) clothings = clothings.Where(clothing => clothing.Gender == ClothingGender.Female).ToList();
            if (ageSearch.Contains("o")) clothings = clothings.Where(clothing => clothing.Age == ClothingAge.Adult).ToList();
            if (ageSearch.Contains("c")) clothings = clothings.Where(clothing => clothing.Age == ClothingAge.Child).ToList();
            if (reservedSearch) clothings = clothings.Where(clothing => clothing.Reserved == false).ToList();
            foreach (Clothing clothing in clothings)
            {
                string gender, age, reserved;
                if (clothing.Gender == ClothingGender.Male) gender = "muški";
                else gender = "ženski";
                if (clothing.Age == ClothingAge.Adult) age = "odrasli";
                else age = "deca";
                if (clothing.Reserved) reserved = "da";
                else reserved = "ne";
                table.Rows.Add(clothing.Id.ToString(), clothing.Kind, clothing.Region, gender, age, clothing.Size, reserved);
            }
            dataGridViewClothings.DataSource = table;
            dataGridViewClothings.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewClothings.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            foreach (DataGridViewRow row in dataGridViewClothings.Rows)
            {
                if (row.Cells["Rezervisano"].Value.ToString().Equals("da")) row.DefaultCellStyle.BackColor = Color.PaleVioletRed;
                else row.DefaultCellStyle.BackColor = Color.LightGreen;
            }
        }

        private void comboBoxAge_SelectedValueChanged(object sender, EventArgs e)
        {
            string id = textBoxId.Text.Trim();
            string kind = comboBoxKind.Text == "Izaberite vrstu" ? "" : comboBoxKind.Text;
            string region = textBoxRegion.Text.Trim();
            string genderSearch = comboBoxGender.Text == "Izaberite pol" ? "" : comboBoxGender.Text;
            string ageSearch = comboBoxAge.Text == "Izaberite uzrast" ? "" : comboBoxAge.Text;
            bool reservedSearch = checkBoxReserved.Checked;
            List<Clothing> clothings = ClothingsHelper.GetClothings();
            DataTable table = new DataTable();
            table.Columns.Add("Šifra");
            table.Columns.Add("Vrsta");
            table.Columns.Add("Oblast");
            table.Columns.Add("Pol");
            table.Columns.Add("Uzrast");
            table.Columns.Add("Veličina");
            table.Columns.Add("Rezervisano");
            if (id != "") clothings = clothings.Where(clothing => clothing.Id == Convert.ToInt32(id)).ToList();
            if (kind != "") clothings = clothings.Where(clothing => clothing.Kind.ToLower() == kind.ToLower()).ToList();
            if (region != "") clothings = clothings.Where(clothing => clothing.Region.ToLower() == region.ToLower()).ToList();
            if (genderSearch.Contains("m")) clothings = clothings.Where(clothing => clothing.Gender == ClothingGender.Male).ToList();
            if (genderSearch.Contains("ž")) clothings = clothings.Where(clothing => clothing.Gender == ClothingGender.Female).ToList();
            if (ageSearch.Contains("o")) clothings = clothings.Where(clothing => clothing.Age == ClothingAge.Adult).ToList();
            if (ageSearch.Contains("c")) clothings = clothings.Where(clothing => clothing.Age == ClothingAge.Child).ToList();
            if (reservedSearch) clothings = clothings.Where(clothing => clothing.Reserved == false).ToList();
            foreach (Clothing clothing in clothings)
            {
                string gender, age, reserved;
                if (clothing.Gender == ClothingGender.Male) gender = "muški";
                else gender = "ženski";
                if (clothing.Age == ClothingAge.Adult) age = "odrasli";
                else age = "deca";
                if (clothing.Reserved) reserved = "da";
                else reserved = "ne";
                table.Rows.Add(clothing.Id.ToString(), clothing.Kind, clothing.Region, gender, age, clothing.Size, reserved);
            }
            dataGridViewClothings.DataSource = table;
            dataGridViewClothings.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewClothings.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            foreach (DataGridViewRow row in dataGridViewClothings.Rows)
            {
                if (row.Cells["Rezervisano"].Value.ToString().Equals("da")) row.DefaultCellStyle.BackColor = Color.PaleVioletRed;
                else row.DefaultCellStyle.BackColor = Color.LightGreen;
            }
        }

        private void checkBoxReserved_CheckedChanged(object sender, EventArgs e)
        {
            string id = textBoxId.Text.Trim();
            string kind = comboBoxKind.Text == "Izaberite vrstu" ? "" : comboBoxKind.Text;
            string region = textBoxRegion.Text.Trim();
            string genderSearch = comboBoxGender.Text == "Izaberite pol" ? "" : comboBoxGender.Text;
            string ageSearch = comboBoxAge.Text == "Izaberite uzrast" ? "" : comboBoxAge.Text;
            bool reservedSearch = checkBoxReserved.Checked;
            List<Clothing> clothings = ClothingsHelper.GetClothings();
            DataTable table = new DataTable();
            table.Columns.Add("Šifra");
            table.Columns.Add("Vrsta");
            table.Columns.Add("Oblast");
            table.Columns.Add("Pol");
            table.Columns.Add("Uzrast");
            table.Columns.Add("Veličina");
            table.Columns.Add("Rezervisano");
            if (id != "") clothings = clothings.Where(clothing => clothing.Id == Convert.ToInt32(id)).ToList();
            if (kind != "") clothings = clothings.Where(clothing => clothing.Kind.ToLower() == kind.ToLower()).ToList();
            if (region != "") clothings = clothings.Where(clothing => clothing.Region.ToLower() == region.ToLower()).ToList();
            if (genderSearch.Contains("m")) clothings = clothings.Where(clothing => clothing.Gender == ClothingGender.Male).ToList();
            if (genderSearch.Contains("ž")) clothings = clothings.Where(clothing => clothing.Gender == ClothingGender.Female).ToList();
            if (ageSearch.Contains("o")) clothings = clothings.Where(clothing => clothing.Age == ClothingAge.Adult).ToList();
            if (ageSearch.Contains("c")) clothings = clothings.Where(clothing => clothing.Age == ClothingAge.Child).ToList();
            if (reservedSearch) clothings = clothings.Where(clothing => clothing.Reserved == false).ToList();
            foreach (Clothing clothing in clothings)
            {
                string gender, age, reserved;
                if (clothing.Gender == ClothingGender.Male) gender = "muški";
                else gender = "ženski";
                if (clothing.Age == ClothingAge.Adult) age = "odrasli";
                else age = "deca";
                if (clothing.Reserved) reserved = "da";
                else reserved = "ne";
                table.Rows.Add(clothing.Id.ToString(), clothing.Kind, clothing.Region, gender, age, clothing.Size, reserved);
            }
            dataGridViewClothings.DataSource = table;
            dataGridViewClothings.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewClothings.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            foreach (DataGridViewRow row in dataGridViewClothings.Rows)
            {
                if (row.Cells["Rezervisano"].Value.ToString().Equals("da")) row.DefaultCellStyle.BackColor = Color.PaleVioletRed;
                else row.DefaultCellStyle.BackColor = Color.LightGreen;
            }
        }
    }
}
