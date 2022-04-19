using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9._7_Burger_Shop_Order_APP
{
    public static class Fonksiyonlar
    {
        /// <summary>
        /// formları temizlemek için metot
        /// </summary>
        /// <param name="koleksiyon"></param>
        public static void FormTemizle(Control.ControlCollection koleksiyon)
        {
            foreach (Control item in koleksiyon)
            {
                if (item is TextBox)
                {
                    TextBox textBox = (TextBox)item;
                    textBox.Clear();
                }

                if (item is NumericUpDown)
                {
                    NumericUpDown numericUpDown = (NumericUpDown)item;
                    numericUpDown.Value = 0;

                }
                if (item is RadioButton)
                {
                    RadioButton radioButton = (RadioButton)item;
                    radioButton.Checked = false;
                }
            }
        }
    }
}
