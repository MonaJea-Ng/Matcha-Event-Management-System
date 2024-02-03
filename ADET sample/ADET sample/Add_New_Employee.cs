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
    public partial class Add_New_Employee : Form
    {
        private MySqlConnection connection;
        private Employees_tab mainForm;
        public Add_New_Employee(Employees_tab mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            connection = DatabaseConnection.GetConnection();
        }

        private void Add_New_Employee_Load(object sender, EventArgs e)
        {

        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            try
            {
                // Retrieve data from textboxes
                string empID = new_empID_TB.Text;
                string firstName = new_fname_TB.Text;
                string lastName = new_lname_TB.Text;
                string status = new_status_TB.Text;
                string work = new_work_TB.Text;
                string rate = new_rate_TB.Text;


                // Update successful confirmation
                DialogResult result = MessageBox.Show("Are you sure you want to add a new employee?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (result == DialogResult.OK)
                {
                    string query = $"INSERT INTO employees (employee_id, first_name, last_name, status, Work, Rate) VALUES ('{empID}', '{firstName}', '{lastName}', '{status}', '{work}', '{rate}')";

                    connection.Open();

                    // Execute the query
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Employee added successfully!");

                    // Update the DataGridView in the main form
                    mainForm.FILL_EMP_LIST();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}