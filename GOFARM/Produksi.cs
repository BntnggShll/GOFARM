using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoFarm
{
    public partial class Produksi : Form
    {
        string connectionString;
        MySqlConnection connect;
        public Produksi()
        {
            InitializeComponent();
            connectionString = "server=localhost;port=3306;database=db_farm;user=root;pwd='';";
            connect = new MySqlConnection(connectionString);
        }

        public void loadData(string valueToLoad)
        {
            try
            {
                string query = "SELECT * FROM money_milking WHERE CONCAT(id_sapi, milking_pagi, milking_sore, milking_malam, total_milking   ) LIKE '%" + valueToLoad + "%'";
                MySqlConnection con = new MySqlConnection(connectionString);
                MySqlCommand commandToDatabase = new MySqlCommand(query, con);
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(commandToDatabase);
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);
                txtNamaSapi.Enabled= false;
                txtidproduksi.Enabled= false;
                txtTotal.Enabled= false;

                // Konversi nilai kolom tanggal_lahir ke tipe data DateTime
                foreach (DataRow row in dt.Rows)
                {
                    row["tanggal_milking"] = Convert.ToDateTime(row["tanggal_milking"]);
                }

                dgvSusu.DataSource = dt;
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
                        txtidproduksi.Enabled = false;
                        txtTotal.Enabled = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }



        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnkembali_Click(object sender, EventArgs e)
        {
            Main mForm = new Main();
            mForm.Show();
            Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string Query = "INSERT INTO money_milking (tanggal_milking, id_sapi,  milking_pagi, milking_sore, milking_malam, total_milking) " +
                               "VALUES (@tanggal_milking, @id_sapi, @milking_pagi, @milking_sore, @milking_malam, @total_milking)";

                decimal milkingPagi = decimal.Parse(txtSpagi.Text);
                decimal milkingSore = decimal.Parse(txtSsore.Text);
                decimal milkingMalam = decimal.Parse(txtSmalam.Text);
                decimal totalMilking = milkingPagi + milkingSore + milkingMalam;
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();

                    using (MySqlCommand CommandToDataBase = new MySqlCommand(Query, con))
                    {
                        CommandToDataBase.Parameters.AddWithValue("@tanggal_milking", dtpProduksi.Value.ToString("yyyy-MM-dd HH:mm:ss"));
                        CommandToDataBase.Parameters.AddWithValue("@id_sapi", cmbIDSapi.SelectedValue.ToString());
                        CommandToDataBase.Parameters.AddWithValue("@milking_pagi", decimal.Parse(txtSpagi.Text));
                        CommandToDataBase.Parameters.AddWithValue("@milking_sore", decimal.Parse(txtSsore.Text));
                        CommandToDataBase.Parameters.AddWithValue("@milking_malam", decimal.Parse(txtSmalam.Text));
                        CommandToDataBase.Parameters.AddWithValue("@total_milking", totalMilking);

                        CommandToDataBase.ExecuteNonQuery();
                    }

                    MessageBox.Show("Data saved successfully!");

                    cmbIDSapi.Enabled = true;

                    // Clear the ComboBox and other controls
                    cmbIDSapi.SelectedIndex = -1;
                    txtNamaSapi.Text = "";
                    txtSpagi.Text = "";
                    txtSsore.Text = "";
                    txtSmalam.Text = "";
                    txtTotal.Text = "";
                    txtidproduksi.Text = "";
                    dtpProduksi.Value = DateTime.Now;
                    // ... continue for other controls

                    // Assuming you have a loadData method to reload data
                    string valueToLoad = cmbIDSapi.Text;
                    loadData(valueToLoad);
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
                    string Query = "UPDATE money_milking SET " +
                                   "milking_pagi = @milking_pagi, " +
                                   "milking_sore = @milking_sore, " +
                                   "milking_malam = @milking_malam, " +
                                   "total_milking = @total_milking, " +
                                   "tanggal_milking=@tanggal_milking "+
                                   " WHERE id_produksi=@id_produksi";

                    using (MySqlConnection con = new MySqlConnection(connectionString))
                    {
                        con.Open();


                        using (MySqlCommand CommandToDataBase = new MySqlCommand(Query, con))
                        {
                            // Set parameter valuess
                            CommandToDataBase.Parameters.AddWithValue("@milking_pagi", decimal.Parse(txtSpagi.Text));
                            CommandToDataBase.Parameters.AddWithValue("@milking_sore", decimal.Parse(txtSsore.Text));
                            CommandToDataBase.Parameters.AddWithValue("@milking_malam", decimal.Parse(txtSmalam.Text));
                            CommandToDataBase.Parameters.AddWithValue("@total_milking", decimal.Parse(txtTotal.Text));
                            CommandToDataBase.Parameters.AddWithValue("@tanggal_milking", dtpProduksi.Value.ToString("yyyy-MM-dd HH:mm:ss"));
                            CommandToDataBase.Parameters.AddWithValue("@id_produksi", int.Parse(txtidproduksi.Text));

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

                    cmbIDSapi.Enabled = true;

                    // Clear the ComboBox and other controls
                    cmbIDSapi.SelectedIndex = -1;
                    txtNamaSapi.Text = "";
                    txtSpagi.Text = "";
                    txtSsore.Text = "";
                    txtSmalam.Text = "";
                    txtTotal.Text = "";
                    txtidproduksi.Text = "";
                    dtpProduksi.Value = DateTime.Now;
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
                if (cmbIDSapi.SelectedIndex != -1 && !string.IsNullOrEmpty(dtpProduksi.Text))
                {
                    string Query = "DELETE FROM money_milking WHERE id_produksi = @id_produksi";

                    using (MySqlConnection con = new MySqlConnection(connectionString))
                    {
                        con.Open();

                        using (MySqlCommand CommandToDataBase = new MySqlCommand(Query, con))
                        {
                            // Set parameter values
                            CommandToDataBase.Parameters.AddWithValue("@id_produksi", int.Parse(txtidproduksi.Text));

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
                    cmbIDSapi.Enabled = true;
                    cmbIDSapi.SelectedIndex = -1;
                    txtNamaSapi.Text = "";
                    txtSpagi.Text = "";
                    txtSsore.Text = "";
                    txtSmalam.Text = "";
                    txtTotal.Text = "";
                    dtpProduksi.Value = DateTime.Now; // Reset DateTimePicker to current date
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
            txtSpagi.Text = "";
            txtSsore.Text = "";
            txtSmalam.Text = "";
            txtTotal.Text = "";
            txtidproduksi.Text = "";
            dtpProduksi.Value = DateTime.Now;
            // ... continue for other controls

            // Assuming you have a loadData method to reload data
            string valueToLoad = cmbIDSapi.Text;
            loadData(valueToLoad);
        }

        private void dgvSusu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cmbIDSapi.Enabled = false;
            txtNamaSapi.Enabled = false;
            txtidproduksi.Enabled = false;
            txtTotal.Enabled = false;

            dgvSusu.CurrentRow.Selected = true;
            cmbIDSapi.Text = dgvSusu.Rows[e.RowIndex].Cells["id_sapi"].FormattedValue.ToString();
            txtidproduksi.Text = dgvSusu.Rows[e.RowIndex].Cells["id_produksi"].FormattedValue.ToString();
            txtSpagi.Text = dgvSusu.Rows[e.RowIndex].Cells["milking_pagi"].FormattedValue.ToString();
            txtSsore.Text = dgvSusu.Rows[e.RowIndex].Cells["milking_sore"].FormattedValue.ToString();
            txtSmalam.Text = dgvSusu.Rows[e.RowIndex].Cells["milking_malam"].FormattedValue.ToString();
            txtTotal.Text = dgvSusu.Rows[e.RowIndex].Cells["total_milking"].FormattedValue.ToString();
            dtpProduksi.Text = dgvSusu.Rows[e.RowIndex].Cells["tanggal_milking"].FormattedValue.ToString();

        }

        private void Produksi_Load(object sender, EventArgs e)
        {
            loadData("");

            FillComboBoxIDSapi();

           
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
