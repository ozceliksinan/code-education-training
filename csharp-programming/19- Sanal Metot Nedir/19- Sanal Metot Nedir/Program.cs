using System;

namespace _19__Sanal_Metot_Nedir
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Temel sınıftan türetilmiş sınıflara aktarılan metotları her zaman olduğu gibi kullanmak istemeyebiliriz. 
             * Bu metotları türetilmiş sınıf içerisinde yeniden tanımlayabilmek için virtual ve override anahtar sözcüklerini kullanırız.
             * 
             * Virtual metotlar kalıtım yolu ile aktarıldıkları sınıfların içerisinde override edilerek değiştirilebilirler. 
             * Eğer override edilmezlerse temel sınıf içerisinde tanımlandıkları şekilde çalışırlar.
             * 
             * Virtual methods (sanal metotlar), base class (temel sınıf) içinde bildirilmiş ve derived class (türemiş sınıf) içinde de tekrar bildirilebilen metotlardır. 
             * Böylelikle sanal metotlar kullanılarak nesne yönelimli programlama da çok sık başvurulan çok biçimliliği yani poliformizm (polimorphizm) uygulanmış olur. 
             * Yani temel sınıfta bir sanal metot bildirildiğinde bu temel sınıftan türeyen sınıflardaki metotlar override edilerek, 
             * temel sınıftaki sanal metotu devre dışı bırakabilirler.
             * 
             * Sanal metotları bildirmek için virtual anahtar sözcüğü kullanılır. Bu anahtar sözcükle, sanal metotumuz bildirilmiş olur. 
             * Türeyen sınıfta ise, temel sınıftaki sanal metotları devre dışı bırakmak için override anahtar sözcüğü kullanılır. 
             * Yani base class?da virtual olarak tanımladığım bir metotu derived class içindeoverride edebilirim. 
             * Eğer override edersem derived class içindeki metot çalışır, eğer etmez isem direkt olarak base class içindeki virtual metot çalışır.
             * 
             * Virtual metotlar private olarak tanımlanamazlar, public olmak zorundadırlar. 
             * Zaten private olmasının bir anlamı yok çünkü aksi halde derived class içinde bunları override edemeyiz. 
             * Public olmasının yanı sıra protected, internal şeklinde de bildirilebilirler.
             */

            // Object => ToString();
            /*
             * Musteri M1 = new Musteri();
             * Object => Musteri 
             *           M1.Tostring(); 
             * 
             * Namespace.Musteri 
             * 
             * 
             */

            Musteri M1 = new Musteri();
            M1.isim = "Sinan";
            M1.soyisim = "Deneme";
            string toStringMesaj = M1.ToString();
            Console.WriteLine(toStringMesaj);
        }
    }
}
