namespace ADET_sample
{
    partial class Edit_Employee_Row
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
            Employee_Info_label = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            done_btn = new ADETADET_sample.RBButton();
            empID = new Label();
            fname = new Label();
            lname = new Label();
            status = new Label();
            work = new Label();
            rate = new Label();
            empID_TB = new TextBox();
            fname_TB = new TextBox();
            lname_TB = new TextBox();
            status_TB = new TextBox();
            work_TB = new TextBox();
            rate_TB = new TextBox();
            edit_btn = new ADETADET_sample.RBButton();
            delete_btn = new ADETADET_sample.RBButton();
            SuspendLayout();
            // 
            // Employee_Info_label
            // 
            Employee_Info_label.AutoSize = true;
            Employee_Info_label.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Employee_Info_label.Location = new Point(12, 9);
            Employee_Info_label.Name = "Employee_Info_label";
            Employee_Info_label.Size = new Size(270, 32);
            Employee_Info_label.TabIndex = 0;
            Employee_Info_label.Text = "Employee Information";
            // 
            // label1
            // 
            label1.Location = new Point(470, 236);
            label1.Name = "label1";
            label1.Size = new Size(100, 3);
            label1.TabIndex = 1;
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Location = new Point(12, 52);
            label2.Name = "label2";
            label2.Size = new Size(679, 2);
            label2.TabIndex = 2;
            // 
            // label3
            // 
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Location = new Point(12, 430);
            label3.Name = "label3";
            label3.Size = new Size(679, 2);
            label3.TabIndex = 3;
            // 
            // label4
            // 
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Location = new Point(12, 54);
            label4.Name = "label4";
            label4.Size = new Size(2, 376);
            label4.TabIndex = 4;
            // 
            // label5
            // 
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.Location = new Point(689, 52);
            label5.Name = "label5";
            label5.Size = new Size(2, 378);
            label5.TabIndex = 5;
            // 
            // done_btn
            // 
            done_btn.BackColor = Color.FromArgb(46, 60, 24);
            done_btn.BackgroundColor = Color.FromArgb(46, 60, 24);
            done_btn.BorderColor = Color.PaleVioletRed;
            done_btn.BorderRadius = 8;
            done_btn.BorderSize = 0;
            done_btn.FlatAppearance.BorderSize = 0;
            done_btn.FlatStyle = FlatStyle.Flat;
            done_btn.ForeColor = Color.White;
            done_btn.ImageAlign = ContentAlignment.BottomCenter;
            done_btn.Location = new Point(12, 440);
            done_btn.Margin = new Padding(2);
            done_btn.Name = "done_btn";
            done_btn.Size = new Size(680, 38);
            done_btn.TabIndex = 11;
            done_btn.Text = "Done";
            done_btn.TextColor = Color.White;
            done_btn.UseVisualStyleBackColor = false;
            done_btn.Click += done_btn_Click;
            // 
            // empID
            // 
            empID.AutoSize = true;
            empID.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            empID.Location = new Point(82, 90);
            empID.Name = "empID";
            empID.Size = new Size(131, 25);
            empID.TabIndex = 12;
            empID.Text = "Employee ID: ";
            // 
            // fname
            // 
            fname.AutoSize = true;
            fname.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            fname.Location = new Point(192, 176);
            fname.Name = "fname";
            fname.Size = new Size(106, 25);
            fname.TabIndex = 13;
            fname.Text = "First Name";
            // 
            // lname
            // 
            lname.AutoSize = true;
            lname.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lname.Location = new Point(403, 176);
            lname.Name = "lname";
            lname.Size = new Size(103, 25);
            lname.TabIndex = 14;
            lname.Text = "Last Name";
            // 
            // status
            // 
            status.AutoSize = true;
            status.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            status.Location = new Point(50, 265);
            status.Name = "status";
            status.Size = new Size(74, 25);
            status.TabIndex = 15;
            status.Text = "Status: ";
            // 
            // work
            // 
            work.AutoSize = true;
            work.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            work.Location = new Point(305, 265);
            work.Name = "work";
            work.Size = new Size(69, 25);
            work.TabIndex = 16;
            work.Text = "Work: ";
            // 
            // rate
            // 
            rate.AutoSize = true;
            rate.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rate.Location = new Point(313, 312);
            rate.Name = "rate";
            rate.Size = new Size(61, 25);
            rate.TabIndex = 17;
            rate.Text = "Rate: ";
            // 
            // empID_TB
            // 
            empID_TB.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            empID_TB.Location = new Point(219, 89);
            empID_TB.Name = "empID_TB";
            empID_TB.ReadOnly = true;
            empID_TB.Size = new Size(266, 29);
            empID_TB.TabIndex = 18;
            // 
            // fname_TB
            // 
            fname_TB.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            fname_TB.Location = new Point(142, 144);
            fname_TB.Name = "fname_TB";
            fname_TB.ReadOnly = true;
            fname_TB.Size = new Size(209, 29);
            fname_TB.TabIndex = 19;
            fname_TB.TextAlign = HorizontalAlignment.Center;
            // 
            // lname_TB
            // 
            lname_TB.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lname_TB.Location = new Point(357, 144);
            lname_TB.Name = "lname_TB";
            lname_TB.ReadOnly = true;
            lname_TB.Size = new Size(213, 29);
            lname_TB.TabIndex = 20;
            lname_TB.TextAlign = HorizontalAlignment.Center;
            // 
            // status_TB
            // 
            status_TB.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            status_TB.Location = new Point(119, 265);
            status_TB.Name = "status_TB";
            status_TB.ReadOnly = true;
            status_TB.Size = new Size(163, 29);
            status_TB.TabIndex = 21;
            // 
            // work_TB
            // 
            work_TB.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            work_TB.Location = new Point(371, 265);
            work_TB.Name = "work_TB";
            work_TB.ReadOnly = true;
            work_TB.Size = new Size(266, 29);
            work_TB.TabIndex = 22;
            // 
            // rate_TB
            // 
            rate_TB.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rate_TB.Location = new Point(371, 312);
            rate_TB.Name = "rate_TB";
            rate_TB.ReadOnly = true;
            rate_TB.Size = new Size(135, 29);
            rate_TB.TabIndex = 23;
            // 
            // edit_btn
            // 
            edit_btn.BackColor = Color.FromArgb(46, 60, 24);
            edit_btn.BackgroundColor = Color.FromArgb(46, 60, 24);
            edit_btn.BorderColor = Color.PaleVioletRed;
            edit_btn.BorderRadius = 8;
            edit_btn.BorderSize = 0;
            edit_btn.FlatAppearance.BorderSize = 0;
            edit_btn.FlatStyle = FlatStyle.Flat;
            edit_btn.ForeColor = Color.White;
            edit_btn.ImageAlign = ContentAlignment.BottomCenter;
            edit_btn.Location = new Point(34, 381);
            edit_btn.Margin = new Padding(2);
            edit_btn.Name = "edit_btn";
            edit_btn.Size = new Size(317, 38);
            edit_btn.TabIndex = 24;
            edit_btn.Text = "Edit";
            edit_btn.TextColor = Color.White;
            edit_btn.UseVisualStyleBackColor = false;
            edit_btn.Click += edit_btn_Click;
            // 
            // delete_btn
            // 
            delete_btn.BackColor = Color.Firebrick;
            delete_btn.BackgroundColor = Color.Firebrick;
            delete_btn.BorderColor = Color.PaleVioletRed;
            delete_btn.BorderRadius = 8;
            delete_btn.BorderSize = 0;
            delete_btn.FlatAppearance.BorderSize = 0;
            delete_btn.FlatStyle = FlatStyle.Flat;
            delete_btn.ForeColor = Color.White;
            delete_btn.ImageAlign = ContentAlignment.BottomCenter;
            delete_btn.Location = new Point(357, 381);
            delete_btn.Margin = new Padding(2);
            delete_btn.Name = "delete_btn";
            delete_btn.Size = new Size(317, 38);
            delete_btn.TabIndex = 25;
            delete_btn.Text = "Delete";
            delete_btn.TextColor = Color.White;
            delete_btn.UseVisualStyleBackColor = false;
            delete_btn.Click += delete_btn_Click;
            // 
            // Edit_Employee_Row
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(223, 232, 215);
            ClientSize = new Size(703, 486);
            Controls.Add(delete_btn);
            Controls.Add(edit_btn);
            Controls.Add(rate_TB);
            Controls.Add(work_TB);
            Controls.Add(status_TB);
            Controls.Add(lname_TB);
            Controls.Add(fname_TB);
            Controls.Add(empID_TB);
            Controls.Add(rate);
            Controls.Add(work);
            Controls.Add(status);
            Controls.Add(lname);
            Controls.Add(fname);
            Controls.Add(empID);
            Controls.Add(done_btn);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Employee_Info_label);
            Name = "Edit_Employee_Row";
            Text = "Edit Employee";
            Load += Edit_Employee_Row_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Employee_Info_label;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ADETADET_sample.RBButton done_btn;
        private Label empID;
        private Label fname;
        private Label lname;
        private Label status;
        private Label work;
        private Label rate;
        private TextBox empID_TB;
        private TextBox fname_TB;
        private TextBox lname_TB;
        private TextBox status_TB;
        private TextBox work_TB;
        private TextBox rate_TB;
        private ADETADET_sample.RBButton edit_btn;
        private ADETADET_sample.RBButton delete_btn;
    }
}