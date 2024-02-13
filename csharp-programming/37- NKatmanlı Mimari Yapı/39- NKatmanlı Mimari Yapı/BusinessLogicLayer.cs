using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39__NKatmanlı_Mimari_Yapı
{
    internal class BusinessLogicLayer
    {
        // İş katmanı olarak isimlendirilir.
        // İş katmanı kullanıcıdan gelen verilerin veya database içerisinde gelen verilerin işlenmiş olduğu data katmanıdır.
        // Bu katman içerisinde data kontrol işlemleri yapılır.
        // Kullanıcıdan gelen yönü ile bakarsak değerler kontrol edilir veya düzenlenir ve database katmanına gönderilir.
        // Database yönü ile bakarsak değerler kullanıcının okuyacağı formata çevrilir

        DataAccessLayer DAL;
        public BusinessLogicLayer()
        {
            DAL = new DataAccessLayer();
        }

        internal int VeriKaydet(int MusteriId, string Isim, string Soyisim)
        {
            if (!string.IsNullOrEmpty(Isim) && !string.IsNullOrEmpty(Soyisim))
            {
                Musteri M1 = new Musteri();
                M1.MusteriID = MusteriId;
                M1.Isim = Isim;
                M1.Soyisim = Soyisim;

                return DAL.VeriKaydet(M1);
            }
            else
            {
                return -1; // Eksik parametre hatası 
            }
        }
    }
}
