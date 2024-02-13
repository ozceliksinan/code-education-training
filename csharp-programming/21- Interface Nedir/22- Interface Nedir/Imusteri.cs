using System;
using System.Collections.Generic;
using System.Text;

namespace _22__Interface_Nedir
{
    public interface Imusteri
    {
        //public Imusteri()
        //{

        //}
        // interface içerisinde ctor kullanılmaz..
        // interface ile abstract arasındaki farktan bir taneside ctor yapılabilmesidir.
        // interface'in bütün tanımları şablondur.
        // Nesne örneğinin alınamadığının garantisi alınmış olunuyor.

        // field 

        int Id { get; set; }
        string isim { get; set; }
        string soyisim { get; set; }

        // metot 

        int yeniKayit(string isim, string soyisim);
        int kayitDuzenle(int id, string isim, string soyisim);
        int kayitSil(int id);
    }
}
