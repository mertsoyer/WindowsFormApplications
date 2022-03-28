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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            btnGuncelle.Enabled = false;
            btnSil.Enabled = false;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            #region Yeni Ürün Oluşturma
            Urun urun = new Urun();

            urun.DevamDurumu = checkBoxDevamDurumu.Checked;
            urun.Fiyati = nmrcUpFiyat.Value;
            urun.GarantiSuresi = Convert.ToInt32(nmrcUpGarantiSure.Value);
            urun.StokMiktari = Convert.ToInt32(nmrcUpGarantiSure.Value);
            urun.UretimTarihi = dateTimePckUretimTarihi.Value;
            urun.UrunAdi = txtUrunAdi.Text;
            urun.UrunKodu = txtUrunKodu.Text;

            // checkbox da seçilmese bile garanti süresi 2 yıldan fazla ise otomatikman ekrana uzatılmış garantisi true olarak basılacak.
            if (urun.GarantiSuresi > 2)
            {
                urun.UzatilmisGarantiVarmi = true;
            }
            //2 yıldan küçük ise checkbox dan gelen değer atanacak.
            else
            {
                urun.UzatilmisGarantiVarmi = chckUzatilmisGarantiVarmi.Checked;
            }
            
            urun.TeshirUrunuMu = chckUzatilmisGarantiVarmi.Checked;
            #endregion

            string[] satirBilgisi = { urun.UrunKodu, urun.UrunAdi, urun.Fiyati.ToString("C2"), urun.StokMiktari.ToString(), urun.UretimTarihi.ToShortTimeString(), urun.UzatilmisGarantiVarmi.ToString() };




            ListViewItem lv = new ListViewItem(satirBilgisi);
            lv.Tag = urun;
            listViewUrunler.Items.Add(lv);
            Temizle();
        }

        private void Temizle()
        {
            foreach (var item in this.Controls)
            {
                if (item is TextBox)
                {
                    TextBox text = (TextBox)item;
                    text.Clear();
                }
                else if (item is NumericUpDown)
                {
                    NumericUpDown numericUpDown = (NumericUpDown)item;
                    numericUpDown.Value = 0;

                }
                else if (item is DateTimePicker)
                {
                    DateTimePicker dateTimePicker = (DateTimePicker)item;
                }
                else if (item is CheckBox)
                {
                    CheckBox checkBox = (CheckBox)item;
                    checkBox.Checked = false;
                }

            }
        }

        Urun guncellenecek;
        private void listViewUrunler_DoubleClick(object sender, EventArgs e)
        {
            if (listViewUrunler.SelectedItems.Count<=0)
            {
                return;
            }
            else
            {
                guncellenecek=(Urun)listViewUrunler.SelectedItems[0].Tag;
                txtUrunAdi.Text = guncellenecek.UrunAdi;
                txtUrunKodu.Text=guncellenecek.UrunKodu;
                nmrcUpFiyat.Value = guncellenecek.Fiyati;
                nmrcUpStokMiktar.Value = guncellenecek.StokMiktari;
                nmrcUpGarantiSure.Value = guncellenecek.GarantiSuresi;
                dateTimePckUretimTarihi.Value = guncellenecek.UretimTarihi;
                checkBoxDevamDurumu.Checked = guncellenecek.DevamDurumu;
                checkBoxTeshirUrunumu.Checked = guncellenecek.TeshirUrunuMu;
                chckUzatilmisGarantiVarmi.Checked = guncellenecek.UzatilmisGarantiVarmi;
            }

            btnKaydet.Enabled= false;
            btnSil.Enabled= true;
            btnGuncelle.Enabled = true;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            guncellenecek.DevamDurumu = checkBoxDevamDurumu.Checked;
            guncellenecek.Fiyati = nmrcUpFiyat.Value;
            guncellenecek.GarantiSuresi=Convert.ToInt32(nmrcUpGarantiSure.Value);
            guncellenecek.StokMiktari=Convert.ToInt32(nmrcUpStokMiktar.Value);
            guncellenecek.UretimTarihi=dateTimePckUretimTarihi.Value;
            guncellenecek.UrunAdi=txtUrunAdi.Text;
            guncellenecek.UrunKodu=txtUrunKodu.Text;
            if (guncellenecek.GarantiSuresi>2)
            {
                guncellenecek.UzatilmisGarantiVarmi = true;
            }
            else
            {
                guncellenecek.UzatilmisGarantiVarmi=chckUzatilmisGarantiVarmi.Checked;
            }
            guncellenecek.TeshirUrunuMu=checkBoxTeshirUrunumu.Checked;


            string[] satirBilgisi = { guncellenecek.UrunKodu, guncellenecek.UrunAdi, guncellenecek.Fiyati.ToString("C2"), guncellenecek.StokMiktari.ToString(), guncellenecek.UretimTarihi.ToShortTimeString(), guncellenecek.UzatilmisGarantiVarmi.ToString() };




            ListViewItem lv = new ListViewItem(satirBilgisi);
            lv.Tag = guncellenecek;

            int index = listViewUrunler.SelectedItems[0].Index;
            listViewUrunler.Items.RemoveAt(index);
            listViewUrunler.Items.Insert(index, lv);

            
            Temizle();

            btnKaydet.Enabled = true;
            btnGuncelle.Enabled = false;
            btnSil.Enabled= false;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (listViewUrunler.SelectedItems.Count<=0)
            {
                return;
            }
            else
            {
                listViewUrunler.Items.Remove(listViewUrunler.SelectedItems[0]);
            }
        }
    }
}
