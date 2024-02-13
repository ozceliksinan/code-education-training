using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İleriDüzeyTryCatch
{
    public class DataAccessLayer_II:Base
    {
        SqlConnection con;
        SqlCommand cmd;
        public DataAccessLayer_II()
        {
            con = new SqlConnection("data source=.; initial catalog = Ogrenci; user id=sa; password = 1;");
        }

        public int OgrenciYeniKayit(Ogrenci o)
        {
            int ReturnValue = 0;


            TryCatchKullanim(() => 
            {
                cmd = new SqlCommand("insert into Tanim (Isim,Soyisim,Sinif) values (@Isim,@Soyisim,@Sinif)", con);
                cmd.Parameters.Add("@Isim", SqlDbType.NVarChar).Value = o.Isim;
                cmd.Parameters.Add("@Soyisim", SqlDbType.NVarChar).Value = o.Soyisim;
                cmd.Parameters.Add("@Sinif", SqlDbType.NVarChar).Value = o.Sinif;
                //con.Open();
                ReturnValue = cmd.ExecuteNonQuery();
                con.Close();
            });
          

            return ReturnValue;
        }
    }
}
