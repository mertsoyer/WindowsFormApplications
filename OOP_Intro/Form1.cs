using OOP_Intro.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Intro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Kitap kitap = new Kitap();

            kitap.KitapAdi = txtKitapAd.Text;
            kitap.Yazar = txtYazar.Text;
            kitap.ISBNo = txtISBN.Text;
            kitap.SayfaSayisi = Convert.ToInt32(numericUpDown1.Value);
            kitap.YayinEvi = txtYayinEvi.Text;
            kitap.YayinTarihi = dateTimePicker1.Value;
            kitap.Tur = txtTur.Text;
            //lstKitaplar.Items.Add(kitap); // bu obje türünde çağırır yani yanlış bir listeleme
            lstKitaplar.Items.Add(string.Format("{0}>>{1}",kitap.KitapAdi,kitap.Yazar));
            Temizle();
        }
      
        public void Temizle()
        {
            foreach (var item in this.Controls)
            {
                if (item is TextBox)
                {
                    TextBox text = (TextBox)item;
                    text.Clear();

                    //text.Text = "";
                    //text.Text=String.Empty;
                    //text.Text = null;
                }
                else if (item is NumericUpDown)
                {
                    NumericUpDown numeric = (NumericUpDown)item;
                    numeric.Value = 0;
                }
                else if (item is DateTimePicker)
                {
                    DateTimePicker dateTimePicker = (DateTimePicker)item;
                    dateTimePicker.Value = DateTime.Now;
                }
            }
            //İmleç Kitapadı textbox unu gelecek.
            txtKitapAd.Focus();
        }
    }
}
