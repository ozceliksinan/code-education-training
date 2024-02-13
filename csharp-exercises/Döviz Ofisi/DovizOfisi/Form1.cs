using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Data.SqlClient;

namespace DovizOfisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=SINANOZCELIK\\SQLEXPRESS;Initial Catalog=DovizBurosu;Integrated Security=True");
        private void Form1_Load(object sender, EventArgs e)
        {
            string bugun = "https://www.tcmb.gov.tr/kurlar/today.xml";
            var xmldosya = new XmlDocument();
            xmldosya.Load(bugun);

            string dolaralis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteBuying").InnerXml;
            LblDolarAlis.Text = dolaralis;

            string dolarsatis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerXml;
            LblDolarSatis.Text = dolarsatis;

            string euroalis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteBuying").InnerXml;
            LblEuroAlis.Text = euroalis;

            string eurosatis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling").InnerXml;
            LblEuroSatis.Text = eurosatis;

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select SUM(TL),SUM(DOLAR),SUM(EURO) from TBLDOVIZ", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblToplamTL.Text = dr[0].ToString();
                LblToplamDolar.Text = dr[1].ToString();
                LblToplamEuro.Text = dr[2].ToString();
            }
            baglanti.Close();
        }

        private void TxtKur_TextChanged(object sender, EventArgs e)
        {
            TxtKur.Text = TxtKur.Text.Replace(".", ",");
        }

        private void BtnDolarAl_Click_1(object sender, EventArgs e)
        {
            //müşteriye dolar verme
            double kur = Convert.ToDouble(TxtKur.Text);
            int miktar = Convert.ToInt32(TxtMiktar.Text);
            int tutar = Convert.ToInt32(miktar / kur); // müşterinin alacağı dolar
            TxtTutar.Text = tutar.ToString();
            int eksitutar = -tutar;
            double kalan = miktar % kur;
            TxtKalan.Text = kalan.ToString();
            double yenimiktar = miktar - kalan;

            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLDOVIZ (TL,DOLAR) values (@p1,@p2)", baglanti);
            komut.Parameters.AddWithValue("@p1", yenimiktar);
            komut.Parameters.AddWithValue("@p2", eksitutar);
            komut.ExecuteNonQuery();
            baglanti.Close();
            var cevap = MessageBox.Show("Dolar alma işlemini onaylıyor musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                MessageBox.Show("İşlem gerçekleşti");
            }

        }

        private void BtnEuroAl_Click_1(object sender, EventArgs e)
        {
            //müşteriye euro verme
            double kur = Convert.ToDouble(TxtKur.Text);
            int miktar = Convert.ToInt32(TxtMiktar.Text);
            int tutar = Convert.ToInt32(miktar / kur); // müşterinin alacağı euro
            TxtTutar.Text = tutar.ToString();
            int eksitutar = -tutar;
            double kalan;
            kalan = miktar % kur;
            TxtKalan.Text = kalan.ToString();
            double yenimiktar = miktar - kalan;

            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLDOVIZ (TL,EURO) values (@p1,@p2)", baglanti);
            komut.Parameters.AddWithValue("@p1", yenimiktar);
            komut.Parameters.AddWithValue("@p2", eksitutar);
            komut.ExecuteNonQuery();
            baglanti.Close();
            var cevap = MessageBox.Show("Euro alma işlemini onaylıyor musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                MessageBox.Show("İşlem gerçekleşti");
            }
        }

        private void BtnDolarSat_Click(object sender, EventArgs e)
        {
            double kur, miktar, tutar, eksitutar;
            kur = Convert.ToDouble(TxtKurBoz.Text);
            miktar = Convert.ToDouble(TxtMiktarBoz.Text);
            tutar = miktar * kur;
            TxtTutarBoz.Text = tutar.ToString();
            eksitutar = -tutar;

            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLDOVIZ (TL,DOLAR) values (@p1,@p2)", baglanti);
            komut.Parameters.AddWithValue("@p1", eksitutar);
            komut.Parameters.AddWithValue("@p2", miktar);
            komut.ExecuteNonQuery();
            baglanti.Close();
            var cevap = MessageBox.Show("Dolar satma işlemini onaylıyor musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                MessageBox.Show("İşlem gerçekleşti");
            }
        }

        private void BtnEuroSat_Click(object sender, EventArgs e)
        {
            double kur, miktar, tutar, eksitutar;
            kur = Convert.ToDouble(TxtKurBoz.Text);
            miktar = Convert.ToDouble(TxtMiktarBoz.Text);
            tutar = miktar * kur;
            TxtTutarBoz.Text = tutar.ToString();
            eksitutar = -tutar;

            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLDOVIZ (TL,EURO) values (@p1,@p2)", baglanti);
            komut.Parameters.AddWithValue("@p1", eksitutar);
            komut.Parameters.AddWithValue("@p2", miktar);
            komut.ExecuteNonQuery();
            baglanti.Close();
            var cevap = MessageBox.Show("Euro satma işlemini onaylıyor musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                MessageBox.Show("İşlem gerçekleşti");
            }
        }

        private void BtnDolarAlis_Click_1(object sender, EventArgs e)
        {
            TxtKur.Text = LblDolarAlis.Text;
        }

        private void BtnDolarSatis_Click_1(object sender, EventArgs e)
        {
            TxtKurBoz.Text = LblDolarSatis.Text;
        }

        private void BtnEuroAlis_Click_1(object sender, EventArgs e)
        {
            TxtKur.Text = LblEuroAlis.Text;
        }

        private void BtnEuroSatis_Click_1(object sender, EventArgs e)
        {
            TxtKurBoz.Text = LblEuroSatis.Text;
        }

        private void TxtKurBoz_TextChanged(object sender, EventArgs e)
        {
            TxtKurBoz.Text = TxtKurBoz.Text.Replace(".", ",");
        }
    }
}
