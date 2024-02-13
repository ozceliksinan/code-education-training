using System;
using System.Collections.Generic;
using System.Text;

namespace _21__Abstract_Nedir
{
    public class musteri : temelSinif
    {
        public int musteriID { get; set; }

        public musteri()
        {
            musteriID = 1;
        }

        // Override edilerek abstract metotun içeriği oluşturulur.
        // İlk implement edildiğinde base anahtar kelimesi olur fakat abstract metot alındığı
        // için içerisi boş olarak bize dönecektir.
        public override void testAbstract()
        {
            Console.WriteLine("musteri => testAbstract");
        }
    }
}
