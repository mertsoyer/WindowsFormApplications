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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Ayakkabi ayakkabi = new Ayakkabi(45,Tip.Spor);
            ayakkabi.Tipi=Tip.GeceAyakkabisi;
            ayakkabi.Cinsiyeti = Cinsiyet.Erkek;
            ayakkabi.Malzemesi = Malzeme.Lastik;
            ayakkabi.Markasi = "Nike";
            ayakkabi.Rengi = Color.Azure;
            ayakkabi.TopukluMu = false;
            MessageBox.Show(ayakkabi.Tipi.ToString()+""+ayakkabi.Cinsiyeti+ayakkabi.Markasi);


            //ENUM DAN GELEN VERİYİ DIZI ILE TUTUP COMBOBAX A EKLEDİK
            string[] malzemeler = Enum.GetNames(typeof(Malzeme));

            foreach (var item in malzemeler)
            {
                comboBox1.Items.Add(item);
            }



            Bebek bebek = new Bebek();
            bebek.Adi = "Mert";
            bebek.Kilo = 9;
            bebek.Cinsiyet = Bebek.Cinsiyetler.Erkek;

            MessageBox.Show(bebek.Adi+bebek.Kilo+bebek.Cinsiyet+bebek.DogumTarihi);


            Urun urun = new Urun();
            urun.UrunAdi = "Test Urun";
            urun.Kategori = "Test Kategori";

            Siparis siparis = new Siparis();
            siparis.SiparisKodu = "1212543";
            siparis.SiparisTarihi=DateTime.Now;
            siparis.Urunler[0] = urun;
            siparis.KargoGonderimDurumu = false;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string secilen = "";

            if (comboBox1.SelectedIndex !=0)
            {
                secilen = comboBox1.SelectedItem.ToString();
            }
            MessageBox.Show(secilen);
        }



        
    }
}
