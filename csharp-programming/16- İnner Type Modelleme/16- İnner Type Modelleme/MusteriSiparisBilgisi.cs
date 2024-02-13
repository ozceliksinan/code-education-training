using System;
using System.Collections.Generic;
using System.Text;

namespace _16__İnner_Type_Modelleme
{
    public class MusteriSiparisBilgisi
    {
        public string siparisNumarasi { get; set; }

        public Urun[] urunler;

        public MusteriSiparisBilgisi()
        {
            urunler = new Urun[2];
        }

        public void MusteriSiparisBilgisiTestMetot()
        {
            Console.WriteLine("MusteriSiparisBilgisiTestMetot");
        }
    }
}
