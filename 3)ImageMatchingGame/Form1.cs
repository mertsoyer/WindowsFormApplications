using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_ImageMatchingGame
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        List<string> icons = new List<string>()
        {
            "a","a","b","b","c","c","d","d","e","e","g","g","h","h","!","!"
        };

        public Form1()
        {
            InitializeComponent();
        }

   
    }
}
