using System;
using System.Collections.Generic;
using System.Text;

namespace _18_Kalıtım_Uygulaması
{
    public class urun : baseClass
    {
        public string marka { get; set; } // * belirtmiş olduğumuz markalar içerisinde ürün eklenebilsin. 
        public string model { get; set; }

        private decimal _alisFiyat;
        public decimal alisFiyat
        {
            get { return _alisFiyat; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Alis fiyatı 0 dan küçük veya eşit olamaz...");
                }
                else
                {
                    _alisFiyat = value;
                }
            }
        } // 0 dan küçük olmamamlı

        private decimal _satisFiyat;
        public decimal satisFiyat
        {
            get { return _satisFiyat; }
            set
            {
                if (value < _alisFiyat)
                {
                    Console.WriteLine("Ürünnün satış fiyatı alış fiyatından küçük olamaz...");
                }
                else
                {
                    _satisFiyat = value;
                }
            } // alisfiyatından küçük olamaz
        }

        private decimal _kampanyaFiyat;
        public decimal kampanyaFiyat
        {
            get { return _kampanyaFiyat; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Kampanya fiyatı 0 dan küçük veya eşit olamaz...");
                }
            }
        } // kampanya fiyat değeri 0 den küçük olamaz 
    }
}
