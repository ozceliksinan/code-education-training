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
namespace VeriTabani_Veri_Sifreleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBLVERILER", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=SINANOZCELIK;Initial Catalog=VeriSifreleme;Integrated Security=True");
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            string ad = Txtad.Text;
            byte[] addizisi = ASCIIEncoding.ASCII.GetBytes(ad);
            string adsifre = Convert.ToBase64String(addizisi);

            string soyad = Txtsoyad.Text;
            byte[] soyaddizisi = ASCIIEncoding.ASCII.GetBytes(soyad);
            string soyadsifre = Convert.ToBase64String(soyaddizisi);

            string mail = Txtmail.Text;
            byte[] maildizisi = ASCIIEncoding.ASCII.GetBytes(mail);
            string mailsifre = Convert.ToBase64String(maildizisi);

            string sifre = Txtsifre.Text;
            byte[] sifredizisi = ASCIIEncoding.ASCII.GetBytes(sifre);
            string sifresifre = Convert.ToBase64String(sifredizisi);

            string hesapno = Txthesapno.Text;
            byte[] hesapnodizisi = ASCIIEncoding.ASCII.GetBytes(hesapno);
            string hesapnosifre = Convert.ToBase64String(hesapnodizisi);

            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLVERILER (AD,SOYAD,MAIL,SIFRE,HESAPNO) values (@P1,@P2,@P3,@P4,@P5)", baglanti);
            komut.Parameters.AddWithValue("@P1", adsifre);
            komut.Parameters.AddWithValue("@P2", soyadsifre);
            komut.Parameters.AddWithValue("@P3", mailsifre);
            komut.Parameters.AddWithValue("@P4", sifresifre);
            komut.Parameters.AddWithValue("@P5", hesapnosifre);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Veriler Basarili Bir Sekilde Sifrelendi");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string adcozum = Txtad.Text;
            byte[] adcozumdizi = Convert.FromBase64String(adcozum);
            string adverisi = ASCIIEncoding.ASCII.GetString(adcozumdizi);
            label6.Text = adverisi;
        }
    }
}
