using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;

namespace ADET_sample
{
    public partial class Events_Info : Form
    {
        private Events_tab eventsTab;
        private string eventName;
        private string eventType;
        public Events_Info(Events_tab eventsTab, string eventName, string eventType, string venue, string time, string clientName,
            string eventDate, string package, string addOns, string paymentStatus, string staff1, string staff2,
            string staff3, string staff4, string contact, string request)
        {
            InitializeComponent();
            this.eventsTab = eventsTab;
            this.eventName = eventName;
            this.eventType = eventType;

            //
            //CONNECTING TO DB FOR DROP DOWN OPTIONS
            using (MySqlConnection con = DatabaseConnection.GetConnection())
            {
                con.Open();
                MySqlCommand packageOptions = new MySqlCommand("SELECT Package_Type FROM matcha_em_sys.packages;", con);//package
                MySqlCommand addOnsOptions = new MySqlCommand("SELECT AddOn FROM matcha_em_sys.addons;", con);//addons
                MySqlCommand staffOptions = new MySqlCommand("SELECT employee_id FROM matcha_em_sys.employees;", con);//staff options

                using (MySqlDataReader packagereader = packageOptions.ExecuteReader())
                {
                    while (packagereader.Read())
                    {
                        string packageTypeOP = packagereader.GetString(0);
                        PackageDB.Items.Add(packageTypeOP);

                    }
                }

                using (MySqlDataReader addOnsreader = addOnsOptions.ExecuteReader())
                {
                    while (addOnsreader.Read())
                    {
                        string addOnsOP = addOnsreader.GetString(0);
                        AddOnsDB.Items.Add(addOnsOP);
                    }
                }

                using (MySqlDataReader staffreader = staffOptions.ExecuteReader())
                {
                    while (staffreader.Read())
                    {
                        string staffOP = staffreader.GetString(0);
                        Staff1DB.Items.Add(staffOP);
                        Staff2DB.Items.Add(staffOP);
                        Staff3DB.Items.Add(staffOP);
                        Staff4DB.Items.Add(staffOP);
                    }
                }

            }
            // CONNECTION DONE


            //For Event Name, Textbox will appear if null.
            if (eventName == null && eventType == null || eventName == "" && eventType == "")
            {
                EventNameLabel.Visible = false;
                TextBox EventNameTB = new TextBox();
                panel3.Controls.Add(EventNameTB);
                EventNameTB.BackColor = Color.FromArgb(223, 232, 215);
                EventNameTB.BorderStyle = BorderStyle.None;
                EventNameTB.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
                EventNameTB.Location = new Point(31, 18);
                EventNameTB.Name = "EventNameTB";
                EventNameTB.Size = new Size(0, 32);
                EventNameTB.TabIndex = 7;
                EventNameTB.TextChanged += EventNameTB_TextChanged;
            }
            else
            {
                EventNameLabel.Text = eventName + " - " + eventType;
            }



            //Making All Text Box initially display values according to Database's record
            VenueTB.ReadOnly = true;
            VenueTB.Text = venue;

            TimeTB.ReadOnly = true;
            TimeTB.Text = time;

            ClientTB.ReadOnly = true;
            ClientTB.Text = clientName;

            DateTB.ReadOnly = true;
            DateTB.Text = eventDate;

            ContactTB.ReadOnly = true;
            ContactTB.Text = contact;

            RequestTB.ReadOnly = true;
            RequestTB.Text = request;

            //Making Drop Down options static
            PackageDB.Enabled = false;
            PaymentStatusDB.Enabled = false;
            Staff1DB.Enabled = false;
            Staff2DB.Enabled = false;
            Staff3DB.Enabled = false;
            Staff4DB.Enabled = false;
            AddOnsDB.Enabled = false;



            PackageDB.Text = package;

            if (addOns != "")
            {
                AddOnsDB.Text = addOns;
            }
            else
            {
                AddOnsDB.Text = "None";
            }



            PaymentStatusDB.Text = paymentStatus;


            if (staff1 != "")
            {
                Staff1DB.Text = staff1;
            }
            else
            {
                Staff1DB.Visible = false;
            }

            if (staff2 != "")
            {
                Staff2DB.Text = staff2;
            }
            else
            {
                Staff2DB.Visible = false;
            }
            if (staff3 != "")
            {
                Staff3DB.Text = staff3;
            }
            else
            {
                Staff3DB.Visible = false;
            }
            if (staff4 != "")
            {
                Staff4DB.Text = staff4;
            }
            else
            {
                Staff4DB.Visible = false;
            }
        }


        private void EventNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void EventInfoLabel_Click(object sender, EventArgs e)
        {

        }

        private void PackageLabel_Click(object sender, EventArgs e)
        {

        }

        private void TotalLabel_Click(object sender, EventArgs e)
        {

        }

        private void DateLabel_Click(object sender, EventArgs e)
        {

        }

        private void ContactLabel_Click(object sender, EventArgs e)
        {

        }

        private void StaffsLabel_Click(object sender, EventArgs e)
        {

        }

        private void TimeLabel_Click_1(object sender, EventArgs e)
        {

        }

        private void VenueLabel_Click(object sender, EventArgs e)
        {

        }

        private void PaymentStatusLabel_Click(object sender, EventArgs e)
        {

        }

