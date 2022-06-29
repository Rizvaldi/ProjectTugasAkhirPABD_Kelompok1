
namespace AplikasiSembakoPABD
{
    partial class Barang
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
            this.idbarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jenisbarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namabarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barangBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.sembakoDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sembakoDataSet1 = new AplikasiSembakoPABD.SembakoDataSet1();
            this.barangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sembakoDataSet = new AplikasiSembakoPABD.sembakoDataSet();
            this.txtidbarang = new System.Windows.Forms.TextBox();
            this.barangTableAdapter = new AplikasiSembakoPABD.sembakoDataSetTableAdapters.barangTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtnamabarang = new System.Windows.Forms.TextBox();
            this.txthargabarang = new System.Windows.Forms.TextBox();
            this.txtjsbarang = new System.Windows.Forms.TextBox();
            this.txtstokbarang = new System.Windows.Forms.TextBox();
            this.EditBarang = new System.Windows.Forms.Button();
            this.SimpanBarang = new System.Windows.Forms.Button();
            this.HapusBarang = new System.Windows.Forms.Button();
            this.TambahBarang = new System.Windows.Forms.Button();
            this.KembaliBarang = new System.Windows.Forms.Button();
            this.barangBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.barangTableAdapter1 = new AplikasiSembakoPABD.SembakoDataSet1TableAdapters.BarangTableAdapter();
            this.fKPembeliidbara3B75D760BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pembeliTableAdapter = new AplikasiSembakoPABD.SembakoDataSet1TableAdapters.PembeliTableAdapter();
            this.sembakoDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datapenjualanDataSet = new AplikasiSembakoPABD.datapenjualanDataSet();
            this.barangBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.barangTableAdapter2 = new AplikasiSembakoPABD.datapenjualanDataSetTableAdapters.BarangTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barangBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sembakoDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sembakoDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sembakoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barangBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPembeliidbara3B75D760BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sembakoDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datapenjualanDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barangBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idbarangDataGridViewTextBoxColumn,
            this.jenisbarangDataGridViewTextBoxColumn,
            this.hargaDataGridViewTextBoxColumn,
            this.stockDataGridViewTextBoxColumn,
            this.namabarangDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.barangBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 150);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idbarangDataGridViewTextBoxColumn
            // 
            this.idbarangDataGridViewTextBoxColumn.DataPropertyName = "id_barang";
            this.idbarangDataGridViewTextBoxColumn.HeaderText = "id_barang";
            this.idbarangDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idbarangDataGridViewTextBoxColumn.Name = "idbarangDataGridViewTextBoxColumn";
            // 
            // jenisbarangDataGridViewTextBoxColumn
            // 
            this.jenisbarangDataGridViewTextBoxColumn.DataPropertyName = "jenis_barang";
            this.jenisbarangDataGridViewTextBoxColumn.HeaderText = "jenis_barang";
            this.jenisbarangDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jenisbarangDataGridViewTextBoxColumn.Name = "jenisbarangDataGridViewTextBoxColumn";
            // 
            // hargaDataGridViewTextBoxColumn
            // 
            this.hargaDataGridViewTextBoxColumn.DataPropertyName = "harga";
            this.hargaDataGridViewTextBoxColumn.HeaderText = "harga";
            this.hargaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hargaDataGridViewTextBoxColumn.Name = "hargaDataGridViewTextBoxColumn";
            // 
            // stockDataGridViewTextBoxColumn
            // 
            this.stockDataGridViewTextBoxColumn.DataPropertyName = "stock";
            this.stockDataGridViewTextBoxColumn.HeaderText = "stock";
            this.stockDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stockDataGridViewTextBoxColumn.Name = "stockDataGridViewTextBoxColumn";
            // 
            // namabarangDataGridViewTextBoxColumn
            // 
            this.namabarangDataGridViewTextBoxColumn.DataPropertyName = "nama_barang";
            this.namabarangDataGridViewTextBoxColumn.HeaderText = "nama_barang";
            this.namabarangDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namabarangDataGridViewTextBoxColumn.Name = "namabarangDataGridViewTextBoxColumn";
            // 
            // barangBindingSource2
            // 
            this.barangBindingSource2.DataMember = "Barang";
            this.barangBindingSource2.DataSource = this.sembakoDataSet1BindingSource;
            // 
            // sembakoDataSet1BindingSource
            // 
            this.sembakoDataSet1BindingSource.DataSource = this.sembakoDataSet1;
            this.sembakoDataSet1BindingSource.Position = 0;
            // 
            // sembakoDataSet1
            // 
            this.sembakoDataSet1.DataSetName = "SembakoDataSet1";
            this.sembakoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // barangBindingSource
            // 
            this.barangBindingSource.DataMember = "barang";
            this.barangBindingSource.DataSource = this.sembakoDataSet;
            // 
            // sembakoDataSet
            // 
            this.sembakoDataSet.DataSetName = "sembakoDataSet";
            this.sembakoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtidbarang
            // 
            this.txtidbarang.Location = new System.Drawing.Point(200, 210);
            this.txtidbarang.Name = "txtidbarang";
            this.txtidbarang.Size = new System.Drawing.Size(100, 22);
            this.txtidbarang.TabIndex = 2;
            this.txtidbarang.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // barangTableAdapter
            // 
            this.barangTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Id Barang :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nama Barang :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Harga :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 341);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Jenis Barang :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(53, 381);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Stok Barang :";
            // 
            // txtnamabarang
            // 
            this.txtnamabarang.Location = new System.Drawing.Point(200, 256);
            this.txtnamabarang.Name = "txtnamabarang";
            this.txtnamabarang.Size = new System.Drawing.Size(100, 22);
            this.txtnamabarang.TabIndex = 8;
            // 
            // txthargabarang
            // 
            this.txthargabarang.Location = new System.Drawing.Point(200, 294);
            this.txthargabarang.Name = "txthargabarang";
            this.txthargabarang.Size = new System.Drawing.Size(100, 22);
            this.txthargabarang.TabIndex = 9;
            // 
            // txtjsbarang
            // 
            this.txtjsbarang.Location = new System.Drawing.Point(200, 341);
            this.txtjsbarang.Name = "txtjsbarang";
            this.txtjsbarang.Size = new System.Drawing.Size(100, 22);
            this.txtjsbarang.TabIndex = 10;
            // 
            // txtstokbarang
            // 
            this.txtstokbarang.Location = new System.Drawing.Point(200, 381);
            this.txtstokbarang.Name = "txtstokbarang";
            this.txtstokbarang.Size = new System.Drawing.Size(100, 22);
            this.txtstokbarang.TabIndex = 11;
            // 
            // EditBarang
            // 
            this.EditBarang.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditBarang.Location = new System.Drawing.Point(422, 225);
            this.EditBarang.Name = "EditBarang";
            this.EditBarang.Size = new System.Drawing.Size(75, 23);
            this.EditBarang.TabIndex = 12;
            this.EditBarang.Text = "Edit";
            this.EditBarang.UseVisualStyleBackColor = true;
            this.EditBarang.Click += new System.EventHandler(this.EditBarang_Click);
            // 
            // SimpanBarang
            // 
            this.SimpanBarang.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SimpanBarang.Location = new System.Drawing.Point(564, 225);
            this.SimpanBarang.Name = "SimpanBarang";
            this.SimpanBarang.Size = new System.Drawing.Size(75, 23);
            this.SimpanBarang.TabIndex = 13;
            this.SimpanBarang.Text = "Simpan";
            this.SimpanBarang.UseVisualStyleBackColor = true;
            this.SimpanBarang.Click += new System.EventHandler(this.SimpanBarang_Click);
            // 
            // HapusBarang
            // 
            this.HapusBarang.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HapusBarang.Location = new System.Drawing.Point(422, 270);
            this.HapusBarang.Name = "HapusBarang";
            this.HapusBarang.Size = new System.Drawing.Size(75, 23);
            this.HapusBarang.TabIndex = 14;
            this.HapusBarang.Text = "Hapus";
            this.HapusBarang.UseVisualStyleBackColor = true;
            this.HapusBarang.Click += new System.EventHandler(this.HapusBarang_Click);
            // 
            // TambahBarang
            // 
            this.TambahBarang.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TambahBarang.Location = new System.Drawing.Point(564, 270);
            this.TambahBarang.Name = "TambahBarang";
            this.TambahBarang.Size = new System.Drawing.Size(75, 23);
            this.TambahBarang.TabIndex = 15;
            this.TambahBarang.Text = "Tambah";
            this.TambahBarang.UseVisualStyleBackColor = true;
            this.TambahBarang.Click += new System.EventHandler(this.TambahBarang_Click);
            // 
            // KembaliBarang
            // 
            this.KembaliBarang.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KembaliBarang.Location = new System.Drawing.Point(494, 321);
            this.KembaliBarang.Name = "KembaliBarang";
            this.KembaliBarang.Size = new System.Drawing.Size(75, 23);
            this.KembaliBarang.TabIndex = 16;
            this.KembaliBarang.Text = "Kembali";
            this.KembaliBarang.UseVisualStyleBackColor = true;
            this.KembaliBarang.Click += new System.EventHandler(this.KembaliBarang_Click);
            // 
            // barangBindingSource1
            // 
            this.barangBindingSource1.DataMember = "Barang";
            this.barangBindingSource1.DataSource = this.sembakoDataSet1;
            // 
            // barangTableAdapter1
            // 
            this.barangTableAdapter1.ClearBeforeFill = true;
            // 
            // fKPembeliidbara3B75D760BindingSource
            // 
            this.fKPembeliidbara3B75D760BindingSource.DataMember = "FK__Pembeli__id_bara__3B75D760";
            this.fKPembeliidbara3B75D760BindingSource.DataSource = this.barangBindingSource1;
            // 
            // pembeliTableAdapter
            // 
            this.pembeliTableAdapter.ClearBeforeFill = true;
            // 
            // sembakoDataSetBindingSource
            // 
            this.sembakoDataSetBindingSource.DataSource = this.sembakoDataSet;
            this.sembakoDataSetBindingSource.Position = 0;
            // 
            // datapenjualanDataSet
            // 
            this.datapenjualanDataSet.DataSetName = "datapenjualanDataSet";
            this.datapenjualanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // barangBindingSource3
            // 
            this.barangBindingSource3.DataMember = "Barang";
            this.barangBindingSource3.DataSource = this.datapenjualanDataSet;
            // 
            // barangTableAdapter2
            // 
            this.barangTableAdapter2.ClearBeforeFill = true;
            // 
            // Barang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.KembaliBarang);
            this.Controls.Add(this.TambahBarang);
            this.Controls.Add(this.HapusBarang);
            this.Controls.Add(this.SimpanBarang);
            this.Controls.Add(this.EditBarang);
            this.Controls.Add(this.txtstokbarang);
            this.Controls.Add(this.txtjsbarang);
            this.Controls.Add(this.txthargabarang);
            this.Controls.Add(this.txtnamabarang);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtidbarang);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Barang";
            this.Text = "Barang";
            this.Load += new System.EventHandler(this.Barang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barangBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sembakoDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sembakoDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sembakoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barangBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPembeliidbara3B75D760BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sembakoDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datapenjualanDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barangBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtidbarang;
        private sembakoDataSet sembakoDataSet;
        private System.Windows.Forms.BindingSource barangBindingSource;
        private sembakoDataSetTableAdapters.barangTableAdapter barangTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtnamabarang;
        private System.Windows.Forms.TextBox txthargabarang;
        private System.Windows.Forms.TextBox txtjsbarang;
        private System.Windows.Forms.TextBox txtstokbarang;
        private System.Windows.Forms.Button EditBarang;
        private System.Windows.Forms.Button SimpanBarang;
        private System.Windows.Forms.Button HapusBarang;
        private System.Windows.Forms.Button TambahBarang;
        private System.Windows.Forms.Button KembaliBarang;
        private SembakoDataSet1 sembakoDataSet1;
        private System.Windows.Forms.BindingSource barangBindingSource1;
        private SembakoDataSet1TableAdapters.BarangTableAdapter barangTableAdapter1;
        private System.Windows.Forms.BindingSource fKPembeliidbara3B75D760BindingSource;
        private SembakoDataSet1TableAdapters.PembeliTableAdapter pembeliTableAdapter;
        private System.Windows.Forms.BindingSource barangBindingSource2;
        private System.Windows.Forms.BindingSource sembakoDataSet1BindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idbarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jenisbarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namabarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource sembakoDataSetBindingSource;
        private datapenjualanDataSet datapenjualanDataSet;
        private System.Windows.Forms.BindingSource barangBindingSource3;
        private datapenjualanDataSetTableAdapters.BarangTableAdapter barangTableAdapter2;
    }
}