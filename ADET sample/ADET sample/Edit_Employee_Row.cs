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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ADET_sample
{
    public partial class Edit_Employee_Row : Form
    {
        private DataGridViewRow selectedRow;
        private Employees_tab parentForm;
        public Edit_Employee_Row(DataGridViewRow row, Employees_tab parentForm)
        {
            InitializeComponent();
            this.selectedRow = row;
            this.parentForm = parentForm;
        }

        private void Edit_Employee_Row_Load(object sender, EventArgs e)
        {
            // fetches selected row's contents
            if (selectedRow != null)
            {
                empID_TB.Text = selectedRow.Cells["employee_id"].Value.ToString();
                lname_TB.Text = selectedRow.Cells["lastname"].Value.ToString();
                fname_TB.Text = selectedRow.Cells["firstname"].Value.ToString();
                work_TB.Text = selectedRow.Cells["work"].Value.ToString();
                status_TB.Text = selectedRow.Cells["status"].Value.ToString();
                rate_TB.Text = selectedRow.Cells["rate"].Value.ToString();
            }
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            // allows textboxes to be editable
            empID_TB.ReadOnly = false;
            lname_TB.ReadOnly = false;
            fname_TB.ReadOnly = false;
            work_TB.ReadOnly = false;
            status_TB.ReadOnly = false;
            rate_TB.ReadOnly = false;
        }

        private bool changesSaved = false;
        private void done_btn_Click(object sender, EventArgs e)
        {
            empID_TB.ReadOnly = true;
            lname_TB.ReadOnly = true;
            fname_TB.ReadOnly = true;
            work_TB.ReadOnly = true;
            status_TB.ReadOnly = true;
            rate_TB.ReadOnly = true;

            // Update successful confirmation
            DialogResult result = MessageBox.Show("Are you sure you want to apply changes?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                // reflects changes to datagrid row
                selectedRow.Cells["employee_id"].Value = empID_TB.Text;
                selectedRow.Cells["firstname"].Value = fname_TB.Text;
                selectedRow.Cells["lastname"].Value = lname_TB.Text;
                selectedRow.Cells["status"].Value = status_TB.Text;
                selectedRow.Cells["work"].Value = work_TB.Text;
                selectedRow.Cells["rate"].Value = rate_TB.Text;

                // Update the database with the changes
                UpdateEmployeeInDatabase(selectedRow);

                changesSaved = true;
                this.Close();
            }
        }

        private void Edit_Employee_Row_FormClosing(object sender, FormClosingEventArgs e)
        {
            // If changes were not saved (e.g., the user closed the form using the close button)
            if (!changesSaved)
            {
                empID_TB.Text = selectedRow.Cells["employee_id"].Value.ToString();
                lname_TB.Text = selectedRow.Cells["lastname"].Value.ToString();
                fname_TB.Text = selectedRow.Cells["firstname"].Value.ToString();
                work_TB.Text = selectedRow.Cells["work"].Value.ToString();
                status_TB.Text = selectedRow.Cells["status"].Value.ToString();
                rate_TB.Text = selectedRow.Cells["rate"].Value.ToString();
            }

        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this employee?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                DeleteEmployeeFromDatabase(selectedRow);
                this.parentForm.FILL_EMP_LIST();
                this.Close();
            }
        }

        private void DeleteEmployeeFromDatabase(DataGridViewRow row)
        {
            using (MySqlConnection connection = DatabaseConnection.GetConnection())
            {
                try
                {
                    connection.Open();
                    string query = "DELETE FROM employees WHERE employee_id = @id";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", row.Cells["employee_id"].Value);
                        command.ExecuteNonQuery();
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error deleting from database: " + ex.Message);
                }
            }
        }

        private void UpdateEmployeeInDatabase(DataGridViewRow row)
        {
            using (MySqlConnection connection = DatabaseConnection.GetConnection())
            {
                try
                {
                    connection.Open();
                    string query = "UPDATE employees SET first_name = @fname, last_name = @lname, Work = @work, status = @status, Rate = @rate WHERE employee_id = @id";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@fname", row.Cells["firstname"].Value);
                        command.Parameters.AddWithValue("@lname", row.Cells["lastname"].Value);
                        command.Parameters.AddWithValue("@work", row.Cells["work"].Value);
                        command.Parameters.AddWithValue("@status", row.Cells["status"].Value);
                        command.Parameters.AddWithValue("@rate", row.Cells["rate"].Value);
                        command.Parameters.AddWithValue("@id", row.Cells["employee_id"].Value);
                        command.ExecuteNonQuery();
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error updating database: " + ex.Message);
                }
            }
        }


    }
}