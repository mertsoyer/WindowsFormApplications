using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._2_OOP_Abstraction.Corba_Classlar
{
    public abstract class Corba
    {
        public List<string> Malzemeler { get; set; }
        public Miktar Miktar { get; set; }
        public decimal Fiyat { get; set; }


        // abstract property
        public abstract  int KaynamaDerecesi{ get; set; }

        public abstract void EkmekBan();
    }

    public enum Miktar
    {
        yarım,
        tam,

    }
}
