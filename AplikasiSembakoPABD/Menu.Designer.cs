
namespace AplikasiSembakoPABD
{
    partial class Menu
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
            this.button1 = new System.Windows.Forms.Button();
            this.PembeliMenu = new System.Windows.Forms.Button();
            this.BarangMenu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TransaksiMenu = new System.Windows.Forms.Button();
            this.KembaliMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(141, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "PENJUAL";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PembeliMenu
            // 
            this.PembeliMenu.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PembeliMenu.Location = new System.Drawing.Point(452, 160);
            this.PembeliMenu.Name = "PembeliMenu";
            this.PembeliMenu.Size = new System.Drawing.Size(113, 23);
            this.PembeliMenu.TabIndex = 1;
            this.PembeliMenu.Text = "PEMBELI";
            this.PembeliMenu.UseVisualStyleBackColor = true;
            this.PembeliMenu.Click += new System.EventHandler(this.PembeliMenu_Click);
            // 
            // BarangMenu
            // 
            this.BarangMenu.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BarangMenu.Location = new System.Drawing.Point(290, 160);
            this.BarangMenu.Name = "BarangMenu";
            this.BarangMenu.Size = new System.Drawing.Size(108, 23);
            this.BarangMenu.TabIndex = 2;
            this.BarangMenu.Text = "BARANG";
            this.BarangMenu.UseVisualStyleBackColor = true;
            this.BarangMenu.Click += new System.EventHandler(this.BarangMenu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(312, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "APLIKASI SEMBAKO";
            // 
            // TransaksiMenu
            // 
            this.TransaksiMenu.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransaksiMenu.Location = new System.Drawing.Point(605, 160);
            this.TransaksiMenu.Name = "TransaksiMenu";
            this.TransaksiMenu.Size = new System.Drawing.Size(127, 23);
            this.TransaksiMenu.TabIndex = 4;
            this.TransaksiMenu.Text = "TRANSAKSI";
            this.TransaksiMenu.UseVisualStyleBackColor = true;
            this.TransaksiMenu.Click += new System.EventHandler(this.TransaksiMenu_Click);
            // 
            // KembaliMenu
            // 
            this.KembaliMenu.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KembaliMenu.Location = new System.Drawing.Point(375, 262);
            this.KembaliMenu.Name = "KembaliMenu";
            this.KembaliMenu.Size = new System.Drawing.Size(75, 23);
            this.KembaliMenu.TabIndex = 5;
            this.KembaliMenu.Text = "Kembali";
            this.KembaliMenu.UseVisualStyleBackColor = true;
            this.KembaliMenu.Click += new System.EventHandler(this.KembaliMenu_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.KembaliMenu);
            this.Controls.Add(this.TransaksiMenu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BarangMenu);
            this.Controls.Add(this.PembeliMenu);
            this.Controls.Add(this.button1);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button PembeliMenu;
        private System.Windows.Forms.Button BarangMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button TransaksiMenu;
        private System.Windows.Forms.Button KembaliMenu;
    }
}