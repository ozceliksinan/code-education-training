namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            rd_Evli = new RadioButton();
            rd_Bekar = new RadioButton();
            label7 = new Label();
            txtID = new TextBox();
            txtAdi = new TextBox();
            txtSoyadi = new TextBox();
            txtSehir = new TextBox();
            txtMaas = new TextBox();
            txtMeslek = new TextBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            btnGrafikler = new Button();
            btnİstatistik = new Button();
            btnTemizle = new Button();
            btnGuncelle = new Button();
            btnSil = new Button();
            btnKaydet = new Button();
            btnListele = new Button();
            groupBox3 = new GroupBox();
            label8 = new Label();
            btnBaglantiDurum = new Button();
            lblDurum = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 19);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1004, 329);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 25);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 1;
            label1.Text = "Personel ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 54);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 2;
            label2.Text = "Personel Adı";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 83);
            label3.Name = "label3";
            label3.Size = new Size(90, 15);
            label3.TabIndex = 3;
            label3.Text = "Personel Soyadı";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(65, 112);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 4;
            label4.Text = "Şehir";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(65, 141);
            label5.Name = "label5";
            label5.Size = new Size(35, 15);
            label5.TabIndex = 5;
            label5.Text = "Maaş";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(56, 171);
            label6.Name = "label6";
            label6.Size = new Size(44, 15);
            label6.TabIndex = 6;
            label6.Text = "Durum";
            // 
            // rd_Evli
            // 
            rd_Evli.AutoSize = true;
            rd_Evli.Location = new Point(106, 171);
            rd_Evli.Name = "rd_Evli";
            rd_Evli.Size = new Size(43, 19);
            rd_Evli.TabIndex = 7;
            rd_Evli.TabStop = true;
            rd_Evli.Text = "Evli";
            rd_Evli.UseVisualStyleBackColor = true;
            rd_Evli.CheckedChanged += rd_Evli_CheckedChanged;
            // 
            // rd_Bekar
            // 
            rd_Bekar.AutoSize = true;
            rd_Bekar.Location = new Point(155, 171);
            rd_Bekar.Name = "rd_Bekar";
            rd_Bekar.Size = new Size(54, 19);
            rd_Bekar.TabIndex = 8;
            rd_Bekar.TabStop = true;
            rd_Bekar.Text = "Bekar";
            rd_Bekar.UseVisualStyleBackColor = true;
            rd_Bekar.CheckedChanged += rd_Bekar_CheckedChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(56, 199);
            label7.Name = "label7";
            label7.Size = new Size(44, 15);
            label7.TabIndex = 9;
            label7.Text = "Meslek";
            // 
            // txtID
            // 
            txtID.Location = new Point(104, 22);
            txtID.Name = "txtID";
            txtID.Size = new Size(100, 23);
            txtID.TabIndex = 10;
            // 
            // txtAdi
            // 
            txtAdi.Location = new Point(104, 51);
            txtAdi.Name = "txtAdi";
            txtAdi.Size = new Size(100, 23);
            txtAdi.TabIndex = 11;
            // 
            // txtSoyadi
            // 
            txtSoyadi.Location = new Point(104, 80);
            txtSoyadi.Name = "txtSoyadi";
            txtSoyadi.Size = new Size(100, 23);
            txtSoyadi.TabIndex = 12;
            // 
            // txtSehir
            // 
            txtSehir.Location = new Point(104, 109);
            txtSehir.Name = "txtSehir";
            txtSehir.Size = new Size(100, 23);
            txtSehir.TabIndex = 13;
            // 
            // txtMaas
            // 
            txtMaas.Location = new Point(106, 138);
            txtMaas.Name = "txtMaas";
            txtMaas.Size = new Size(100, 23);
            txtMaas.TabIndex = 14;
            // 
            // txtMeslek
            // 
            txtMeslek.Location = new Point(104, 196);
            txtMeslek.Name = "txtMeslek";
            txtMeslek.Size = new Size(100, 23);
            txtMeslek.TabIndex = 15;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtMaas);
            groupBox1.Controls.Add(txtMeslek);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtSehir);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtSoyadi);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtAdi);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtID);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(rd_Evli);
            groupBox1.Controls.Add(rd_Bekar);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(254, 232);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Personel Kayıt Bilgileri";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnGrafikler);
            groupBox2.Controls.Add(btnİstatistik);
            groupBox2.Controls.Add(btnTemizle);
            groupBox2.Controls.Add(btnGuncelle);
            groupBox2.Controls.Add(btnSil);
            groupBox2.Controls.Add(btnKaydet);
            groupBox2.Controls.Add(btnListele);
            groupBox2.Location = new Point(299, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 232);
            groupBox2.TabIndex = 17;
            groupBox2.TabStop = false;
            groupBox2.Text = "İşlemler";
            // 
            // btnGrafikler
            // 
            btnGrafikler.Location = new Point(54, 196);
            btnGrafikler.Name = "btnGrafikler";
            btnGrafikler.Size = new Size(86, 23);
            btnGrafikler.TabIndex = 6;
            btnGrafikler.Text = "Grafikler";
            btnGrafikler.UseVisualStyleBackColor = true;
            // 
            // btnİstatistik
            // 
            btnİstatistik.Location = new Point(54, 167);
            btnİstatistik.Name = "btnİstatistik";
            btnİstatistik.Size = new Size(86, 23);
            btnİstatistik.TabIndex = 5;
            btnİstatistik.Text = "İstatistik";
            btnİstatistik.UseVisualStyleBackColor = true;
            // 
            // btnTemizle
            // 
            btnTemizle.Location = new Point(54, 138);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(86, 23);
            btnTemizle.TabIndex = 4;
            btnTemizle.Text = "Temizle";
            btnTemizle.UseVisualStyleBackColor = true;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(54, 109);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(86, 23);
            btnGuncelle.TabIndex = 3;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(54, 80);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(86, 23);
            btnSil.TabIndex = 2;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(54, 51);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(86, 23);
            btnKaydet.TabIndex = 1;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnListele
            // 
            btnListele.Location = new Point(54, 22);
            btnListele.Name = "btnListele";
            btnListele.Size = new Size(86, 23);
            btnListele.TabIndex = 0;
            btnListele.Text = "Listele";
            btnListele.UseVisualStyleBackColor = true;
            btnListele.Click += btnListele_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridView1);
            groupBox3.Location = new Point(12, 261);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1010, 351);
            groupBox3.TabIndex = 18;
            groupBox3.TabStop = false;
            groupBox3.Text = "Kayıtlar";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(522, 34);
            label8.Name = "label8";
            label8.Size = new Size(152, 15);
            label8.TabIndex = 19;
            label8.Text = "Veritabanı Bağlantı Durumu";
            // 
            // btnBaglantiDurum
            // 
            btnBaglantiDurum.Location = new Point(522, 52);
            btnBaglantiDurum.Name = "btnBaglantiDurum";
            btnBaglantiDurum.Size = new Size(152, 34);
            btnBaglantiDurum.TabIndex = 20;
            btnBaglantiDurum.UseVisualStyleBackColor = true;
            // 
            // lblDurum
            // 
            lblDurum.AutoSize = true;
            lblDurum.Location = new Point(522, 19);
            lblDurum.Name = "lblDurum";
            lblDurum.Size = new Size(38, 15);
            lblDurum.TabIndex = 21;
            lblDurum.Text = "label9";
            lblDurum.TextChanged += lblDurum_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 624);
            Controls.Add(lblDurum);
            Controls.Add(btnBaglantiDurum);
            Controls.Add(label8);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private RadioButton rd_Evli;
        private RadioButton rd_Bekar;
        private Label label7;
        private TextBox txtID;
        private TextBox txtAdi;
        private TextBox txtSoyadi;
        private TextBox txtSehir;
        private TextBox txtMaas;
        private TextBox txtMeslek;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnGrafikler;
        private Button btnİstatistik;
        private Button btnTemizle;
        private Button btnGuncelle;
        private Button btnSil;
        private Button btnKaydet;
        private Button btnListele;
        private GroupBox groupBox3;
        private Label label8;
        private Button btnBaglantiDurum;
        private Label lblDurum;
    }
}