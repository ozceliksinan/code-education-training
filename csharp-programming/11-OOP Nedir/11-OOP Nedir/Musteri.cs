using System;
using System.Collections.Generic;
using System.Text;

namespace _11_OOP_Nedir
{
    public class Musteri
    {
        /*
        * TCKimlik Numarası 
        * İsim
        * Soyisim 
        * Cinsiyet
        */

        // Yapıcı Metot ctor

        public Musteri()
        {
            //TCkimliknumara = "1234567890";
        }

        public Musteri(string _tckimlikno)
        {
            TCkimliknumara = _tckimlikno;
        }

        public Musteri(string _tckimlikno, string _isim)
        {
            TCkimliknumara = _tckimlikno;
            isim = _isim;

        }

        public Musteri(string _tckimlikno, string _isim, string _soyisim)
        {
            TCkimliknumara = _tckimlikno;
            isim = _isim;
            soyisim = _soyisim;

        }

        public string TCkimliknumara;
        public string isim;
        public string soyisim;
        public int cinsiyet; // 717770001 : Bay - 717770002 : Bayan 

        public bool MusteriKontrol()
        {
            bool kontrol = MusteriKontrolDatabase(TCkimliknumara);
            return kontrol;
        }

        private bool MusteriKontrolDatabase(string tckimlikNumarasi)
        {
            // database gidilir müşterinin tckimlik numarasına göre daha önce kayıt edilip edilmediği bilgisi sorgulanır... 
            return true;
        }
    }
}
