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
    public partial class Kesehatan : Form
    {
        string connectionString;
        MySqlConnection connect;
        public Kesehatan()
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
                string query = "SELECT * FROM sapi_hp WHERE CONCAT(id_sapi, keluhan, Diagnosis, penanganan, biaya_perawatan, doc_namaewa) LIKE '%" + valueToLoad + "%'";
                MySqlConnection con = new MySqlConnection(connectionString);
                MySqlCommand commandToDatabase = new MySqlCommand(query, con);
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(commandToDatabase);
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);
                txtNamaSapi.Enabled = false;
                txtidkesehatan.Enabled = false;

                dgvKesehatan.DataSource = dt;
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
                string query = "SELECT id_sapi FROM sapi";
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
                        txtidkesehatan.Enabled = false;
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
                string query = "INSERT INTO sapi_hp (id_sapi, keluhan, Diagnosis, penanganan, biaya_perawatan, doc_namaewa) " +
                               "VALUES (@id_sapi, @keluhan, @Diagnosis, @penanganan, @biaya_perawatan, @doc_namaewa)";

                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();

                    using (MySqlCommand commandToDatabase = new MySqlCommand(query, con))
                    {
                        // Set parameter values
                        commandToDatabase.Parameters.AddWithValue("@id_sapi", cmbIDSapi.SelectedValue.ToString());
                        commandToDatabase.Parameters.AddWithValue("@keluhan", txtKeluhan.Text);
                        commandToDatabase.Parameters.AddWithValue("@Diagnosis", txtDiagnosis.Text);
                        commandToDatabase.Parameters.AddWithValue("@penanganan", txtTreatment.Text);
                        commandToDatabase.Parameters.AddWithValue("@biaya_perawatan", txtBiayaT.Text);
                        commandToDatabase.Parameters.AddWithValue("@doc_namaewa", txtDokter.Text);

                        commandToDatabase.ExecuteNonQuery();
                    }

                    MessageBox.Show("Data saved successfully!");
                }

                // Enable the cmbIDSapi ComboBox
                cmbIDSapi.Enabled = true;

                // Clear the ComboBox and other controls
                cmbIDSapi.SelectedIndex = -1;
                txtNamaSapi.Text = "";
                txtKeluhan.Text = "";
                txtDiagnosis.Text = "";
                txtTreatment.Text = "";
                txtBiayaT.Text = "";
                txtDokter.Text = "";
                txtidkesehatan.Text = "";
                // ... continue for other controls

                // Assuming you have a loadData method to reload data
                string valueToLoad = cmbIDSapi.Text;
                loadData(valueToLoad);
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
                if (cmbIDSapi.SelectedIndex != -1)
                {
                    string query = "UPDATE sapi_hp SET " +
                                   "keluhan = @keluhan, " +
                                   "Diagnosis = @Diagnosis, " +
                                   "penanganan = @penanganan, " +
                                   "biaya_perawatan = @biaya_perawatan, " +
                                   "doc_namaewa = @doc_namaewa " +
                                   "WHERE id_kesehatan = @id_kesehatan";

                    using (MySqlConnection con = new MySqlConnection(connectionString))
                    {
                        con.Open();

                        using (MySqlCommand commandToDatabase = new MySqlCommand(query, con))
                        {

                            // Set parameter values
                            commandToDatabase.Parameters.AddWithValue("@id_kesehatan", txtidkesehatan.Text);
                            commandToDatabase.Parameters.AddWithValue("@keluhan", txtKeluhan.Text);
                            commandToDatabase.Parameters.AddWithValue("@Diagnosis", txtDiagnosis.Text);
                            commandToDatabase.Parameters.AddWithValue("@penanganan", txtTreatment.Text);
                            commandToDatabase.Parameters.AddWithValue("@biaya_perawatan", txtBiayaT.Text);
                            commandToDatabase.Parameters.AddWithValue("@doc_namaewa", txtDokter.Text);
                            commandToDatabase.Parameters.AddWithValue("@id_sapi", cmbIDSapi.SelectedValue.ToString());

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

                    // Enable the cmbIDSapi ComboBox
                    cmbIDSapi.Enabled = true;

                    // Clear the ComboBox and other controls
                    cmbIDSapi.SelectedIndex = -1;
                    txtNamaSapi.Text = "";
                    txtKeluhan.Text = "";
                    txtDiagnosis.Text = "";
                    txtTreatment.Text = "";
                    txtBiayaT.Text = "";
                    txtDokter.Text = "";
                    txtidkesehatan.Text = "";
                    // ... continue for other controls

                    // Assuming you have a loadData method to reload data
                    string valueToLoad = cmbIDSapi.Text;
                    loadData(valueToLoad);
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
                if (cmbIDSapi.SelectedIndex != -1)
                {
                    string query = "DELETE FROM sapi_hp WHERE id_kesehatan = @id_kesehatan";

                    using (MySqlConnection con = new MySqlConnection(connectionString))
                    {
                        con.Open();

                        using (MySqlCommand commandToDatabase = new MySqlCommand(query, con))
                        {
                            // Set parameter value
                            commandToDatabase.Parameters.AddWithValue("@id_kesehatan", txtidkesehatan.Text);

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

                    // Enable the cmbIDSapi ComboBox
                    cmbIDSapi.Enabled = true;

                    // Clear the ComboBox and other controls
                    cmbIDSapi.SelectedIndex = -1;
                    txtNamaSapi.Text = "";
                    txtKeluhan.Text = "";
                    txtDiagnosis.Text = "";
                    txtTreatment.Text = "";
                    txtBiayaT.Text = "";
                    txtDokter.Text = "";
                    txtidkesehatan.Text = "";
                    // ... continue for other controls

                    // Assuming you have a loadData method to reload data
                    string valueToLoad = cmbIDSapi.Text;
                    loadData(valueToLoad);
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
            // Enable the cmbIDSapi ComboBox
            cmbIDSapi.Enabled = true;

            // Clear the ComboBox and other controls
            cmbIDSapi.SelectedIndex = -1;
            txtNamaSapi.Text = "";
            txtidkesehatan.Text = "";
            txtKeluhan.Text = "";
            txtDiagnosis.Text = "";
            txtTreatment.Text = "";
            txtBiayaT.Text = "";
            txtDokter.Text = "";
            txtidkesehatan.Text = "";
            // ... continue for other controls

            // Assuming you have a loadData method to reload data
            string valueToLoad = cmbIDSapi.Text;
            loadData(valueToLoad);
        }

        private void dgvKesehatan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cmbIDSapi.Enabled = false;
            txtNamaSapi.Enabled = false;
            txtidkesehatan.Enabled = false;

            dgvKesehatan.CurrentRow.Selected = true;
            cmbIDSapi.Text = dgvKesehatan.Rows[e.RowIndex].Cells["id_sapi"].FormattedValue.ToString();
            txtidkesehatan.Text = dgvKesehatan.Rows[e.RowIndex].Cells["id_kesehatan"].FormattedValue.ToString();
            txtKeluhan.Text = dgvKesehatan.Rows[e.RowIndex].Cells["keluhan"].FormattedValue.ToString();
            txtDiagnosis.Text = dgvKesehatan.Rows[e.RowIndex].Cells["Diagnosis"].FormattedValue.ToString();
            txtTreatment.Text = dgvKesehatan.Rows[e.RowIndex].Cells["penanganan"].FormattedValue.ToString();
            txtBiayaT.Text = dgvKesehatan.Rows[e.RowIndex].Cells["biaya_perawatan"].FormattedValue.ToString();
            txtDokter.Text = dgvKesehatan.Rows[e.RowIndex].Cells["doc_namaewa"].FormattedValue.ToString();
        }

        private void Kesehatan_Load(object sender, EventArgs e)
        {
            loadData("");

            FillComboBoxIDSapi();

            // Load data sesuai dengan id_sapi yang dipilih
            string selectedValue = cmbIDSapi.SelectedValue.ToString();
            loadData(selectedValue);
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
