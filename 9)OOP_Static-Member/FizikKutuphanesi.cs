using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_OOP_Static_Member
{

    /// <summary>
    /// Nesneye bağımlı olarak işlemler gerçekleştirmiyorsak, sadece belirli durumlara hizmet eden birden fazla öğeyi bir arada bulundurmak istenirse sınıf static olarak işaretlenir ve bu öğeler instance dan bağımsız olarak ulaşılabilir.
    /// </summary>

    // Static sınıflar içerisinde yanlızca static öğeler bulundurabilir. ( Field - property - method )

    // Static bir class başka bir classtan kalıtım alamaz.


    public static class FizikKutuphanesi
    {

        public static decimal YerCekimi
        {
            get
            {
                return 9.80M;
            }
        }


        public const int KaldirmaKuvveti = 12;
        //const sabit değerdir. 
        //kendiliğinden static yapıdadır , static işaretlenmez.


        public static readonly int IndirmeKuvveti = 2;


        public static void Kaldir ()
        {

            //kaldırma metodu
        }

    }
}
