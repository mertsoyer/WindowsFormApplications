using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._2_OOP_Abstraction.Corba_Classlar
{
    public class Mercimek : Corba
    {
        public MercimekRengi Renk { get; set; }
        private int _kaynamaDerecesi;
        public override int KaynamaDerecesi
        {
            get
            {
                return _kaynamaDerecesi;
            }
            set
            {
                if (value > 100)
                {
                    _kaynamaDerecesi = value;
                    System.Windows.Forms.MessageBox.Show("mercimek çorbası kaynadı");

                }
                else
                {
                    _kaynamaDerecesi = value;
                }

            }
        }

        public override void EkmekBan()
        {
            System.Windows.Forms.MessageBox.Show("mercimek corbasına ekmek banılır");
        }
    }


    public enum MercimekRengi
    {
        yesil,
        kirmizi,
        sari,
    }
}
