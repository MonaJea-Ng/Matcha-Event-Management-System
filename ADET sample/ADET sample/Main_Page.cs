namespace ADET_sample
{
    public partial class Main_Page : Form
    {
        public Main_Page()
        {
            InitializeComponent();
        }

        public void loadform(object Form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }

        private void Main_Page_Load_1(object sender, EventArgs e)
        {

            loadform(new Events_tab());
        }

        public void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
           DateTime selectedDate = e.Start;
           Events_tab eventsTab = this.mainpanel.Tag as Events_tab; // Get the loaded instance
           eventsTab.FillEventsDataGridView(selectedDate);
        }

        public void mainpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Employee_Button_Click(object sender, EventArgs e)
        {
            loadform(new Employees_tab());
        }

        private void Event_Button_Click(object sender, EventArgs e)
        {
            loadform(new Events_tab());
        }

        private void Services_Button_Click(object sender, EventArgs e)
        {
            loadform(new Services_tab());
        }
        
    }
}
