using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İleriDüzeyTryCatch
{
    public class DataAccessLayer
    {
        SqlConnection con;
        SqlCommand cmd;
        public DataAccessLayer()
        {
            con = new SqlConnection("data source=.; initial catalog = Ogrenci; user id=sa; password = 1;");
        }

        public int OgrenciYeniKayit(Ogrenci o)
        {
            int ReturnValue = 0;

            try
            {
                cmd = new SqlCommand("insert into Tanim (Isim,Soyisim,Sinif) values (@Isim,@Soyisim,@Sinif)", con);
                cmd.Parameters.Add("@Isim", SqlDbType.NVarChar).Value = o.Isim;
                cmd.Parameters.Add("@Soyisim", SqlDbType.NVarChar).Value = o.Soyisim;
                cmd.Parameters.Add("@Sinif", SqlDbType.NVarChar).Value = o.Sinif;
                con.Open();
                ReturnValue =  cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                // Hata loglama işlemleri ( ilerleyen derslerde burada NLOG kullanımını incleyeceğiz ) 
                ReturnValue = -1;
            }

            return ReturnValue;
        }

        public int OgrenciKayitDuzenle(Ogrenci o)
        {
            int ReturnValues = 0;
            try
            {

            }
            catch (Exception)
            {

               // Log işlemleri
            }
            return ReturnValues;
        }

        public int OgrenciKayitSil(Ogrenci o)
        {
            int ReturnValues = 0;
            try
            {

            }
            catch (Exception)
            {

                // Log işlemleri
            }
            return ReturnValues;
        }

        public Ogrenci OgrenciKayitGetir(int ID)
        {
            Ogrenci O1 = null;
            try
            {

            }
            catch (Exception)
            {

                // Log işlemleri
            }
            return null;
        }
    }
}
