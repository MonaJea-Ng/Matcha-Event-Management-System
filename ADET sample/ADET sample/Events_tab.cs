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
    public partial class Events_tab : Form
    {
        public Events_tab()
        {
            InitializeComponent();
        }

        private void AddEventButton_Click(object sender, EventArgs e)
        {
            Events_Info events_Info = new Events_Info();
            //this.Visibility = Visibility.Hidden;
            events_Info.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Events_tab_Load(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
            FillEvents(today);
        }

        private void Upcoming_Events_DataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        public void FillEvents(DateTime selectedDate)
        {
            using (MySqlConnection con = DatabaseConnection.GetConnection())
            {
                try
                {
                    con.Open();
                    MySqlDataAdapter Events = new MySqlDataAdapter("SELECT Event_Name,Event_Type,Venue FROM event WHERE Event_date =@selectedDate", con);
                    Events.SelectCommand.Parameters.AddWithValue("@selectedDate", selectedDate);
                    DataTable EventTable = new DataTable();
                    Events.Fill(EventTable);
                    Upcoming_Events_DataGrid.DataSource = EventTable;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error connecting to database: " + ex.Message);
                }
            }
        }

    }
}
