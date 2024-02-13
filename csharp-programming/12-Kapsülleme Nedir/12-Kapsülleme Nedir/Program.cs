using System;

namespace _12_Kapsülleme_Nedir
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Kapsülleme (Encapsulation) kavramı bir nesnenin bazı özellik ve işlevlerini başka sınıflardan ve nesnelerden saklamaktır. 
             * Private erişim belirteci sayesinde bu şekilde tanımlanan bir field’ i başka sınıflardan gizlemiş oluruz. 
             * Ayrıca bu field başka sınıflarda kullanılamaz.
             * 
             * Kapsülleme (Encapsulation) sayesinde nesneler bilinçsiz kullanımdan korunmuş olur. 
             * Fakat bazı durumlarda private field’ lara erişmemiz ve özelliklerini kullanmamız gerekebilir. 
             * Bu durumda Property kavramı devreye girer. 
             * Property bir field’ in değerini geri döndürmeye (Get) ve değerini ayarlamaya (Set) olanak sağlar.
             * 
             * Kapsülleme, sınıf içindeki değişkenlere erişimi kaldırmak ya da kısıtlamak için kullanılır. 
             * Önemli bir değişkeni public olarak tanımlamak, değişkene yazılımcı tarafından -bilinçli ya da bilinçsiz- müdahaleye açık hale getirir. 
             * Bu da sınıf içindeki metotların çalışmasını olumsuz etkileyebilir. 
             * Bu gibi durumların önüne geçmek için kapsülleme tekniği kullanılır.
             * 
             * Sınıf içindeki private değişkenlere field (alan) denir. Alanlara sınıf dışından erişimi kontrol eden değişkenlere ise property (özellik) denir.
             * 
             * Kapsülleme get ve set anahtar kelimeleri ile yapılır. Alanın değerini geriye döndürmek için get, alanın değerini belirlemek için set kullanırız.
             * 
             * this sınıfın kendisini, value set bloğuna gelen (yani atanmaya çalışan) değeri ifade eder.
             */

            Musteri M1 = new Musteri();
            /*
             * Field değer ataması yapılamasın ama değer okunabilsin.
             * Field değer ataması yapılsın ama değer okunamasın. 
             * Field değer ataması yapılsın ama değerin ilk 4 hanesi okunsun.
             * Field değer ataması ve okuma işlemleri yapılsın ama bu iki işlemde bizim belirlediğimiz bir süreçten geçsin veri daha sonra gösterilsin. 
             */

            // Class 
            //  Field 
            //  Property
            //  Get & Set 

            // M1.emailAdres = "sinanozcelik@yaani.com"; ( Field ) 

            // Genel olarak kapsülleme konusuna giriş yaptık.
            //M1.EmailAdres = "sinanozcelik@yaani.com";
            //Console.Write(M1.EmailAdres);

            // 1. Field değer ataması yapılamasın ama değer okunabilsin.

            Console.WriteLine("Musteri Id Değeri = " + M1.ID.ToString());
            // M1.ID = 10;

            M1.TCKimlikNumarasi = "11111111111";
            string TC = M1.TCKimlikNumarasi;

            // isim ve soyisim 
            // isim ve soyisim [soyisim] = set 
            // email adresi .... 
            // email get sinanozcelik@yaani.com
            // set : private 

            M1.isim = "sinan";
            M1.Soyisim = "deneme";
            Console.WriteLine(M1.EmailAdres);
        }
    }
}