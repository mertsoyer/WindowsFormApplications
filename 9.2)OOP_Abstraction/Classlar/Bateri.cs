using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._2_OOP_Abstraction.Classlar
{
    internal class Bateri : MuzikAleti
    {

        public int Id { get; set; }
        public override string Cal()
        {

            return "bateri çalınıyor";
        }
    }
}
