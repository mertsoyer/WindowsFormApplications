using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9_OOP_Static_Member
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            //INSTANCE ALMADAN STATIC OLDUGU ICIN KULLANABİLİYORUZ.
            //formun adını yercekiminden al
            this.Text=FizikKutuphanesi.YerCekimi.ToString();

            MessageBox.Show(FizikKutuphanesi.IndirmeKuvveti.ToString());
        }
    }
}
