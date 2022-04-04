using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._1_Polymorphisim.Kuş
{
    public class Kus
    {

        public int GagaBoyu { get; set; }
        public Color Rengi { get; set; }
        public bool Cinsiyet { get; set; }

        public virtual void SesCikar()
        {

            System.Windows.Forms.MessageBox.Show("cıkcık:)");
        }
    }
}
