using System;
using System.Collections.Generic;
using System.Text;

namespace _16__İnner_Type_Modelleme
{
    public class MusteriAdres
    {
        public string adresTip { get; set; }
        public string Il { get; set; }
        public string Ilce { get; set; }
        public string Adres { get; set; }

        public MusteriAdres()
        {
            Console.WriteLine("Musteri Adres yapıcı metotu çalıştı...");
        }

        public void MusteriAdresTestMetot()
        {
            Console.WriteLine("MusteriAdresTestMetot");
        }
    }
}
