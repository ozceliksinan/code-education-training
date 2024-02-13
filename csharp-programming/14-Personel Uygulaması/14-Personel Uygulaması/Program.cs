using System;

namespace _14_Personel_Uygulaması
{
    class Program
    {
        static void Main(string[] args)
        {
            Personel P1 = new Personel();
            P1.Isim = "sinan";
            P1.Soyisim = "deneme";
            P1.Emailadres = "sinan.deneme";
            P1.Cinsiyet = 717770001; // Bay 717770002 - Bayan

            Personel P2 = new Personel();
            P2.Isim = "sinan";
            P2.Soyisim = "deneme";
            P2.Emailadres = "sinan.deneme";
            P2.Cinsiyet = 717770001; // Bay 717770002 - Bayan

            Helper.emailGonder("ik@firmam.com", "Yeni Personel Bilgilendirme", P1.Isim + P1.Soyisim);
            Helper.emailGonder("ik@firmam.com", "Yeni Personel Bilgilendirme", P1.Isim + P1.Soyisim);
        }
    }
}
