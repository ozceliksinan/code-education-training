
namespace Secim_Istatistik
{
    partial class FrmGiris
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
            this.label1 = new System.Windows.Forms.Label();
            this.Txtİlce = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Txtc = new System.Windows.Forms.TextBox();
            this.Txta = new System.Windows.Forms.TextBox();
            this.Txtb = new System.Windows.Forms.TextBox();
            this.Txtd = new System.Windows.Forms.TextBox();
            this.Txte = new System.Windows.Forms.TextBox();
            this.Btnoygiris = new System.Windows.Forms.Button();
            this.Btngrafikler = new System.Windows.Forms.Button();
            this.Btncikisyap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "İLÇE ADI :";
            // 
            // Txtİlce
            // 
            this.Txtİlce.Location = new System.Drawing.Point(134, 55);
            this.Txtİlce.Name = "Txtİlce";
            this.Txtİlce.Size = new System.Drawing.Size(419, 34);
            this.Txtİlce.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "A PARTİ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "B PARTİ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 28);
            this.label4.TabIndex = 4;
            this.label4.Text = "C PARTİ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 317);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 28);
            this.label5.TabIndex = 5;
            this.label5.Text = "D PARTİ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 369);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 28);
            this.label6.TabIndex = 6;
            this.label6.Text = "E PARTİ";
            // 
            // Txtc
            // 
            this.Txtc.Location = new System.Drawing.Point(134, 259);
            this.Txtc.Name = "Txtc";
            this.Txtc.Size = new System.Drawing.Size(419, 34);
            this.Txtc.TabIndex = 7;
            // 
            // Txta
            // 
            this.Txta.Location = new System.Drawing.Point(134, 154);
            this.Txta.Name = "Txta";
            this.Txta.Size = new System.Drawing.Size(419, 34);
            this.Txta.TabIndex = 8;
            // 
            // Txtb
            // 
            this.Txtb.Location = new System.Drawing.Point(134, 204);
            this.Txtb.Name = "Txtb";
            this.Txtb.Size = new System.Drawing.Size(419, 34);
            this.Txtb.TabIndex = 9;
            // 
            // Txtd
            // 
            this.Txtd.Location = new System.Drawing.Point(134, 311);
            this.Txtd.Name = "Txtd";
            this.Txtd.Size = new System.Drawing.Size(419, 34);
            this.Txtd.TabIndex = 10;
            // 
            // Txte
            // 
            this.Txte.Location = new System.Drawing.Point(134, 363);
            this.Txte.Name = "Txte";
            this.Txte.Size = new System.Drawing.Size(419, 34);
            this.Txte.TabIndex = 11;
            // 
            // Btnoygiris
            // 
            this.Btnoygiris.BackColor = System.Drawing.Color.GreenYellow;
            this.Btnoygiris.Location = new System.Drawing.Point(204, 412);
            this.Btnoygiris.Name = "Btnoygiris";
            this.Btnoygiris.Size = new System.Drawing.Size(247, 54);
            this.Btnoygiris.TabIndex = 12;
            this.Btnoygiris.Text = "Oy Girişi Yap ";
            this.Btnoygiris.UseVisualStyleBackColor = false;
            this.Btnoygiris.Click += new System.EventHandler(this.Btnoygiris_Click);
            // 
            // Btngrafikler
            // 
            this.Btngrafikler.BackColor = System.Drawing.Color.OrangeRed;
            this.Btngrafikler.Location = new System.Drawing.Point(117, 472);
            this.Btngrafikler.Name = "Btngrafikler";
            this.Btngrafikler.Size = new System.Drawing.Size(419, 54);
            this.Btngrafikler.TabIndex = 14;
            this.Btngrafikler.Text = "Grafikler";
            this.Btngrafikler.UseVisualStyleBackColor = false;
            this.Btngrafikler.Click += new System.EventHandler(this.Btngrafikler_Click);
            // 
            // Btncikisyap
            // 
            this.Btncikisyap.BackColor = System.Drawing.Color.AliceBlue;
            this.Btncikisyap.Location = new System.Drawing.Point(494, 532);
            this.Btncikisyap.Name = "Btncikisyap";
            this.Btncikisyap.Size = new System.Drawing.Size(111, 44);
            this.Btncikisyap.TabIndex = 15;
            this.Btncikisyap.Text = "Çıkış Yap";
            this.Btncikisyap.UseVisualStyleBackColor = false;
            // 
            // FrmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(606, 577);
            this.Controls.Add(this.Btncikisyap);
            this.Controls.Add(this.Btngrafikler);
            this.Controls.Add(this.Btnoygiris);
            this.Controls.Add(this.Txte);
            this.Controls.Add(this.Txtd);
            this.Controls.Add(this.Txtb);
            this.Controls.Add(this.Txta);
            this.Controls.Add(this.Txtc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txtİlce);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seçim İstatistik";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txtİlce;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Txtc;
        private System.Windows.Forms.TextBox Txta;
        private System.Windows.Forms.TextBox Txtb;
        private System.Windows.Forms.TextBox Txtd;
        private System.Windows.Forms.TextBox Txte;
        private System.Windows.Forms.Button Btnoygiris;
        private System.Windows.Forms.Button Btngrafikler;
        private System.Windows.Forms.Button Btncikisyap;
    }
}

