using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06_OOP_Struct
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // STRUCT yapı oldugu ıcın new lemeden burada kullanabiliyoruz. ama isteğe göre de new ile Kitap kitap = new Kitap(); şeklinde de kullanılabilir.
        Kitap kitap;
        private void Form1_Load(object sender, EventArgs e)
        {
            kitap.Adi = "Davam";
            kitap.Tur = Tur.Hikaye;
            kitap.YazarAdi = "Jhon Doe";
            kitap.ISBN = "3493894384";

              
        }
    }
}
