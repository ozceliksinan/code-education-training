using System;

namespace _8_MetotlaraGiriş
{
    class Program
    {
        static void Main(string[] args)
        {
            Matematik M = new Matematik();
            YenidenIslemYap:
            M.menuHazirla();
            int kullaniciSecim = int.Parse(Console.ReadLine());

            Console.WriteLine("Lütfen 1. sayı değerini giriniz");
            decimal kullaniciSayi1 = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Lütfen 2. sayı değerini giriniz");
            decimal kullaniciSayi2 = decimal.Parse(Console.ReadLine());

            decimal sonuc = 0;

            switch (kullaniciSecim)
            {
                case 1: // Toplama 
                    sonuc = M.toplamaIslemi(kullaniciSayi1, kullaniciSayi2);
                    M.sonucEkranaYaz(kullaniciSayi1, kullaniciSayi2, sonuc, "+");
                    break;
                case 2: // Çıkartma
                    sonuc = M.cikartmaIslemi(kullaniciSayi1, kullaniciSayi2);
                    M.sonucEkranaYaz(kullaniciSayi1, kullaniciSayi2, sonuc, "-");
                    break;
                case 3: // Bölme
                    sonuc = M.bolmeIslemi(kullaniciSayi1, kullaniciSayi2);
                    M.sonucEkranaYaz(kullaniciSayi1, kullaniciSayi2, sonuc, "/");
                    break;
                case 4: // Çarpma İşlemi 
                    sonuc = M.carpmaIslemi(kullaniciSayi1, kullaniciSayi2);
                    M.sonucEkranaYaz(kullaniciSayi1, kullaniciSayi2, sonuc, "*");
                    break;
                default:
                    Console.WriteLine("Belirtmiş olduğunuz değer liste içerisinde bulunamadı.");
                    Console.WriteLine("Lütfen yeniden deneyiniz");
                    System.Threading.Thread.Sleep(2000);
                    goto YenidenIslemYap;
            }

            Console.WriteLine("Yeni işlem yapmak istiyor musunuz ? [E/H] ");
            string EH = Console.ReadLine();
            if (EH == "E")
            {
                goto YenidenIslemYap;
            }
        }
    }
}
