using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_OOP_Sealed_Class
{

    public class Kitap:BaseBook
    {

        //override ile ezerek aynı methodu farklı bır amacla kullanabiliriz.
        public override void Read()
        {
            System.Windows.Forms.MessageBox.Show("sessiz okuma yap");
        }

    }


    public class BaseBook
    {
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }

        /// <summary>
        /// Virtual olarak metodu işaretlediğimiz için çağırıldığı yerde istenildiği gibi gövdesi değiştirilerek veya aynı şekilde kullanılabilir. 
        /// </summary>
        public virtual void Read ()
        {
            System.Windows.Forms.MessageBox.Show("sesli oku");
        }

        

    }
    
        
        
}
