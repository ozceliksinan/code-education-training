using System;
using System.Collections.Generic;
using System.Text;

namespace _14_Personel_Uygulaması
{
    public class Personel
    {
        public static string domainAdres;
        public string Isim { get; set; }
        public string Soyisim { get; set; }

        private string _emailadres;
        public string Emailadres
        {
            get
            {
                return this._emailadres;
            }
            set
            {
                this._emailadres = value.ToLower() + "@" + Personel.domainAdres;
            }
        }

        public int Cinsiyet { get; set; }

        public Personel()
        {
            Console.WriteLine("Her örneklemede çalışan metot");
        }

        static Personel()
        {
            domainAdres = "firmam.com";
        }
    }
}
