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
    public partial class NewClothingForm : Form
    {
        private string userName;
        public NewClothingForm(string userName)
        {
            this.userName = userName;
            InitializeComponent();
        }

        private void textBoxRegion_Leave(object sender, EventArgs e)
        {
            if(textBoxRegion.Text.Trim()=="")
            {
                MessageBox.Show("Naziv oblasti ne može ostati prazan!", "Greška");
                textBoxRegion.Focus();
            }
        }

        private void comboBoxGender_Leave(object sender, EventArgs e)
        {
            if(comboBoxGender.Text=="Izaberite pol")
            {
                MessageBox.Show("Morate izabrati pol!", "Greška");
                comboBoxGender.Focus();
            }
        }

        private void comboBoxAge_Leave(object sender, EventArgs e)
        {
            if (comboBoxAge.Text == "Izaberite uzrast")
            {
                MessageBox.Show("Morate izabrati uzrast!", "Greška");
                comboBoxAge.Focus();
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Clothing clothing = new Clothing();
            clothing.Kind = comboBoxKind.Text;
            clothing.Region = textBoxRegion.Text.Trim();
            if (comboBoxGender.Text.Contains("m")) clothing.Gender = ClothingGender.Male;
            else clothing.Gender = ClothingGender.Female;
            if (comboBoxAge.Text.Contains("o")) clothing.Age = ClothingAge.Adult;
            else clothing.Age = ClothingAge.Child;
            clothing.Size = textBoxSize.Text.Trim();
            ClothingsHelper.PostClothing(clothing);
            clothing = ClothingsHelper.GetClothings().Where(clothings => clothings.Kind == comboBoxKind.Text &&
                clothings.Region == textBoxRegion.Text.Trim()).Last();
            LogHelper.PostLog(userName, "Dodat novi komad nošnje: " + clothing.Id.ToString() + " " + comboBoxKind.Text +
                " " + textBoxRegion.Text.Trim() + " " +comboBoxGender.Text + " " + comboBoxAge.Text +
                " " + textBoxSize.Text.Trim());
            MessageBox.Show("Dodat novi komad nošnje:\nŠifra: " + clothing.Id.ToString() + "\nVrsta: " +
                comboBoxKind.Text + "\nOblast: " + textBoxRegion.Text.Trim() +
                "\nPol: " + comboBoxGender.Text + "\nUzrast: " + comboBoxAge.Text +
                "\nVeličina: " + textBoxSize.Text.Trim(), "Uspeh");
        }


        private void NewClothingForm_Load(object sender, EventArgs e)
        {
            List<string> kinds = ClothingsHelper.GetClothingKinds();
            foreach(string kind in kinds)
            {
                comboBoxKind.Items.Add(kind);
            }
        }

        private void textBoxSize_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(Convert.ToInt32(e.KeyChar)==13)
            {
                Clothing clothing = new Clothing();
                clothing.Kind = comboBoxKind.Text;
                clothing.Region = textBoxRegion.Text.Trim();
                if (comboBoxGender.Text.Contains("m")) clothing.Gender = ClothingGender.Male;
                else clothing.Gender = ClothingGender.Female;
                if (comboBoxAge.Text.Contains("o")) clothing.Age = ClothingAge.Adult;
                else clothing.Age = ClothingAge.Child;
                clothing.Size = textBoxSize.Text.Trim();
                ClothingsHelper.PostClothing(clothing);
                clothing = ClothingsHelper.GetClothings().Where(clothings => clothings.Kind == comboBoxKind.Text &&
                clothings.Region == textBoxRegion.Text.Trim()).Last();
                LogHelper.PostLog(userName, "Dodat novi komad nošnje: " + clothing.Id.ToString() + " " +
                    comboBoxKind.Text + " " + textBoxRegion.Text.Trim() + " " + comboBoxGender.Text + " " +
                    comboBoxAge.Text + " " + textBoxSize.Text.Trim());
                MessageBox.Show("Dodat novi komad nošnje:\nŠifra: " + clothing.Id.ToString() + "\nVrsta: " +
                    comboBoxKind.Text + "\nOblast: " + textBoxRegion.Text.Trim() + "\nPol: " + comboBoxGender.Text +
                    "\nUzrast: " + comboBoxAge.Text + "\nVeličina: " + textBoxSize.Text.Trim(), "Uspeh");
            }
        }
    }
}
