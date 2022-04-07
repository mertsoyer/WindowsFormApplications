using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._7_Burger_Shop_Order_APP.Classes
{
    public class Menu
    {

        public string MenuAdi { get; set; }
        public decimal Fiyati { get; set; }


        public override string ToString()
        {
            return MenuAdi + "Menü";
        }

    }
}
