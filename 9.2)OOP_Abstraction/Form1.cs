using _9._2_OOP_Abstraction.Classlar;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Gitar gitar = new Gitar();
            gitar.Markasi = "Yamaha";
            gitar.Aciklamasi = "Sol el";
            gitar.Id = 1;

            string ses = gitar.Cal();

            Muzisyen muzisyen = new Muzisyen();
            muzisyen.Adi = "Mert";
            muzisyen.Soyadi = "Soyer";
            muzisyen.CaldigiEnstruman = gitar;

            MessageBox.Show($"Gitarist Adı:{muzisyen.Adi} \n Gitarist Soyad: {muzisyen.Soyadi} \n Ensturuman {ses} ");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bateri bateri = new Bateri();
            bateri.Markasi = "Batery";
            bateri.Aciklamasi = "Çalmalı bateri";
            bateri.Id = 2;
            string bateriSes = bateri.Cal();

            Muzisyen muzisyen = new Muzisyen();
            muzisyen.Adi = "John";
            muzisyen.Soyadi = "Doe";
            muzisyen.CaldigiEnstruman = bateri;


            MessageBox.Show($"Gitarist Adı:{muzisyen.Adi} \n Gitarist Soyad: {muzisyen.Soyadi} \n Ensturuman {bateriSes} ");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            YanFulut yanFulut = new YanFulut();
            yanFulut.Markasi = "yandan";
            yanFulut.Aciklamasi = "Yandan calacaksın";
            string yanFulutSes = yanFulut.Cal();


            Muzisyen muzisyen = new Muzisyen();
            muzisyen.CaldigiEnstruman = yanFulut;
            muzisyen.Adi = "Jane";
            muzisyen.Soyadi = "Doe";

            MessageBox.Show($"Muzisyen adı : {muzisyen.Adi}, soyadı {muzisyen.Soyadi}, caldıgı enst: {yanFulutSes}");

        }
    }
}
