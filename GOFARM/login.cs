using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace GoFarm
{
    public partial class Login : Form
    {
        string connectionString;
        MySqlConnection connect;

        public Login()
        {
            InitializeComponent();
            connectionString = "server=localhost;port=3306;database=db_farm;user=root;pwd='';";
            connect = new MySqlConnection(connectionString);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUser.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Silakan isi semua kolom yang kosong", "Pesan Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT * FROM users WHERE username = @username " +
                            "AND password = @password";

                    using (MySqlCommand cmd = new MySqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@username", txtUser.Text.Trim());
                        cmd.Parameters.AddWithValue("@password", txtPassword.Text.Trim());

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count >= 1)
                            {
                                MessageBox.Show("Login berhasil!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                Main mForm = new Main();
                                mForm.Show();
                                Hide();
                            }
                            else
                            {
                                MessageBox.Show("Username/Password Salah", "Pesan Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Pesan Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        private void txtReset_Click(object sender, EventArgs e)
        {
            txtUser.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }
    }
}
