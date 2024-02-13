using System;
using System.Collections.Generic;
using System.Text;

namespace _17__Kalıtım_Nedir
{
    public sealed class Egitmen : Personel
    {
        public string Brans { get; set; }
        public int BransSeviye { get; set; }

        public Egitmen()
        {
            Console.WriteLine("Egitmen nesnesinin yapıcı metotu çalıştı");
            //IdAtamaIslemi
        }
    }
}