        private void RequestLabel_Click(object sender, EventArgs e)
        {

        }

        private void DateTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void ClientTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void ContactTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void Staff1TB_TextChanged(object sender, EventArgs e)
        {

        }

        private void TimeTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void VenueTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void TotalTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void PaymentStatusTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void RequestTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ClientLabel_Click(object sender, EventArgs e)
        {

        }

        private void PaymentStatusDB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddOnsLabel_Click(object sender, EventArgs e)
        {

        }

        private void AddOnsTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void Edit_EventInfo_Click(object sender, EventArgs e)
        {
            // Make the text boxes editable
            VenueTB.ReadOnly = false;
            TimeTB.ReadOnly = false;
            ClientTB.ReadOnly = false;
            DateTB.ReadOnly = false;
            ContactTB.ReadOnly = false;
            RequestTB.ReadOnly = false;

            // Make the combo boxes editable
            PackageDB.Enabled = true;
            PaymentStatusDB.Enabled = true;
            Staff1DB.Enabled = true;
            Staff2DB.Enabled = true;
            Staff3DB.Enabled = true;
            Staff4DB.Enabled = true;
            AddOnsDB.Enabled = true;

            //Visibility of additional staff
            Staff1DB.Visible = true;
            Staff2DB.Visible = true;
            Staff3DB.Visible = true;
            Staff4DB.Visible = true;
            AddOnsDB.Visible = true;
            ExitButton.Text = "Save";

        }

        private void Delete_EventInfo_Click(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            string eventName = this.eventName;
            string eventType = this.eventType;
            string venue = VenueTB.Text;
            string time = TimeTB.Text;
            string clientName = ClientTB.Text;
            string eventDate = DateTB.Text;
            string contact = ContactTB.Text;
            string request = RequestTB.Text;
            string package = PackageDB.SelectedItem.ToString();
            string paymentStatus = PaymentStatusDB.SelectedItem.ToString();

            string staff1 = (Staff1DB.SelectedItem == null || Staff1DB.SelectedItem == "" || Staff1DB.SelectedItem == "None") ? "" : Staff1DB.SelectedItem.ToString();
            string staff2 = (Staff2DB.SelectedItem == null || Staff2DB.SelectedItem == "" || Staff2DB.SelectedItem == "None") ? "" : Staff2DB.SelectedItem.ToString();
            string staff3 = (Staff3DB.SelectedItem == null || Staff3DB.SelectedItem == "" || Staff3DB.SelectedItem == "None") ? "" : Staff3DB.SelectedItem.ToString();
            string staff4 = (Staff4DB.SelectedItem == null || Staff4DB.SelectedItem == "" || Staff4DB.SelectedItem == "None") ? "" : Staff4DB.SelectedItem.ToString();

            string addOns = AddOnsDB.SelectedItem.ToString();
            

            UpdatingEventDataBase(eventName, eventType, venue, time, clientName, eventDate,
                    package, addOns, paymentStatus, staff1, staff2, staff3, staff4, contact,request);
            RefreshDataGridView();
            this.Close();

        }

        private void AddOnsDB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Staff1DB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Staff2DB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Staff3DB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Staff4DB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PackageDB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void EventNameTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void UpdatingEventDataBase(string eventName, string eventType, string venue, string time, string clientName,
            string eventDate, string package, string addOns, string paymentStatus, string staff1, string staff2,
            string staff3, string staff4, string contact, string request)
        {
            using (MySqlConnection con = DatabaseConnection.GetConnection())
            {
                con.Open();
                MySqlCommand command = new MySqlCommand("UPDATE matcha_em_sys.event SET Venue = @Venue, Event_Time = @Time, " +
                    "Client_Name = @Client, Event_Date = @Date, Contact = @Contact, Package = @Package, Payment_Status = @PaymentStatus, " +
                    "Staff_1 = @Staff1, Staff_2 = @Staff2, Staff_3 = @Staff3, Staff_4 = @Staff4, Add_Ons = @AddOns, " +
                    "Other_Request = @Request WHERE Event_Name = @EventName AND Event_Type =@EventType", con);
                // Set the parameters for the command
                command.Parameters.AddWithValue("@EventName", eventName);
                command.Parameters.AddWithValue("@EventType", eventType);
                command.Parameters.AddWithValue("@Venue", venue);
                command.Parameters.AddWithValue("@Time", time);
                command.Parameters.AddWithValue("@Client", clientName);
                command.Parameters.AddWithValue("@Date", eventDate);
                command.Parameters.AddWithValue("@Contact", contact);
                command.Parameters.AddWithValue("@Package", package);
                command.Parameters.AddWithValue("@PaymentStatus", paymentStatus);
                command.Parameters.AddWithValue("@Staff1", staff1);
                command.Parameters.AddWithValue("@Staff2", staff2);
                command.Parameters.AddWithValue("@Staff3", staff3);
                command.Parameters.AddWithValue("@Staff4", staff4);
                command.Parameters.AddWithValue("@AddOns", addOns);
                command.Parameters.AddWithValue("@Request", request);

                // Execute the command to update the data in the database
                command.ExecuteNonQuery();
            }

        }
        public void RefreshDataGridView()
        {
            eventsTab.FillEventsDataGridView(DateTime.Today);
        }
    }
}


