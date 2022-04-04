using _10_OOP_Basic_Sample.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_OOP_Basic_Sample.Forms
{
    public partial class FormCalisan : Form
    {
        public FormCalisan()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calisan calisan = new Calisan();
            calisan.AdSoyad = textBox1.Text;
            calisan.Sehir = textBox2.Text;
            calisan.Unvani= textBox3.Text;

            StreamWriter yazici = new StreamWriter("calisan.txt",true);
            string satir = string.Format("{0};{1};{2}", calisan.AdSoyad, calisan.Sehir, calisan.Unvani);
            yazici.Write(satir);
            yazici.Close();
            MessageBox.Show("Çalışan kaydedildi");
            Temizle();

            (this.MdiParent as FormMain).TumListViewleriGuncelle();
        }

        /// <summary>
        /// textboxların içini temizlemek için
        /// </summary>
        void Temizle()
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = String.Empty;
                }
            }

        }
    }
}
