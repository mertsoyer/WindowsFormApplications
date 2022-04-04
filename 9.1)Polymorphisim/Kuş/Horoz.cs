using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._1_Polymorphisim.Kuş
{
    internal class Horoz:Kus
    {

        public override void SesCikar()
        {
            System.Windows.Forms.MessageBox.Show("horoz sesi çıkar");
        }
    }
}
