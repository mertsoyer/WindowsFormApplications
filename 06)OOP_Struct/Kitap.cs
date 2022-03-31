using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_OOP_Struct
{
    // Class referans tipli STRUCT değer tiplidir.
    // Struct değer tiplidir.Ram de stack alanında tutulur.
    // Struct yapılar da boş constructor tanımlanamaz, tanımlanacaksa mutlaka parametre almak zorundadır ve başlangıç değeri atanmak zorundadır.
    // Structlar da new anahtar kelimesi kullanma zorunluluğu yoktur.
    // Structlar her hangi bir yapıdan struct ve class kalıtım alamaz ! 

    public struct Kitap
    {

        public int Id { get; set; }
        public string Adi { get; set; }
        public Tur Tur { get; set; }
        public string ISBN { get; set; }
        public string YazarAdi { get; set; }

        public Kitap(int id , string adi,Tur tur,string isbn,string yazarAdi)
        {
            Id = id;
            Adi = adi;
            Tur = tur;
            ISBN = isbn;
            YazarAdi = yazarAdi;

        }


    }



    //Tür de sınırlama için enum oluşturuldu

    public enum Tur
    {
        Roman,
        Hikaye,
        Dergi,
        Ansiklopedi,
        BilimKurgu,
    }
}
