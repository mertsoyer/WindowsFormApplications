using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._3_OOP_Interface.Class_Araba
{
    // Interface kendısınden ımplement edılen bir sınıfa , doldurulması zorunlu olan bazı yetenek / ozellıklerın aktarılmasını sağlayan yapılardır

    // tanımlanan herşeyin sadece imzası olur, gövdesi olamaz.

    // bir sınıf sadece bir sınıfı miras olarak alabilir, ama birden fazla interface dahil / implement edilebilir.

    // interfaceler başka interfaceleri implement edebilir.

    // interfaceler başka bir sınıftan miras alamazlar.
    public interface ITekerlekliArac
    {

         int TekerlekSayisi { get; set; }
        void Calistir();

    }
}
