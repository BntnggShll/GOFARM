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
    public partial class Pembiakan : Form
    {
        string connectionString;
        MySqlConnection connect;
        public Pembiakan()
        {
            InitializeComponent();
            connectionString = "server=localhost;port=3306;database=db_farm;user=root;pwd='';";
            connect = new MySqlConnection(connectionString);
        }

        private void btnkembali_Click(object sender, EventArgs e)
        {
            Main mForm = new Main();
            mForm.Show();
            Hide();
        }

        public void loadData(string valueToLoad)
        {
            try
            {
                string query = "SELECT * FROM breeding WHERE CONCAT(id_sapi, tanggal_kawin, tanggal_hamil, tanggal_perkiraan) LIKE '%" + valueToLoad + "%'";
                MySqlConnection con = new MySqlConnection(connectionString);
                MySqlCommand commandToDatabase = new MySqlCommand(query, con);
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(commandToDatabase);
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);

                // Konversi nilai kolom tanggal_kawin, tanggal_hamil, tanggal_perkiraan, dan tanggal_lahir ke tipe data DateTime
                foreach (DataRow row in dt.Rows)
                {
                    row["tanggal_kawin"] = Convert.ToDateTime(row["tanggal_kawin"]);
                    row["tanggal_hamil"] = Convert.ToDateTime(row["tanggal_hamil"]);
                    row["tanggal_perkiraan"] = Convert.ToDateTime(row["tanggal_perkiraan"]);
                }

                dgvPembiakan.DataSource = dt;
                txtbreeding.Enabled = false;
                txtNamaSapi.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void FillComboBoxIDSapi()
        {
            try
            {
                string query = "SELECT id_sapi, nama_sapi FROM sapi";
                MySqlCommand commandToDatabase = new MySqlCommand(query, connect);
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(commandToDatabase);
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);

                // Set ComboBox DataSource dan ValueMember, DisplayMember
                cmbIDSapi.DataSource = dt;
                cmbIDSapi.ValueMember = "id_sapi";
                cmbIDSapi.DisplayMember = "id_sapi";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void FillNamaSapiTextBox(string idSapi)
        {
            try
            {
                using (MySqlConnection connect = new MySqlConnection(connectionString))
                {
                    string query = "SELECT nama_sapi FROM sapi WHERE id_sapi = @idSapi";
                    MySqlCommand commandToDatabase = new MySqlCommand(query, connect);
                    commandToDatabase.Parameters.AddWithValue("@idSapi", idSapi);
                    connect.Open();

                    // Gunakan ExecuteScalar dengan cek null
                    object result = commandToDatabase.ExecuteScalar();
                    if (result != null)
                    {
                        string namaSapi = result.ToString();
                        // Set nilai txtNamaSapi dengan nama sapi yang didapatkan
                        txtNamaSapi.Text = namaSapi;
                        txtNamaSapi.Enabled = false;
                        txtbreeding.Enabled = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Pembiakan_Load(object sender, EventArgs e)
        {
            loadData("");

            FillComboBoxIDSapi();

       
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();

                    string query = "INSERT INTO breeding (id_sapi, tanggal_kawin, tanggal_hamil, tanggal_perkiraan) " +
                        "VALUES (@id_sapi, @tanggal_kawin, @tanggal_hamil, @tanggal_perkiraan)";

                    using (MySqlCommand CommandToDataBase = new MySqlCommand(query, con))
                    {
                        CommandToDataBase.Parameters.AddWithValue("@id_sapi", cmbIDSapi.Text);
                        CommandToDataBase.Parameters.AddWithValue("@tanggal_kawin", dtpTanggalkawin.Value.ToString("yyyy-MM-dd HH:mm:ss"));
                        CommandToDataBase.Parameters.AddWithValue("@tanggal_hamil", dtpTanggalHamil.Value.ToString("yyyy-MM-dd HH:mm:ss"));
                        CommandToDataBase.Parameters.AddWithValue("@tanggal_perkiraan", dtpPerkiraanLahir.Value.ToString("yyyy-MM-dd HH:mm:ss"));

                        CommandToDataBase.ExecuteNonQuery();
                    }

                    MessageBox.Show("Data saved successfully!");

                    // Clear the form fields after saving
                    cmbIDSapi.SelectedIndex = -1;
                    txtbreeding.Text = "";
                    txtNamaSapi.Text = "";
                    dtpTanggalkawin.Value = DateTime.Now; // Set default value or leave it as is
                    dtpTanggalHamil.Value = DateTime.Now; // Set default value or leave it as is
                    dtpPerkiraanLahir.Value = DateTime.Now; // Set default value or leave it as is

                    // Assuming you have a loadData method to reload data
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
                if (!string.IsNullOrEmpty(cmbIDSapi.Text))
                {
                    using (MySqlConnection con = new MySqlConnection(connectionString))
                    {
                        con.Open();

                        string query = "UPDATE breeding SET " +
                                       "tanggal_kawin = @tanggal_kawin, " +
                                       "tanggal_hamil = @tanggal_hamil, " +
                                       "tanggal_perkiraan = @tanggal_perkiraan " +
                                       "WHERE id_breeding = @id_breeding";

                        using (MySqlCommand CommandToDataBase = new MySqlCommand(query, con))
                        {
                            CommandToDataBase.Parameters.AddWithValue("@id_sapi", cmbIDSapi.Text);
                            CommandToDataBase.Parameters.AddWithValue("@id_breeding", txtbreeding.Text);
                            CommandToDataBase.Parameters.AddWithValue("@tanggal_kawin", dtpTanggalkawin.Value.ToString("yyyy-MM-dd HH:mm:ss"));
                            CommandToDataBase.Parameters.AddWithValue("@tanggal_hamil", dtpTanggalHamil.Value.ToString("yyyy-MM-dd HH:mm:ss"));
                            CommandToDataBase.Parameters.AddWithValue("@tanggal_perkiraan", dtpPerkiraanLahir.Value.ToString("yyyy-MM-dd HH:mm:ss"));

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

                    // Clear the form fields after update
                    cmbIDSapi.SelectedIndex = -1;
                    txtNamaSapi.Text = "";
                    txtbreeding.Text = "";
                    dtpTanggalkawin.Value = DateTime.Now; // Set default value or leave it as is
                    dtpTanggalHamil.Value = DateTime.Now; // Set default value or leave it as is
                    dtpPerkiraanLahir.Value = DateTime.Now; // Set default value or leave it as is

                    // Assuming you have a loadData method to reload data
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
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();

                    string query = "DELETE FROM breeding WHERE id_breeding = @id_breeding";

                    using (MySqlCommand CommandToDataBase = new MySqlCommand(query, con))
                    {
                        CommandToDataBase.Parameters.AddWithValue("@id_breeding", txtbreeding.Text);

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
                cmbIDSapi.SelectedIndex = -1;
                txtNamaSapi.Text = "";
                txtbreeding.Text = "";
                dtpTanggalkawin.Value = DateTime.Now; // Set default value or leave it as is
                dtpTanggalHamil.Value = DateTime.Now; // Set default value or leave it as is
                dtpPerkiraanLahir.Value = DateTime.Now; // Set default value or leave it as is

                // Assuming you have a loadData method to reload data
                loadData("");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Enable the cmbIDSapi ComboBox
            cmbIDSapi.Enabled = true;

            // Clear the ComboBox and other controls
            cmbIDSapi.SelectedIndex = -1;
            txtNamaSapi.Text = "";
            txtbreeding.Text = "";
            dtpTanggalkawin.Value = DateTime.Now; // Set default value or leave it as is
            dtpTanggalHamil.Value = DateTime.Now; // Set default value or leave it as is
            dtpPerkiraanLahir.Value = DateTime.Now; // Set default value or leave it as is

            // Assuming you have a loadData method to reload data
            string valueToLoad = cmbIDSapi.Text;
            loadData(valueToLoad);

        }

        private void dgvPembiakan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cmbIDSapi.Enabled = false;
            txtNamaSapi.Enabled = false;
            txtbreeding.Enabled = false;

            dgvPembiakan.CurrentRow.Selected = true;
            cmbIDSapi.SelectedValue = dgvPembiakan.Rows[e.RowIndex].Cells["id_sapi"].Value;
            txtbreeding.Text = dgvPembiakan.Rows[e.RowIndex].Cells["id_breeding"].FormattedValue.ToString();
            dtpTanggalkawin.Value = Convert.ToDateTime(dgvPembiakan.Rows[e.RowIndex].Cells["tanggal_kawin"].Value);
            dtpTanggalHamil.Value = Convert.ToDateTime(dgvPembiakan.Rows[e.RowIndex].Cells["tanggal_hamil"].Value);
            dtpPerkiraanLahir.Value = Convert.ToDateTime(dgvPembiakan.Rows[e.RowIndex].Cells["tanggal_perkiraan"].Value);

        }

        private void cmbIDSapi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbIDSapi.SelectedItem != null)
            {
                // Mendapatkan id_sapi yang dipilih dari ComboBox
                string selectedIdSapi = cmbIDSapi.SelectedValue.ToString();

                // Mengisi textbox txtNamaSapi dengan nama_sapi sesuai dengan id_sapi yang dipilih
                FillNamaSapiTextBox(selectedIdSapi);

                // Load data sesuai dengan id_sapi yang dipilih
                loadData(selectedIdSapi);
            }
        }
    }
}
