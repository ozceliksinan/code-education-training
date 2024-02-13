using System;
using System.Collections.Generic;
using System.Text;

namespace _19__Sanal_Metot_Nedir
{
    public class Musteri // : Object => Framework standart olarak tüm nesneleri object den türetir. 
    {
        public int musteriID { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public override string ToString()
        {
            return isim + " " + soyisim;
        }
    }
}
