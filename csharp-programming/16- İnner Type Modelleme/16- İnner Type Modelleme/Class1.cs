using System;
using System.Collections.Generic;
using System.Text;

namespace _16__İnner_Type_Modelleme
{
    public class Class1
    {
        public int iletisimTip { get; set; } // 717770001 : Mobil - 717770002 : Sabit Hat
        public string alankodu { get; set; }
        public string numara { get; set; }
        public bool aktifPasif { get; set; }

        public void MusteriIletisimBilgisiTestMetot()
        {
            Console.WriteLine("MusteriIletisimBilgisiTestMetot");
        }
    }
}
