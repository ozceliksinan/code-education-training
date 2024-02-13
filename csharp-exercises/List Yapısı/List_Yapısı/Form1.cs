using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace List_Yapısı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            List<string> karakterler = new List<string>();
            karakterler.Add("İsim");
            karakterler.Add("Deneme");
            karakterler.Add("Temp");
            karakterler.Add("İsim 2");
            karakterler.Add("İsim 3");
            karakterler.Add("İsim 4");

            foreach (string k in karakterler)
            {
                listBox1.Items.Add(k);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<int> sayilar = new List<int>();
            sayilar.Add(45);
            sayilar.Add(30);
            sayilar.Add(90);
            sayilar.Add(20);
            sayilar.Add(60);
            sayilar.Add(45);
            sayilar.Add(25);

            foreach (int s in sayilar)
            {
                if (s % 5 == 0)
                {
                    listBox2.Items.Add(s);
                }
            }
            if (sayilar.Contains(74))
            {
                MessageBox.Show("Bu Sayi Var");
            }
            else
            {
                MessageBox.Show("Bu Sayi Yok");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<Kisiler> kisi = new List<Kisiler>();
            kisi.Add(new Kisiler()
            {
                ADI = "Sinan",
                SOYADI = "Özçelik",
                MESLEGI = "Mühendis"
            });

            foreach (Kisiler k in kisi)
            {
                listBox3.Items.Add(k.ADI + " " + k.SOYADI + " " + k.MESLEGI);
            }
        }
    }
}
