namespace ProjeHareket
{
    partial class FrmUrunListesi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hareketDataSet = new ProjeHareket.HareketDataSet();
            this.uRUNLERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uRUNLERTableAdapter = new ProjeHareket.HareketDataSetTableAdapters.URUNLERTableAdapter();
            this.ıDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTOKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aLISFIYATDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sATISFIYATDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hareketDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uRUNLERBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıDDataGridViewTextBoxColumn,
            this.aDDataGridViewTextBoxColumn,
            this.sTOKDataGridViewTextBoxColumn,
            this.aLISFIYATDataGridViewTextBoxColumn,
            this.sATISFIYATDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.uRUNLERBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(942, 304);
            this.dataGridView1.TabIndex = 0;
            // 
            // hareketDataSet
            // 
            this.hareketDataSet.DataSetName = "HareketDataSet";
            this.hareketDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uRUNLERBindingSource
            // 
            this.uRUNLERBindingSource.DataMember = "URUNLER";
            this.uRUNLERBindingSource.DataSource = this.hareketDataSet;
            // 
            // uRUNLERTableAdapter
            // 
            this.uRUNLERTableAdapter.ClearBeforeFill = true;
            // 
            // ıDDataGridViewTextBoxColumn
            // 
            this.ıDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.ıDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.ıDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ıDDataGridViewTextBoxColumn.Name = "ıDDataGridViewTextBoxColumn";
            this.ıDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aDDataGridViewTextBoxColumn
            // 
            this.aDDataGridViewTextBoxColumn.DataPropertyName = "AD";
            this.aDDataGridViewTextBoxColumn.HeaderText = "AD";
            this.aDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aDDataGridViewTextBoxColumn.Name = "aDDataGridViewTextBoxColumn";
            // 
            // sTOKDataGridViewTextBoxColumn
            // 
            this.sTOKDataGridViewTextBoxColumn.DataPropertyName = "STOK";
            this.sTOKDataGridViewTextBoxColumn.HeaderText = "STOK";
            this.sTOKDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sTOKDataGridViewTextBoxColumn.Name = "sTOKDataGridViewTextBoxColumn";
            // 
            // aLISFIYATDataGridViewTextBoxColumn
            // 
            this.aLISFIYATDataGridViewTextBoxColumn.DataPropertyName = "ALISFIYAT";
            this.aLISFIYATDataGridViewTextBoxColumn.HeaderText = "ALISFIYAT";
            this.aLISFIYATDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aLISFIYATDataGridViewTextBoxColumn.Name = "aLISFIYATDataGridViewTextBoxColumn";
            // 
            // sATISFIYATDataGridViewTextBoxColumn
            // 
            this.sATISFIYATDataGridViewTextBoxColumn.DataPropertyName = "SATISFIYAT";
            this.sATISFIYATDataGridViewTextBoxColumn.HeaderText = "SATISFIYAT";
            this.sATISFIYATDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sATISFIYATDataGridViewTextBoxColumn.Name = "sATISFIYATDataGridViewTextBoxColumn";
            // 
            // FrmUrunListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 304);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmUrunListesi";
            this.Text = "Ürün Listesi";
            this.Load += new System.EventHandler(this.FrmUrunListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hareketDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uRUNLERBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private HareketDataSet hareketDataSet;
        private System.Windows.Forms.BindingSource uRUNLERBindingSource;
        private HareketDataSetTableAdapters.URUNLERTableAdapter uRUNLERTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTOKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aLISFIYATDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sATISFIYATDataGridViewTextBoxColumn;
    }
}