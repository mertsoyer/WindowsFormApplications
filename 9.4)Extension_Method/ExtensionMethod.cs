using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._4_Extension_Method
{
    internal class ExtensionMethod
    {
    }


    public static class StringExtensionClass
    {
        public static string IlkIkiKarakter (this string metin)
        {
            return metin.Substring (0,2);
        }

        public static bool IsTrue(this int deger)
        {
            return true;
        }


        public static DateTime GetBirhDate (this Person person)
        {
            return person.BirthDate;
        }

        public class Person
        {
            public string FullName { get; set; }
            public DateTime BirthDate { get; set; }= DateTime.Now;
        }


    }
}
