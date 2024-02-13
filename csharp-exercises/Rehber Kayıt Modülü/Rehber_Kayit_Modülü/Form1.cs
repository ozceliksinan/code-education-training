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

namespace Rehber_Kayit_Modülü
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=SINANOZCELIK;Initial Catalog=Rehber;Integrated Security=True");

        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from KISILER", baglanti);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        void temizle()
        {
            Txtad.Text = "";
            Txtsoyad.Text = "";
            Txtmail.Text = "";
            MskTel.Text = "";
            Txtid.Text = "";
            Txtad.Focus();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("insert into KISILER (AD,SOYAD,MAIL,TELEFON) values(@P1,@P2,@P3,@P4)", baglanti);
            komut.Parameters.AddWithValue("@P1", Txtad.Text);
            komut.Parameters.AddWithValue("@P2", Txtsoyad.Text);
            komut.Parameters.AddWithValue("@P3", Txtmail.Text);
            komut.Parameters.AddWithValue("@P4", MskTel.Text);
            komut.ExecuteNonQuery();

            baglanti.Close();

            MessageBox.Show("Basarili bir sekilde ekleme islemi gerçekleştirildi");

            listele();
            temizle();
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            Txtid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            Txtad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            Txtsoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            MskTel.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            Txtmail.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("Delete From Kısıler where ID=" + Txtid.Text, baglanti);

            komut.ExecuteNonQuery();

            baglanti.Close();

            MessageBox.Show("Basarili bir sekilde silme islemi gerçekleştirildi");

            listele();
            temizle();
        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update KISILER set AD=@P1,SOYAD=P2,TELEFON=@P3,MAIL=@P4 WHERE ID=@P5", baglanti);
            komut.Parameters.AddWithValue("@P1", Txtad.Text);
            komut.Parameters.AddWithValue("@P2", Txtsoyad.Text);
            komut.Parameters.AddWithValue("@P3", MskTel.Text);
            komut.Parameters.AddWithValue("@p4", Txtmail.Text);
            komut.Parameters.AddWithValue("@p5", Txtid.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Basarili bir sekilde guncelleme islemi gerçekleştirildi");

            listele();
            temizle();
        }
    }
}
