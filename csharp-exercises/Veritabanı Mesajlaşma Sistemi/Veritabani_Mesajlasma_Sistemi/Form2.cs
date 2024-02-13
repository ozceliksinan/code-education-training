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

namespace Veritabani_Mesajlasma_Sistemi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public string numara;

        SqlConnection baglanti = new SqlConnection(@"Data Source=SINANOZCELIK;Initial Catalog=Mesajlasma;Integrated Security=True");

        void gelenkutusu()
        {
            SqlDataAdapter da1 = new SqlDataAdapter("Select * from TBLMESAJLAR where alıcı=" + numara, baglanti);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;
        }

        void gidenkutusu()
        {
            SqlDataAdapter da2 = new SqlDataAdapter("Select * From TBLMESAJLAR where gonderen=" + numara, baglanti);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            dataGridView3.DataSource = dt2;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            LblNumara.Text = numara;

            gelenkutusu();

            gidenkutusu();

            //Ad Soyadı Çekme
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select  Ad,Soyad From TBLKISILER where numara=" + numara, baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblAdSoyad.Text = dr[0] + " " + dr[1];
            }
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("insert into TBLMESAJLAR (GONDEREN,ALICI,BASLIK,ICERIK) values (@P1,@P2,@P3,@P4)", baglanti);
            komut.Parameters.AddWithValue("@P1", numara);
            komut.Parameters.AddWithValue("@P2", txtAlici.Text);
            komut.Parameters.AddWithValue("@P3", txtbaslik.Text);
            komut.Parameters.AddWithValue("@P4", rchicerik.Text);
            komut.ExecuteNonQuery();

            baglanti.Close();

            MessageBox.Show("Mesaj Başarılı Bir Şekilde Gönderildi");

            gidenkutusu();
        }
    }
}
