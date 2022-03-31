using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7_OOP_Inheritance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MobilePhone mobilePhone = new MobilePhone(true, true,"İphone",true) ;
            mobilePhone.WifiBagla();
            mobilePhone.TakePhoto();
            mobilePhone.Call();


            SmartPhone smartPhone = new SmartPhone("Samsung",false,true,true);
            smartPhone.Call();
            smartPhone.DoVideoCall();
            smartPhone.TakePhoto();
            smartPhone.WifiBagla();

        }
    }
}
