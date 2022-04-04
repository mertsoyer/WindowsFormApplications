using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._1_Polymorphisim
{
    public class Labrador:Kopek
    {

        public override void Havla()
        {
            System.Windows.Forms.MessageBox.Show("labrodor ile havla");
        }
    }
}
