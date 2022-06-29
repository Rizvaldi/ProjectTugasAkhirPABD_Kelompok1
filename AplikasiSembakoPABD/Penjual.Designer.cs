
namespace AplikasiSembakoPABD
{
    partial class Penjual
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
            this.idpenjualDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namapenjualDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alamatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nopenjualDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.penjualBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.datapenjualanDataSet = new AplikasiSembakoPABD.datapenjualanDataSet();
            this.penjualBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.sembakoDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sembakoDataSet = new AplikasiSembakoPABD.sembakoDataSet();
            this.penjualBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.barangBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtpenjual = new System.Windows.Forms.TextBox();
            this.txtnamapenjual = new System.Windows.Forms.TextBox();
            this.txtnotlppenjual = new System.Windows.Forms.TextBox();
            this.txtalamatpenjual = new System.Windows.Forms.TextBox();
            this.barangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.barangTableAdapter = new AplikasiSembakoPABD.sembakoDataSetTableAdapters.barangTableAdapter();
            this.penjualTableAdapter = new AplikasiSembakoPABD.sembakoDataSetTableAdapters.penjualTableAdapter();
            this.EditPenjual = new System.Windows.Forms.Button();
            this.SimpanPenjual = new System.Windows.Forms.Button();
            this.HapusPenjual = new System.Windows.Forms.Button();
            this.TambahPenjual = new System.Windows.Forms.Button();
            this.KembaliPenjual = new System.Windows.Forms.Button();
            this.penjualBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fKtransaksiidpe4CA06362BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transaksiTableAdapter = new AplikasiSembakoPABD.sembakoDataSetTableAdapters.transaksiTableAdapter();
            this.barangBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.fKtransaksiidpe4CA06362BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fKtransaksiidpe4CA06362BindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.sembakoDataSet1 = new AplikasiSembakoPABD.SembakoDataSet1();
            this.penjualBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.penjualTableAdapter1 = new AplikasiSembakoPABD.SembakoDataSet1TableAdapters.PenjualTableAdapter();
            this.penjualTableAdapter2 = new AplikasiSembakoPABD.datapenjualanDataSetTableAdapters.PenjualTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.penjualBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datapenjualanDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.penjualBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sembakoDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sembakoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.penjualBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barangBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.penjualBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKtransaksiidpe4CA06362BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barangBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKtransaksiidpe4CA06362BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKtransaksiidpe4CA06362BindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sembakoDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.penjualBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idpenjualDataGridViewTextBoxColumn,
            this.namapenjualDataGridViewTextBoxColumn,
            this.alamatDataGridViewTextBoxColumn,
            this.nopenjualDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.penjualBindingSource4;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 176);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idpenjualDataGridViewTextBoxColumn
            // 
            this.idpenjualDataGridViewTextBoxColumn.DataPropertyName = "id_penjual";
            this.idpenjualDataGridViewTextBoxColumn.HeaderText = "id_penjual";
            this.idpenjualDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idpenjualDataGridViewTextBoxColumn.Name = "idpenjualDataGridViewTextBoxColumn";
            // 
            // namapenjualDataGridViewTextBoxColumn
            // 
            this.namapenjualDataGridViewTextBoxColumn.DataPropertyName = "nama_penjual";
            this.namapenjualDataGridViewTextBoxColumn.HeaderText = "nama_penjual";
            this.namapenjualDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namapenjualDataGridViewTextBoxColumn.Name = "namapenjualDataGridViewTextBoxColumn";
            // 
            // alamatDataGridViewTextBoxColumn
            // 
            this.alamatDataGridViewTextBoxColumn.DataPropertyName = "alamat";
            this.alamatDataGridViewTextBoxColumn.HeaderText = "alamat";
            this.alamatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.alamatDataGridViewTextBoxColumn.Name = "alamatDataGridViewTextBoxColumn";
            // 
            // nopenjualDataGridViewTextBoxColumn
            // 
            this.nopenjualDataGridViewTextBoxColumn.DataPropertyName = "no_penjual";
            this.nopenjualDataGridViewTextBoxColumn.HeaderText = "no_penjual";
            this.nopenjualDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nopenjualDataGridViewTextBoxColumn.Name = "nopenjualDataGridViewTextBoxColumn";
            // 
            // penjualBindingSource4
            // 
            this.penjualBindingSource4.DataMember = "Penjual";
            this.penjualBindingSource4.DataSource = this.datapenjualanDataSet;
            // 
            // datapenjualanDataSet
            // 
            this.datapenjualanDataSet.DataSetName = "datapenjualanDataSet";
            this.datapenjualanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // penjualBindingSource2
            // 
            this.penjualBindingSource2.DataMember = "penjual";
            this.penjualBindingSource2.DataSource = this.sembakoDataSetBindingSource;
            // 
            // sembakoDataSetBindingSource
            // 
            this.sembakoDataSetBindingSource.DataSource = this.sembakoDataSet;
            this.sembakoDataSetBindingSource.Position = 0;
            // 
            // sembakoDataSet
            // 
            this.sembakoDataSet.DataSetName = "sembakoDataSet";
            this.sembakoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // penjualBindingSource
            // 
            this.penjualBindingSource.DataMember = "penjual";
            this.penjualBindingSource.DataSource = this.sembakoDataSetBindingSource;
            // 
            // barangBindingSource1
            // 
            this.barangBindingSource1.DataMember = "barang";
            this.barangBindingSource1.DataSource = this.sembakoDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Id Penjual :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nama Penjual :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nomor Telepon :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 347);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Alamat :";
            // 
            // txtpenjual
            // 
            this.txtpenjual.Location = new System.Drawing.Point(163, 241);
            this.txtpenjual.Name = "txtpenjual";
            this.txtpenjual.Size = new System.Drawing.Size(100, 22);
            this.txtpenjual.TabIndex = 6;
            // 
            // txtnamapenjual
            // 
            this.txtnamapenjual.Location = new System.Drawing.Point(163, 281);
            this.txtnamapenjual.Name = "txtnamapenjual";
            this.txtnamapenjual.Size = new System.Drawing.Size(100, 22);
            this.txtnamapenjual.TabIndex = 7;
            // 
            // txtnotlppenjual
            // 
            this.txtnotlppenjual.Location = new System.Drawing.Point(163, 317);
            this.txtnotlppenjual.Name = "txtnotlppenjual";
            this.txtnotlppenjual.Size = new System.Drawing.Size(100, 22);
            this.txtnotlppenjual.TabIndex = 8;
            // 
            // txtalamatpenjual
            // 
            this.txtalamatpenjual.Location = new System.Drawing.Point(163, 347);
            this.txtalamatpenjual.Name = "txtalamatpenjual";
            this.txtalamatpenjual.Size = new System.Drawing.Size(100, 22);
            this.txtalamatpenjual.TabIndex = 9;
            // 
            // barangBindingSource
            // 
            this.barangBindingSource.DataMember = "barang";
            this.barangBindingSource.DataSource = this.sembakoDataSetBindingSource;
            // 
            // barangTableAdapter
            // 
            this.barangTableAdapter.ClearBeforeFill = true;
            // 
            // penjualTableAdapter
            // 
            this.penjualTableAdapter.ClearBeforeFill = true;
            // 
            // EditPenjual
            // 
            this.EditPenjual.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditPenjual.Location = new System.Drawing.Point(363, 241);
            this.EditPenjual.Name = "EditPenjual";
            this.EditPenjual.Size = new System.Drawing.Size(75, 23);
            this.EditPenjual.TabIndex = 10;
            this.EditPenjual.Text = "Edit";
            this.EditPenjual.UseVisualStyleBackColor = true;
            this.EditPenjual.Click += new System.EventHandler(this.EditPenjual_Click);
            // 
            // SimpanPenjual
            // 
            this.SimpanPenjual.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SimpanPenjual.Location = new System.Drawing.Point(489, 241);
            this.SimpanPenjual.Name = "SimpanPenjual";
            this.SimpanPenjual.Size = new System.Drawing.Size(75, 23);
            this.SimpanPenjual.TabIndex = 11;
            this.SimpanPenjual.Text = "Simpan";
            this.SimpanPenjual.UseVisualStyleBackColor = true;
            this.SimpanPenjual.Click += new System.EventHandler(this.SimpanPenjual_Click);
            // 
            // HapusPenjual
            // 
            this.HapusPenjual.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HapusPenjual.Location = new System.Drawing.Point(363, 301);
            this.HapusPenjual.Name = "HapusPenjual";
            this.HapusPenjual.Size = new System.Drawing.Size(75, 23);
            this.HapusPenjual.TabIndex = 12;
            this.HapusPenjual.Text = "Hapus";
            this.HapusPenjual.UseVisualStyleBackColor = true;
            this.HapusPenjual.Click += new System.EventHandler(this.HapusPenjual_Click);
            // 
            // TambahPenjual
            // 
            this.TambahPenjual.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TambahPenjual.Location = new System.Drawing.Point(489, 301);
            this.TambahPenjual.Name = "TambahPenjual";
            this.TambahPenjual.Size = new System.Drawing.Size(75, 23);
            this.TambahPenjual.TabIndex = 13;
            this.TambahPenjual.Text = "Tambah";
            this.TambahPenjual.UseVisualStyleBackColor = true;
            this.TambahPenjual.Click += new System.EventHandler(this.TambahPenjual_Click);
            // 
            // KembaliPenjual
            // 
            this.KembaliPenjual.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KembaliPenjual.Location = new System.Drawing.Point(420, 344);
            this.KembaliPenjual.Name = "KembaliPenjual";
            this.KembaliPenjual.Size = new System.Drawing.Size(75, 23);
            this.KembaliPenjual.TabIndex = 14;
            this.KembaliPenjual.Text = "Kembali";
            this.KembaliPenjual.UseVisualStyleBackColor = true;
            this.KembaliPenjual.Click += new System.EventHandler(this.KembaliPenjual_Click);
            // 
            // penjualBindingSource1
            // 
            this.penjualBindingSource1.DataMember = "Penjual";
            this.penjualBindingSource1.DataSource = this.sembakoDataSet;
            // 
            // fKtransaksiidpe4CA06362BindingSource
            // 
            this.fKtransaksiidpe4CA06362BindingSource.DataMember = "FK__transaksi__id_pe__4CA06362";
            this.fKtransaksiidpe4CA06362BindingSource.DataSource = this.penjualBindingSource1;
            // 
            // transaksiTableAdapter
            // 
            this.transaksiTableAdapter.ClearBeforeFill = true;
            // 
            // barangBindingSource2
            // 
            this.barangBindingSource2.DataMember = "barang";
            this.barangBindingSource2.DataSource = this.sembakoDataSetBindingSource;
            // 
            // fKtransaksiidpe4CA06362BindingSource1
            // 
            this.fKtransaksiidpe4CA06362BindingSource1.DataMember = "FK__transaksi__id_pe__4CA06362";
            this.fKtransaksiidpe4CA06362BindingSource1.DataSource = this.penjualBindingSource;
            // 
            // fKtransaksiidpe4CA06362BindingSource2
            // 
            this.fKtransaksiidpe4CA06362BindingSource2.DataMember = "FK__transaksi__id_pe__4CA06362";
            this.fKtransaksiidpe4CA06362BindingSource2.DataSource = this.penjualBindingSource2;
            // 
            // sembakoDataSet1
            // 
            this.sembakoDataSet1.DataSetName = "SembakoDataSet1";
            this.sembakoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // penjualBindingSource3
            // 
            this.penjualBindingSource3.DataMember = "Penjual";
            this.penjualBindingSource3.DataSource = this.sembakoDataSet1;
            // 
            // penjualTableAdapter1
            // 
            this.penjualTableAdapter1.ClearBeforeFill = true;
            // 
            // penjualTableAdapter2
            // 
            this.penjualTableAdapter2.ClearBeforeFill = true;
            // 
            // Penjual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.KembaliPenjual);
            this.Controls.Add(this.TambahPenjual);
            this.Controls.Add(this.HapusPenjual);
            this.Controls.Add(this.SimpanPenjual);
            this.Controls.Add(this.EditPenjual);
            this.Controls.Add(this.txtalamatpenjual);
            this.Controls.Add(this.txtnotlppenjual);
            this.Controls.Add(this.txtnamapenjual);
            this.Controls.Add(this.txtpenjual);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Penjual";
            this.Text = "Penjual";
            this.Load += new System.EventHandler(this.Penjual_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.penjualBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datapenjualanDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.penjualBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sembakoDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sembakoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.penjualBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barangBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.penjualBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKtransaksiidpe4CA06362BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barangBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKtransaksiidpe4CA06362BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKtransaksiidpe4CA06362BindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sembakoDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.penjualBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtpenjual;
        private System.Windows.Forms.TextBox txtnamapenjual;
        private System.Windows.Forms.TextBox txtnotlppenjual;
        private System.Windows.Forms.TextBox txtalamatpenjual;
        private System.Windows.Forms.BindingSource sembakoDataSetBindingSource;
        private sembakoDataSet sembakoDataSet;
        private System.Windows.Forms.BindingSource barangBindingSource;
        private sembakoDataSetTableAdapters.barangTableAdapter barangTableAdapter;
        private System.Windows.Forms.BindingSource barangBindingSource1;
        private System.Windows.Forms.BindingSource penjualBindingSource;
        private sembakoDataSetTableAdapters.penjualTableAdapter penjualTableAdapter;
        private System.Windows.Forms.Button EditPenjual;
        private System.Windows.Forms.Button SimpanPenjual;
        private System.Windows.Forms.Button HapusPenjual;
        private System.Windows.Forms.Button TambahPenjual;
        private System.Windows.Forms.Button KembaliPenjual;
        private System.Windows.Forms.BindingSource penjualBindingSource1;
        private System.Windows.Forms.BindingSource fKtransaksiidpe4CA06362BindingSource;
        private sembakoDataSetTableAdapters.transaksiTableAdapter transaksiTableAdapter;
        private System.Windows.Forms.BindingSource penjualBindingSource2;
        private System.Windows.Forms.BindingSource fKtransaksiidpe4CA06362BindingSource2;
        private System.Windows.Forms.BindingSource barangBindingSource2;
        private System.Windows.Forms.BindingSource fKtransaksiidpe4CA06362BindingSource1;
        private SembakoDataSet1 sembakoDataSet1;
        private System.Windows.Forms.BindingSource penjualBindingSource3;
        private SembakoDataSet1TableAdapters.PenjualTableAdapter penjualTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpenjualDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namapenjualDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alamatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nopenjualDataGridViewTextBoxColumn;
        private datapenjualanDataSet datapenjualanDataSet;
        private System.Windows.Forms.BindingSource penjualBindingSource4;
        private datapenjualanDataSetTableAdapters.PenjualTableAdapter penjualTableAdapter2;
    }
}