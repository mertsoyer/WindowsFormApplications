using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._6_IEnumarable
{
    //IEnumerable , generic olmayan bir koleksiyon üzerinde iterasyon(liste içinde dönmemizi) yapmamızı sağlar.
    //GetEnumerator metodu bir koleksiyon dizi içinden iterasyon yapmamızı sağlar ve geriye IEnumeratır tipinde bir sınıf döndürür.
    public class Personel : IEnumerable
    {



        string[] personel = new string[3];

        public Personel()
        {
            personel[0] = "Mert";
            personel[1] = "Doğukan";
            personel[2] = "Soyer";
        }
        public IEnumerator GetEnumerator()
        {
           return personel.GetEnumerator();
        }
    }
}
