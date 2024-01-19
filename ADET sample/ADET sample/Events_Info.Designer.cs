using Org.BouncyCastle.Tls;

namespace ADET_sample
{
    partial class Events_Info
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            process1 = new System.Diagnostics.Process();
            panel3 = new Panel();
            AddOnsTB = new TextBox();
            PaymentStatusDB = new ComboBox();
            AddOnsLabel = new Label();
            RequestTB = new TextBox();
            TotalTB = new TextBox();
            VenueTB = new TextBox();
            TimeTB = new TextBox();
            PackageTB = new TextBox();
            Staff4TB = new TextBox();
            Staff3TB = new TextBox();
            Staff2TB = new TextBox();
            Staff1TB = new TextBox();
            ContactTB = new TextBox();
            DateTB = new TextBox();
            ClientTB = new TextBox();
            TimeLabel = new Label();
            RequestLabel = new Label();
            PaymentStatusLabel = new Label();
            VenueLabel = new Label();
            PackageLabel = new Label();
            StaffsLabel = new Label();
            ContactLabel = new Label();
            DateLabel = new Label();
            ClientLabel = new Label();
            EventNameLabel = new Label();
            Delete_EventInfo = new ADETADET_sample.RBButton();
            Edit_EventInfo = new ADETADET_sample.RBButton();
            EventInfoLabel = new Label();
            ExitButton = new ADETADET_sample.RBButton();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // process1
            // 
            process1.StartInfo.Domain = "";
            process1.StartInfo.LoadUserProfile = false;
            process1.StartInfo.Password = null;
            process1.StartInfo.StandardErrorEncoding = null;
            process1.StartInfo.StandardInputEncoding = null;
            process1.StartInfo.StandardOutputEncoding = null;
            process1.StartInfo.UseCredentialsForNetworkingOnly = false;
            process1.StartInfo.UserName = "";
            process1.SynchronizingObject = this;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(AddOnsTB);
            panel3.Controls.Add(PaymentStatusDB);
            panel3.Controls.Add(AddOnsLabel);
            panel3.Controls.Add(RequestTB);
            panel3.Controls.Add(TotalTB);
            panel3.Controls.Add(VenueTB);
            panel3.Controls.Add(TimeTB);
            panel3.Controls.Add(PackageTB);
            panel3.Controls.Add(Staff4TB);
            panel3.Controls.Add(Staff3TB);
            panel3.Controls.Add(Staff2TB);
            panel3.Controls.Add(Staff1TB);
            panel3.Controls.Add(ContactTB);
            panel3.Controls.Add(DateTB);
            panel3.Controls.Add(ClientTB);
            panel3.Controls.Add(TimeLabel);
            panel3.Controls.Add(RequestLabel);
            panel3.Controls.Add(PaymentStatusLabel);
            panel3.Controls.Add(VenueLabel);
            panel3.Controls.Add(PackageLabel);
            panel3.Controls.Add(StaffsLabel);
            panel3.Controls.Add(ContactLabel);
            panel3.Controls.Add(DateLabel);
            panel3.Controls.Add(ClientLabel);
            panel3.Controls.Add(EventNameLabel);
            panel3.Controls.Add(Delete_EventInfo);
            panel3.Controls.Add(Edit_EventInfo);
            panel3.Location = new Point(8, 54);
            panel3.Margin = new Padding(2, 3, 2, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(809, 545);
            panel3.TabIndex = 5;
            panel3.Paint += panel3_Paint;
            // 
            // AddOnsTB
            // 
            AddOnsTB.BackColor = Color.FromArgb(223, 232, 215);
            AddOnsTB.BorderStyle = BorderStyle.None;
            AddOnsTB.Location = new Point(298, 306);
            AddOnsTB.Multiline = true;
            AddOnsTB.Name = "AddOnsTB";
            AddOnsTB.Size = new Size(171, 31);
            AddOnsTB.TabIndex = 33;
            AddOnsTB.TextChanged += AddOnsTB_TextChanged;
            // 
            // PaymentStatusDB
            // 
            PaymentStatusDB.BackColor = Color.FromArgb(223, 232, 215);
            PaymentStatusDB.DropDownStyle = ComboBoxStyle.DropDownList;
            PaymentStatusDB.FormattingEnabled = true;
            PaymentStatusDB.Items.AddRange(new object[] { "FULL", "PRTL" });
            PaymentStatusDB.Location = new Point(620, 306);
            PaymentStatusDB.Name = "PaymentStatusDB";
            PaymentStatusDB.Size = new Size(140, 33);
            PaymentStatusDB.TabIndex = 32;
            PaymentStatusDB.SelectedIndexChanged += PaymentStatusDB_SelectedIndexChanged;
            // 
            // AddOnsLabel
            // 
            AddOnsLabel.AutoSize = true;
            AddOnsLabel.Location = new Point(298, 278);
            AddOnsLabel.Name = "AddOnsLabel";
            AddOnsLabel.Size = new Size(83, 25);
            AddOnsLabel.TabIndex = 31;
            AddOnsLabel.Text = "Add Ons";
            AddOnsLabel.TextAlign = ContentAlignment.MiddleLeft;
            AddOnsLabel.Click += AddOnsLabel_Click;
            // 
            // RequestTB
            // 
            RequestTB.BackColor = Color.FromArgb(223, 232, 215);
            RequestTB.BorderStyle = BorderStyle.None;
            RequestTB.Location = new Point(41, 406);
            RequestTB.Multiline = true;
            RequestTB.Name = "RequestTB";
            RequestTB.Size = new Size(726, 62);
            RequestTB.TabIndex = 0;
            RequestTB.TextChanged += RequestTB_TextChanged;
            // 
            // TotalTB
            // 
            TotalTB.BackColor = Color.FromArgb(223, 232, 215);
            TotalTB.BorderStyle = BorderStyle.None;
            TotalTB.Location = new Point(306, 306);
            TotalTB.Name = "TotalTB";
            TotalTB.Size = new Size(194, 24);
            TotalTB.TabIndex = 29;
            TotalTB.TextChanged += TotalTB_TextChanged;
            // 
            // VenueTB
            // 
            VenueTB.BackColor = Color.FromArgb(223, 232, 215);
            VenueTB.BorderStyle = BorderStyle.None;
            VenueTB.Location = new Point(41, 306);
            VenueTB.Name = "VenueTB";
            VenueTB.Size = new Size(194, 24);
            VenueTB.TabIndex = 28;
            VenueTB.TextChanged += VenueTB_TextChanged;
            // 
            // TimeTB
            // 
            TimeTB.BackColor = Color.FromArgb(223, 232, 215);
            TimeTB.BorderStyle = BorderStyle.None;
            TimeTB.Location = new Point(41, 206);
            TimeTB.Name = "TimeTB";
            TimeTB.Size = new Size(194, 24);
            TimeTB.TabIndex = 27;
            TimeTB.TextChanged += TimeTB_TextChanged;
            // 
            // PackageTB
            // 
            PackageTB.BackColor = Color.FromArgb(223, 232, 215);
            PackageTB.BorderStyle = BorderStyle.None;
            PackageTB.Location = new Point(306, 206);
            PackageTB.Name = "PackageTB";
            PackageTB.Size = new Size(194, 24);
            PackageTB.TabIndex = 26;
            PackageTB.TextChanged += textBox1_TextChanged_2;
            // 
            // Staff4TB
            // 
            Staff4TB.BackColor = Color.FromArgb(223, 232, 215);
            Staff4TB.BorderStyle = BorderStyle.None;
            Staff4TB.Location = new Point(623, 207);
            Staff4TB.Name = "Staff4TB";
            Staff4TB.Size = new Size(171, 24);
            Staff4TB.TabIndex = 25;
            // 
            // Staff3TB
            // 
            Staff3TB.BackColor = Color.FromArgb(223, 232, 215);
            Staff3TB.BorderStyle = BorderStyle.None;
            Staff3TB.Location = new Point(623, 177);
            Staff3TB.Name = "Staff3TB";
            Staff3TB.Size = new Size(171, 24);
            Staff3TB.TabIndex = 24;
            // 
            // Staff2TB
            // 
            Staff2TB.BackColor = Color.FromArgb(223, 232, 215);
            Staff2TB.BorderStyle = BorderStyle.None;
            Staff2TB.Location = new Point(623, 147);
            Staff2TB.Name = "Staff2TB";
            Staff2TB.Size = new Size(171, 24);
            Staff2TB.TabIndex = 23;
            // 
            // Staff1TB
            // 
            Staff1TB.BackColor = Color.FromArgb(223, 232, 215);
            Staff1TB.BorderStyle = BorderStyle.None;
            Staff1TB.Location = new Point(623, 117);
            Staff1TB.Name = "Staff1TB";
            Staff1TB.Size = new Size(171, 24);
            Staff1TB.TabIndex = 22;
            Staff1TB.TextChanged += Staff1TB_TextChanged;
            // 
            // ContactTB
            // 
            ContactTB.BackColor = Color.FromArgb(223, 232, 215);
            ContactTB.BorderStyle = BorderStyle.None;
            ContactTB.Location = new Point(306, 117);
            ContactTB.Name = "ContactTB";
            ContactTB.Size = new Size(194, 24);
            ContactTB.TabIndex = 21;
            ContactTB.TextChanged += ContactTB_TextChanged;
            // 
            // DateTB
            // 
            DateTB.BackColor = Color.FromArgb(223, 232, 215);
            DateTB.BorderStyle = BorderStyle.None;
            DateTB.Location = new Point(39, 117);
            DateTB.Name = "DateTB";
            DateTB.Size = new Size(185, 24);
            DateTB.TabIndex = 20;
            DateTB.TextChanged += DateTB_TextChanged;
            // 
            // ClientTB
            // 
            ClientTB.BackColor = Color.FromArgb(223, 232, 215);
            ClientTB.BorderStyle = BorderStyle.None;
            ClientTB.Location = new Point(93, 53);
            ClientTB.Name = "ClientTB";
            ClientTB.Size = new Size(229, 24);
            ClientTB.TabIndex = 19;
            ClientTB.TextChanged += ClientTB_TextChanged;
            // 
            // TimeLabel
            // 
            TimeLabel.AutoSize = true;
            TimeLabel.Location = new Point(33, 182);
            TimeLabel.Name = "TimeLabel";
            TimeLabel.Size = new Size(50, 25);
            TimeLabel.TabIndex = 18;
            TimeLabel.Text = "Time";
            TimeLabel.TextAlign = ContentAlignment.MiddleLeft;
            TimeLabel.Click += TimeLabel_Click_1;
            // 
            // RequestLabel
            // 
            RequestLabel.AutoSize = true;
            RequestLabel.Location = new Point(33, 376);
            RequestLabel.Name = "RequestLabel";
            RequestLabel.Size = new Size(160, 25);
            RequestLabel.TabIndex = 17;
            RequestLabel.Text = "Specified Requests";
            RequestLabel.TextAlign = ContentAlignment.MiddleLeft;
            RequestLabel.Click += RequestLabel_Click;
            // 
            // PaymentStatusLabel
            // 
            PaymentStatusLabel.AutoSize = true;
            PaymentStatusLabel.Location = new Point(615, 278);
            PaymentStatusLabel.Name = "PaymentStatusLabel";
            PaymentStatusLabel.Size = new Size(133, 25);
            PaymentStatusLabel.TabIndex = 16;
            PaymentStatusLabel.Text = "Payment Status";
            PaymentStatusLabel.TextAlign = ContentAlignment.MiddleLeft;
            PaymentStatusLabel.Click += PaymentStatusLabel_Click;
            // 
            // VenueLabel
            // 
            VenueLabel.AutoSize = true;
            VenueLabel.Location = new Point(33, 278);
            VenueLabel.Name = "VenueLabel";
            VenueLabel.Size = new Size(60, 25);
            VenueLabel.TabIndex = 14;
            VenueLabel.Text = "Venue";
            VenueLabel.TextAlign = ContentAlignment.MiddleLeft;
            VenueLabel.Click += VenueLabel_Click;
            // 
            // PackageLabel
            // 
            PackageLabel.AutoSize = true;
            PackageLabel.Location = new Point(298, 182);
            PackageLabel.Name = "PackageLabel";
            PackageLabel.Size = new Size(76, 25);
            PackageLabel.TabIndex = 13;
            PackageLabel.Text = "Package";
            PackageLabel.TextAlign = ContentAlignment.MiddleLeft;
            PackageLabel.Click += PackageLabel_Click;
            // 
            // StaffsLabel
            // 
            StaffsLabel.AutoSize = true;
            StaffsLabel.Location = new Point(615, 93);
            StaffsLabel.Name = "StaffsLabel";
            StaffsLabel.Size = new Size(134, 25);
            StaffsLabel.TabIndex = 11;
            StaffsLabel.Text = "Staffs Assigned";
            StaffsLabel.TextAlign = ContentAlignment.MiddleLeft;
            StaffsLabel.Click += StaffsLabel_Click;
            // 
            // ContactLabel
            // 
            ContactLabel.AutoSize = true;
            ContactLabel.Location = new Point(298, 93);
            ContactLabel.Name = "ContactLabel";
            ContactLabel.Size = new Size(131, 25);
            ContactLabel.TabIndex = 10;
            ContactLabel.Text = "Contact Details";
            ContactLabel.TextAlign = ContentAlignment.MiddleLeft;
            ContactLabel.Click += ContactLabel_Click;
            // 
            // DateLabel
            // 
            DateLabel.AutoSize = true;
            DateLabel.Location = new Point(33, 93);
            DateLabel.Name = "DateLabel";
            DateLabel.Size = new Size(49, 25);
            DateLabel.TabIndex = 9;
            DateLabel.Text = "Date";
            DateLabel.TextAlign = ContentAlignment.MiddleLeft;
            DateLabel.Click += DateLabel_Click;
            // 
            // ClientLabel
            // 
            ClientLabel.AutoSize = true;
            ClientLabel.Location = new Point(33, 51);
            ClientLabel.Name = "ClientLabel";
            ClientLabel.Size = new Size(60, 25);
            ClientLabel.TabIndex = 8;
            ClientLabel.Text = "Client:";
            ClientLabel.TextAlign = ContentAlignment.MiddleLeft;
            ClientLabel.Click += ClientLabel_Click;
            // 
            // EventNameLabel
            // 
            EventNameLabel.AutoSize = true;
            EventNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            EventNameLabel.Location = new Point(31, 18);
            EventNameLabel.Name = "EventNameLabel";
            EventNameLabel.Size = new Size(0, 32);
            EventNameLabel.TabIndex = 7;
            EventNameLabel.TextAlign = ContentAlignment.MiddleLeft;
            EventNameLabel.Click += EventNameLabel_Click;
            // 
            // Delete_EventInfo
            // 
            Delete_EventInfo.BackColor = Color.FromArgb(46, 60, 24);
            Delete_EventInfo.BackgroundColor = Color.FromArgb(46, 60, 24);
            Delete_EventInfo.BorderColor = Color.PaleVioletRed;
            Delete_EventInfo.BorderRadius = 8;
            Delete_EventInfo.BorderSize = 0;
            Delete_EventInfo.FlatAppearance.BorderSize = 0;
            Delete_EventInfo.FlatStyle = FlatStyle.Flat;
            Delete_EventInfo.ForeColor = Color.White;
            Delete_EventInfo.Location = new Point(408, 499);
            Delete_EventInfo.Margin = new Padding(2, 3, 2, 3);
            Delete_EventInfo.Name = "Delete_EventInfo";
            Delete_EventInfo.Size = new Size(398, 39);
            Delete_EventInfo.TabIndex = 6;
            Delete_EventInfo.Text = "Delete";
            Delete_EventInfo.TextColor = Color.White;
            Delete_EventInfo.UseVisualStyleBackColor = false;
            Delete_EventInfo.Click += Delete_EventInfo_Click;
            // 
            // Edit_EventInfo
            // 
            Edit_EventInfo.BackColor = Color.FromArgb(46, 60, 24);
            Edit_EventInfo.BackgroundColor = Color.FromArgb(46, 60, 24);
            Edit_EventInfo.BorderColor = Color.PaleVioletRed;
            Edit_EventInfo.BorderRadius = 8;
            Edit_EventInfo.BorderSize = 0;
            Edit_EventInfo.FlatAppearance.BorderSize = 0;
            Edit_EventInfo.FlatStyle = FlatStyle.Flat;
            Edit_EventInfo.ForeColor = Color.White;
            Edit_EventInfo.Location = new Point(2, 499);
            Edit_EventInfo.Margin = new Padding(2, 3, 2, 3);
            Edit_EventInfo.Name = "Edit_EventInfo";
            Edit_EventInfo.Size = new Size(398, 39);
            Edit_EventInfo.TabIndex = 5;
            Edit_EventInfo.Text = "Save";
            Edit_EventInfo.TextColor = Color.White;
            Edit_EventInfo.UseVisualStyleBackColor = false;
            Edit_EventInfo.Click += Edit_EventInfo_Click;
            // 
            // EventInfoLabel
            // 
            EventInfoLabel.AutoSize = true;
            EventInfoLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EventInfoLabel.ImageAlign = ContentAlignment.MiddleLeft;
            EventInfoLabel.Location = new Point(1, 9);
            EventInfoLabel.Name = "EventInfoLabel";
            EventInfoLabel.Size = new Size(291, 45);
            EventInfoLabel.TabIndex = 8;
            EventInfoLabel.Text = "Event Information";
            EventInfoLabel.Click += EventInfoLabel_Click;
            // 
            // ExitButton
            // 
            ExitButton.BackColor = Color.FromArgb(46, 60, 24);
            ExitButton.BackgroundColor = Color.FromArgb(46, 60, 24);
            ExitButton.BorderColor = Color.PaleVioletRed;
            ExitButton.BorderRadius = 8;
            ExitButton.BorderSize = 0;
            ExitButton.FlatAppearance.BorderSize = 0;
            ExitButton.FlatStyle = FlatStyle.Flat;
            ExitButton.ForeColor = Color.White;
            ExitButton.Location = new Point(9, 605);
            ExitButton.Margin = new Padding(2, 3, 2, 3);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(805, 39);
            ExitButton.TabIndex = 7;
            ExitButton.Text = "Done";
            ExitButton.TextColor = Color.White;
            ExitButton.UseVisualStyleBackColor = false;
            ExitButton.Click += ExitButton_Click;
            // 
            // Events_Info
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(223, 232, 215);
            ClientSize = new Size(829, 650);
            Controls.Add(EventInfoLabel);
            Controls.Add(ExitButton);
            Controls.Add(panel3);
            Margin = new Padding(2, 3, 2, 3);
            Name = "Events_Info";
            Text = "Event Information";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private System.Diagnostics.Process process1;
        private Panel panel3;
        private ADETADET_sample.RBButton Edit_EventInfo;
        private ADETADET_sample.RBButton ExitButton;
        private ADETADET_sample.RBButton Delete_EventInfo;
        private Label EventNameLabel;
        private Label EventInfoLabel;
        private Label ContactLabel;
        private Label DateLabel;
        private Label ClientLabel;
        private Label StaffsLabel;
        private Label VenueLabel;
        private Label PackageLabel;
        private Label TimeLabel;
        private Label RequestLabel;
        private Label PaymentStatusLabel;
        private TextBox Staff4TB;
        private TextBox Staff3TB;
        private TextBox Staff2TB;
        private TextBox Staff1TB;
        private TextBox ContactTB;
        private TextBox DateTB;
        private TextBox ClientTB;
        private TextBox AddOnsTB;
        private TextBox PackageTB;
        private TextBox RequestTB;
        private TextBox TotalTB;
        private TextBox VenueTB;
        private TextBox TimeTB;
        private Label AddOnsLabel;
        private ComboBox PaymentStatusDB;
    }
}