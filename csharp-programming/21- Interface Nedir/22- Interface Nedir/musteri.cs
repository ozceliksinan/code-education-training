using System;
using System.Collections.Generic;
using System.Text;

namespace _22__Interface_Nedir
{
    public class musteri : Imusteri
    {
        // interface tarafındna yazılan tüm metotlar burada şablon olarak kullanılmak zorundadır.

        int _id;
        string _isim;
        string _soyisim;

        public int Id { get { return _id; } set { _id = value; } }
        public string isim { get { return _isim; } set { _isim = value; } }
        public string soyisim { get { return _soyisim; } set { _soyisim = value; } }

        public int kayitDuzenle(int id, string isim, string soyisim)
        {
            Console.WriteLine("kayıt duzenlendi");
            return 1;
        }

        public int kayitSil(int id)
        {
            Console.WriteLine("Kayıt Silindi");
            return 1;
        }

        public int yeniKayit(string isim, string soyisim)
        {
            Console.WriteLine("Kayıt Eklendi");
            return 1;
        }
    }
}
