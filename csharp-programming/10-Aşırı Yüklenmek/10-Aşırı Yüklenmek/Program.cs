using System;

namespace _10_Aşırı_Yüklenmek
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("merhaba dünya");
            //Console.WriteLine(true);

            //decimal toplam = topla(12M, 45M);
            //EkrandaGoster(toplam);

            EkrandaGoster(topla(12, 33));

        }

        static void EkrandaGoster(object o)
        {
            Console.WriteLine(o.ToString());
        }

        static int topla(int sayi1, int sayi2)
        {
            int toplam = sayi1 + sayi2;
            return toplam;
        }

        static decimal topla(decimal sayi1, decimal sayi2)
        {
            decimal toplam = sayi1 + sayi2;
            return toplam;
        }

        static string topla(string metin1, string metin2)
        {
            return metin1 + " " + metin2;
        }
    }
}
