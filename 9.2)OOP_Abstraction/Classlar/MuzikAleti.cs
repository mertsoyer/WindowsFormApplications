using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._2_OOP_Abstraction.Classlar
{
    public abstract class MuzikAleti
    {
        
        public string Markasi { get; set; }
        public string Aciklamasi { get; set; }

        //Abstract olarak işaretlenen metotların gövdeleri doldurulamaz
        public abstract string Cal(); // imza olusturulur gövde cagırıldıgı yerde doldurulur.
                                      // abstract classlar miras aldığı classlarda implement edilmesi zorunludur.
                                      // abstract classlar sadece abstract classlar içerisinde tanımlanabilir.
                                      // abstract classlar virtual olarak tanımlanamaz
                                      // abstract classlar static olarak tanımlanamaz

        //Abstract olarak işaretlenmemiş metotların gövdeleri doldurulabilir.
        public string X ()
        {
            return "";
        }

    }
}
