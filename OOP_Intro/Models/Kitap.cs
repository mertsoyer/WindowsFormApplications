using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Intro.Models
{
    public class Kitap
    {

        public string KitapAdi { get; set; }
        public string Yazar { get; set; }
        public string ISBNo { get; set; }
        public string Tur { get; set; }
        public string YayinEvi { get; set; }
        public DateTime YayinTarihi { get; set; }
        public int SayfaSayisi { get; set; }

    }
}
