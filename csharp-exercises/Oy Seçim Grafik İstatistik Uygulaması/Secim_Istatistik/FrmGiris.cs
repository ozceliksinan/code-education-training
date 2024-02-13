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
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=SINANOZCELIK;Initial Catalog=SecimIstatistik;Integrated Security=True");

        private void Btnoygiris_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLILCE (ilcead,AParti,BParti,CParti,DParti,EParti) values (@P1,@P2,@P3,@P4,@P5,@P6)", baglanti);
            komut.Parameters.AddWithValue("@P1", Txtİlce.Text);
            komut.Parameters.AddWithValue("@P2", Txta.Text);
            komut.Parameters.AddWithValue("@P3", Txtb.Text);
            komut.Parameters.AddWithValue("@P4", Txtc.Text);
            komut.Parameters.AddWithValue("@P5", Txtd.Text);
            komut.Parameters.AddWithValue("@P6", Txte.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Oy Girişi Başarılı Bir Şekilde Gerçekleşti");
        }

        private void Btngrafikler_Click(object sender, EventArgs e)
        {
            FrmGrafikler fr = new FrmGrafikler();
            fr.Show();
        }
    }
}
