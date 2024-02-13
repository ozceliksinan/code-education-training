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
namespace Secim_Istatistik
{
    public partial class FrmGrafikler : Form
    {
        public FrmGrafikler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=SINANOZCELIK;Initial Catalog=SecimIstatistik;Integrated Security=True");
        private void FrmGrafikler_Load(object sender, EventArgs e)
        {
            //İlçe Adlarını Combobox'a Çekelim
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select ilcead from TBLILCE", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0]);
            }
            baglanti.Close();

            //Grafiğer Toplam Sonuçları Aktarma
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("SELECT SUM(AParti),SUM(BParti),SUM(CParti),SUM(DParti),SUM(EParti) FROM TBLILCE", baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                chart1.Series["Partiler"].Points.AddXY("AParti", dr2[0]);
                chart1.Series["Partiler"].Points.AddXY("BParti", dr2[1]);
                chart1.Series["Partiler"].Points.AddXY("CParti", dr2[2]);
                chart1.Series["Partiler"].Points.AddXY("DParti", dr2[3]);
                chart1.Series["Partiler"].Points.AddXY("EParti", dr2[4]);
            }
            baglanti.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM TBLILCE where ilcead=@P1", baglanti);
            komut.Parameters.AddWithValue("@P1", comboBox1.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                progressBar1.Value = int.Parse(dr[2].ToString());
                progressBar2.Value = int.Parse(dr[3].ToString());
                progressBar3.Value = int.Parse(dr[4].ToString());
                progressBar4.Value = int.Parse(dr[5].ToString());
                progressBar5.Value = int.Parse(dr[6].ToString());

                Lbla.Text = dr[2].ToString();
                Lblb.Text = dr[3].ToString();
                Lblc.Text = dr[4].ToString();
                Lbld.Text = dr[5].ToString();
                Lble.Text = dr[6].ToString();
            }

            baglanti.Close();
        }
    }
}
