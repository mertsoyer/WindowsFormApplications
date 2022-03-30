using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5_OOP_Example.Models
{
    public class Urun
    {

        public string UrunKodu { get; set; }
        public string UrunAdi { get; set; }
        public int StokMiktari { get; set; }
        public string Kategori { get; set; }
        public DateTime UretimTarihi { get; set; }
        public DateTime GarantiBitisTarihi { get; set; }
        public DateTime GarantiBaslangicTarihi { get; set; }

        private double _fiyat;

        public double Fiyat
        {
            get
            {
                return _fiyat;
            }
            set
            {
                if (value>0)
                {
                    _fiyat = value;
                }
                else
                {
                    MessageBox.Show("Fiyat negatif olamaz!");
                }
            }
        }


        public void Sat()
        {
            GarantiBitisTarihi = DateTime.Now.AddYears(2);
        }

        public void IadeEt()
        {
            //stok miktarı eksildiği gün
            DateTime iadeSuresi = GarantiBaslangicTarihi.AddDays(30);
            string mesaj = "Ürününüzü " + iadeSuresi + " tarihine kadar iade edebilirsiniz.";

        }


    }
}
