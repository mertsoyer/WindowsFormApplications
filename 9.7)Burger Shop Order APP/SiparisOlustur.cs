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
using Menu = _9._7_Burger_Shop_Order_APP.Classes.Menu;

namespace _9._7_Burger_Shop_Order_APP
{
    public partial class SiparisOlustur : Form
    {
        public SiparisOlustur()
        {
            InitializeComponent();
        }

        public static List<Menu> menuler = new List<Menu>();

        public static List<Extra> extralar = new List<Extra>();
   

        private void SiparisOlustur_Load(object sender, EventArgs e)
        {
            rdBuyukBoy.Checked = true;

            foreach (Menu item in menuler)
            {
                cmbMenu.Items.Add(item);
            }

            foreach (Extra item in extralar)
            {
                flpEkstraMalzemeler.Controls.Add(new CheckBox()
                {
                    Text = item.EkstraAdi,
                    Tag = item,
                });
            }
          

        }
    }
}
