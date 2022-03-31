using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_OOP_Inheritance
{
    public class MobilePhone:BasePhone
    {
        public bool HasCamera { get; set; }
        public bool IsTouchable { get; set; }


        public MobilePhone()
        {
            PhoneType = "Mobile Phone";
        }

        //:base diyerek miras aldığımız base class olan BasePhone class ındaki constructor ı eklemıs olduk.
        public MobilePhone(bool hasCamera, bool isTouchable,string brand,bool wifi):base(brand,wifi)
        {
            HasCamera = hasCamera;
            IsTouchable = isTouchable;
            Brand = brand;
            Wifi = wifi;
        }


        public string TakePhoto()
        {
            if (HasCamera==true)
            {
                return "resim cekebilir";
            }
            else
            {
                return "resim cekemez";
            }
        }

    }
}
