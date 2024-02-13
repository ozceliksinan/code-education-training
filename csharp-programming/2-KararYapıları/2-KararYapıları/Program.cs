using System;

namespace _2_KararYapıları
{
    class Program
    {
        static void Main(string[] args)
        {
            string isimSoyisim = string.Empty;

            string kullaniciGelen1 = string.Empty;
            string kullaniciGelen2 = string.Empty;
            string kullaniciGelen3 = string.Empty;

            int not1, not2, not3 = 0;

            double ortalama = 0;

            Console.WriteLine("Lütfen ortalamasını hesaplamak istediğiniz öğrencinin bilgilerini giriniz");

            Console.Write("İsim Soyisim : ");
            isimSoyisim = Console.ReadLine();

            Console.Write("1. Not değerini giriniz : ");
            kullaniciGelen1 = Console.ReadLine();

            Console.Write("2. Not değerini giriniz : ");
            kullaniciGelen2 = Console.ReadLine();

            Console.Write("3. Not değerini giriniz : ");
            kullaniciGelen3 = Console.ReadLine();

            not1 = int.Parse(kullaniciGelen1);
            not2 = int.Parse(kullaniciGelen2);
            not3 = int.Parse(kullaniciGelen3);

            ortalama = (not1 + not2 + not3) / 3;

            if (ortalama >= 45)
            {
                Console.WriteLine("Merhaba {0}", isimSoyisim);
                Console.WriteLine("Not ortalamanız {0} değeri ile geçtiniz", ortalama);
            }
            else Console.WriteLine("Kaldınız");

            /********************************************************************************/
            /*                             SWITCH - CASE YAPISI                             */
            /********************************************************************************/
            string kullaniciGelenDeger = string.Empty;

            // Goto kullanımı için bir başlık tanımlaması yapalım. 

            YenidenSecim:

            Console.WriteLine("Lütfen bulunduğunuz ay'ın sayısal değerini yazınız");
            kullaniciGelenDeger = Console.ReadLine();

            switch (kullaniciGelenDeger)
            {
                case "1": Console.WriteLine("Ocak"); break;
                case "2": Console.WriteLine("Şubat"); break;
                case "3": Console.WriteLine("Mart"); break;
                case "4": Console.WriteLine("Nisan"); break;
                case "5": Console.WriteLine("Mayıs"); break;
                case "6": Console.WriteLine("Haziran"); break;
                case "7": Console.WriteLine("Temmuz"); break;
                case "8": Console.WriteLine("Agustos"); break;
                case "9": Console.WriteLine("Eylül"); break;
                case "10": Console.WriteLine("Ekim"); break;
                case "11": Console.WriteLine("Kasım"); break;
                case "12": Console.WriteLine("Aralık"); break;
                default:
                    Console.WriteLine("Aralık dışı değer girişi yaptınız...");
                    goto YenidenSecim;
            }
        }
    }
}
