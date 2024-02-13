using System;
using System.Collections.Generic;
using System.Text;

namespace _21__Abstract_Nedir
{
    public abstract class temelSinif
    {
        public DateTime kayitTarih { get; set; }
        public DateTime guncellemeTarih { get; set; }

        public temelSinif()
        {
            kayitTarih = DateTime.Now;
            guncellemeTarih = DateTime.Now;
        }

        public void test()
        {
            Console.WriteLine("temel sınıf => test");
        }

        // Abstract metotların body içeriği olmaz.
        // Abstract class miras alındığında abstract metot varsa bu metot kullanılmak zorundadır.
        public abstract void testAbstract(); // metot imzası yazılır ve bırakılır.
        //{
        //}
    }
}
