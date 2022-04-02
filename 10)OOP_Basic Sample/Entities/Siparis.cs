using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_OOP_Basic_Sample.Entities
{
    public class Siparis
    {/// <summary>
     /// sipariş boş olarak da oluşturabilir
     /// </summary>
        public Siparis()
        {

        }

        /// <summary>
        /// sipariş de urunad ve miktar olmadan oluşturulamaz
        /// </summary>
        /// <param name="urunAd"></param>
        /// <param name="miktar"></param>
        public Siparis(string urunAd, int miktar)
        {
            UrunAd = urunAd;
            Miktar = miktar;
        }


        public string UrunAd { get; set; }
        public string UrunId { get; set; }
        public int Miktar { get; set; }
        public decimal KDVDahilFiyat { get; set; }
        public DovizCinsi DovizCinsi { get; set; }

        /// <summary>
        /// sipariş oluşturulduğu günün tarihini döndürür
        /// </summary>
        public DateTime SiparisTarihi
        {
            get
            {
                return DateTime.Now;
            }

        }
        public decimal SiparisTutari { get; set; }

        public override string ToString()
        {
            return UrunAd + SiparisTarihi;
            
            //STRING FORMAT İLE;
            //return string.Format("{0}-{1}",UrunAd,SiparisTarihi);
        }


    }


    public enum DovizCinsi
    {
        tl,
        dolar,
        euro,
        pound
    }
}
