using _9._7_Burger_Shop_Order_APP.Enum_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._7_Burger_Shop_Order_APP.Classes
{
    public class Siparis
    {
        public Menu SeciliMenu { get; set; }
        public Boyut Boyutu { get; set; }
        public List<Extra> ExtraMalzeme { get; set; }
        public int Adet { get; set; }
        public decimal ToplamTutar { get; set; }


        public override string ToString()
        {
            if (ExtraMalzeme.Count<1)
            {
                return ($"{ SeciliMenu.MenuAdi} { Adet} Adet, {Boyutu} Boy, Toplam Tutar : {ToplamTutar} ");

            }
            else
            {
                string ekstraMalzemeler = null;
                foreach (Extra item in ExtraMalzeme)
                {
                    ekstraMalzemeler=item.EkstraAdi + ",";
                }
                return ($"{ SeciliMenu.MenuAdi} { Adet} Adet, {Boyutu} Boy, Ekstra Malzemeler : {ekstraMalzemeler} Toplam Tutar : {ToplamTutar} ");
            }
        }
    }
}
