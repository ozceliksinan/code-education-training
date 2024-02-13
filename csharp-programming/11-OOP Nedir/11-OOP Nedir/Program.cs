using System;

namespace _11_OOP_Nedir
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Araç Sınıfı İnceleme 
            Arac A1 = new Arac("Opel", "Corsa", 2010, 56000);
            A1.AlisFiyat = 28000;
            A1.SatisFiyat = 32000;
            A1.MaxIndirimTutar = 1500;
            // A1.Fiyat = Kapsülleme konusu ....
            A1.FiyatAta(31000);
            A1.BilgileriGoruntule();
            #endregion

            //Musteri M1 = new Musteri();
            Musteri M1 = new Musteri("122544013254", "Sinan");
            M1.TCkimliknumara = "12254401352";
            M1.isim = "Name1";
            M1.soyisim = "Surname1";
            M1.cinsiyet = 717770001;

            Musteri M2 = M1;

            M2.isim = "Sinan2";
            M1.TCkimliknumara = "12254401325";

            bool musteriKontrol = M1.MusteriKontrol();

            //M2 = null;
            //M1 = null;

            //string isim = M2.isim;
        }
    }
}
