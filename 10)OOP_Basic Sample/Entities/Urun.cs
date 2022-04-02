using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_OOP_Basic_Sample.Entities
{
    public class Urun
    {

        public Urun()
        {

        }

        public Urun(string ad, string kategori)
        {
            Ad = ad;
            Kategori = kategori;
        }

        public string Ad { get; set; }
        public string Id { get; set; }
        public string Kategori { get; set; }
        public double Fiyat { get; set; }
        public int StokMiktari { get; set; }
        public Birim Birim { get; set; }

        /// <summary>
        /// Kişi class ında ovveride ettiğimiz tostring metodunu  burada tekrardan ovveride edip toString metodu cagırıldıgı zaman kişinin adını döndürüyoruz.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            //return this.Ad;
            return Ad;
        }

    }


    public enum Birim
    {
        paket,
        koli,
        adet,
        kilo,
        palet,
        kart,
        düzine


    }
}
