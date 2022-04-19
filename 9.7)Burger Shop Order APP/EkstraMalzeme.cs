using _9._7_Burger_Shop_Order_APP.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9._7_Burger_Shop_Order_APP
{
    public partial class EkstraMalzeme : Form
    {
        public EkstraMalzeme()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SiparisOlustur.extralar.Add(new Extra
            {
                EkstraAdi = textBox1.Text,
                Fiyat=numericUpDown1.Value
                
            });
            MessageBox.Show("başarıyla eklendi");
            //form temizleme metodunu direk temizlenmesini istediğimiz form kontrolleri üzerinden çağırıyoruz.
            Fonksiyonlar.FormTemizle(groupBox1.Controls);
        }
    }
}
