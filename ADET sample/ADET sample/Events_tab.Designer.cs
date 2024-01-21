namespace ADET_sample
{
    partial class Events_tab
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label1 = new Label();
            AddEventButton = new ADETADET_sample.RBButton();
            UpcomingEventsData = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)UpcomingEventsData).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(15, 12);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(333, 43);
            label1.TabIndex = 1;
            label1.Text = "Upcoming Events";
            label1.Click += label1_Click;
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
            AddEventButton.ImageAlign = ContentAlignment.BottomCenter;
            AddEventButton.Location = new Point(15, 754);
            AddEventButton.Margin = new Padding(2, 3, 2, 3);
            AddEventButton.Name = "AddEventButton";
            AddEventButton.Size = new Size(1198, 39);
            AddEventButton.TabIndex = 9;
            AddEventButton.Text = "Add Event";
            AddEventButton.TextColor = Color.White;
            AddEventButton.UseVisualStyleBackColor = false;
            AddEventButton.Click += AddEventButton_Click;
            // 
            // UpcomingEventsData
            // 
            UpcomingEventsData.AllowUserToAddRows = false;
            UpcomingEventsData.AllowUserToDeleteRows = false;
            UpcomingEventsData.AllowUserToResizeColumns = false;
            UpcomingEventsData.AllowUserToResizeRows = false;
            UpcomingEventsData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            UpcomingEventsData.BackgroundColor = Color.FromArgb(106, 115, 93);
            UpcomingEventsData.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(28, 37, 14);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 15F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(28, 37, 14);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            UpcomingEventsData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            UpcomingEventsData.ColumnHeadersHeight = 60;
            UpcomingEventsData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(46, 60, 24);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(95, 122, 86);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            UpcomingEventsData.DefaultCellStyle = dataGridViewCellStyle2;
            UpcomingEventsData.EnableHeadersVisualStyles = false;
            UpcomingEventsData.GridColor = SystemColors.InactiveBorder;
            UpcomingEventsData.Location = new Point(24, 61);
            UpcomingEventsData.MultiSelect = false;
            UpcomingEventsData.Name = "UpcomingEventsData";
            UpcomingEventsData.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            UpcomingEventsData.RowHeadersVisible = false;
            UpcomingEventsData.RowHeadersWidth = 62;
            UpcomingEventsData.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            UpcomingEventsData.RowTemplate.Height = 50;
            UpcomingEventsData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            UpcomingEventsData.ShowEditingIcon = false;
            UpcomingEventsData.Size = new Size(1183, 690);
            UpcomingEventsData.TabIndex = 10;
            UpcomingEventsData.CellContentClick += UpcomingEventsData_CellContentClick;
            // 
            // Events_tab
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(223, 232, 215);
            ClientSize = new Size(1226, 808);
            Controls.Add(UpcomingEventsData);
            Controls.Add(AddEventButton);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Events_tab";
            Text = "Events_tab";
            ((System.ComponentModel.ISupportInitialize)UpcomingEventsData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ADETADET_sample.RBButton AddEventButton;
        private DataGridView UpcomingEventsData;
    }
}