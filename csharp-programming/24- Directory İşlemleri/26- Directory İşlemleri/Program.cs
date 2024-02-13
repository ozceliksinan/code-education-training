using System;
using System.IO;

namespace _26__Directory_İşlemleri
{
    class Program
    {
        static void Main(string[] args)
        {
            //YeniKlasorOlustur("c:\\Sinan");
            //KlasorVarlikKontrolu("c:\\Sinan");
            //KlasorSilmeIslemleri("c:\\Sinan");
            //KlasorTasima("c:\\Sinan", "c:\\TasimaIslemi\\Sinan");
        }
        static void YeniKlasorOlustur(string path)
        {
            // using System.IO eklenmelidir.
            DirectoryInfo DI = Directory.CreateDirectory(path); // Nesne olarak döndü
            // Hangi klasör oldu, en son erişilen zaman, en son değişiklik zamanları gibi özelliklerini bu nesne aracılığı ile görebiliriz.
        }
        static void KlasorVarlikKontrolu(string path)
        {
            // Parametre olarak alınan path yolunda klasör var mı yok mu diye true veya false döndürür.
            // Exists metodu ile kontrol sağlanır
            bool kontrol = Directory.Exists(path);
        }
        static void KlasorSilmeIslemleri(string path)
        {
            // Güvenlik kontrolunu geçebilmek içim delete parametresine true ya da false değerini girmemiz gerekiyor.
            // True: Silinen klasörün içinde dosya varsa da sil demektir.
            Directory.Delete(path, true);
        }
        static void OdevI()
        {
            /*
             * C sürücüsü içerisinde Sinan adında bir klasör oluşturun oluşturmadan önce varlık kontorlü yapın eğer klasor var ise silin daha sonra oluşturun 
             * eğer klasor yok ise oluşturun fakat bu adımların bilgisini ekrana yazdırın .
             */

            string dosyaYol = @"c:\Sinan";
            bool kontrol = Directory.Exists(dosyaYol);
            if (kontrol)
            {
                Console.WriteLine("Eklemek istediğiniz klasör sistemde mevcut");
                Console.Write("Silmek ve yerine yeni olarak oluşturmak istiyor musunuz [E/H]");
                string cevap = Console.ReadLine().ToUpper();
                if (cevap == "E")
                {
                    Directory.Delete(dosyaYol, true);
                    Console.WriteLine("Dosya silme işlemi tamamlandı");
                    System.Threading.Thread.Sleep(2000);
                    Console.WriteLine(dosyaYol + " sisteminize oluşturuluyor");
                    Directory.CreateDirectory(dosyaYol);
                }
                else
                {
                    Console.WriteLine("İşlem Bitti");
                }

            }
            else
            {
                DirectoryInfo DI = Directory.CreateDirectory(dosyaYol);
                if (DI.Exists)
                {
                    Console.WriteLine("Dosya sistemde oluşturuldu");
                }
            }
        }
        static void KlasorTasima(string kaynak, string hedef)
        {
            Directory.Move(kaynak, hedef);
        }
    }
}