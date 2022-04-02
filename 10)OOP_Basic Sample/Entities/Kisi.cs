using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_OOP_Basic_Sample.Entities
{
    public class Kisi
    {

        public string AdSoyad { get; set; }
        public string Sehir { get; set; }

        public override string ToString()
        {
            return this.AdSoyad;
        }
    }
}
