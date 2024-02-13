using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqTeknolojisi
{
    class Program
    {
        static void Main(string[] args)
        {
            dataSource ds = new dataSource();
            List<Musteri> musteriListe = ds.musteriListesi();

            #region Linq Sorgulama Çeşitleri
            // Müşteri Listesi içerisinde arama yapmak için where şartı kullanalım;
            int toplamMusteriAdet = musteriListe.Where(I => I.isim.StartsWith("A")).Count();
            // Her kaydı I nesneri üzerinden kayıt edilir. (geçici)

            var toplamMusteriAdetII = (from I in musteriListe where I.isim.StartsWith("A") select I).Count();
            #endregion

            #region Alıştırmalar
            // 1: Müşteriler içerisinde ülke değeri A ile başlayan müşterileri Linq to metot kullanarak bulunuz.
            IEnumerable<Musteri> musteriListeAlistirma1 = musteriListe.Where(I => I.ulke.StartsWith("A"));
            Console.WriteLine("İlk harfi A olan ülke adeti {0}", musteriListeAlistirma1.Count);

            // 2: Müşteriler listesi içerisindeki kayıtlardan isminin içinde b harfi geçen ve ülke değeri içerisinde
            // A harfi geçen müşterilerin listesini getiriniz => &&
            var musteriListeAlistirma2 = musteriListe.Where(I => I.isim.Contains("a") && I.ulke.StartsWith("A")).ToList();

            // 3: Müşteriler listesi içerisindeki kayıtlardan doğum yılı 1990 dan büyük olan ve isminin içerisinde 
            // a harfi geçen müşteriler II. yol olan Linq to Query ile bulunuz
            var musteriListeAlistirma3 = from I in musteriListe where I.dogumTarihi.Year > 1990 && I.isim.Contains("a") select I;
            Console.WriteLine("Doğum yılı 1990 ve isminin içinde a geçen kayıt sayısı: {0}", musteriListeAlistirma3.Count);
            #endregion

            #region Başlarken
            // A ile başlayan müşterilerin adet numarası
            int bulunanToplam = 0;
            for (int i = 0; i < musteriListe.Count; i++)
            {
                if(musteriListe[i].isim[0] == 'A')
                {
                    bulunanToplam++;
                }

            }

            Console.WriteLine("Liste içerisinde ilk harfi A ile başlayan kayıt sayısı {0}", bulunanToplam);

            // Linq teknolojisi ile yukardaki sorgu yapısını yeniden yazalım.
            bulunanToplam = 0;
            bulunanToplam = musteriListe.Where(i => i.isim.StartsWith("A")).Count();
            Console.WriteLine("Linq teknolojisi ile yapılan sorgu sonucu {0}", bulunanToplam);

            Console.ReadLine();
            #endregion
        }
    }
}
