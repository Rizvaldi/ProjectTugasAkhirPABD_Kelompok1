
namespace AplikasiSembakoPABD
{
    partial class Transaksi
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
            this.idtransaksiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idbarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpembeliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpenjualDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transaksiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sembakoDataSet = new AplikasiSembakoPABD.sembakoDataSet();
            this.transaksiTableAdapter = new AplikasiSembakoPABD.sembakoDataSetTableAdapters.transaksiTableAdapter();
            this.KembaliTransaksi = new System.Windows.Forms.Button();
            this.pembeliTableAdapter = new AplikasiSembakoPABD.sembakoDataSetTableAdapters.pembeliTableAdapter();
            this.datapenjualanDataSet = new AplikasiSembakoPABD.datapenjualanDataSet();
            this.transaksiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.transaksiTableAdapter1 = new AplikasiSembakoPABD.datapenjualanDataSetTableAdapters.TransaksiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transaksiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sembakoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datapenjualanDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transaksiBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idtransaksiDataGridViewTextBoxColumn,
            this.idbarangDataGridViewTextBoxColumn,
            this.idpembeliDataGridViewTextBoxColumn,
            this.idpenjualDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.transaksiBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 323);
            this.dataGridView1.TabIndex = 0;
            // 
            // idtransaksiDataGridViewTextBoxColumn
            // 
            this.idtransaksiDataGridViewTextBoxColumn.DataPropertyName = "id_transaksi";
            this.idtransaksiDataGridViewTextBoxColumn.HeaderText = "id_transaksi";
            this.idtransaksiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idtransaksiDataGridViewTextBoxColumn.Name = "idtransaksiDataGridViewTextBoxColumn";
            this.idtransaksiDataGridViewTextBoxColumn.Width = 125;
            // 
            // idbarangDataGridViewTextBoxColumn
            // 
            this.idbarangDataGridViewTextBoxColumn.DataPropertyName = "id_barang";
            this.idbarangDataGridViewTextBoxColumn.HeaderText = "id_barang";
            this.idbarangDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idbarangDataGridViewTextBoxColumn.Name = "idbarangDataGridViewTextBoxColumn";
            this.idbarangDataGridViewTextBoxColumn.Width = 125;
            // 
            // idpembeliDataGridViewTextBoxColumn
            // 
            this.idpembeliDataGridViewTextBoxColumn.DataPropertyName = "id_pembeli";
            this.idpembeliDataGridViewTextBoxColumn.HeaderText = "id_pembeli";
            this.idpembeliDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idpembeliDataGridViewTextBoxColumn.Name = "idpembeliDataGridViewTextBoxColumn";
            this.idpembeliDataGridViewTextBoxColumn.Width = 125;
            // 
            // idpenjualDataGridViewTextBoxColumn
            // 
            this.idpenjualDataGridViewTextBoxColumn.DataPropertyName = "id_penjual";
            this.idpenjualDataGridViewTextBoxColumn.HeaderText = "id_penjual";
            this.idpenjualDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idpenjualDataGridViewTextBoxColumn.Name = "idpenjualDataGridViewTextBoxColumn";
            this.idpenjualDataGridViewTextBoxColumn.Width = 125;
            // 
            // transaksiBindingSource
            // 
            this.transaksiBindingSource.DataMember = "transaksi";
            this.transaksiBindingSource.DataSource = this.sembakoDataSet;
            // 
            // sembakoDataSet
            // 
            this.sembakoDataSet.DataSetName = "sembakoDataSet";
            this.sembakoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // transaksiTableAdapter
            // 
            this.transaksiTableAdapter.ClearBeforeFill = true;
            // 
            // KembaliTransaksi
            // 
            this.KembaliTransaksi.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KembaliTransaksi.Location = new System.Drawing.Point(666, 367);
            this.KembaliTransaksi.Name = "KembaliTransaksi";
            this.KembaliTransaksi.Size = new System.Drawing.Size(75, 23);
            this.KembaliTransaksi.TabIndex = 1;
            this.KembaliTransaksi.Text = "Kembali";
            this.KembaliTransaksi.UseVisualStyleBackColor = true;
            this.KembaliTransaksi.Click += new System.EventHandler(this.KembaliTransaksi_Click);
            // 
            // pembeliTableAdapter
            // 
            this.pembeliTableAdapter.ClearBeforeFill = true;
            // 
            // datapenjualanDataSet
            // 
            this.datapenjualanDataSet.DataSetName = "datapenjualanDataSet";
            this.datapenjualanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // transaksiBindingSource1
            // 
            this.transaksiBindingSource1.DataMember = "Transaksi";
            this.transaksiBindingSource1.DataSource = this.datapenjualanDataSet;
            // 
            // transaksiTableAdapter1
            // 
            this.transaksiTableAdapter1.ClearBeforeFill = true;
            // 
            // Transaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.KembaliTransaksi);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Transaksi";
            this.Text = "Transaksi";
            this.Load += new System.EventHandler(this.Transaksi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transaksiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sembakoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datapenjualanDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transaksiBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private sembakoDataSet sembakoDataSet;
        private System.Windows.Forms.BindingSource transaksiBindingSource;
        private sembakoDataSetTableAdapters.transaksiTableAdapter transaksiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtransaksiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idbarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpembeliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpenjualDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button KembaliTransaksi;
        private sembakoDataSetTableAdapters.pembeliTableAdapter pembeliTableAdapter;
        private datapenjualanDataSet datapenjualanDataSet;
        private System.Windows.Forms.BindingSource transaksiBindingSource1;
        private datapenjualanDataSetTableAdapters.TransaksiTableAdapter transaksiTableAdapter1;
    }
}