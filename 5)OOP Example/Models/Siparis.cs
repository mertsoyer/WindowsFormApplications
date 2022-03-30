using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_OOP_Example.Models
{
    public class Siparis
    {

        public string SiparisKodu { get; set; }
        public DateTime SiparisTarihi { get; set; }
        public string GonderimAdresi { get; set; }

        //public List<Urun> Urunler { get; set; }
        public Urun[] Urunler { get; set; }

        public int ToplamUrunsayisi
        {
            get
            {
                return Urunler.Length;

            }

        }

        private bool _kargoGonderimDurumu;
        public bool KargoGonderimDurumu
        {
            get
            {
                return _kargoGonderimDurumu;
            }
            set
            {
                if (SiparisTarihi.AddDays(5) < DateTime.Now && value==false)
                {
                    _kargoGonderimDurumu = value;
                    System.Windows.Forms.MessageBox.Show("Kargo tarihi gecikti");
                }

                else
                {
                    _kargoGonderimDurumu=value;
                }

            }
        }

    }
}
