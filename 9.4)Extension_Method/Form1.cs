using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static _9._4_Extension_Method.StringExtensionClass;

namespace _9._4_Extension_Method
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Ornek1
            string metin = "as34 SOY 41";
            string metninIlkIkiKarakteri = metin.IlkIkiKarakter();
            Console.WriteLine(metninIlkIkiKarakteri);

            //Ornek2
            int sayi = 1;
            bool sonuc =sayi.IsTrue();
            MessageBox.Show(sonuc.ToString());

            //Ornek3
            Person person = new Person();
            DateTime birthDate = person.GetBirhDate();
            MessageBox.Show(birthDate.ToString());
        }
    }
}
