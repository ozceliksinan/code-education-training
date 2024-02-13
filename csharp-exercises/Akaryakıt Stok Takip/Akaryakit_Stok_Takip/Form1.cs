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

namespace Akaryakit_Stok_Takip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=SINANOZCELIK;Initial Catalog=AkaryakıtStok;Integrated Security=True");

        void liste()
        {
            //Kursunsuz 95
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From TBLBENZIN where PETROLTUR='Kurşunsuz95'", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblKursunsuz95.Text = dr[3].ToString();
                progressBar1.Value = int.Parse(dr[4].ToString());
                LblKrs95Miktar.Text = dr[4].ToString();
            }
            baglanti.Close();

            //Diesel
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Select * From TBLBENZIN where PETROLTUR='Diesel'", baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                LblDiesel.Text = dr2[3].ToString();
                progressBar2.Value = int.Parse(dr2[4].ToString());
                LblDiselMiktar.Text = dr2[4].ToString();
            }
            baglanti.Close();

            //Pro Diesel
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("Select * From TBLBENZIN where PETROLTUR='Pro Diesel'", baglanti);
            SqlDataReader dr3 = komut2.ExecuteReader();
            while (dr3.Read())
            {
                LblProDiesel.Text = dr3[3].ToString();
                progressBar3.Value = int.Parse(dr3[4].ToString());
                LblPDieselMiktar.Text = dr3[4].ToString();

            }
            baglanti.Close();

            //LPG
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("Select * From TBLBENZIN where PETROLTUR='LPG'", baglanti);
            SqlDataReader dr4 = komut2.ExecuteReader();
            while (dr4.Read())
            {
                LblLPG.Text = dr4[3].ToString();
                progressBar4.Value = int.Parse(dr4[4].ToString());
                LblLPGMiktar.Text = dr4[4].ToString();
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("select * From TBLKASA ", baglanti);
            SqlDataReader dr6 = komut6.ExecuteReader();
            while (dr6.Read())
            {
                LblKasa.Text = dr6[0].ToString();
            }
            baglanti.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            liste();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            double kursunsuz95, litre, tutar;
            kursunsuz95 = Convert.ToDouble(LblKursunsuz95.Text);
            litre = Convert.ToDouble(numericUpDown1.Value);

            tutar = kursunsuz95 * litre;
            TxtKursunsuz95Fiyat.Text = tutar.ToString();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            double Diesel, litre, tutar;
            Diesel = Convert.ToDouble(LblDiesel.Text);
            litre = Convert.ToDouble(numericUpDown2.Value);

            tutar = Diesel * litre;
            TxtDieselFiyat.Text = tutar.ToString();
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            double PDiesel, litre, tutar;
            PDiesel = Convert.ToDouble(LblProDiesel.Text);
            litre = Convert.ToDouble(numericUpDown3.Value);

            tutar = PDiesel * litre;
            TxtPDİeselFiyat.Text = tutar.ToString();
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            double LPG, litre, tutar;
            LPG = Convert.ToDouble(LblLPG.Text);
            litre = Convert.ToDouble(numericUpDown4.Value);

            tutar = LPG * litre;
            TxtLPGFiyat.Text = tutar.ToString();
        }

        private void BtnDepoDoldur_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value != 0)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into TBLHAREKET (PLAKA,BENZINTURU,LITRE,FIYAT) values (@P1,@P2,@P3,@P4)", baglanti);
                komut.Parameters.AddWithValue("@P1", TxtPlaka.Text);
                komut.Parameters.AddWithValue("@P2", "Kurşunsuz95");
                komut.Parameters.AddWithValue("@P3", numericUpDown1.Value);
                komut.Parameters.AddWithValue("@P4", decimal.Parse(TxtKursunsuz95Fiyat.Text));
                komut.ExecuteNonQuery();
                baglanti.Close();


                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("update TBLKASA set MIKTAR=MIKTAR+@P1", baglanti);
                komut2.Parameters.AddWithValue("@P1", decimal.Parse(TxtKursunsuz95Fiyat.Text));
                komut2.ExecuteNonQuery();
                baglanti.Close();


                baglanti.Open();
                SqlCommand komut3 = new SqlCommand("update TBLBENZIN set STOK=STOK-@P1 where PETROLTUR='Kurşunsuz95'", baglanti);
                komut3.Parameters.AddWithValue("@P1", numericUpDown1.Value);
                komut3.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Satış Başarılı Bir Şekilde Gerçekleştirildi");

                liste();

            }
        }
    }
}
