
namespace ADET_sample
{
    partial class Main_Page
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Page));
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel1 = new Panel();
            Services_Button = new Button();
            Employee_Button = new Button();
            panel2 = new Panel();
            DatePicker = new MonthCalendar();
            Event_Button = new Button();
            imageList1 = new ImageList(components);
            mainpanel = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(46, 60, 24);
            panel1.Controls.Add(Services_Button);
            panel1.Controls.Add(Employee_Button);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(Event_Button);
            panel1.Location = new Point(-5, -2);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(254, 619);
            panel1.TabIndex = 1;
            // 
            // Services_Button
            // 
            Services_Button.BackgroundImageLayout = ImageLayout.Zoom;
            Services_Button.FlatAppearance.BorderColor = SystemColors.ButtonHighlight;
            Services_Button.FlatAppearance.BorderSize = 0;
            Services_Button.FlatStyle = FlatStyle.Flat;
            Services_Button.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Services_Button.ForeColor = Color.White;
            Services_Button.Image = (Image)resources.GetObject("Services_Button.Image");
            Services_Button.ImageAlign = ContentAlignment.MiddleLeft;
            Services_Button.Location = new Point(5, 330);
            Services_Button.Margin = new Padding(2, 2, 2, 2);
            Services_Button.Name = "Services_Button";
            Services_Button.Padding = new Padding(16, 0, 0, 0);
            Services_Button.Size = new Size(251, 64);
            Services_Button.TabIndex = 4;
            Services_Button.Text = "    Services";
            Services_Button.UseVisualStyleBackColor = true;
            Services_Button.Click += Services_Button_Click;
            // 
            // Employee_Button
            // 
            Employee_Button.BackgroundImageLayout = ImageLayout.Zoom;
            Employee_Button.FlatAppearance.BorderColor = SystemColors.ButtonHighlight;
            Employee_Button.FlatAppearance.BorderSize = 0;
            Employee_Button.FlatStyle = FlatStyle.Flat;
            Employee_Button.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Employee_Button.ForeColor = Color.White;
            Employee_Button.Image = (Image)resources.GetObject("Employee_Button.Image");
            Employee_Button.ImageAlign = ContentAlignment.MiddleLeft;
            Employee_Button.Location = new Point(5, 261);
            Employee_Button.Margin = new Padding(2, 2, 2, 2);
            Employee_Button.Name = "Employee_Button";
            Employee_Button.Padding = new Padding(16, 0, 0, 0);
            Employee_Button.Size = new Size(251, 64);
            Employee_Button.TabIndex = 3;
            Employee_Button.Text = "    Employee";
            Employee_Button.UseVisualStyleBackColor = true;
            Employee_Button.Click += Employee_Button_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(30, 40, 16);
            panel2.Controls.Add(DatePicker);
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(2, 2, 2, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(256, 192);
            panel2.TabIndex = 2;
            // 
            // DatePicker
            // 
            DatePicker.BackColor = Color.FromArgb(30, 40, 16);
            DatePicker.ForeColor = SystemColors.InactiveCaption;
            DatePicker.Location = new Point(16, 15);
            DatePicker.Margin = new Padding(7, 7, 7, 7);
            DatePicker.Name = "DatePicker";
            DatePicker.TabIndex = 9;
            DatePicker.TitleBackColor = SystemColors.ActiveBorder;
            DatePicker.TitleForeColor = SystemColors.AppWorkspace;
            DatePicker.TrailingForeColor = SystemColors.ControlText;
            DatePicker.DateChanged += monthCalendar1_DateChanged;
            // 
            // Event_Button
            // 
            Event_Button.BackgroundImageLayout = ImageLayout.Zoom;
            Event_Button.FlatAppearance.BorderColor = SystemColors.ButtonHighlight;
            Event_Button.FlatAppearance.BorderSize = 0;
            Event_Button.FlatStyle = FlatStyle.Flat;
            Event_Button.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Event_Button.ForeColor = Color.White;
            Event_Button.Image = (Image)resources.GetObject("Event_Button.Image");
            Event_Button.ImageAlign = ContentAlignment.MiddleLeft;
            Event_Button.Location = new Point(6, 193);
            Event_Button.Margin = new Padding(2, 2, 2, 2);
            Event_Button.Name = "Event_Button";
            Event_Button.Padding = new Padding(16, 0, 0, 0);
            Event_Button.Size = new Size(249, 64);
            Event_Button.TabIndex = 2;
            Event_Button.Text = "    Events";
            Event_Button.UseVisualStyleBackColor = true;
            Event_Button.Click += Event_Button_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // mainpanel
            // 
            mainpanel.Location = new Point(254, 1);
            mainpanel.Name = "mainpanel";
            mainpanel.Size = new Size(981, 614);
            mainpanel.TabIndex = 10;
            mainpanel.Paint += mainpanel_Paint;
            // 
            // Main_Page
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(223, 232, 215);
            ClientSize = new Size(1233, 615);
            Controls.Add(panel1);
            Controls.Add(mainpanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 2, 2, 2);
            Name = "Main_Page";
            Text = "Matcha Event System";
            Load += Main_Page_Load_1;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label1;
        private Panel panel1;
        private Button Services_Button;
        private Button Event_Button;
        private Panel panel2;
        private ImageList imageList1;
        private Button Employee_Button;
        private MonthCalendar monthCalendar1;
        public MonthCalendar DatePicker;
        private Panel mainpanel;
    }
}
