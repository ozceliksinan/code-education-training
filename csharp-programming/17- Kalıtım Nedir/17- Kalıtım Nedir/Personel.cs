using System;
using System.Collections.Generic;
using System.Text;

namespace _17__Kalıtım_Nedir
{
    public class Personel : temelTip
    {
        public DateTime IsBaslangicTarih { get; set; }
        public DateTime IsBitisTarih { get; set; }
        public int IzinGunSayisi { get; set; }

        public Personel()
        {
            Console.WriteLine("Personel nesnesi yapıcı metot");
        }
    }
}
