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

namespace ADET_sample
{
    public partial class Services_tab : Form
    {
        public Services_tab()
        {
            InitializeComponent();
        }

        private void Services_tab_Load(object sender, EventArgs e)
        {
            FILL_EMP_LIST();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void FILL_EMP_LIST()
        {
            using (MySqlConnection conn = DatabaseConnection.GetConnection())
            {
                try
                {
                    conn.Open();
                    MySqlCommand command = new MySqlCommand("SELECT * FROM matcha.packages", conn);
                    DataTable dataTable = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dataTable);
                    Packages_List_DataGrid.DataSource = dataTable;

                    command = new MySqlCommand("SELECT * FROM matcha.addons", conn);
                    dataTable = new DataTable();
                    adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dataTable);
                    Addons_List_DataGrid.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void SavePackageBtn_Click(object sender, EventArgs e)
        {
            
        }
    }
}
