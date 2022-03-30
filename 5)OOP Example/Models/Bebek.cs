using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_OOP_Example.Models
{
    public class Bebek
    {
        // Bebek sınıfından instance alındığı zaman otomatik olarak dogum tarihi o anın tarihi olarak alınacak.
        public Bebek()
        {
            DogumTarihi=DateTime.Now;   
        }

        public string Adi { get; set; }
        public DateTime DogumTarihi { get; set; }
        public Cinsiyetler Cinsiyet { get; set; }

        private decimal _kilo;
        public decimal Kilo {
            get
            {
                return _kilo;
            }
            set
            {
                if (value>8)
                {
                    _kilo = value;
                    System.Windows.Forms.MessageBox.Show("bebek" +_kilo + " kilo dan büyük, doktora başvurun");

                }
                else
                {
                    _kilo=value;    
                }
               
            } 
        }


        // Enum ile burada cinsiyet seçenekleri belirlendi.
        public enum Cinsiyetler
        {
            Kiz, Erkek
        }
        


    }
}
