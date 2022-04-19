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
    public partial class DelegateOrnek : Form
    {
        public DelegateOrnek()
        {
            InitializeComponent();
        }

        public delegate void SelamlaHandler();
        
        
        void Selamla()
        {
            MessageBox.Show("Tokalaşıldı");
        }

        void Selamla1()
        {
            MessageBox.Show("Uzaktan selamlaşıldı");
        }

        void Selamla2(string selamSekli)
        {
            MessageBox.Show(selamSekli+""+"ile selamlandı");
        }

        void Selamla3()
        {
            MessageBox.Show("selamsız çıkıldı");
        }

        private void DelegateOrnek_Load(object sender, EventArgs e)
        {
            SelamlaHandler handler = new SelamlaHandler(Selamla);
            handler += Selamla1;
            handler += Selamla3;

            handler();


        }
    }
}
