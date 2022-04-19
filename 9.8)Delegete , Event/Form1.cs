using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9._8_Delegete___Event
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Delegate ile bir olay gerçekleştiğinde birden fazla fonksiyonu çağırmak istersen delegate adlı yapıyı kullanırız. Bir dugmeye tıklandıgı zaman birden fazla metodun calısması gibi.


        //Delegate oluşturma tanımlama
        //Orneklendırme ( ınstance)
        //Çağırma (Invoke)




        #region Delegate Metot 
        private delegate void MetotTemsilcisi();
        private void Metodum()
        {
            MessageBox.Show("hello world");
        }
        #endregion


        //parametre alan delegate metot
        private delegate void MetotTemsilcisi2(string deger);
        private void Metodum2(string kutu)
        {
            MessageBox.Show(kutu);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MetotTemsilcisi temsilci = new MetotTemsilcisi(Metodum);

            temsilci();



            MetotTemsilcisi2 temsilci2 = new MetotTemsilcisi2(Metodum2);
            temsilci2("dede");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region delegate metot kullanmadan normal yazım
            //string yazi = textBox1.Text;

            //if (checkBox1.Checked == true)
            //{
            //    label1.Text = yazi + "tıklandı";
            //}
            //else
            //{
            //    label1.Text = yazi + "tıklanmadı";
            //} 
            #endregion
            CheckTemsilci checkTemsilci = new CheckTemsilci(MetiniYaz);
            checkTemsilci();
            
        }

        private delegate void CheckTemsilci();
        private void MetiniYaz()
        {
            label1.Text = textBox1.Text;
        }
        private void CheckBoxYaz()
        {
            if (checkBox1.Checked==true)
            {
                label1.Text = "secıldı";
            }
        }
            
    }
}
