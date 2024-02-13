using System;

namespace _16__İnner_Type_Modelleme
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri M1 = new Musteri();

            M1.musteriID = 1;
            M1.tcKimlikNumarasi = "11111111111";
            M1.isim = "Sinan";
            M1.soyisim = "Deneme";
            M1.olusturmaTarih = DateTime.Now;

            //  M1.musteriAdresleri = new MusteriAdres[5];
            // Asla yapmayın..

            M1.musteriAdresleri[0] = new MusteriAdres()
            {
                Il = "İstanbul",
                Ilce = "Başakşehir",
                Adres = "Adres ... ",
                adresTip = "İş Yeri"
            };

            M1.musteriAdresleri[0].MusteriAdresTestMetot();

            M1.musteriSiparisBilgileri[0] = new MusteriSiparisBilgisi()
            {
                siparisNumarasi = "SIP0001"
            };

            M1.musteriSiparisBilgileri[0].urunler[0] = new Urun()
            {
                urunId = 1,
                Tanim = "Telefon",
                fiyat = 1500
            };
        }
    }
}
