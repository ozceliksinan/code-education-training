using System;

namespace _1_Degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            // Veri tipi değişken adı
            string isimDegiskeni;
            isimDegiskeni = "Sinan";

            Console.WriteLine("Kullanıcı adı: ");
            Console.WriteLine(isimDegiskeni);

            // Bir veri tipindeki max ve min boyutu bulalım..
            int sayi1;
            sayi1 = int.MinValue;
            Console.WriteLine("En düşük deger: ");
            Console.WriteLine(sayi1);

            int sayi2;
            sayi2 = int.MaxValue;
            Console.WriteLine("En yüksek değer: ");
            Console.WriteLine(sayi2);

            double sayi3 = double.MinValue;
            Console.WriteLine("En düşük double değeri: ");
            Console.WriteLine(sayi3);

            const int ortakBolumDegeri = 2;
            int Sonuc = sayi2 / ortakBolumDegeri;
            // ortakBolumDegeri = 3 -> Hata!!! Sabitler sadece bir kere tanımlanır. Daha sonradan değiştirilemez.

            // Bilinçli Tür Dönüşümü
            int temp1 = 125;
            byte temp2 = 0;
            temp1 = (byte)temp2;
            Console.WriteLine(temp1);

            // Boxing işlemi
            object temelTip;
            temelTip = sayi2; // Boxing işlemi
            sayi2 = (int)temelTip; // unboxing işlemi

            // Console uygulaması
            Console.Clear();

            Console.Write("Lütfen 1-10 arasında bir değer giriniz: ");
            string gelenDeger = Console.ReadLine();

            int tempSayi1 = int.Parse(gelenDeger);
            int tempSayi2 = Convert.ToInt32(gelenDeger);
            // parse ile convert arasındaki fark
            int toplam = tempSayi1 + 15;
            Console.WriteLine("Toplam değer: {0}", toplam);

            /*
             * Bir string değerin varsa ve bunun her daim integer olmasını istiyorsan Int.Parse() kullanabilirsin.
             * Int32.TryParse() : Kullanıcıdan integer değer girmesini istediğinde fakat kullanıcının integer harici mesela 
             * string gibi bir veri tipi girmesi haline programın daha esnek davranmasını sağlar.
             * Convert.ToInt32:Arguman olarak bir nesne alır ve inanıyorum ki bu içerisinde bir nesne algıladığında bir nevi Int.Parse yi çağırıyor.
             * Ama Convert.ToInt32 Int.Parse() nin yaptığı arguman boş olduğunda Throw ettiği ArgumentNullException hatasını vermez.
             */


            /*
             * Parse Metodları
             * Türlerin Yapısal isimleri altından Int32.Parse(string) / int.Parse(string) şeklinde ulaşılabilen bu metodlar ile yanlızca string türdeki değişkenleri Tam yada Gerçek Sayı türüne dönüştürebiliriz.
             * 
             * Bir string dönüşüm işleminde 3 farklı hata (error) oluşabilir. Bunlar;
             * ArgumentNullException : değer null (tanımlanmış fakat değer atanmamış) olduğunda oluşur,
             * FormatException : değer uygun formatta olmağı zaman (alfanumerik karakter içerdiğinde) oluşur,
             * OverflowException : değer dönüştürülecek hedef türün sınırlarının dışında ise oluşur.
             * 
             * Convert Sınıfı 
             * Convert sınıfı altında bulunan ve To ifadesi ile başlayıp türlerin yapısal karşılıkları ile devam eden Convert.ToInt32(string) şeklindeki metodlar ile 
             * Parse metodlarından farklı olarak yanlızca string değil  bool, byte, char,DateTime, decimal, double, float, int, long, object, sbyte, 
             * short, string, uint, long ve short türlerinin tamamından dönüştürme işlemi yapabilir.
             * Ayrıca Parse metodlarından farklı olarak Convert sınıfı altındaki metodlarda ArgumentNullException hatası yoktur, 
             * kendilerine dönüştürme işlemi için null bir girdi verildiğinde sıfır (0) değeri döndürürler
             */

            /*******************************************************************/
            /*                  PART - 2                                       */
            /*******************************************************************/

            /*******************************************************************/
            /* En büyük ve en küçük sayı değerleri tür dönüşümleri konusunda   */
            /* fazlasıyla işimize yaramaktadır.                                */
            /*******************************************************************/

            int buyukSayi;
            int kucukSayi;

            buyukSayi = int.MaxValue;
            kucukSayi = int.MinValue;

            // Büyük ve küçük sayı değerlerini ekrana yazdıralım
            Console.WriteLine("En büyük int sayı değerimiz: " + buyukSayi);
            Console.WriteLine("En küçük int sayı değerimiz: " + kucukSayi);
            // Bu şekilde int, char, bool, float gibi veri tiplerinin max ve min değerleri bulunabilir.

            /****************************************************/
            /* Sabit sayı değerleri sonradan değiştirilemez!    */
            /****************************************************/
            int sayi1 = 1000;
            const int ortakBolum = 2;
            int sonuc = sayi1 / ortakBolum;
            Console.WriteLine("Bölme işleminin sonucu: " + sonuc);

            /********************************************************/
            /* Değişkenlerin içerisinde olan değerlere göre farklı  */
            /* veri tiplerine dönüştürebilme olanakları vardır.     */
            /********************************************************/

            byte number1 = byte.MaxValue;
            number1 = byte.MinValue;

            // Bilinçli tür dönüşümü örneği
            int number2 = 125;
            // Number2'nin içerisindeki değer programımızda daha az yer 
            // kaplasın diye number1 değişkenin içine atılıyor.
            number1 = (byte)number2;
            Console.WriteLine(number1);

            // Bilinçsiz tür dönüşümü
            double number3 = 10;
            number3 = number2;
            Console.WriteLine(number3);

            /********************************************************/
            /* Checked: Değişkenlerimizde değer kaybı yaşadığımızda */
            /* programın bize hata mesajını vermesini sağlar        */
            /********************************************************/

            number2 = 512;
            number1 = (byte)number2; // DİKKAT!! Burda number1 değişkeni 0 olur (Değer kaybederiz)

            checked
            {
                // Program derlendikten sonra hata verir.
                // Değer kaybı söz konusudur.
                number2 = 512;
                number1 = (byte)number2;
            }

            unchecked
            {
                // Program derlendikten sonra değer kaybı söz konusu dikkate alınmaz
                // Program çalışmaya devam eder. Default sistem ayarından farkı ise
                // Detaylı matematiksel işlemlerde, hassas gram işlemlerinde ve tür
                // dönüşümlerinde unchecked anahtar kelimesini kullanmakta fayda vardır.
                number2 = 512;
                number1 = (byte)number2;
            }

            /*********************************************************************************/
            /* .Net Framework'ün içerisinde tüm veri tiplerinin oluşturulduğu ana            */
            /* veri tipi olan object hakkında bilgi verelim. Object veri tipi .Net           */
            /* Framework içerisinde olan, oluşan büyün tiplerin atasıdır. Biz istediğimiz    */
            /* veri tipini objecte çevirip kutulama işlemini yapabiliriz. Daha sonra değer   */
            /* kaybı olmadan eski haline geri getirebiliriz.                                 */
            /*********************************************************************************/

            object temelTip = number2;
            temelTip = number3;
            temelTip = new
            {
                marka = "Mercedes",
                model = "E200",
            };

            // Object sınıfını referans alarak kutulama işlemini görelim
            temelTip = sayi2; // Boxing işlemi yapılır.
            sayi2 = (int)temelTip; //Unboxing işlemi.

            // Console işlemlerine bakalım;

            Console.WriteLine("Mesaj 1"); // Metni ekrana yazar ve imleç yanında bekler.
            Console.WriteLine("Mesaj 2"); // Metni ekrana yazar ve imleç yanında bekler.

            // Ekranda bulunan tüm verileri silmek için;
            Console.Clear();

            /*************************************/
            /* Kullanıcıdan veri almak için;     */
            /*************************************/
            // Önce bir değişken tanımlayalım ve içini boşaltalım.
            string kullaniciDegeri = string.Empty;
            Console.WriteLine("Lütfen adınızı giriniz: ");
            kullaniciDegeri = Console.ReadLine();

            // Elimizde olan değişken veya değişkenleri kullanarak kullanıcılara 
            // mesaj göndermenin birden fazla yöntemi bulunmaktadır.

            // 1. Yöntem
            string mesaj = "Girmiş olduğunuz isim değeri: " + kullaniciDegeri;
            Console.WriteLine(mesaj);

            // 2. Yöntem
            mesaj = "";
            mesaj = string.Format("Girmiş olduğunuz isim değeri: {0}", kullaniciDegeri);

            /********************************************************/
            /* Kullanıcıdan gelen string bir veriyi değişkene atama */
            /* işlemi yaparken int veri tipine dönüştürmek için;    */
            /********************************************************/
            Console.WriteLine("Lütfen bir sayı giriniz: ");
            string gelenDeger = Console.ReadLine();
            // Kullanıcıdan girilen değer string veri tipinde alındı!
            int number4 = int.Parse(gelenDeger);       // String veri tipi değişkene atama yaparken int veri tipine dönüştürüldü.
            int number5 = Convert.ToInt32(gelenDeger); // String veri tipi değişkene atama yaparken int veri tipine dönüştürüldü.

            // Parse komutu ile Convert.ToInt32 arasındaki fark ise: 
            // Parse: Yalnızca string türdeki değişkenleri Tam yada Gerçek sayı türüne dönüştürebilir. Null bir değeri dönüştüremez.
            // Veya değer uygun formatta olmağı zaman (alfanumerik karakter içerdiğinde) değeri dönüştüremez.

            // Convert.ToInt32(string): yanlızca string değil  bool, byte, char,DateTime, decimal, double, float, int, long, object, 
            // sbyte, short, string, uint, long ve short türlerinin tamamından dönüştürme işlemi yapabilir.
            // yrıca Parse metodlarından farklı olarak Convert sınıfı altındaki metodlarda ArgumentNullException hatası yoktur, kendilerine 
            // dönüştürme işlemi için null bir girdi verildiğinde sıfır (0) değeri döndürürler.


            #region is - as operatörleri tanım

            object object1 = "Sinan";
            // int sayi1 = (int)object1 -> Hata verir tipi dönüştüremez!!!
            bool veriTipiKontrol = object1 is int; // int tipine çevirebiliyor muyuz diye kontrol eder. Bool tipinde veri döndürür.

            object object2 = "Sinan";
            string isim = object2 as string; // as ile çevirme işlemi yapılır.

            #endregion
        }
    }
}