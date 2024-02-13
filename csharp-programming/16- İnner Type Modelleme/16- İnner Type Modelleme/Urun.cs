using System;
using System.Collections.Generic;
using System.Text;

namespace _16__İnner_Type_Modelleme
{
    public class Urun
    {
        public string Tanim { get; set; }
        public decimal fiyat { get; set; }

        public Urun()
        {
            Console.WriteLine("Urun Yapıcı Metot Çalıştı");
        }

        public void UrunTestMetot()
        {
            Console.WriteLine("UrunTestMetot");
        }
    }
}
