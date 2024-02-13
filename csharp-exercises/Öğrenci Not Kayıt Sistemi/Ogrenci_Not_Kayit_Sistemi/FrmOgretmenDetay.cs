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

namespace Ogrenci_Not_Kayit_Sistemi
{
    public partial class FrmOgretmenDetay : Form
    {
        public FrmOgretmenDetay()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=SINANOZCELIK;Initial Catalog=NotKayit;Integrated Security=True");
        private void FrmOgretmenDetay_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'notKayitDataSet.TBLDERS' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tBLDERSTableAdapter.Fill(this.notKayitDataSet.TBLDERS);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLDERS (OGRNUMARA,OGRAD,OGRSOYAD) values (@p1,@p2,@p3)", baglanti);
            komut.Parameters.AddWithValue("@p1", msknumara.Text);
            komut.Parameters.AddWithValue("@p2", txtad.Text);
            komut.Parameters.AddWithValue("@p3", txtsoyad.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ogrenci Basarılı bir sekilde eklendi");
            this.tBLDERSTableAdapter.Fill(this.notKayitDataSet.TBLDERS);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double ortalama, s1, s2, s3;
            string durum;
            s1 = Convert.ToDouble(txts1.Text);
            s2 = Convert.ToDouble(txts2.Text);
            s3 = Convert.ToDouble(txts3.Text);

            ortalama = (s1 + s2 + s3) / 3;
            lblort.Text = ortalama.ToString();

            if (ortalama >= 50)
            {
                durum = "True";
            }
            else
            {
                durum = "False";
            }

            baglanti.Open();
            SqlCommand komut = new SqlCommand("update TBLDERS set OGRS1=@P1,OGRS2=@P2,OGRS3=@P3,ORTALAMA=@P4,DURUM=@P5 where OGRNUMARA=@P6", baglanti);
            komut.Parameters.AddWithValue("@p1", txts1.Text);
            komut.Parameters.AddWithValue("@p2", txts2.Text);
            komut.Parameters.AddWithValue("@p3", txts3.Text);
            komut.Parameters.AddWithValue("@p4", decimal.Parse(lblort.Text));
            komut.Parameters.AddWithValue("@p5", durum);
            komut.Parameters.AddWithValue("@p6", msknumara.Text);

            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Basarili bir sekilde eklendi");
            this.tBLDERSTableAdapter.Fill(this.notKayitDataSet.TBLDERS);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            msknumara.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtsoyad.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txts1.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txts2.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            txts3.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
        }
    }
}
