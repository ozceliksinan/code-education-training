using System;

namespace _15_Static_Kavramı_Genel_Uygulama
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri M1 = new Musteri();
            M1.musteriID = 1;
            M1.isim = "sinan";
            M1.soyisim = "deneme";
            M1.emailAdres = "sinanozcelik@yaani.com";
            M1.KullaniciAdi = "sinan.deneme";
            M1.sifre = "1";

            Musteri.MusteriEkle(M1);

            Musteri M2 = new Musteri()
            {
                musteriID = 2,
                isim = "namee",
                soyisim = "deneme",
                emailAdres = "sinanozcelik@yaani.com",
                KullaniciAdi = "namee.deneme",
                sifre = "2"
            };

            Musteri.MusteriEkle(M2);

            Musteri M3 = new Musteri();
            M3.musteriID = 1;
            M3.isim = "sinan";
            M3.soyisim = "deneme";
            M3.emailAdres = "sinanozcelik@yaani.com";
            M3.KullaniciAdi = "sinan.deneme";
            M3.sifre = "1";

            Musteri.MusteriEkle(M3);
        }
    }
}
