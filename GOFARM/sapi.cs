using GoFarm.DAL;
using GoFarm.Models;
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
    public partial class Sapi : Form
    {
        string connectionString;
        MySqlConnection connect;

        public Sapi()
        {
            InitializeComponent();
            connectionString = "server=localhost;port=3306;database=db_farm;user=root;pwd='';";
            connect = new MySqlConnection(connectionString);
        }

        public void loadData(string valueToLoad)
        {
            try
            {
                string query = "SELECT * FROM sapi WHERE CONCAT(id_sapi, nama_sapi, warna, keturunan, berat_lahir, kandang, umur) LIKE '%" + valueToLoad + "%'";
                MySqlConnection con = new MySqlConnection(connectionString);
                MySqlCommand commandToDatabase = new MySqlCommand(query, con);
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(commandToDatabase);
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);

                // Konversi nilai kolom tanggal_lahir ke tipe data DateTime
                foreach (DataRow row in dt.Rows)
                {
                    row["tanggal_lahir"] = Convert.ToDateTime(row["tanggal_lahir"]);
                }

                dgvSapi.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnkembali_Click(object sender, EventArgs e)
        {
            Main mForm = new Main();
            mForm.Show();
            Hide();
        }

        private void Sapi_Load(object sender, EventArgs e)
        {
            loadData("");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string Query = "INSERT INTO sapi (id_sapi, nama_sapi, tanggal_lahir, warna, keturunan, berat_lahir, kandang, umur) " +
                               "VALUES (@id_sapi, @nama_sapi, @tanggal_lahir, @warna, @keturunan, @berat_lahir, @kandang, @umur)";

                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();

                    using (MySqlCommand CommandToDataBase = new MySqlCommand(Query, con))
                    {
                        CommandToDataBase.Parameters.AddWithValue("@id_sapi", txtIDSapi.Text);
                        CommandToDataBase.Parameters.AddWithValue("@nama_sapi", txtNamaSapi.Text);
                        CommandToDataBase.Parameters.AddWithValue("@tanggal_lahir", dtpTanggalLahir.Value.ToString("yyyy-MM-dd"));
                        CommandToDataBase.Parameters.AddWithValue("@warna", txtWarna.Text);
                        CommandToDataBase.Parameters.AddWithValue("@keturunan", txtKeturunan.Text);
                        CommandToDataBase.Parameters.AddWithValue("@berat_lahir", decimal.Parse(txtBeratlahir.Text));
                        CommandToDataBase.Parameters.AddWithValue("@kandang", txtKandang.Text);

                        int umur = DateTime.Now.Year - dtpTanggalLahir.Value.Year;
                        CommandToDataBase.Parameters.AddWithValue("@umur", umur);

                        CommandToDataBase.ExecuteNonQuery();
                    }

                    MessageBox.Show("Data saved successfully!");

                    // Clear the textboxes after saving
                    txtIDSapi.Text = "";
                    txtNamaSapi.Text = "";
                    txtWarna.Text = "";
                    txtKeturunan.Text = "";
                    dtpTanggalLahir.Value = DateTime.Now; // Reset DateTimePicker to current date
                    txtUmur.Text = "";
                    txtBeratlahir.Text = "";
                    txtKandang.Text = "";

                    // Reload data setelah penyimpanan selesai
                    loadData("");
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
                if (!string.IsNullOrEmpty(txtIDSapi.Text))
                {
                    string Query = "UPDATE sapi SET " +
                                   "nama_sapi = '" + txtNamaSapi.Text.ToString() + "', " +
                                   "tanggal_lahir = '" + dtpTanggalLahir.Value.ToString("yyyy-MM-dd") + "', " +
                                   "warna = '" + txtWarna.Text.ToString() + "', " +
                                   "keturunan = '" + txtKeturunan.Text.ToString() + "', " +
                                   "berat_lahir = '" + decimal.Parse(txtBeratlahir.Text) + "', " +
                                   "kandang = '" + txtKandang.Text.ToString() + "', " +
                                   "umur = '" + int.Parse(txtUmur.Text) + "' " +
                                   "WHERE id_sapi = '" + txtIDSapi.Text + "'";

                    using (MySqlConnection con = new MySqlConnection(connectionString))
                    {
                        con.Open();

                        using (MySqlCommand CommandToDataBase = new MySqlCommand(Query, con))
                        {
                            int rowsAffected = CommandToDataBase.ExecuteNonQuery();

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

                    // Clear the textboxes after saving
                    txtIDSapi.Text = "";
                    txtNamaSapi.Text = "";
                    txtWarna.Text = "";
                    txtKeturunan.Text = "";
                    dtpTanggalLahir.Value = DateTime.Now; // Reset DateTimePicker to current date
                    txtUmur.Text = "";
                    txtBeratlahir.Text = "";
                    txtKandang.Text = "";

                    // Reload data setelah penyimpanan selesai
                    loadData("");
                }
                else
                {
                    MessageBox.Show("Please select a record to update.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtIDSapi.Text))
                {
                    string Query = "DELETE FROM sapi WHERE id_sapi = '" + txtIDSapi.Text + "'";

                    using (MySqlConnection con = new MySqlConnection(connectionString))
                    {
                        con.Open();

                        using (MySqlCommand CommandToDataBase = new MySqlCommand(Query, con))
                        {
                            int rowsAffected = CommandToDataBase.ExecuteNonQuery();

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

                    // Clear the form fields after deletion
                    txtIDSapi.Enabled = true;
                    txtIDSapi.Text = "";
                    txtNamaSapi.Text = "";
                    txtWarna.Text = "";
                    txtKeturunan.Text = "";
                    dtpTanggalLahir.Text = "";
                    txtUmur.Text = "";
                    txtBeratlahir.Text = "";
                    txtKandang.Text = "";
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtIDSapi.Enabled = true;

            string valueToLoad = txtIDSapi.Text;
            loadData(valueToLoad);

            txtIDSapi.Text = "";
            txtNamaSapi.Text = "";
            txtWarna.Text = "";
            txtKeturunan.Text = "";
            dtpTanggalLahir.Text = "";
            txtUmur.Text = "";
            txtBeratlahir.Text = "";
            txtKandang.Text = "";
        }

        private void dgvSapi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIDSapi.Enabled = false;

            dgvSapi.CurrentRow.Selected = true;
            txtIDSapi.Text = dgvSapi.Rows[e.RowIndex].Cells["id_sapi"].FormattedValue.ToString();
            txtNamaSapi.Text = dgvSapi.Rows[e.RowIndex].Cells["nama_sapi"].FormattedValue.ToString();
            dtpTanggalLahir.Text = dgvSapi.Rows[e.RowIndex].Cells["tanggal_lahir"].FormattedValue.ToString();
            txtBeratlahir.Text = dgvSapi.Rows[e.RowIndex].Cells["berat_lahir"].FormattedValue.ToString();
            txtUmur.Text = dgvSapi.Rows[e.RowIndex].Cells["umur"].FormattedValue.ToString();
            txtWarna.Text = dgvSapi.Rows[e.RowIndex].Cells["warna"].FormattedValue.ToString();
            txtKeturunan.Text = dgvSapi.Rows[e.RowIndex].Cells["keturunan"].FormattedValue.ToString();
            txtKandang.Text = dgvSapi.Rows[e.RowIndex].Cells["kandang"].FormattedValue.ToString();
        }

        private void dtpTanggalLahir_ValueChanged(object sender, EventArgs e)
        {
            txtUmur.Enabled = false;
        }
    }
}