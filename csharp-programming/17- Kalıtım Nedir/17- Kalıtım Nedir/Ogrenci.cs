using System;
using System.Collections.Generic;
using System.Text;

namespace _17__Kalıtım_Nedir
{
    public sealed class Ogrenci : temelTip
    {
        public string bolum { get; set; }
        public int seviye { get; set; }

        public Ogrenci()
        {
            Console.WriteLine("Ogrenci nesnesi çalıştı");

            // TemelTipMetot2(); protected olarak işaretlendiği için ve bu nesne kendisini temeltip nesnesinden kalıttığı için protected seviyesinde olan field veya metotlara erişebilir. 

        }
    }
}