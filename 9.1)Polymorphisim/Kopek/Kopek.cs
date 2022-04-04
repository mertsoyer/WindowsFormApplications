using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._1_Polymorphisim
{

    public class Kopek
    {
        public string Cins { get; set; }
        public string Adi { get; set; }
        public bool Cinsiyet { get; set; }
        public int Kilo { get; set; }
        public int Yas { get; set; }

        public virtual void Havla()
        {
            System.Windows.Forms.MessageBox.Show("havlama");
        }
    }
}
