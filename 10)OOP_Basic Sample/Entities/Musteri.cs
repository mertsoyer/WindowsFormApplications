using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_OOP_Basic_Sample.Entities
{
    public class Musteri:Kisi
    {
        public Musteri(string adSoyad,string telNo)
        {
            AdSoyad = adSoyad;
            TelNo = telNo;
        }
        public string TelNo { get; set; }
        public string Adres { get; set; }
    }
}
