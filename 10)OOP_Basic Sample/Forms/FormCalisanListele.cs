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
    public partial class FormCalisanListele : Form
    {
        /// <summary>
        /// Calisanlar formunun constructor methodunda metodu cagırdık
        /// </summary>
        public FormCalisanListele()
        {
            InitializeComponent();
            ListViewAyarla();
        }



        public void VeriyiCek()
        {
            listView1.Items.Clear();
            StreamReader okuyucu = new StreamReader("calisan.txt");

            string satir;
            while ((satir = okuyucu.ReadLine()) != null)
            {

                string[] calisanBilgileri = satir.Split(';');

                ListViewItem itm = new ListViewItem();
                itm.Text = calisanBilgileri[0];
                itm.SubItems.Add(calisanBilgileri[1]);
                itm.SubItems.Add(calisanBilgileri[2]);

                listView1.Items.Add(itm);
            }

            okuyucu.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormCalisanListele_Load(object sender, EventArgs e)
        {
            VeriyiCek();
        }


        /// <summary>
        /// çalışanları listele formundaki listview özellik ve kolonlarını ayarlar.
        /// </summary>
        private void ListViewAyarla()
        {

            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;

            ColumnHeader kolonAdSoyad = new ColumnHeader();
            kolonAdSoyad.Text = "Ad Soyad";
            kolonAdSoyad.Width = 150;

            ColumnHeader kolonSehir = new ColumnHeader();
            kolonSehir.Text = "Şehir";
            kolonSehir.Width = 100;

            ColumnHeader kolonUnvan = new ColumnHeader();
            kolonUnvan.Text = "Ünvan";
            kolonUnvan.Width = 100;



            listView1.Columns.Add(kolonAdSoyad);
            listView1.Columns.Add(kolonSehir);
            listView1.Columns.Add(kolonUnvan);
        }
    }
}
