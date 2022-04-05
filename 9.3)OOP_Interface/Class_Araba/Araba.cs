using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._3_OOP_Interface.Class_Araba
{
    public class Araba : MotorluTasit, ITekerlekliArac
    {
        public int TekerlekSayisi { get; set; } 
        public void Calistir()
        {
           
        }
    }
}
