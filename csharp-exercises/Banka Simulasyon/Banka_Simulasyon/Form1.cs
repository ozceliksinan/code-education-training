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
namespace Banka_Simulasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=SINANOZCELIK;Initial Catalog=Banka_Simulasyon;Integrated Security=True");
        private void LnkKayit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
        }

        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From TBLKISILER where HESAPNO=@P1 and SIFRE=@P2", baglanti);
            komut.Parameters.AddWithValue("@P1", MskHesapNo.Text);
            komut.Parameters.AddWithValue("@P2", TxtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Form2 frm = new Form2();
                frm.hesap = MskHesapNo.Text;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Hatali Giris !");
            }
            baglanti.Close();
        }
    }
}
