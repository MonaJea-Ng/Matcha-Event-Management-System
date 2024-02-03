namespace ADET_sample
{
    partial class Add_New_Employee
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
            cancel_btn = new ADETADET_sample.RBButton();
            add_btn = new ADETADET_sample.RBButton();
            new_rate_TB = new TextBox();
            new_work_TB = new TextBox();
            new_status_TB = new TextBox();
            new_lname_TB = new TextBox();
            new_fname_TB = new TextBox();
            new_empID_TB = new TextBox();
            new_rate = new Label();
            new_work = new Label();
            new_status = new Label();
            new_lname = new Label();
            new_fname = new Label();
            new_empID = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            New_Employee_label = new Label();
            SuspendLayout();
            // 
            // cancel_btn
            // 
            cancel_btn.BackColor = Color.FromArgb(46, 60, 24);
            cancel_btn.BackgroundColor = Color.FromArgb(46, 60, 24);
            cancel_btn.BorderColor = Color.PaleVioletRed;
            cancel_btn.BorderRadius = 8;
            cancel_btn.BorderSize = 0;
            cancel_btn.FlatAppearance.BorderSize = 0;
            cancel_btn.FlatStyle = FlatStyle.Flat;
            cancel_btn.ForeColor = Color.White;
            cancel_btn.ImageAlign = ContentAlignment.BottomCenter;
            cancel_btn.Location = new Point(358, 424);
            cancel_btn.Margin = new Padding(2);
            cancel_btn.Name = "cancel_btn";
            cancel_btn.Size = new Size(317, 38);
            cancel_btn.TabIndex = 46;
            cancel_btn.Text = "Cancel";
            cancel_btn.TextColor = Color.White;
            cancel_btn.UseVisualStyleBackColor = false;
            cancel_btn.Click += cancel_btn_Click;
            // 
            // add_btn
            // 
            add_btn.BackColor = Color.FromArgb(46, 60, 24);
            add_btn.BackgroundColor = Color.FromArgb(46, 60, 24);
            add_btn.BorderColor = Color.PaleVioletRed;
            add_btn.BorderRadius = 8;
            add_btn.BorderSize = 0;
            add_btn.FlatAppearance.BorderSize = 0;
            add_btn.FlatStyle = FlatStyle.Flat;
            add_btn.ForeColor = Color.White;
            add_btn.ImageAlign = ContentAlignment.BottomCenter;
            add_btn.Location = new Point(35, 424);
            add_btn.Margin = new Padding(2);
            add_btn.Name = "add_btn";
            add_btn.Size = new Size(317, 38);
            add_btn.TabIndex = 45;
            add_btn.Text = "Add";
            add_btn.TextColor = Color.White;
            add_btn.UseVisualStyleBackColor = false;
            add_btn.Click += add_btn_Click;
            // 
            // new_rate_TB
            // 
            new_rate_TB.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            new_rate_TB.Location = new Point(370, 332);
            new_rate_TB.Name = "new_rate_TB";
            new_rate_TB.Size = new Size(135, 29);
            new_rate_TB.TabIndex = 44;
            // 
            // new_work_TB
            // 
            new_work_TB.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            new_work_TB.Location = new Point(370, 285);
            new_work_TB.Name = "new_work_TB";
            new_work_TB.Size = new Size(266, 29);
            new_work_TB.TabIndex = 43;
            // 
            // new_status_TB
            // 
            new_status_TB.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            new_status_TB.Location = new Point(118, 285);
            new_status_TB.Name = "new_status_TB";
            new_status_TB.Size = new Size(163, 29);
            new_status_TB.TabIndex = 42;
            // 
            // new_lname_TB
            // 
            new_lname_TB.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            new_lname_TB.Location = new Point(359, 167);
            new_lname_TB.Name = "new_lname_TB";
            new_lname_TB.Size = new Size(213, 29);
            new_lname_TB.TabIndex = 41;
            // 
            // new_fname_TB
            // 
            new_fname_TB.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            new_fname_TB.Location = new Point(144, 167);
            new_fname_TB.Name = "new_fname_TB";
            new_fname_TB.Size = new Size(209, 29);
            new_fname_TB.TabIndex = 40;
            // 
            // new_empID_TB
            // 
            new_empID_TB.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            new_empID_TB.Location = new Point(221, 112);
            new_empID_TB.Name = "new_empID_TB";
            new_empID_TB.Size = new Size(266, 29);
            new_empID_TB.TabIndex = 39;
            // 
            // new_rate
            // 
            new_rate.AutoSize = true;
            new_rate.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            new_rate.Location = new Point(312, 332);
            new_rate.Name = "new_rate";
            new_rate.Size = new Size(61, 25);
            new_rate.TabIndex = 38;
            new_rate.Text = "Rate: ";
            // 
            // new_work
            // 
            new_work.AutoSize = true;
            new_work.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            new_work.Location = new Point(304, 285);
            new_work.Name = "new_work";
            new_work.Size = new Size(69, 25);
            new_work.TabIndex = 37;
            new_work.Text = "Work: ";
            // 
            // new_status
            // 
            new_status.AutoSize = true;
            new_status.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            new_status.Location = new Point(49, 285);
            new_status.Name = "new_status";
            new_status.Size = new Size(74, 25);
            new_status.TabIndex = 36;
            new_status.Text = "Status: ";
            // 
            // new_lname
            // 
            new_lname.AutoSize = true;
            new_lname.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            new_lname.Location = new Point(405, 199);
            new_lname.Name = "new_lname";
            new_lname.Size = new Size(103, 25);
            new_lname.TabIndex = 35;
            new_lname.Text = "Last Name";
            // 
            // new_fname
            // 
            new_fname.AutoSize = true;
            new_fname.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            new_fname.Location = new Point(194, 199);
            new_fname.Name = "new_fname";
            new_fname.Size = new Size(106, 25);
            new_fname.TabIndex = 34;
            new_fname.Text = "First Name";
            // 
            // new_empID
            // 
            new_empID.AutoSize = true;
            new_empID.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            new_empID.Location = new Point(84, 113);
            new_empID.Name = "new_empID";
            new_empID.Size = new Size(131, 25);
            new_empID.TabIndex = 33;
            new_empID.Text = "Employee ID: ";
            // 
            // label5
            // 
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.Location = new Point(690, 51);
            label5.Name = "label5";
            label5.Size = new Size(2, 422);
            label5.TabIndex = 31;
            // 
            // label4
            // 
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Location = new Point(13, 53);
            label4.Name = "label4";
            label4.Size = new Size(2, 422);
            label4.TabIndex = 30;
            // 
            // label3
            // 
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Location = new Point(13, 475);
            label3.Name = "label3";
            label3.Size = new Size(679, 2);
            label3.TabIndex = 29;
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Location = new Point(13, 51);
            label2.Name = "label2";
            label2.Size = new Size(679, 2);
            label2.TabIndex = 28;
            // 
            // label1
            // 
            label1.Location = new Point(471, 235);
            label1.Name = "label1";
            label1.Size = new Size(100, 3);
            label1.TabIndex = 27;
            // 
            // New_Employee_label
            // 
            New_Employee_label.AutoSize = true;
            New_Employee_label.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            New_Employee_label.Location = new Point(13, 8);
            New_Employee_label.Name = "New_Employee_label";
            New_Employee_label.Size = new Size(268, 32);
            New_Employee_label.TabIndex = 26;
            New_Employee_label.Text = "New Employee Details";
            // 
            // Add_New_Employee
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(223, 232, 215);
            ClientSize = new Size(706, 486);
            Controls.Add(cancel_btn);
            Controls.Add(add_btn);
            Controls.Add(new_rate_TB);
            Controls.Add(new_work_TB);
            Controls.Add(new_status_TB);
            Controls.Add(new_lname_TB);
            Controls.Add(new_fname_TB);
            Controls.Add(new_empID_TB);
            Controls.Add(new_rate);
            Controls.Add(new_work);
            Controls.Add(new_status);
            Controls.Add(new_lname);
            Controls.Add(new_fname);
            Controls.Add(new_empID);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(New_Employee_label);
            Name = "Add_New_Employee";
            Text = "Add New Employee";
            Load += Add_New_Employee_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ADETADET_sample.RBButton cancel_btn;
        private ADETADET_sample.RBButton add_btn;
        private TextBox new_rate_TB;
        private TextBox new_work_TB;
        private TextBox new_status_TB;
        private TextBox new_lname_TB;
        private TextBox new_fname_TB;
        private TextBox new_empID_TB;
        private Label new_rate;
        private Label new_work;
        private Label new_status;
        private Label new_lname;
        private Label new_fname;
        private Label new_empID;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label New_Employee_label;
    }
}