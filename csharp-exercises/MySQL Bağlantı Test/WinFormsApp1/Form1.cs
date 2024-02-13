using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using System.Data;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Veritabanı Bağlantısı //
        MySqlConnection connection = new MySqlConnection("Server=localhost;Database=personel;Uid=root;Pwd=root;");
        DataTable datatable;
        MySqlDataAdapter adapter;
        MySqlCommand command;

        public void VeriListele()
        {
            datatable = new DataTable();
            adapter = new MySqlDataAdapter();
            connection.Open();
            BaglantiDurum(connection);
            adapter = new MySqlDataAdapter("Select *from bilgiler", connection);
            adapter.Fill(datatable);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = datatable;
            connection.Close();
        }

        public void BaglantiDurum(MySqlConnection connection)
        {
            if (connection.State == ConnectionState.Open)
            {
                btnBaglantiDurum.BackColor = Color.Green;
                btnBaglantiDurum.Text = "BAŞARILI";
            }
            else
            {
                btnBaglantiDurum.BackColor = Color.Red;
                btnBaglantiDurum.Text = "BAŞARISIZ";
            }
        }

        public void VeriEkle()
        {
            connection.Open();
            command = new MySqlCommand("insert into bilgiler (adi, soyadi, sehir, maas, durum, meslek) values (@p1, @p2, @p3, @p4, @p5, @p6)", connection);
            command.Parameters.AddWithValue("@p1", txtAdi.Text);
            command.Parameters.AddWithValue("@p2", txtSoyadi.Text);
            command.Parameters.AddWithValue("@p3", txtSehir.Text);
            command.Parameters.AddWithValue("@p4", Convert.ToInt32(txtMaas.Text));
            command.Parameters.AddWithValue("@p5", lblDurum.Text);
            command.Parameters.AddWithValue("@p6", txtMeslek.Text);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Kullanıcı Eklendi");
        }

        void VeriTemizle()
        {
            txtAdi.Text = "";
            txtSoyadi.Text = "";
            txtSehir.Text = "";
            txtMaas.Text = "";
            lblDurum.Text = "";
            txtMeslek.Text = "";
            rd_Bekar.Checked = false;
            rd_Evli.Checked = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            VeriListele();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnBaglantiDurum.BackColor = Color.Blue;
            btnBaglantiDurum.Text = "BEKLENİYOR";
            btnBaglantiDurum.ForeColor = Color.White;
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            VeriListele();
        }

        private void rd_Evli_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_Evli.Checked == true)
            {
                lblDurum.Text = "Evli";
            }
        }

        private void rd_Bekar_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_Bekar.Checked == true)
            {
                lblDurum.Text = "Bekar";
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            VeriEkle();
            VeriTemizle();
            VeriListele();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            VeriTemizle();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            txtID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtAdi.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtSoyadi.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtSehir.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtMaas.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            lblDurum.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            txtMeslek.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
        }

        private void lblDurum_TextChanged(object sender, EventArgs e)
        {
            if (lblDurum.Text == "Evli")
            {
                rd_Evli.Checked = true;
            }
            if (lblDurum.Text == "Bekar")
            {
                rd_Bekar.Checked = true;
            }
        }

        public void VeriSil()
        {
            connection.Open();
            command = new MySqlCommand("delete from bilgiler where id=@p1", connection);
            command.Parameters.AddWithValue("@p1", txtID.Text);
            command.ExecuteNonQuery();

            connection.Close();
            MessageBox.Show("Kayıt Silindi");
            VeriTemizle();
            VeriListele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            VeriSil();
        }
    }
}