using System;
using System.Collections.Generic;

namespace _24__Generic_Class_Nedir
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 
             * Database  | Uygulama
             * MSSQL       C#
             * 
             * tblMusteri
             * id int
             * musteriNumara uniqueidentitfy ( Guid ) 
             * isim nvarchar(50) string 
             * soyisim nvarchar(50) string 
             * dogumTarih datetime  datetime
             * 
             * UnitOfWorks => Generic Class |Generic Interface 
             * 
             */

            genericRepository<Musteri> repositoryMusteri = new genericRepository<Musteri>();

            List<Musteri> musterilerim = repositoryMusteri.Getir();

            repositoryMusteri.yeniKayitEkle(null);

            genericRepository<Urun> repositoryUrun = new genericRepository<Urun>();
            repositoryUrun.Getir();
            repositoryUrun.yeniKayitEkle(null);
        }
    }
}
