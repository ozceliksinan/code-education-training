using System;

namespace _30__Delegete_Nedir
{
    class Program
    {
        // Delegate metot tutuculardır.
        // Aynı metot imzasına sahip olam metotları saklayan ve sırası ile çalıştıran yapılardır.

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

            // Topla metodunu işaret edecek şekilde delegemiz örneklendi.
            MatematikselIslemler M1 = new MatematikselIslemler(Topla);

            M1 += Carp; // Çarp metodunun işaret edilmesini söyledik delegeye
            M1 += Cikart; // Çıkart metodunun işaret edilmesini söyledik delegeye
                          // Derlenip çalıştığında alt alta sıralı bir şekilde 3 metot da çalışır.

            // invoke ile ilgili delege çağrılır.
            //M1.Invoke(30, 2); // Invoke metodu ile verilmiş olan değerleri sırası ile ilgili metotlar ile çalıştırır.

            // GetInvocationList delege tipinde liste şeklinde değer döndürür.
            Delegate[] IsaretEdilenMetotlar = M1.GetInvocationList();

            foreach (var item in IsaretEdilenMetotlar)
            {
                Console.WriteLine(item.Method.Name);
            }
            Console.ReadLine();
        }
    }
}