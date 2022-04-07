using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9._6_IEnumarable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //string[] isimler = new string[3];
            //isimler[0] = "SOY39";
            //isimler[1] = "SOY40";
            //isimler[2] = "SOY41";


            Personel personel = new Personel();
            foreach (string item in personel)
            {
                MessageBox.Show(item);
            }
        }
    }
}
