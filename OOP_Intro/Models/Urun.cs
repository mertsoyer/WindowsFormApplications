using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Intro.Models
{
    public class Urun
    {
        public string mesaj = "";
        public string UrunKodu { get; set; }
        public string UrunAdi { get; set; }
        public decimal Fiyati { get; set; }

        private int _stokMiktari;
        public int StokMiktari
        {
            get
            {
                return _stokMiktari;
            }
            set
            {
                if (value <= 50)
                {
                    _stokMiktari = value;
                    mesaj = "Kritik stok";
                }
                else
                {
                    _stokMiktari =value;
                }

            }
        }

        private int _garantiSuresi;
        public int GarantiSuresi
        {
            get
            {
                return _garantiSuresi;
            }
            set
            {
                if (value > 2)
                {
                    _garantiSuresi = value;
                    UzatilmisGarantiVarmi = true;
                    MessageBox.Show("uzatılmış garanti var");
                }
                else
                {
                    _garantiSuresi = value;
                }

            }
        }

        private bool _teshirUrunuMu;
        public bool TeshirUrunuMu
        {
            get
            {
                return _teshirUrunuMu;
            }
            set
            {
                if (DevamDurumu == true && value == true)
                {
                    _teshirUrunuMu = value;
                    GarantiSureOpsiyonluIndırım(0, Fiyati, 30);

                }

                else
                {
                    _teshirUrunuMu=value;
                }
            }
        }
        public bool UzatilmisGarantiVarmi { get; set; }
        public DateTime UretimTarihi { get; set; }

        private bool _devamDurumu;
        public bool DevamDurumu
        {
            get
            {
                return _devamDurumu;
            }
            set
            {
                if (value == false)
                {
                    _devamDurumu = value;
                    mesaj = "Ürün satışı yok. Ürün satılamaz";
                }
                else
                {

                }
            }

        }


        public decimal GarantiSureOpsiyonluIndırım(int garantiSuresi, decimal fiyat, int indirimYuzdesi)
        {
            decimal sonuc = 0;
            decimal indirimMiktari = 0;
            if (garantiSuresi > 5)
            {
                indirimMiktari = fiyat * 20 / 100;
                sonuc = fiyat - indirimMiktari;
            }
            else if (indirimYuzdesi != 0)
            {
                indirimMiktari = fiyat * 30 / 100;
                sonuc = fiyat - indirimMiktari;
            }


            return sonuc;
        }

    }
}
