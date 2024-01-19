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
using System.Data.Common;

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
            //Events_Info events_Info = new Events_Info();
            //this.Visibility = Visibility.Hidden;
            //events_Info.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Events_tab_Load(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
            FillEventsDataGridView(today);

            


        }

        private void UpcomingEventsData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = UpcomingEventsData.Rows[e.RowIndex];

                string eventName = selectedRow.Cells["Event_Name"].Value.ToString();
                string eventType = selectedRow.Cells["Event_Type"].Value.ToString();
                string venue = selectedRow.Cells["Venue"].Value.ToString();
                string time = selectedRow.Cells["Event_Time"].Value.ToString();
                string clientName = selectedRow.Cells["Client_Name"].Value.ToString();
                DateTime selectedEventDate = Convert.ToDateTime(selectedRow.Cells["Event_Date"].Value);
                string eventDate = selectedEventDate.ToString("yyyy-MM-dd");
                string package = selectedRow.Cells["Package"].Value.ToString();
                string addOns = selectedRow.Cells["Add_Ons"].Value.ToString();
                string paymentStatus = selectedRow.Cells["Payment_Status"].Value.ToString();
                string staff1 = selectedRow.Cells["Staff_1"].Value.ToString();
                string staff2 = selectedRow.Cells["Staff_2"].Value.ToString();
                string staff3 = selectedRow.Cells["Staff_3"].Value.ToString();
                string staff4 = selectedRow.Cells["Staff_4"].Value.ToString();

                Events_Info eventsInfoForm = new Events_Info(eventName, eventType, venue, time, clientName, eventDate, 
                    package, addOns, paymentStatus, staff1, staff2, staff3, staff4);
                eventsInfoForm.Show();
            }
        }

        //Filling the DataGrid View
        public void FillEventsDataGridView(DateTime selectedDate)
        {
            using (MySqlConnection con = DatabaseConnection.GetConnection())
            {
                con.Open();
                MySqlDataAdapter Events = new MySqlDataAdapter("SELECT * FROM event WHERE DATE_FORMAT(Event_date, '%Y/%m/%d') = @selectedDate  ", con);
                Events.SelectCommand.Parameters.AddWithValue("@selectedDate", selectedDate);
                DataTable EventTable = new DataTable();
                Events.Fill(EventTable);
                UpcomingEventsData.DataSource = EventTable;

                //Changing name to appear sa header
                UpcomingEventsData.Columns["Event_Name"].HeaderText = "Name";
                UpcomingEventsData.Columns["Event_Type"].HeaderText = "Type";
                UpcomingEventsData.Columns["Event_Time"].HeaderText = "Time";

                // Hide columns na di pa need sa display
                UpcomingEventsData.Columns["Client_Name"].Visible = false;
                UpcomingEventsData.Columns["Event_Date"].Visible = false;
                UpcomingEventsData.Columns["Package"].Visible = false;
                UpcomingEventsData.Columns["Add_Ons"].Visible = false;
                UpcomingEventsData.Columns["Payment_Status"].Visible = false;
                UpcomingEventsData.Columns["Staff_1"].Visible = false;
                UpcomingEventsData.Columns["Staff_2"].Visible = false;
                UpcomingEventsData.Columns["Staff_3"].Visible = false;
                UpcomingEventsData.Columns["Staff_4"].Visible = false;
                UpcomingEventsData.Columns["Other_Request"].Visible = false;
            }
        }
    }
}
