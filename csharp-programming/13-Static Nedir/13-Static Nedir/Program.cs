using System;

namespace _13_Static_Nedir
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bir sınıf içerisindeki static olmayan metotlara ve özelliklere o sınıftan oluşturduğumuz nesneler üzerinden erişiriz. 
            // Static olan metotlara ve özelliklere ise nesne oluşturmadan sınıf adı ile erişiriz.

            /*
             * Static Yapıcı Metotlar
             * Yapıcı metotları da normal metotlar gibi static olarak tanımlayabiliriz. 
             * Sınıfın static değişkenleri ile ilgili işlemler static yapıcı metodun içerisinde yapılabilir. 
             * Static yapıcı metotlar parametre almazlar ve erişim belirteçleri yoktur.
             */

            /*
             * Static Sınıflar
             * Oluşturduğumuz sınıf içerisinde sadece static metotlar ve değişkenler bulunuyorsa sınıfı static olarak tanımlayabiliriz. 
             * Sınıfların static olarak tanımlanması bir zorunluluk değildir sadece okunabilirliği arttıran bir yaklaşımdır.
             * 
             * Static sınıflarla alakalı bilinmesi gerekenler;
             * Static sınıflardan nesne oluşturulamaz. (new Matematik(); YANLIŞ)
             * Static sınıf türünden referanslar oluşturulamaz. (Matematik m; YANLIŞ)
             * Static sınıfların içinde static olmayan metot yada değişken tanımlanamaz.
             * Static sınıflarda kalıtım yoktur.
             */

            // Static : nesne örneği alınmadan ulaşabildiğimiz metot , field , sınıf.. 
            // Tip M1 = new Tip();
            // Tip.

            // Stack bölge içerisinde pointer ımız oluştu... 
            Ogrenci O1;
            // Stack bölgede pointer oluştuğu zaman static olan bir yapıcı metot çalıştı ve yine class içerisinde tanımlı olan static field , metot static dediğimiz bölgede oluşturuldu.
            Ogrenci.Test2();

            O1 = new Ogrenci();
            // Stack bölgede pointer => kendisini heap bölgede tamamladı.. static olmayan tanımlarını tamamladı.. 
            O1.Test1(); // nesne örneği alındıktan sonra test1 adındaki metotuma ulaşabidim. 

            /* Static Kavramı gerçek hayatta nerelerde kullanılır... 
            1 - Helper.cs => Kontroller
            2 - Olusturmuş olduğumuz nesnemizin => bağımlılığı farklı class lara olduğu için ( proje içerisinde özel olduğu icin ) nesne içerisinde static metot tanımları yapılır. 
            3 - Class içerisinde bir field ( static ) tanımı yapar ilgili field içerisine bir değer ataması yaparız. Daha sonra uygulama içerisinde N farklı yerde oluşturmuş olduğumuz static field ımıza ulaşır değerimizi okuruz. 
            4 - [ Uygulama ] => [ozelHelper] => [ DLL ]
            */
        }
    }
}
