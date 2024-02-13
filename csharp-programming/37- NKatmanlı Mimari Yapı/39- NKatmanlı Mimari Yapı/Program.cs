using System;

namespace _39__NKatmanlı_Mimari_Yapı
{
    class Program
    {
        static void Main(string[] args)
        {
            // UI : User Interface 
            // Kullanıcılarımızın kullanmış olduğu uygulamanın görsel ara yüzü;
            // Windows Form,
            // Web Form,
            // vb...

            BusinessLogicLayer BLL = new BusinessLogicLayer();

            int EKS = BLL.VeriKaydet(1, string.Empty, "Sinan");

            if (EKS > 0)
            {
                Console.WriteLine("İşlem Başarılı");
            }
            else
            {
                Console.WriteLine("İşlem Başarısız");
            }

            Console.ReadLine();
        }
    }
}
