using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace ADET_sample
{
    public partial class Employees_tab : Form
    {

        public Employees_tab()
        {
            InitializeComponent();
        }

        private void Employees_tab_Load(object sender, EventArgs e)
        {
            FILL_EMP_LIST();
        }

        private void Employees_List_Datagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == Employees_List_Datagrid.Columns["edit_button_image"].Index)
            {
                DataGridViewRow selectedRow = Employees_List_Datagrid.Rows[e.RowIndex];
                Edit_Employee_Row editForm = new Edit_Employee_Row(selectedRow, this);
                editForm.ShowDialog();
            }
        }

        public void FILL_EMP_LIST()
        {
            using (MySqlConnection conn = DatabaseConnection.GetConnection())
            {
                try
                {
                    conn.Open();
                    MySqlCommand command = new MySqlCommand("SELECT * FROM matcha.employees", conn);
                    DataTable dataTable = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dataTable);
                    Employees_List_Datagrid.DataSource = dataTable;
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

        private void Add_New_Emp_Btn_Click(object sender, EventArgs e)
        {
            Add_New_Employee new_form = new Add_New_Employee(this);
            new_form.ShowDialog();
        }
    }
}