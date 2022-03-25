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
            lstKitaplar.Items.Add(kitap); // bu obje türünde çağırır yani yanlış bir listeleme
            //lstKitaplar.Items.Add(string.Format("{0}>>{1}",kitap.KitapAdi,kitap.Yazar));
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

        Kitap secili; // kitap tipinde bir değer oluşturduk
        private void lstKitaplar_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            secili =(Kitap)lstKitaplar.SelectedItem; // lstKitaplar ın selecteditem ini Kitap türüne CAST ettik ve yine Kitap türünden "secili" değerine attık
            txtKitapAd.Text = secili.KitapAdi;
            txtYazar.Text = secili.Yazar;
            txtYayinEvi.Text = secili.Tur;
            txtISBN.Text = secili.ISBNo;
            dateTimePicker1.Value = secili.YayinTarihi;
            numericUpDown1.Value = secili.SayfaSayisi;

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            secili.ISBNo=txtISBN.Text;
            secili.KitapAdi=txtKitapAd.Text;
            secili.Yazar=txtYazar.Text;
            secili.YayinTarihi = dateTimePicker1.Value;
            secili.SayfaSayisi = Convert.ToInt32(numericUpDown1.Value);

            int index = lstKitaplar.SelectedIndex;
            lstKitaplar.Items.RemoveAt(index);
            lstKitaplar.Items.Insert(index, secili);
            Temizle();

        }

        private void txtISBN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
