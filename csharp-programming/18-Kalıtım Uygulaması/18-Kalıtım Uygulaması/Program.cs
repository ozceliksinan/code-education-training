using System;

namespace _18_Kalıtım_Uygulaması
{
    class Program
    {
        static void Main(string[] args)
        {
            bilgisayar B1 = new bilgisayar();
            // B1.id = 1; // girmek istemiyorum , uygulamanın bana bu alanı set edilebilir şekilde bırakmasınıda istemiyorum ... 
            B1.marka = "Lenovo";
            B1.model = "z50";
            B1.islemci = "I5";
            B1.alisFiyat = 1000;
            B1.satisFiyat = 1500;
            B1.kampanyaFiyat = 1000;
            B1.barkod = "1234567890"; // => 

            sanalDatabase.yeniUrunEkle(B1);

            bilgisayar B2 = new bilgisayar();
            // B1.id = 1; // girmek istemiyorum , uygulamanın bana bu alanı set edilebilir şekilde bırakmasınıda istemiyorum ... 
            B2.marka = "Lenovo";
            B2.model = "z50";
            B2.islemci = "I5";
            B2.alisFiyat = 1000;
            B2.satisFiyat = 1500;
            B2.kampanyaFiyat = 1000;
            B2.barkod = "1234567890"; // => 

            sanalDatabase.yeniUrunEkle(B2);
        }
    }
}
