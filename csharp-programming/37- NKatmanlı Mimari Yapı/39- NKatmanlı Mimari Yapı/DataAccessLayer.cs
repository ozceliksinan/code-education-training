using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39__NKatmanlı_Mimari_Yapı
{
    internal class DataAccessLayer
    {
        // Data katmanı olarak isimlendirilir.
        // Bu katman içerisinde sadece database düzeyinde işlemler yapılır.
        // Bu katman BLL -> iş katmanından gelen değerler üzerinde işlem yaptığı gibi kendi içerisindeki değerleride
        // BLL -> iş katmanına gönderir.

        SqlConnection connect;
        SqlCommand command;
        SqlDataReader reader;
 
        public DataAccessLayer()
        {
            connect = new SqlConnection();
            connect.ConnectionString = "Data Source=.; Initial Catalog = AdoNet; User ID=sa; Password = 1";
        }

        internal void BaglantiAyarla()
        {
            if (connect.State == System.Data.ConnectionState.Closed)
                connect.Open();
            else
                connect.Close();
        }

        internal int VeriKaydet(Musteri M)
        {
            // Database içerisine kaydetme işlemleri. 
            return 1;
        }
    }
}
