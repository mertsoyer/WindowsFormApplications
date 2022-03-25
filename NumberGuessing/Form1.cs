using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberGuessing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        int sayi = 0;
       


        private void button1_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            int number = Convert.ToInt32(textBox1.Text);

            if (number == sayi)
            {
                MessageBox.Show("Doğru tahmin ettiniz");
                

            }
            else if (number > sayi)
            {
                MessageBox.Show("Daha kuçük bir sayı yazın");


            }
            else
            {
                MessageBox.Show("Daha büyük bir sayı yazın");
                textBox1.Clear();
            }



        }


        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            Random rnd = new Random();
            sayi = rnd.Next(0, 100);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
        }
    }
}
