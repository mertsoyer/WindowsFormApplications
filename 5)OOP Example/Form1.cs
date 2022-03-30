using _5_OOP_Example.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5_OOP_Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Urun urun = new Urun();


            urun.UrunKodu=txtUrunID.Text;
            urun.UrunAdi = txtUrunAd.Text;
            urun.Fiyat=Convert.ToDouble (txtUrunFiyat.Text);

            MessageBox.Show($"Ürün Kodu:{urun.UrunAdi}, {urun.UrunKodu}, {urun.Fiyat}");
        }
    }
}
