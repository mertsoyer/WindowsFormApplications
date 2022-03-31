using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_OOP_Inheritance
{
    public class BasePhone
    {

        public BasePhone()
        {
            //yeni bir telefon üretildiği zaman tipi otomatik olarak cep telefonu olarak gelir.
            PhoneType = "Cep telefonu";
        }


        // 
        public BasePhone(string brand, bool wifi)
        {
            Brand = brand;
            Wifi = wifi;

        }


        private string _brand;
        public string Brand { get; set; }
        public string IMEI { get; set; }
        public string PhoneType { get; set; }
        public bool Wifi { get; set; }
        public bool Bluetooth { get; set; }



        public void Call()
        {
            System.Windows.Forms.MessageBox.Show("Arama yapılıyor");
        }

        public string WifiBagla()
        {
            string durum = "";
            if (Wifi==true)
            {
                durum = "Wifi bağlanıyor...";
             }
            else
            {
                durum = "wifi yok";
            }

            return durum;
        }
    }
}
