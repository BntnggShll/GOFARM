namespace GoFarm
{
    partial class Pembiakan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pembiakan));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNamaSapi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtpTanggalkawin = new System.Windows.Forms.DateTimePicker();
            this.dtpPerkiraanLahir = new System.Windows.Forms.DateTimePicker();
            this.cmbIDSapi = new System.Windows.Forms.ComboBox();
            this.dtpTanggalHamil = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dgvPembiakan = new System.Windows.Forms.DataGridView();
            this.btnkembali = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbreeding = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPembiakan)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(670, 35);
            this.panel1.TabIndex = 34;
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
            // txtNamaSapi
            // 
            this.txtNamaSapi.Location = new System.Drawing.Point(264, 248);
            this.txtNamaSapi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNamaSapi.Name = "txtNamaSapi";
            this.txtNamaSapi.Size = new System.Drawing.Size(140, 20);
            this.txtNamaSapi.TabIndex = 62;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(262, 215);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 19);
            this.label3.TabIndex = 58;
            this.label3.Text = "Nama Sapi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(262, 128);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 19);
            this.label2.TabIndex = 57;
            this.label2.Text = "ID Sapi Betina";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(452, 215);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 19);
            this.label1.TabIndex = 56;
            this.label1.Text = "Perkiraan Lahir";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(452, 128);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 19);
            this.label5.TabIndex = 55;
            this.label5.Text = "Tanggal Kawin";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(190, 58);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(270, 38);
            this.label7.TabIndex = 54;
            this.label7.Text = "Pembiakan Sapi";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(455, 59);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 63;
            this.pictureBox1.TabStop = false;
            // 
            // dtpTanggalkawin
            // 
            this.dtpTanggalkawin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTanggalkawin.Location = new System.Drawing.Point(455, 161);
            this.dtpTanggalkawin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpTanggalkawin.Name = "dtpTanggalkawin";
            this.dtpTanggalkawin.Size = new System.Drawing.Size(156, 20);
            this.dtpTanggalkawin.TabIndex = 64;
            this.dtpTanggalkawin.Value = new System.DateTime(2023, 12, 25, 23, 59, 59, 0);
            // 
            // dtpPerkiraanLahir
            // 
            this.dtpPerkiraanLahir.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPerkiraanLahir.Location = new System.Drawing.Point(455, 247);
            this.dtpPerkiraanLahir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpPerkiraanLahir.Name = "dtpPerkiraanLahir";
            this.dtpPerkiraanLahir.Size = new System.Drawing.Size(156, 20);
            this.dtpPerkiraanLahir.TabIndex = 65;
            this.dtpPerkiraanLahir.Value = new System.DateTime(2023, 12, 25, 23, 59, 59, 0);
            // 
            // cmbIDSapi
            // 
            this.cmbIDSapi.FormattingEnabled = true;
            this.cmbIDSapi.Location = new System.Drawing.Point(264, 159);
            this.cmbIDSapi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbIDSapi.Name = "cmbIDSapi";
            this.cmbIDSapi.Size = new System.Drawing.Size(140, 21);
            this.cmbIDSapi.TabIndex = 66;
            this.cmbIDSapi.Text = "Pilih ID";
            this.cmbIDSapi.SelectedIndexChanged += new System.EventHandler(this.cmbIDSapi_SelectedIndexChanged);
            // 
            // dtpTanggalHamil
            // 
            this.dtpTanggalHamil.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTanggalHamil.Location = new System.Drawing.Point(53, 248);
            this.dtpTanggalHamil.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpTanggalHamil.Name = "dtpTanggalHamil";
            this.dtpTanggalHamil.Size = new System.Drawing.Size(156, 20);
            this.dtpTanggalHamil.TabIndex = 68;
            this.dtpTanggalHamil.Value = new System.DateTime(2023, 12, 25, 23, 59, 59, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 215);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 19);
            this.label4.TabIndex = 67;
            this.label4.Text = "Tanggal Hamil";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Azure;
            this.label11.Location = new System.Drawing.Point(256, 385);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(169, 19);
            this.label11.TabIndex = 101;
            this.label11.Text = "Laporan Pembiakan";
            // 
            // dgvPembiakan
            // 
            this.dgvPembiakan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPembiakan.Location = new System.Drawing.Point(52, 421);
            this.dgvPembiakan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvPembiakan.Name = "dgvPembiakan";
            this.dgvPembiakan.RowHeadersWidth = 51;
            this.dgvPembiakan.RowTemplate.Height = 24;
            this.dgvPembiakan.Size = new System.Drawing.Size(562, 220);
            this.dgvPembiakan.TabIndex = 100;
            this.dgvPembiakan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPembiakan_CellContentClick);
            // 
            // btnkembali
            // 
            this.btnkembali.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnkembali.FlatAppearance.BorderSize = 0;
            this.btnkembali.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnkembali.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnkembali.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnkembali.Location = new System.Drawing.Point(528, 332);
            this.btnkembali.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnkembali.Name = "btnkembali";
            this.btnkembali.Size = new System.Drawing.Size(87, 31);
            this.btnkembali.TabIndex = 99;
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
            this.btnClear.Location = new System.Drawing.Point(412, 332);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 31);
            this.btnClear.TabIndex = 98;
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
            this.btnDelete.Location = new System.Drawing.Point(301, 332);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 31);
            this.btnDelete.TabIndex = 97;
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
            this.btnEdit.Location = new System.Drawing.Point(184, 332);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(86, 31);
            this.btnEdit.TabIndex = 96;
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
            this.btnSave.Location = new System.Drawing.Point(52, 332);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(98, 31);
            this.btnSave.TabIndex = 95;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(50, 128);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 19);
            this.label6.TabIndex = 58;
            this.label6.Text = "ID Pembiakan";
            // 
            // txtbreeding
            // 
            this.txtbreeding.Location = new System.Drawing.Point(52, 161);
            this.txtbreeding.Margin = new System.Windows.Forms.Padding(2);
            this.txtbreeding.Name = "txtbreeding";
            this.txtbreeding.Size = new System.Drawing.Size(140, 20);
            this.txtbreeding.TabIndex = 62;
            // 
            // Pembiakan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(670, 640);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dgvPembiakan);
            this.Controls.Add(this.btnkembali);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dtpTanggalHamil);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbIDSapi);
            this.Controls.Add(this.dtpPerkiraanLahir);
            this.Controls.Add(this.dtpTanggalkawin);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtbreeding);
            this.Controls.Add(this.txtNamaSapi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Pembiakan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pembiakan";
            this.Load += new System.EventHandler(this.Pembiakan_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPembiakan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtNamaSapi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpTanggalkawin;
        private System.Windows.Forms.DateTimePicker dtpPerkiraanLahir;
        private System.Windows.Forms.ComboBox cmbIDSapi;
        private System.Windows.Forms.DateTimePicker dtpTanggalHamil;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgvPembiakan;
        private System.Windows.Forms.Button btnkembali;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtbreeding;
    }
}