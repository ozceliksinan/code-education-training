using System;
using System.Collections.Generic;
using System.Text;

namespace _20__Sanal_Metotların_Kullanımı
{
    public class baseClass
    {
        public baseClass()
        {
            Console.WriteLine("base class");
        }
        public virtual void ekranaYaz(string data)
        {
            Console.WriteLine(data);
        }
    }
}
