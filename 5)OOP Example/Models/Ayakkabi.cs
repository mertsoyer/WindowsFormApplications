using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_OOP_Example.Models
{
    public class Ayakkabi
    {


        public Ayakkabi()
        {

        }

        public Ayakkabi(int ayakkabiNo, Tip tip)
        {
            AyakkabiNo = ayakkabiNo;
            Tipi = tip;
        }

        public int AyakkabiNo { get; set; }
        public Tip Tipi { get; set; }
        public string Markasi { get; set; }
        public Color Rengi { get; set; }
        public bool TopukluMu { get; set; }
        public Cinsiyet Cinsiyeti { get; set; }
        public Malzeme Malzemesi { get; set; }


    }


    public enum Malzeme
    { Deri,Rugan,Suet,Kumas,Lastik}

    public enum Cinsiyet
    {
        Kadin,
        Erkek,
        Unisex,
        KizCocuk,
        ErkekCocuk
    }

    public enum Tip
    {
        Spor,Klasik,Kundura,GeceAyakkabisi
    }
}
