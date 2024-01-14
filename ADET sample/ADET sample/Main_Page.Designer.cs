
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
            Event_Button = new Button();
            imageList1 = new ImageList(components);
            textBox1 = new TextBox();
            AddEventButton = new ADETADET_sample.RBButton();
            DatePicker = new MonthCalendar();
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
            panel1.Location = new Point(-6, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(318, 815);
            panel1.TabIndex = 1;
            // 
            // Services_Button
            // 
            Services_Button.BackgroundImageLayout = ImageLayout.Zoom;
            Services_Button.FlatAppearance.BorderColor = SystemColors.ButtonHighlight;
            Services_Button.FlatAppearance.BorderSize = 0;
            Services_Button.FlatStyle = FlatStyle.Flat;
            Services_Button.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Services_Button.ForeColor = Color.White;
            Services_Button.Image = (Image)resources.GetObject("Services_Button.Image");
            Services_Button.ImageAlign = ContentAlignment.MiddleLeft;
            Services_Button.Location = new Point(6, 434);
            Services_Button.Name = "Services_Button";
            Services_Button.Padding = new Padding(20, 0, 0, 0);
            Services_Button.Size = new Size(314, 84);
            Services_Button.TabIndex = 4;
            Services_Button.Text = "    Services";
            Services_Button.UseVisualStyleBackColor = true;
            // 
            // Employee_Button
            // 
            Employee_Button.BackgroundImageLayout = ImageLayout.Zoom;
            Employee_Button.FlatAppearance.BorderColor = SystemColors.ButtonHighlight;
            Employee_Button.FlatAppearance.BorderSize = 0;
            Employee_Button.FlatStyle = FlatStyle.Flat;
            Employee_Button.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Employee_Button.ForeColor = Color.White;
            Employee_Button.Image = (Image)resources.GetObject("Employee_Button.Image");
            Employee_Button.ImageAlign = ContentAlignment.MiddleLeft;
            Employee_Button.Location = new Point(6, 344);
            Employee_Button.Name = "Employee_Button";
            Employee_Button.Padding = new Padding(20, 0, 0, 0);
            Employee_Button.Size = new Size(314, 84);
            Employee_Button.TabIndex = 3;
            Employee_Button.Text = "    Employee";
            Employee_Button.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(30, 40, 16);
            panel2.Controls.Add(DatePicker);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(320, 253);
            panel2.TabIndex = 2;
            // 
            // Event_Button
            // 
            Event_Button.BackgroundImageLayout = ImageLayout.Zoom;
            Event_Button.FlatAppearance.BorderColor = SystemColors.ButtonHighlight;
            Event_Button.FlatAppearance.BorderSize = 0;
            Event_Button.FlatStyle = FlatStyle.Flat;
            Event_Button.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Event_Button.ForeColor = Color.White;
            Event_Button.Image = (Image)resources.GetObject("Event_Button.Image");
            Event_Button.ImageAlign = ContentAlignment.MiddleLeft;
            Event_Button.Location = new Point(7, 254);
            Event_Button.Name = "Event_Button";
            Event_Button.Padding = new Padding(20, 0, 0, 0);
            Event_Button.Size = new Size(311, 84);
            Event_Button.TabIndex = 2;
            Event_Button.Text = "    Events";
            Event_Button.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(241, 241, 241);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Arial", 15F, FontStyle.Bold);
            textBox1.Location = new Point(320, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(253, 35);
            textBox1.TabIndex = 2;
            textBox1.Text = "Upcoming Events";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // AddEventButton
            // 
            AddEventButton.BackColor = Color.FromArgb(46, 60, 24);
            AddEventButton.BackgroundColor = Color.FromArgb(46, 60, 24);
            AddEventButton.BorderColor = Color.PaleVioletRed;
            AddEventButton.BorderRadius = 8;
            AddEventButton.BorderSize = 0;
            AddEventButton.FlatAppearance.BorderSize = 0;
            AddEventButton.FlatStyle = FlatStyle.Flat;
            AddEventButton.ForeColor = Color.White;
            AddEventButton.Location = new Point(320, 757);
            AddEventButton.Name = "AddEventButton";
            AddEventButton.Size = new Size(1211, 40);
            AddEventButton.TabIndex = 8;
            AddEventButton.Text = "Add Event";
            AddEventButton.TextColor = Color.White;
            AddEventButton.UseVisualStyleBackColor = false;
            // 
            // DatePicker
            // 
            DatePicker.BackColor = Color.Yellow;
            DatePicker.Location = new Point(6, 0);
            DatePicker.Name = "DatePicker";
            DatePicker.TabIndex = 9;
            DatePicker.DateChanged += monthCalendar1_DateChanged;
            // 
            // Main_Page
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 241, 241);
            ClientSize = new Size(1543, 809);
            Controls.Add(AddEventButton);
            Controls.Add(textBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Main_Page";
            Text = "Matcha Event System";
            Load += Main_Page_Load_1;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label1;
        private Panel panel1;
        private Button Services_Button;
        private Button Event_Button;
        private Panel panel2;
        private ImageList imageList1;
        private TextBox textBox1;
        private ADETADET_sample.RBButton AddEventButton;
        private Button Employee_Button;
        private MonthCalendar monthCalendar1;
        public MonthCalendar DatePicker;
    }
}
