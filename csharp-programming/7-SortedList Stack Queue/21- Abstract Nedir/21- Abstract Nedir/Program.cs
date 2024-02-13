using System;

namespace _21__Abstract_Nedir
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Abstract anahtar kelimesi sınıflara, metotlara ve özelliklere uygulanır. Abstract sınıflara soyut yada özet sınıflar diyebiliriz.
             * Abstract Class: abstract olarak tanımlanan bir sınıf temel sınıftır. Bu sınıftan new anahtar kelimesi kullanılarak bir nesne oluşturulamaz.
             * 
             * Abstract Metot: Sadece soyut sınıflar içerisinde kullanılabilirler. 
             * Mirasçı sınıflarda override edilmek zorundadırlar.
             * Abstarct metotlar sadece tanımlanır. 
             * Herhangi bir işlemi yerine getirmezler. 
             * Yapacakları işlemler override edildikleri sınıfta kodlanmalıdır.
             */

            // Abstract = Şablon

            superMusteri SP1 = new superMusteri();
            SP1.testAbstract();

            // temelSinif T1 = new temelSinif();
            // Abstract ile şablonladığımız için new komutu ile artık örnekleştiremeyiz.
            // Şablonlamayı başka sınıflar içerisinde kullanırız.

            musteri M1 = new musteri();
            // Kalıtım yapılan nesnemiz abstract sınıf bile olsa constructer metotları yinede çalışır.
            M1.test();
            M1.testAbstract();
        }
    }
}
