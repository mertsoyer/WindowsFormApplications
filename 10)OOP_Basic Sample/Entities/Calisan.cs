using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_OOP_Basic_Sample.Entities
{
    public class Calisan:Kisi
    {
        public Calisan(string adSoyad, string unvani)
        {
            Unvani = unvani;
            //Kisi class ınden ad soyad bilgisi geliyor.
            AdSoyad = adSoyad;
        }
        public string  Unvani { get; set; }
    
    }
}
