namespace ADET_sample
{
    partial class Employees_tab
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label1 = new Label();
            AddEventButton = new ADETADET_sample.RBButton();
            Employees_List_Datagrid = new DataGridView();
            employee_id = new DataGridViewTextBoxColumn();
            firstname = new DataGridViewTextBoxColumn();
            lastname = new DataGridViewTextBoxColumn();
            status = new DataGridViewTextBoxColumn();
            work = new DataGridViewTextBoxColumn();
            rate = new DataGridViewTextBoxColumn();
            edit_button = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)Employees_List_Datagrid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(192, 29);
            label1.TabIndex = 0;
            label1.Text = "Employees List";
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
            AddEventButton.Location = new Point(11, 573);
            AddEventButton.Margin = new Padding(2);
            AddEventButton.Name = "AddEventButton";
            AddEventButton.Size = new Size(958, 30);
            AddEventButton.TabIndex = 10;
            AddEventButton.Text = "Add New Employee";
            AddEventButton.TextColor = Color.White;
            AddEventButton.UseVisualStyleBackColor = false;
            // 
            // Employees_List_Datagrid
            // 
            Employees_List_Datagrid.AllowUserToAddRows = false;
            Employees_List_Datagrid.AllowUserToDeleteRows = false;
            Employees_List_Datagrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Employees_List_Datagrid.BackgroundColor = Color.FromArgb(223, 232, 215);
            Employees_List_Datagrid.BorderStyle = BorderStyle.None;
            Employees_List_Datagrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Employees_List_Datagrid.Columns.AddRange(new DataGridViewColumn[] { employee_id, firstname, lastname, status, work, rate, edit_button });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(223, 232, 215);
            dataGridViewCellStyle4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(46, 60, 24);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            Employees_List_Datagrid.DefaultCellStyle = dataGridViewCellStyle4;
            Employees_List_Datagrid.GridColor = Color.FromArgb(46, 60, 24);
            Employees_List_Datagrid.Location = new Point(30, 56);
            Employees_List_Datagrid.Name = "Employees_List_Datagrid";
            Employees_List_Datagrid.Size = new Size(918, 498);
            Employees_List_Datagrid.TabIndex = 11;
            // 
            // employee_id
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(223, 232, 215);
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            employee_id.DefaultCellStyle = dataGridViewCellStyle3;
            employee_id.HeaderText = "Employee ID";
            employee_id.Name = "employee_id";
            // 
            // firstname
            // 
            firstname.HeaderText = "First Name";
            firstname.Name = "firstname";
            // 
            // lastname
            // 
            lastname.HeaderText = "Last Name";
            lastname.Name = "lastname";
            // 
            // status
            // 
            status.HeaderText = "Status";
            status.Name = "status";
            // 
            // work
            // 
            work.HeaderText = "Work";
            work.Name = "work";
            // 
            // rate
            // 
            rate.HeaderText = "Rate";
            rate.Name = "rate";
            // 
            // edit_button
            // 
            edit_button.HeaderText = "Edit";
            edit_button.Name = "edit_button";
            // 
            // Employees_tab
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(223, 232, 215);
            ClientSize = new Size(981, 614);
            Controls.Add(Employees_List_Datagrid);
            Controls.Add(AddEventButton);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Employees_tab";
            Text = "Employees_tab";
            Load += Employees_tab_Load;
            ((System.ComponentModel.ISupportInitialize)Employees_List_Datagrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ADETADET_sample.RBButton AddEventButton;
        private DataGridView Employees_List_Datagrid;
        private DataGridViewTextBoxColumn employee_id;
        private DataGridViewTextBoxColumn firstname;
        private DataGridViewTextBoxColumn lastname;
        private DataGridViewTextBoxColumn status;
        private DataGridViewTextBoxColumn work;
        private DataGridViewTextBoxColumn rate;
        private DataGridViewButtonColumn edit_button;
    }
}