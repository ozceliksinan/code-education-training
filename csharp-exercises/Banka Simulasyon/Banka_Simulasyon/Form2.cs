using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Banka_Simulasyon
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=SINANOZCELIK;Initial Catalog=Banka_Simulasyon;Integrated Security=True");

        public string hesap;

        private void Form2_Load(object sender, EventArgs e)
        {
            LblHesapNo.Text = hesap;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From TBLKISILER where HESAPNO=@P1", baglanti);
            komut.Parameters.AddWithValue("@P1", hesap);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblAdSoyad.Text = dr[1] + " " + dr[2];
                LblTcno.Text = dr[3].ToString();
                LblTelefon.Text = dr[4].ToString();
            }
            baglanti.Close();
        }

        private void BtnGönder_Click(object sender, EventArgs e)
        {
            //Gönderilen Hesabın Para Artışı
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update TBLHESAP set BAKIYE=BAKIYE+@P1 where HESAPNO=@P2", baglanti);
            komut.Parameters.AddWithValue("@P1", decimal.Parse(TxtTutar.Text));
            komut.Parameters.AddWithValue("@p2", MskHesapNo.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();

            //Gönderen Hesabın Para Azalışı
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("update TBLHESAP set BAKIYE=BAKIYE-@K1 where HESAPNO=@K2", baglanti);
            komut2.Parameters.AddWithValue("@K1", decimal.Parse(TxtTutar.Text));
            komut2.Parameters.AddWithValue("@K2", hesap);
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Islem Gerceklestırıldı");
        }
    }
}
