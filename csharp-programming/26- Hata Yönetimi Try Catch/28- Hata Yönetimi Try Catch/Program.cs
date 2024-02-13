using System;

namespace _28__Hata_Yönetimi_Try_Catch
{
    class Program
    {
        static void Main(string[] args)
        {
            // MerhabaHataYonetimi();
            HataYonetimiInceleme();
        }
        static void HataYonetimiInceleme()
        {
            try
            {
                // Standart uygulama için yazmış olduğumuz kod blokları 
                Console.WriteLine("Bir sayı girişi yapınız");
                int sayi1 = int.Parse(Console.ReadLine());

                if (sayi1 == 10)
                {
                    throw new OzelHataSinifi();
                }
            }
            catch (OzelHataSinifi fx)
            {
                Console.WriteLine("Ozel hata sınıfı catch içerisinde yakalandı");
            }
            catch (FormatException fx)
            {
                Console.WriteLine("Sizden beklenen değer sayısal bir değerdir.");
                Console.WriteLine(fx.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Herhangi bir hata oluştu");
                Console.WriteLine(ex.Message);
                // Catch blokları sistem içerisinde çalışma zamanında alınan hataların 
                // loglanmasına ve kullanıcıya daha açıklayıcı hata mesajları vermemize yarayan bloklardır.
            }
            finally
            {
                // Try kısmında bizim kodlarımız çalışır , 
                // Catch => ....
                // Finally => Kod tarafında herhangi bir hata almasakda bizim finally çalışmaya devam eder. 
                Console.WriteLine("Finally bloğu çalıştı");
            }

            Console.WriteLine("Uygulama Bitti");
            Console.ReadLine();
        }
        static void MerhabaHataYonetimi()
        {
            Console.WriteLine("Bir sayı girişi yapınız");
            int sayi1 = int.Parse(Console.ReadLine());
        }
    }
}