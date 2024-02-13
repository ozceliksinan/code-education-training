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
namespace Pastahane_Urun_Maliyet_Hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=SINANOZCELIK;Initial Catalog=PastahaneMaliyet;Integrated Security=True");

        void malzemelistele()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBLMALZEMELER", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        void urunlistele()
        {
            SqlDataAdapter da2 = new SqlDataAdapter("Select * From TBLURUNLER", baglanti);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            dataGridView1.DataSource = dt2;
        }

        void kasa()
        {
            SqlDataAdapter da3 = new SqlDataAdapter("Select * From TBLKASA", baglanti);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            dataGridView1.DataSource = dt3;
        }

        void urunler()
        {
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBLURUNLER", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            CmbUrun.ValueMember = "URUNID";
            CmbUrun.DisplayMember = "AD";
            CmbUrun.DataSource = dt;
            baglanti.Close();
        }
        void malzeme()
        {
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBLMALZEMELER", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            CmbMalzeme.ValueMember = "MALZEMEID";
            CmbMalzeme.DisplayMember = "AD";
            CmbMalzeme.DataSource = dt;
            baglanti.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            malzemelistele();
            urunler();
            malzeme();
        }

        private void BtnMalzemeListesi_Click(object sender, EventArgs e)
        {
            malzemelistele();
        }

        private void BtnUrunListesi_Click(object sender, EventArgs e)
        {
            urunlistele();
        }

        private void BtnKasa_Click(object sender, EventArgs e)
        {
            kasa();
        }

        private void BtnMalzemeEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLMALZEMELER (AD,STOK,FIYAT,NOTLAR) values (@P1,@P2,@P3,@P4)", baglanti);
            komut.Parameters.AddWithValue("@P1", TxtMalzemeAD.Text);
            komut.Parameters.AddWithValue("@P2", decimal.Parse(TxtMalzemeSTOK.Text));
            komut.Parameters.AddWithValue("@P3", decimal.Parse(TxtMalzemeFIYAT.Text));
            komut.Parameters.AddWithValue("@P4", TxtMalzemeNOTLAR.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ekleme İslemi Basarili Bir Sekilde Gerceklestirildi");
            malzemelistele();
        }

        private void BtnUrunEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLURUNLER (AD) values (@P1)", baglanti);
            komut.Parameters.AddWithValue("@P1", TxtUrunAd.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ekleme İslemi Basarili Bir Sekilde Gerceklestirildi");
            urunlistele();
        }

        private void BtnUrunOlustur_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLFIRIN (URUNID,MALZEMEID,MIKTAR,MALIYET) values (@P1,@P2,@P3,@P4)", baglanti);
            komut.Parameters.AddWithValue("@P1", CmbUrun.SelectedValue);
            komut.Parameters.AddWithValue("@P2", CmbMalzeme.SelectedValue);
            komut.Parameters.AddWithValue("@P3", decimal.Parse(TxtUrunMiktar.Text));
            komut.Parameters.AddWithValue("@P4", decimal.Parse(TxtUrunMaliyet.Text));
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Malzeme Ekleme İslemi Basarili Bir Sekilde Gerceklestirildi");

            listBox1.Items.Add(CmbMalzeme.Text + " - " + TxtUrunMaliyet.Text);
        }

        private void TxtUrunMiktar_TextChanged(object sender, EventArgs e)
        {

            double maliyet;
            if (TxtUrunMiktar.Text == "")
            {
                TxtUrunMiktar.Text = "0";
            }
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From TBLMALZEMELER where MALZEMEID=@P1", baglanti);
            komut.Parameters.AddWithValue("@P1", CmbMalzeme.SelectedValue);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                TxtUrunMaliyet.Text = dr[3].ToString();
            }
            baglanti.Close();

            maliyet = Convert.ToDouble(TxtUrunMaliyet.Text) / 1000 * Convert.ToDouble(TxtUrunMiktar.Text);

            TxtUrunMaliyet.Text = maliyet.ToString();

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtUrunID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            TxtUrunAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();


            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select sum(Malıyet) from TBLFIRIN where URUNID=@P1", baglanti);
            komut.Parameters.AddWithValue("@P1", TxtUrunID.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                TxtUrunMFıyat.Text = dr[0].ToString();
            }
        }
    }
}
