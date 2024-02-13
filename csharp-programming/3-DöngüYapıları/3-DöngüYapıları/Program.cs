using System;

namespace _3_DöngüYapıları
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Genel Kullanımı
            string[] Isimler = new[] { "Name1 Surname1", "Name2 Surname2", "Name3 Surname3", "Name4 Surname4" };

            foreach (string item in Isimler)
            {
                Console.WriteLine(item);
            }

            #endregion
            Console.Clear();
            #region Ornek Uygulamalar -- 

            #region Uygulama 1 : int veri tipinde bir dizi oluşturalım , kullanıcımız dizinin kaç elemanlı olacağı bilgisini bize versin, ve dizi içindeki alanlara değer ataması yapsın. Daha sonra dizi içerisindeki elemanların toplamlarını ve ortalamasını ekrana yazdıran bir uygulama yazalım. 

            //Console.WriteLine("Lütfen oluşturmak istediğiniz veri kümesinin uzunluğunu giriniz");
            //string uygulama1DiziUzunluk = Console.ReadLine();
            //int uygulamaDiziUzunlukInt = int.Parse(uygulama1DiziUzunluk);

            //int[] uygulama1Dizi = new int[uygulamaDiziUzunlukInt];

            //for (int uygulamaSayac = 0; uygulamaSayac < uygulama1Dizi.Length; uygulamaSayac++)
            //{
            //    Console.WriteLine("{0}. index e denk gelen değeri giriniz", uygulamaSayac);

            //    uygulama1Dizi[uygulamaSayac] = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("Tebrikler dizinin içerisindeki tüm alanları doldurdunuz");

            //Console.WriteLine("Dizi içerisindeki değerler ve toplam, ortalama değeri aşağıdaki gibidir.");

            //int uygulama1Toplam = 0, uygulama1Ortalama = 0;
            //foreach (int item in uygulama1Dizi)
            //{
            //    Console.WriteLine(item);
            //    uygulama1Toplam = uygulama1Toplam + item;
            //}
            //Console.WriteLine("+----------------------------");

            //Console.WriteLine(uygulama1Toplam);

            //Console.WriteLine("Dizi içerisindeki eleman sayısı : {0}", uygulama1Dizi.Length);
            //uygulama1Ortalama = uygulama1Toplam / uygulama1Dizi.Length;
            //Console.WriteLine("Ortalama : {0}", uygulama1Ortalama);

            #endregion

            #region Uygulama 2: 20 elemanlı bir int dizi oluşturalım. Değerlerimizi random sınıfının next fonksiyonu ile 1 - 10 arasındaki değerler ile dolduralm. Daha sonra dizi içerisindeki elemanlarımızı ekrana yazdıralım ve ilgili dizi içerisinde kaç tane 4 değeri olduğunu bulalım. 

            Random Rnd = new Random();

            int[] uygulama2Dizi = new int[20];
            for (int uygulama2Sayac = 0; uygulama2Sayac < uygulama2Dizi.Length; uygulama2Sayac++)
            {
                uygulama2Dizi[uygulama2Sayac] = Rnd.Next(1, 10);
            }

            int uygulama2Bul = 0;

            foreach (int item in uygulama2Dizi)
            {
                Console.WriteLine(item);
                if (item == 4)
                    uygulama2Bul++;
            }

            Console.WriteLine("Dizi içindeki 4 değeri {0} adettir.", uygulama2Bul);
            #endregion

            #endregion


            /*************************************************************************************/
            /*                           WHILE DÖNGÜSÜ KULLANIMI                                 */
            /*************************************************************************************/

            #region While Döngüsü Genel Kullanımı 
            //while (true) // Şartımız true olduğu süre boyunca döngümüz çalışmasına devam eder. 
            //{
            //    /*
            //     * 1 - While ( False ) 
            //     * 2 - Break; 
            //     */
            //}

            #endregion

            #region Örnek Kullanım 1 : Ekrana 1 - 10 a kadar sayıların değerlerini yazdıralım. 

            // For döngüsü ile bu işlemin cevabı 
            //for(int i = 1; i<=10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            int sayac = 1;
            while (sayac <= 10)
            {
                Console.WriteLine(sayac);
                sayac++;
            }

            #endregion
            Console.Clear();
            #region Kullanıcıdan gelen sayısal değere göre ekrana 1 eksilterek 0 değerine ulaşıncaya kadar ekrana yazalım 
            /*
             * 3
             * 2
             * 1
             * 0
             */

            //Console.WriteLine("Lütfen bir sayı giriniz:");
            //string kullanicidanGelenDeger = Console.ReadLine();
            //Console.WriteLine("---------------------------------------------");
            //int ornekKullanimSayac = int.Parse(kullanicidanGelenDeger);

            //while (ornekKullanimSayac != -1)
            //{
            //    Console.WriteLine(ornekKullanimSayac);
            //    ornekKullanimSayac = ornekKullanimSayac - 1;
            //    //ornekKullanimSayac--;
            //}

            //Console.WriteLine("Örnek 1 işlemi tamamlandı");

            #endregion
            Console.Clear();
            #region Kullanıcıdan gelen değerlerin toplamını ekrana yazdıralım. 0 dan kucuk bir değer girişi yapılırsa toplama işlemini bitirelim. ve ekrana toplam sonucu yazalım. 

            //Console.WriteLine("Lütfen toplamak istediğiniz sayıları giriniz. ");
            //Console.WriteLine("Not : -1  değeri işlemlerinizi dururur.");

            //int ornekKullanimToplam = 0;
            //while (true)
            //{
            //    string Ornek2KullaniciGelenDeger = Console.ReadLine();
            //    int Ornek2KulGelenDegerInt = int.Parse(Ornek2KullaniciGelenDeger);
            //    if (Ornek2KulGelenDegerInt < 0)
            //        break;
            //    else
            //        ornekKullanimToplam = ornekKullanimToplam + Ornek2KulGelenDegerInt;
            //}

            //Console.WriteLine("Toplam Değer : {0}", ornekKullanimToplam);

            #endregion
            #region Ödev : Sistemin çalışma zamanında oluşturduğu 1 ile 10 arasındaki bir değeri kullanıcının tahmin etmesini isteyecek bir uygulama yazalım. 

            int sistemUretSayi = 0;
            int tahmminAdet = 1;
            Random rnd = new Random();
            sistemUretSayi = rnd.Next(1, 10);

            while (true)
            {

                Console.Write("{0} . deneme - Lütfen sistemin üretmiş olduğu sayıyı tahmin ediniz :", tahmminAdet);
                string rndKullaniciGelen = Console.ReadLine();

                int rndKullaniciGelenInt = int.Parse(rndKullaniciGelen);

                //if (int.Parse(rndKullaniciGelen) == sistemUretSayi)
                if (rndKullaniciGelenInt == sistemUretSayi)
                {
                    tahmminAdet++;
                    Console.WriteLine("{0}. denemenizde değeri buldunuz Tebrikler !", tahmminAdet);
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("{0} . denemeniz , Tahmin edemediniz lütfen yeniden deneyin ...", tahmminAdet);
                    tahmminAdet++;

                }
            }
            Console.Clear();
            #endregion
        }
    }
}
