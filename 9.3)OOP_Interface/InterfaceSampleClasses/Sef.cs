using _9._3_OOP_Interface.InterfaceSampleClasses.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._3_OOP_Interface.InterfaceSampleClasses
{
    public class Sef:Insan,ISef,IGarson
    {

        public int Tecrubesi { get; set; }
        public string Alani { get; set; }

        public void GarsonKiyafetiGiy()
        {
          // şef yeri geldiği zaman garson kıyafeti giyer.
        }

        public void SefKiyafetiGiy()
        {
         // şef kıyafeti gyecek   
        }

        public void YemekYap()
        {
            // kendı yontemıne gore yemek yapacak
        }
    }
}
