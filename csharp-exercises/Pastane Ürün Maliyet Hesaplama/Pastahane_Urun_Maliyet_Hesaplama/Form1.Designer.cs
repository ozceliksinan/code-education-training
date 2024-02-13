
namespace Pastahane_Urun_Maliyet_Hesaplama
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnMalzemeEkle = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.TxtMalzemeNOTLAR = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtMalzemeFIYAT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtMalzemeSTOK = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtMalzemeAD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtMalzemeID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnUrunEkle = new System.Windows.Forms.Button();
            this.BtnUrunGuncelle = new System.Windows.Forms.Button();
            this.TxtUrunSFıyat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtUrunMFıyat = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtUrunStok = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtUrunAd = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtUrunID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.CmbMalzeme = new System.Windows.Forms.ComboBox();
            this.CmbUrun = new System.Windows.Forms.ComboBox();
            this.BtnUrunOlustur = new System.Windows.Forms.Button();
            this.TxtUrunMaliyet = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtUrunMiktar = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.BtnCikis = new System.Windows.Forms.Button();
            this.BtnKasa = new System.Windows.Forms.Button();
            this.BtnMalzemeListesi = new System.Windows.Forms.Button();
            this.BtnUrunListesi = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnMalzemeEkle);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.TxtMalzemeNOTLAR);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TxtMalzemeFIYAT);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TxtMalzemeSTOK);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtMalzemeAD);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtMalzemeID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(17, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(404, 349);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Malzeme Girişi";
            // 
            // BtnMalzemeEkle
            // 
            this.BtnMalzemeEkle.BackColor = System.Drawing.Color.LightGreen;
            this.BtnMalzemeEkle.Location = new System.Drawing.Point(116, 287);
            this.BtnMalzemeEkle.Name = "BtnMalzemeEkle";
            this.BtnMalzemeEkle.Size = new System.Drawing.Size(155, 35);
            this.BtnMalzemeEkle.TabIndex = 11;
            this.BtnMalzemeEkle.Text = "Malzeme Ekle";
            this.BtnMalzemeEkle.UseVisualStyleBackColor = false;
            this.BtnMalzemeEkle.Click += new System.EventHandler(this.BtnMalzemeEkle_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PowderBlue;
            this.button1.Location = new System.Drawing.Point(277, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 33);
            this.button1.TabIndex = 10;
            this.button1.Text = "Getir:";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // TxtMalzemeNOTLAR
            // 
            this.TxtMalzemeNOTLAR.Location = new System.Drawing.Point(116, 251);
            this.TxtMalzemeNOTLAR.Name = "TxtMalzemeNOTLAR";
            this.TxtMalzemeNOTLAR.Size = new System.Drawing.Size(155, 30);
            this.TxtMalzemeNOTLAR.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "NOTLAR:";
            // 
            // TxtMalzemeFIYAT
            // 
            this.TxtMalzemeFIYAT.Location = new System.Drawing.Point(116, 202);
            this.TxtMalzemeFIYAT.Name = "TxtMalzemeFIYAT";
            this.TxtMalzemeFIYAT.Size = new System.Drawing.Size(155, 30);
            this.TxtMalzemeFIYAT.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "FİYAT:";
            // 
            // TxtMalzemeSTOK
            // 
            this.TxtMalzemeSTOK.Location = new System.Drawing.Point(116, 152);
            this.TxtMalzemeSTOK.Name = "TxtMalzemeSTOK";
            this.TxtMalzemeSTOK.Size = new System.Drawing.Size(155, 30);
            this.TxtMalzemeSTOK.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "STOK:";
            // 
            // TxtMalzemeAD
            // 
            this.TxtMalzemeAD.Location = new System.Drawing.Point(116, 95);
            this.TxtMalzemeAD.Name = "TxtMalzemeAD";
            this.TxtMalzemeAD.Size = new System.Drawing.Size(155, 30);
            this.TxtMalzemeAD.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "AD:";
            // 
            // TxtMalzemeID
            // 
            this.TxtMalzemeID.Enabled = false;
            this.TxtMalzemeID.Location = new System.Drawing.Point(116, 43);
            this.TxtMalzemeID.Name = "TxtMalzemeID";
            this.TxtMalzemeID.Size = new System.Drawing.Size(155, 30);
            this.TxtMalzemeID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(17, 368);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1228, 242);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Malzemeler";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1222, 213);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnUrunEkle);
            this.groupBox3.Controls.Add(this.BtnUrunGuncelle);
            this.groupBox3.Controls.Add(this.TxtUrunSFıyat);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.TxtUrunMFıyat);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.TxtUrunStok);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.TxtUrunAd);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.TxtUrunID);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(427, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(404, 349);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ÜRÜN GİRİŞİ";
            // 
            // BtnUrunEkle
            // 
            this.BtnUrunEkle.BackColor = System.Drawing.Color.LightGreen;
            this.BtnUrunEkle.Location = new System.Drawing.Point(188, 287);
            this.BtnUrunEkle.Name = "BtnUrunEkle";
            this.BtnUrunEkle.Size = new System.Drawing.Size(155, 35);
            this.BtnUrunEkle.TabIndex = 11;
            this.BtnUrunEkle.Text = "Ürün Ekle";
            this.BtnUrunEkle.UseVisualStyleBackColor = false;
            this.BtnUrunEkle.Click += new System.EventHandler(this.BtnUrunEkle_Click);
            // 
            // BtnUrunGuncelle
            // 
            this.BtnUrunGuncelle.BackColor = System.Drawing.Color.Plum;
            this.BtnUrunGuncelle.Location = new System.Drawing.Point(27, 287);
            this.BtnUrunGuncelle.Name = "BtnUrunGuncelle";
            this.BtnUrunGuncelle.Size = new System.Drawing.Size(155, 33);
            this.BtnUrunGuncelle.TabIndex = 10;
            this.BtnUrunGuncelle.Text = "Güncelle";
            this.BtnUrunGuncelle.UseVisualStyleBackColor = false;
            // 
            // TxtUrunSFıyat
            // 
            this.TxtUrunSFıyat.Location = new System.Drawing.Point(116, 251);
            this.TxtUrunSFıyat.Name = "TxtUrunSFıyat";
            this.TxtUrunSFıyat.Size = new System.Drawing.Size(155, 30);
            this.TxtUrunSFıyat.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "S.FİYAT:";
            // 
            // TxtUrunMFıyat
            // 
            this.TxtUrunMFıyat.Location = new System.Drawing.Point(116, 202);
            this.TxtUrunMFıyat.Name = "TxtUrunMFıyat";
            this.TxtUrunMFıyat.Size = new System.Drawing.Size(155, 30);
            this.TxtUrunMFıyat.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "M.FİYAT:";
            // 
            // TxtUrunStok
            // 
            this.TxtUrunStok.Location = new System.Drawing.Point(116, 152);
            this.TxtUrunStok.Name = "TxtUrunStok";
            this.TxtUrunStok.Size = new System.Drawing.Size(155, 30);
            this.TxtUrunStok.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(41, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 25);
            this.label8.TabIndex = 4;
            this.label8.Text = "STOK:";
            // 
            // TxtUrunAd
            // 
            this.TxtUrunAd.Location = new System.Drawing.Point(116, 95);
            this.TxtUrunAd.Name = "TxtUrunAd";
            this.TxtUrunAd.Size = new System.Drawing.Size(155, 30);
            this.TxtUrunAd.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(70, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 25);
            this.label9.TabIndex = 2;
            this.label9.Text = "AD:";
            // 
            // TxtUrunID
            // 
            this.TxtUrunID.Location = new System.Drawing.Point(116, 43);
            this.TxtUrunID.Name = "TxtUrunID";
            this.TxtUrunID.Size = new System.Drawing.Size(155, 30);
            this.TxtUrunID.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(79, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 25);
            this.label10.TabIndex = 0;
            this.label10.Text = "ID:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.CmbMalzeme);
            this.groupBox4.Controls.Add(this.CmbUrun);
            this.groupBox4.Controls.Add(this.BtnUrunOlustur);
            this.groupBox4.Controls.Add(this.TxtUrunMaliyet);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.TxtUrunMiktar);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Location = new System.Drawing.Point(837, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(404, 349);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "ÜRÜN OLUŞTUR";
            // 
            // CmbMalzeme
            // 
            this.CmbMalzeme.FormattingEnabled = true;
            this.CmbMalzeme.Location = new System.Drawing.Point(116, 95);
            this.CmbMalzeme.Name = "CmbMalzeme";
            this.CmbMalzeme.Size = new System.Drawing.Size(155, 33);
            this.CmbMalzeme.TabIndex = 13;
            // 
            // CmbUrun
            // 
            this.CmbUrun.FormattingEnabled = true;
            this.CmbUrun.Location = new System.Drawing.Point(116, 40);
            this.CmbUrun.Name = "CmbUrun";
            this.CmbUrun.Size = new System.Drawing.Size(155, 33);
            this.CmbUrun.TabIndex = 12;
            // 
            // BtnUrunOlustur
            // 
            this.BtnUrunOlustur.BackColor = System.Drawing.Color.LightGreen;
            this.BtnUrunOlustur.Location = new System.Drawing.Point(116, 251);
            this.BtnUrunOlustur.Name = "BtnUrunOlustur";
            this.BtnUrunOlustur.Size = new System.Drawing.Size(155, 80);
            this.BtnUrunOlustur.TabIndex = 11;
            this.BtnUrunOlustur.Text = "Ekle";
            this.BtnUrunOlustur.UseVisualStyleBackColor = false;
            this.BtnUrunOlustur.Click += new System.EventHandler(this.BtnUrunOlustur_Click);
            // 
            // TxtUrunMaliyet
            // 
            this.TxtUrunMaliyet.Location = new System.Drawing.Point(116, 202);
            this.TxtUrunMaliyet.Name = "TxtUrunMaliyet";
            this.TxtUrunMaliyet.Size = new System.Drawing.Size(155, 30);
            this.TxtUrunMaliyet.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 205);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 25);
            this.label12.TabIndex = 6;
            this.label12.Text = "MALİYET:";
            // 
            // TxtUrunMiktar
            // 
            this.TxtUrunMiktar.Location = new System.Drawing.Point(116, 152);
            this.TxtUrunMiktar.Name = "TxtUrunMiktar";
            this.TxtUrunMiktar.Size = new System.Drawing.Size(155, 30);
            this.TxtUrunMiktar.TabIndex = 5;
            this.TxtUrunMiktar.TextChanged += new System.EventHandler(this.TxtUrunMiktar_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(16, 157);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 25);
            this.label13.TabIndex = 4;
            this.label13.Text = "MIKTAR:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(-5, 100);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(115, 25);
            this.label14.TabIndex = 2;
            this.label14.Text = "MALZEME:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(37, 48);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(73, 25);
            this.label15.TabIndex = 0;
            this.label15.Text = "ÜRÜN:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.BtnCikis);
            this.groupBox5.Controls.Add(this.BtnKasa);
            this.groupBox5.Controls.Add(this.BtnMalzemeListesi);
            this.groupBox5.Controls.Add(this.BtnUrunListesi);
            this.groupBox5.Location = new System.Drawing.Point(1248, 368);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(229, 232);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            // 
            // BtnCikis
            // 
            this.BtnCikis.BackColor = System.Drawing.Color.Salmon;
            this.BtnCikis.Location = new System.Drawing.Point(6, 179);
            this.BtnCikis.Name = "BtnCikis";
            this.BtnCikis.Size = new System.Drawing.Size(205, 30);
            this.BtnCikis.TabIndex = 3;
            this.BtnCikis.Text = "Çıkış";
            this.BtnCikis.UseVisualStyleBackColor = false;
            // 
            // BtnKasa
            // 
            this.BtnKasa.BackColor = System.Drawing.Color.PapayaWhip;
            this.BtnKasa.Location = new System.Drawing.Point(6, 124);
            this.BtnKasa.Name = "BtnKasa";
            this.BtnKasa.Size = new System.Drawing.Size(205, 30);
            this.BtnKasa.TabIndex = 2;
            this.BtnKasa.Text = "Kasa";
            this.BtnKasa.UseVisualStyleBackColor = false;
            this.BtnKasa.Click += new System.EventHandler(this.BtnKasa_Click);
            // 
            // BtnMalzemeListesi
            // 
            this.BtnMalzemeListesi.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BtnMalzemeListesi.Location = new System.Drawing.Point(6, 78);
            this.BtnMalzemeListesi.Name = "BtnMalzemeListesi";
            this.BtnMalzemeListesi.Size = new System.Drawing.Size(205, 30);
            this.BtnMalzemeListesi.TabIndex = 1;
            this.BtnMalzemeListesi.Text = "Malzeme Listesi";
            this.BtnMalzemeListesi.UseVisualStyleBackColor = false;
            this.BtnMalzemeListesi.Click += new System.EventHandler(this.BtnMalzemeListesi_Click);
            // 
            // BtnUrunListesi
            // 
            this.BtnUrunListesi.BackColor = System.Drawing.Color.Red;
            this.BtnUrunListesi.Location = new System.Drawing.Point(6, 29);
            this.BtnUrunListesi.Name = "BtnUrunListesi";
            this.BtnUrunListesi.Size = new System.Drawing.Size(205, 30);
            this.BtnUrunListesi.TabIndex = 0;
            this.BtnUrunListesi.Text = "Ürün Listesi";
            this.BtnUrunListesi.UseVisualStyleBackColor = false;
            this.BtnUrunListesi.Click += new System.EventHandler(this.BtnUrunListesi_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.listBox1);
            this.groupBox6.Location = new System.Drawing.Point(1248, 13);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(238, 349);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(3, 26);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(232, 320);
            this.listBox1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(1490, 609);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnMalzemeEkle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TxtMalzemeNOTLAR;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtMalzemeFIYAT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtMalzemeSTOK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtMalzemeAD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtMalzemeID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BtnUrunEkle;
        private System.Windows.Forms.Button BtnUrunGuncelle;
        private System.Windows.Forms.TextBox TxtUrunSFıyat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtUrunMFıyat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtUrunStok;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtUrunAd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtUrunID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button BtnUrunOlustur;
        private System.Windows.Forms.TextBox TxtUrunMaliyet;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TxtUrunMiktar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button BtnCikis;
        private System.Windows.Forms.Button BtnKasa;
        private System.Windows.Forms.Button BtnMalzemeListesi;
        private System.Windows.Forms.Button BtnUrunListesi;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox CmbMalzeme;
        private System.Windows.Forms.ComboBox CmbUrun;
    }
}

