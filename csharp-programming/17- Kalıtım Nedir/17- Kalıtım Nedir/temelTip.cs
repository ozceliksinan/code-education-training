using System;
using System.Collections.Generic;
using System.Text;

namespace _17__Kalıtım_Nedir
{
    public class temelTip
    {
        public int id { get; set; }
        public string referansKod { get; set; }
        public string tcKimlikNumarasi { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public int cinsiyet { get; set; }
        public DateTime kayitTarih { get; set; }
        public int kayitKullanici { get; set; }
        public DateTime guncellemeTarih { get; set; }
        public int guncellemeKullanici { get; set; }
        public bool silindi { get; set; }

        public temelTip()
        {
            Console.WriteLine("Temel tip nesnesinin yapıcı metotu çalıştı");
            IdAtamaIslemi();
        }

        private void IdAtamaIslemi()
        {
            Random rnd = new Random();
            this.id = rnd.Next(1000, 9000);
        }

        public void TemelTipMetot1()
        {
            Console.WriteLine("Temel Tip => Metot 1");
            // TemelTipMetot2(); protected olduğu için class içerisinde private gibi davranır...
        }

        protected void TemelTipMetot2()
        {
            Console.WriteLine("Protected Metot .");
        }
    }
}
