using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Maintenance1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string connectionString = "server=localhost;uid=root;pwd=Mysql.123@h;database=test";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string query = "SELECT * FROM test.login";
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds, "login");

                        if (ds.Tables["login"].Rows.Count > 0)
                        {
                            dataGridView1.DataSource = ds.Tables["login"];
                            dataGridView1.AutoGenerateColumns = true;
                            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                            dataGridView1.ColumnHeadersVisible = true;
                        }
                        else
                        {
                            MessageBox.Show("No data found.");
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                // Handle MySQL exceptions
                MessageBox.Show("MySQL error: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Handle other exceptions
                MessageBox.Show("Error: " + ex.Message);
            }

            // Check DataGridView configuration
            MessageBox.Show("DataGridView Properties: " +
                "\nAutoGenerateColumns = " + dataGridView1.AutoGenerateColumns.ToString() +
                "\nAutoSizeColumnsMode = " + dataGridView1.AutoSizeColumnsMode.ToString() +
                "\nColumnHeadersVisible = " + dataGridView1.ColumnHeadersVisible.ToString());
        }

    }
}
