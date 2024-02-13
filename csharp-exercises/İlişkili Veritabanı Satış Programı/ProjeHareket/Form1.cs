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

namespace ProjeHareket
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=SINANOZCELIK\\SQLEXPRESS;Initial Catalog=Hareket;Integrated Security=True");
        private void Form1_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Execute Hareket", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            SqlCommand komut = new SqlCommand("select * from URUNLER", baglanti);
            SqlDataAdapter da2 = new SqlDataAdapter(komut);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            CmbUrunAd.DisplayMember = "AD";
            CmbUrunAd.ValueMember = "ID";
            CmbUrunAd.DataSource = dt2;

            SqlCommand komut2 = new SqlCommand("select * from MUSTERILER", baglanti);
            SqlDataAdapter da3 = new SqlDataAdapter(komut2);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            CmbMusteri.DisplayMember = "ADSOYAD";
            CmbMusteri.ValueMember = "ID";
            CmbMusteri.DataSource = dt3;

            SqlCommand komut3 = new SqlCommand("select * from PERSONELLER", baglanti);
            SqlDataAdapter da4 = new SqlDataAdapter(komut3);
            DataTable dt4 = new DataTable();
            da4.Fill(dt4);
            CmbPersonel.DisplayMember = "AD";
            CmbPersonel.ValueMember = "ID";
            CmbPersonel.DataSource = dt4;
        }

        private void BtnSatisYap_Click(object sender, EventArgs e)
        {
            if (TxtStokSayisi.Text != "0")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into HAREKETLER (URUN,MUSTERI,PERSONEL,FIYAT) values (@p1,@p2,@p3,@p4)", baglanti);
                komut.Parameters.AddWithValue("@p1", CmbUrunAd.SelectedValue);
                komut.Parameters.AddWithValue("@p2", CmbMusteri.SelectedValue);
                komut.Parameters.AddWithValue("@p3", CmbPersonel.SelectedValue);
                komut.Parameters.AddWithValue("@p4", TxtFiyat.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();

                baglanti.Open();
                SqlCommand komutstok = new SqlCommand("update URUNLER set STOK = STOK-1 where AD=@a1", baglanti);
                komutstok.Parameters.AddWithValue("@a1", CmbUrunAd.Text);
                komutstok.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Satış işlemi gerçekleşti");
            }
            else
            {
                MessageBox.Show("Seçtiğiniz ürün tükenmiştir.İşlemi gerçekleştiremezsiniz", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CmbUrunAd_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbUrunAd.Text == "Buzdolabı")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select STOK from URUNLER where AD=@p1", baglanti);
                komut.Parameters.AddWithValue("@p1", CmbUrunAd.Text);
                SqlDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    TxtStokSayisi.Text = dr[0].ToString();
                }
                baglanti.Close();
            }

            if (CmbUrunAd.Text == "Çamaşır Makinesi")
            {
                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("select STOK from URUNLER where AD=@p1", baglanti);
                komut2.Parameters.AddWithValue("@p1", CmbUrunAd.Text);
                SqlDataReader dr2 = komut2.ExecuteReader();
                while (dr2.Read())
                {
                    TxtStokSayisi.Text = dr2[0].ToString();
                }
                baglanti.Close();
            }

            if (CmbUrunAd.Text == "Laptop")
            {
                baglanti.Open();
                SqlCommand komut3 = new SqlCommand("select STOK from URUNLER where AD=@p1", baglanti);
                komut3.Parameters.AddWithValue("@p1", CmbUrunAd.Text);
                SqlDataReader dr3 = komut3.ExecuteReader();
                while (dr3.Read())
                {
                    TxtStokSayisi.Text = dr3[0].ToString();
                }
                baglanti.Close();
            }

            if (CmbUrunAd.Text == "Bulaşık Makinesi")
            {
                baglanti.Open();
                SqlCommand komut4 = new SqlCommand("select STOK from URUNLER where AD=@p1", baglanti);
                komut4.Parameters.AddWithValue("@p1", CmbUrunAd.Text);
                SqlDataReader dr4 = komut4.ExecuteReader();
                while (dr4.Read())
                {
                    TxtStokSayisi.Text = dr4[0].ToString();
                }
                baglanti.Close();
            }
        }

        private void BtnUrunEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into URUNLER (AD,STOK,ALISFIYAT,SATISFIYAT) values (@p1,@p2,@p3,@p4)", baglanti);
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtStok.Text);
            komut.Parameters.AddWithValue("@p3", TxtAlisFiyati.Text);
            komut.Parameters.AddWithValue("@p4", TxtSatisFiyati.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ürün eklendi");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmUrunListesi fr = new FrmUrunListesi();
            fr.Show();
        }
    }
}
