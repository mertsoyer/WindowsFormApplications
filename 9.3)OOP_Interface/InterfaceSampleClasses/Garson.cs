using _9._3_OOP_Interface.InterfaceSampleClasses.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._3_OOP_Interface.InterfaceSampleClasses
{
    public class Garson:Calisan,IGarson
    {
        public List<string> Siparisler { get; set; }
        public int MyProperty { get; set; }

        public void GarsonKiyafetiGiy()
        {
            
        }

        public void SiparisNotEt(string siparis)
        {
            Siparisler.Add(siparis);
        }
    }
}
