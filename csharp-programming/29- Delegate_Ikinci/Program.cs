using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Ikinci
{
    class Program
    {
        delegate void MatematikselIslemler(int Sayi1, int Sayi2);

        static void Topla(int Sayi1, int Sayi2)
        {
            int Sonuc = Sayi1 + Sayi2;
            Console.WriteLine("Toplam işleminin sonucu : {0}", Sonuc);
        }

        static void Cikart(int Sayi1, int Sayi2)
        {
            int Sonuc = Sayi1 - Sayi2;
            Console.WriteLine("Çıkartma işleminin sonucu : {0}", Sonuc);
        }

        static void Carp(int Sayi1, int Sayi2)
        {
            int Sonuc = Sayi1 * Sayi2;
            Console.WriteLine("Çarpma işleminin sonucu : {0}", Sonuc);
        }

        static void Main(string[] args)
        {
            //Topla(10, 20);
            //Cikart(20, 2);
            //Carp(20, 2);

            MatematikselIslemler M1 = new MatematikselIslemler(Topla);
            M1 += Carp;
            M1 += Cikart;

            //M1.Invoke(30, 2);

            Delegate[] IsaretEdilenMetotlar = M1.GetInvocationList();

            foreach (var item in IsaretEdilenMetotlar)
            {
                Console.WriteLine(item.Method.Name);
            }

            M1 -= Carp; // Metot çıkarıldı
            foreach (var item in M1.GetInvocationList())
            {
                Console.WriteLine(item.Method.Name);
            }

            M1 -= Cikart; // Metot çıkarıldı
            foreach (var item in M1.GetInvocationList())
            {
                Console.WriteLine(item.Method.Name);
            }

            M1 += Carp; // Metot eklendi
            foreach (var item in M1.GetInvocationList())
            {
                Console.WriteLine(item.Method.Name);
            }

            Console.ReadLine();
        }
    }
}
