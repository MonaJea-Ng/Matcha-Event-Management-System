using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADET_sample
{
    public partial class Events_Info : Form
    {

        public Events_Info(string eventName, string eventType, string venue, string time, string clientName,
            string eventDate, string package, string addOns, string paymentStatus, string staff1, string staff2, string staff3, string staff4)
        {
            InitializeComponent();
            EventNameLabel.Text = eventName + " - " + eventType;

            //Making All Text Box initially display values
            VenueTB.ReadOnly = true;
            VenueTB.Text = venue;

            TimeTB.ReadOnly = true;
            TimeTB.Text = time;

            ClientTB.ReadOnly = true;
            ClientTB.Text = clientName;

            DateTB.ReadOnly = true;
            DateTB.Text = eventDate;

            PackageTB.ReadOnly = true;
            PackageTB.Text = package;

            AddOnsTB.ReadOnly = true;
            AddOnsTB.Text = addOns;

            PaymentStatusDB.Text = paymentStatus;

            Staff1TB.ReadOnly = true;
            Staff1TB.Text = staff1;

            Staff2TB.ReadOnly = true;
            Staff2TB.Text = staff2;

            Staff3TB.ReadOnly = true;
            Staff3TB.Text = staff3;

            Staff4TB.ReadOnly = true;
            Staff4TB.Text = staff4;


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

        }

        private void Delete_EventInfo_Click(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {

        }
    }
}

