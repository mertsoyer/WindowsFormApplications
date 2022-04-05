using _9._3_OOP_Interface.InterfaceSampleClasses.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._3_OOP_Interface.InterfaceSampleClasses
{
    public class Musteri:Insan,IMusteri
    {
        public string YemekIstedikleri { get; set; }
        public decimal SiparisTutari { get; set; }
        public decimal MinimumBahsisTutari { get; set; }

        public void BahsisVer()
        {
          //MinimumBahsisTutari
        }

        public void OdemeYap()
        {
            //SiparisTutari
        }

        public void SiparisVer()
        {
           
        }
    }
}
