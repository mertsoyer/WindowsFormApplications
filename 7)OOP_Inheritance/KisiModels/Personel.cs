using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_OOP_Inheritance.KisiModels
{
    public class Personel:Insan
    {
        public int SicilNo { get; set; }
        public int Maas { get; set; }
        public string Departman { get; set; }

        public void MesaiYap()
        {
            System.Windows.Forms.MessageBox.Show("fazla mesai yapıldı");
        }


    }
}
