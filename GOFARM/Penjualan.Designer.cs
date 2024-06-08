namespace GoFarm
{
    partial class Penjualan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Penjualan));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvPenjualan = new System.Windows.Forms.DataGridView();
            this.btnkembali = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.txtNamaPembeli = new System.Windows.Forms.TextBox();
            this.txtHarga = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNoTelp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpTanggalJual = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbKualitas = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTotalSusu = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPenjualan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(657, 35);
            this.panel1.TabIndex = 35;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(278, 0);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 26);
            this.label10.TabIndex = 33;
            this.label10.Text = "GO FARM";
            // 
            // dgvPenjualan
            // 
            this.dgvPenjualan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPenjualan.Location = new System.Drawing.Point(55, 408);
            this.dgvPenjualan.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPenjualan.Name = "dgvPenjualan";
            this.dgvPenjualan.RowHeadersWidth = 51;
            this.dgvPenjualan.RowTemplate.Height = 24;
            this.dgvPenjualan.Size = new System.Drawing.Size(562, 236);
            this.dgvPenjualan.TabIndex = 93;
            this.dgvPenjualan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPenjualan_CellContentClick);
            // 
            // btnkembali
            // 
            this.btnkembali.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnkembali.FlatAppearance.BorderSize = 0;
            this.btnkembali.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnkembali.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnkembali.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnkembali.Location = new System.Drawing.Point(530, 323);
            this.btnkembali.Margin = new System.Windows.Forms.Padding(2);
            this.btnkembali.Name = "btnkembali";
            this.btnkembali.Size = new System.Drawing.Size(87, 31);
            this.btnkembali.TabIndex = 92;
            this.btnkembali.Text = "Kembali";
            this.btnkembali.UseVisualStyleBackColor = false;
            this.btnkembali.Click += new System.EventHandler(this.btnkembali_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClear.Location = new System.Drawing.Point(414, 323);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 31);
            this.btnClear.TabIndex = 91;
            this.btnClear.Text = "Refersh";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDelete.Location = new System.Drawing.Point(303, 323);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 31);
            this.btnDelete.TabIndex = 90;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEdit.Location = new System.Drawing.Point(186, 323);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(86, 31);
            this.btnEdit.TabIndex = 89;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSave.Location = new System.Drawing.Point(55, 323);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(98, 31);
            this.btnSave.TabIndex = 88;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(192, 56);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(248, 38);
            this.label8.TabIndex = 86;
            this.label8.Text = "Penjualan Susu";
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(455, 238);
            this.txttotal.Margin = new System.Windows.Forms.Padding(2);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(114, 20);
            this.txttotal.TabIndex = 83;
            // 
            // txtNamaPembeli
            // 
            this.txtNamaPembeli.Location = new System.Drawing.Point(522, 160);
            this.txtNamaPembeli.Margin = new System.Windows.Forms.Padding(2);
            this.txtNamaPembeli.Name = "txtNamaPembeli";
            this.txtNamaPembeli.Size = new System.Drawing.Size(102, 20);
            this.txtNamaPembeli.TabIndex = 82;
            // 
            // txtHarga
            // 
            this.txtHarga.BackColor = System.Drawing.SystemColors.Window;
            this.txtHarga.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtHarga.Location = new System.Drawing.Point(207, 160);
            this.txtHarga.Margin = new System.Windows.Forms.Padding(2);
            this.txtHarga.Name = "txtHarga";
            this.txtHarga.Size = new System.Drawing.Size(94, 20);
            this.txtHarga.TabIndex = 81;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(451, 205);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 19);
            this.label3.TabIndex = 80;
            this.label3.Text = "Total Bayar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(519, 126);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 19);
            this.label5.TabIndex = 79;
            this.label5.Text = "Nama Pembeli";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(204, 126);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 19);
            this.label6.TabIndex = 78;
            this.label6.Text = "Harga";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtNoTelp
            // 
            this.txtNoTelp.Location = new System.Drawing.Point(94, 242);
            this.txtNoTelp.Margin = new System.Windows.Forms.Padding(2);
            this.txtNoTelp.Name = "txtNoTelp";
            this.txtNoTelp.Size = new System.Drawing.Size(128, 20);
            this.txtNoTelp.TabIndex = 76;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(284, 205);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 19);
            this.label2.TabIndex = 75;
            this.label2.Text = "Kualitas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 205);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 19);
            this.label1.TabIndex = 74;
            this.label1.Text = "No. Telp Pembeli";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(429, 56);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 87;
            this.pictureBox1.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Azure;
            this.label11.Location = new System.Drawing.Point(280, 377);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(157, 19);
            this.label11.TabIndex = 94;
            this.label11.Text = "Laporan Penjualan";
            // 
            // dtpTanggalJual
            // 
            this.dtpTanggalJual.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTanggalJual.Location = new System.Drawing.Point(28, 162);
            this.dtpTanggalJual.Margin = new System.Windows.Forms.Padding(2);
            this.dtpTanggalJual.Name = "dtpTanggalJual";
            this.dtpTanggalJual.Size = new System.Drawing.Size(110, 20);
            this.dtpTanggalJual.TabIndex = 72;
            this.dtpTanggalJual.Value = new System.DateTime(2023, 12, 25, 23, 59, 59, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 126);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 19);
            this.label4.TabIndex = 73;
            this.label4.Text = "Tanggal Jual";
            // 
            // cmbKualitas
            // 
            this.cmbKualitas.FormattingEnabled = true;
            this.cmbKualitas.Items.AddRange(new object[] {
            "20%",
            "40%",
            "60%",
            "80%"});
            this.cmbKualitas.Location = new System.Drawing.Point(288, 242);
            this.cmbKualitas.Margin = new System.Windows.Forms.Padding(2);
            this.cmbKualitas.Name = "cmbKualitas";
            this.cmbKualitas.Size = new System.Drawing.Size(105, 21);
            this.cmbKualitas.TabIndex = 95;
            this.cmbKualitas.Text = "Pilih Kualitas";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(354, 126);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 19);
            this.label7.TabIndex = 80;
            this.label7.Text = "Total Susu";
            // 
            // txtTotalSusu
            // 
            this.txtTotalSusu.Location = new System.Drawing.Point(357, 159);
            this.txtTotalSusu.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotalSusu.Name = "txtTotalSusu";
            this.txtTotalSusu.Size = new System.Drawing.Size(114, 20);
            this.txtTotalSusu.TabIndex = 83;
            // 
            // Penjualan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(657, 640);
            this.Controls.Add(this.cmbKualitas);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dgvPenjualan);
            this.Controls.Add(this.btnkembali);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTotalSusu);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.txtNamaPembeli);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtHarga);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNoTelp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpTanggalJual);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Penjualan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Penjualan";
            this.Load += new System.EventHandler(this.Penjualan_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPenjualan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvPenjualan;
        private System.Windows.Forms.Button btnkembali;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.TextBox txtNamaPembeli;
        private System.Windows.Forms.TextBox txtHarga;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNoTelp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpTanggalJual;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbKualitas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTotalSusu;
    }
}