using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoFarm
{
    public partial class Penjualan : Form
    {
        string connectionString;
        MySqlConnection connect;
        public Penjualan()
        {
            InitializeComponent();
            connectionString = "server=localhost;port=3306;database=db_farm;user=root;pwd='';";
            connect = new MySqlConnection(connectionString);
        }

        public void loadData(string valueToLoad)
        {
            try
            {
                string query = "SELECT * FROM milk_sell WHERE CONCAT(id_penjualan, tanggal_jual, harga, no_pembeli, kualitas, nama_pembeli, total_susu,total) LIKE '%" + valueToLoad + "%'";
                MySqlConnection con = new MySqlConnection(connectionString);
                MySqlCommand commandToDatabase = new MySqlCommand(query, con);
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(commandToDatabase);
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);
                // Konversi nilai kolom tanggal_jual ke tipe data DateTime
                foreach (DataRow row in dt.Rows)
                {
                    row["tanggal_jual"] = Convert.ToDateTime(row["tanggal_jual"]);
                }
                txttotal.Enabled = false;
                dgvPenjualan.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnkembali_Click(object sender, EventArgs e)
        {
            Main mForm = new Main();
            mForm.Show();
            Hide();
        }

        private void dgvPenjualan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Select the current row in the dgvMilkSell
            dgvPenjualan.CurrentRow.Selected = true;

            // Populate controls with data from the selected row
            dtpTanggalJual.Value = Convert.ToDateTime(dgvPenjualan.Rows[e.RowIndex].Cells["tanggal_jual"].FormattedValue);
            txtHarga.Text = dgvPenjualan.Rows[e.RowIndex].Cells["harga"].FormattedValue.ToString();
            txtNamaPembeli.Text = dgvPenjualan.Rows[e.RowIndex].Cells["nama_pembeli"].FormattedValue.ToString();
            txtNoTelp.Text = dgvPenjualan.Rows[e.RowIndex].Cells["no_pembeli"].FormattedValue.ToString();
            cmbKualitas.Text = dgvPenjualan.Rows[e.RowIndex].Cells["kualitas"].FormattedValue.ToString();
            txtTotalSusu.Text = dgvPenjualan.Rows[e.RowIndex].Cells["total_susu"].FormattedValue.ToString();
            txttotal.Text = dgvPenjualan.Rows[e.RowIndex].Cells["total"].FormattedValue.ToString();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

     
                string valueToLoad = txtHarga.Text;
                loadData(valueToLoad);

                txtHarga.Text = "";
                txtNamaPembeli.Text = "";
                txtNoTelp.Text = "";
                cmbKualitas.SelectedIndex = -1;
                txtTotalSusu.Text = "";
                txttotal.Text = "";

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPenjualan.CurrentRow != null)
                {
                    DataGridViewRow selectedRow = dgvPenjualan.CurrentRow;

                    // Ambil nilai id dari kolom "id" (gantilah "id" sesuai dengan nama kolom sebenarnya)
                    int idToDelete = int.Parse(selectedRow.Cells["id_penjualan"].Value.ToString());

                    // Ubah query untuk menghapus berdasarkan id
                    string query = "DELETE FROM milk_sell WHERE id_penjualan = @id_penjualan";

                    using (MySqlConnection con = new MySqlConnection(connectionString))
                    {
                        con.Open();

                        using (MySqlCommand commandToDatabase = new MySqlCommand(query, con))
                        {
                            // Gunakan parameter untuk menghindari SQL injection dan memberikan nilai pada id
                            commandToDatabase.Parameters.AddWithValue("@id_penjualan", idToDelete);

                            int rowsAffected = commandToDatabase.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Delete successful!");
                            }
                            else
                            {
                                MessageBox.Show("No matching record found for deletion.");
                            }
                        }
                    }

                    string valueToLoad = txtHarga.Text;
                    loadData(valueToLoad);

                    txtHarga.Text = "";
                    txtNamaPembeli.Text = "";
                    txtNoTelp.Text = "";
                    cmbKualitas.SelectedIndex = -1;
                    txtTotalSusu.Text = "";
                    txttotal.Text = "";
                }
                else
                {
                    MessageBox.Show("Please select a record to delete.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }


        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtNamaPembeli.Text))
                {
                    if (dgvPenjualan.CurrentRow != null)
                    {
                        DataGridViewRow selectedRow = dgvPenjualan.CurrentRow;

                        // Ambil nilai id dari kolom "id" (gantilah "id" sesuai dengan nama kolom sebenarnya)
                        int idToUpdate = int.Parse(selectedRow.Cells["id_penjualan"].Value.ToString());

                        string query = "UPDATE milk_sell SET " +
                                       "tanggal_jual = @tanggal_jual, " +
                                       "harga = @harga, " +
                                       "no_pembeli = @no_pembeli, " +
                                       "kualitas = @kualitas, " +
                                       "nama_pembeli = @nama_pembeli, " +
                                       "total_susu = @total_susu " +
                                       "total = @total " +
                                       "WHERE id_penjualan = @id_penjualan";

                        using (MySqlConnection con = new MySqlConnection(connectionString))
                        {
                            con.Open();

                            using (MySqlCommand commandToDatabase = new MySqlCommand(query, con))
                            {
                                // Gunakan parameter untuk menghindari SQL injection dan memberikan nilai pada kolom
                                commandToDatabase.Parameters.AddWithValue("@tanggal_jual", dtpTanggalJual.Value.ToString("yyyy-MM-dd HH:mm:ss"));
                                commandToDatabase.Parameters.AddWithValue("@harga", long.Parse(txtHarga.Text));
                                commandToDatabase.Parameters.AddWithValue("@no_pembeli", int.Parse(txtNoTelp.Text));
                                commandToDatabase.Parameters.AddWithValue("@kualitas", cmbKualitas.Text);
                                commandToDatabase.Parameters.AddWithValue("@nama_pembeli", txtNamaPembeli.Text);
                                commandToDatabase.Parameters.AddWithValue("@total_susu", int.Parse(txtTotalSusu.Text));
                                commandToDatabase.Parameters.AddWithValue("@total", int.Parse(txttotal.Text));
                                commandToDatabase.Parameters.AddWithValue("@id_penjualan", idToUpdate);

                                int rowsAffected = commandToDatabase.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Update successful!");
                                }
                                else
                                {
                                    MessageBox.Show("No matching record found for update.");
                                }
                            }
                        }


                        string valueToLoad = txtHarga.Text;
                        loadData(valueToLoad);

                        txtHarga.Text = "";
                        txtNamaPembeli.Text = "";
                        txtNoTelp.Text = "";
                        cmbKualitas.SelectedIndex = -1;
                        txtTotalSusu.Text = "";
                        txttotal.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Please select a record to update.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }



        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                int totalsusu = int.Parse(txtTotalSusu.Text);
                int harga = int.Parse(txtHarga.Text);
                int total = totalsusu * harga;

                    string query = "INSERT INTO milk_sell (tanggal_jual, harga, no_pembeli, kualitas, nama_pembeli, total_susu,total) " +
                               "VALUES (@tanggal_jual, @harga, @no_pembeli, @kualitas, @nama_pembeli, @total_susu,@total)";

                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();

                    using (MySqlCommand commandToDatabase = new MySqlCommand(query, con))
                    {
                        // Tidak perlu menyertakan nilai untuk kolom id karena itu auto-increment
                        commandToDatabase.Parameters.AddWithValue("@tanggal_jual", dtpTanggalJual.Value.ToString("yyyy-MM-dd HH:mm:ss"));
                        commandToDatabase.Parameters.AddWithValue("@harga", long.Parse(txtHarga.Text));
                        commandToDatabase.Parameters.AddWithValue("@no_pembeli", int.Parse(txtNoTelp.Text));
                        commandToDatabase.Parameters.AddWithValue("@kualitas", cmbKualitas.Text);
                        commandToDatabase.Parameters.AddWithValue("@nama_pembeli", txtNamaPembeli.Text);
                        commandToDatabase.Parameters.AddWithValue("@total_susu", int.Parse(txtTotalSusu.Text));
                        commandToDatabase.Parameters.AddWithValue("@total", total);

                        commandToDatabase.ExecuteNonQuery();
                    }

                    MessageBox.Show("Data saved successfully!");
                }

                string valueToLoad = txtHarga.Text;
                loadData(valueToLoad);

                txtHarga.Text = "";
                txtNamaPembeli.Text = "";
                txtNoTelp.Text = "";
                cmbKualitas.SelectedIndex = -1;
                txttotal.Text = "";
                txtTotalSusu.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void Penjualan_Load(object sender, EventArgs e)
        {
            loadData("");
        }
    }
}
