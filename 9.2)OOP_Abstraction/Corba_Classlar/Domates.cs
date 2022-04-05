using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._2_OOP_Abstraction.Corba_Classlar
{
    public class Domates : Corba
    {

        public bool KasarliMi { get; set; }


        public override int KaynamaDerecesi { get; set; }

        public override void EkmekBan()
        {
            System.Windows.Forms.MessageBox.Show("domates çorbası ekmek banılır mı ");
        }
    }
}
