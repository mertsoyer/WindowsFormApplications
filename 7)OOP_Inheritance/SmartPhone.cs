using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_OOP_Inheritance
{
    public class SmartPhone:MobilePhone
    {
        public bool FrontCam { get; set; }

        public SmartPhone()
        {
            base.HasCamera = true;
            base.PhoneType = "Smart Phone";
        }


        public SmartPhone(string brand, bool wifi,bool hasCamera,bool isTouchable):base()
        {
            base.HasCamera = hasCamera;
            base.Brand = brand;
            base.Wifi = wifi;
            base.IsTouchable = isTouchable;

        }

        public string DoVideoCall()
        {
            return "Calling..";
        }


    }
}
