using _9._2_OOP_Abstraction.Corba_Classlar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9._2_OOP_Abstraction
{
    public partial class Corba : Form
    {
        public Corba()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mercimek mercimek = new Mercimek();
            mercimek.Fiyat = 30;
            mercimek.Renk = MercimekRengi.kirmizi;
            mercimek.Malzemeler = new List<string> { "soğan", "havuç", "mercimek" };
            mercimek.KaynamaDerecesi = 120;
            mercimek.Miktar = Miktar.tam;
            mercimek.EkmekBan();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Domates domates = new Domates();
            domates.Fiyat = 25;
            domates.Miktar=Miktar.tam;
            domates.KasarliMi = true;
            domates.EkmekBan();
            domates.Malzemeler = new List<string> { "assa", "asasa", "dsdsd" };
            domates.KaynamaDerecesi = 85;
           

        }
    }
}
