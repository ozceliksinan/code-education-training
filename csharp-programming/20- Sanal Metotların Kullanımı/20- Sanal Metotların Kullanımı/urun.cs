using System;
using System.Collections.Generic;
using System.Text;

namespace _20__Sanal_Metotların_Kullanımı
{
    public class urun : baseClass
    {
        public urun()
        {
            Console.WriteLine("urun");
        }
        public override void ekranaYaz(string data)
        {
            Console.WriteLine("urun => " + data);
        }
    }
}
