using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9._5_Recursive_Function
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private int Faktoriyel_Recursive(int sayi)
        {
            if (sayi==0)
            {
                return 1;
            }
            else
            {
                return sayi * Faktoriyel_Recursive(sayi - 1);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int sonuc = Faktoriyel_Recursive(5);
            MessageBox.Show(sonuc.ToString());
        }
    }
}
