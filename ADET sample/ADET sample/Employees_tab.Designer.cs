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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employees_tab));
            label1 = new Label();
            AddEventButton = new ADETADET_sample.RBButton();
            Employees_List_Datagrid = new DataGridView();
            employee_id = new DataGridViewTextBoxColumn();
            firstname = new DataGridViewTextBoxColumn();
            lastname = new DataGridViewTextBoxColumn();
            status = new DataGridViewTextBoxColumn();
            work = new DataGridViewTextBoxColumn();
            rate = new DataGridViewTextBoxColumn();
            edit_button_image = new DataGridViewImageColumn();
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
            Employees_List_Datagrid.AllowUserToResizeColumns = false;
            Employees_List_Datagrid.AllowUserToResizeRows = false;
            Employees_List_Datagrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Employees_List_Datagrid.BackgroundColor = Color.FromArgb(223, 232, 215);
            Employees_List_Datagrid.BorderStyle = BorderStyle.None;
            Employees_List_Datagrid.CellBorderStyle = DataGridViewCellBorderStyle.None;
            Employees_List_Datagrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(46, 60, 24);
            dataGridViewCellStyle1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(223, 232, 215);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlText;
            Employees_List_Datagrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            Employees_List_Datagrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Employees_List_Datagrid.Columns.AddRange(new DataGridViewColumn[] { employee_id, firstname, lastname, status, work, rate, edit_button_image });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(223, 232, 215);
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(46, 60, 24);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            Employees_List_Datagrid.DefaultCellStyle = dataGridViewCellStyle3;
            Employees_List_Datagrid.EnableHeadersVisualStyles = false;
            Employees_List_Datagrid.GridColor = Color.FromArgb(46, 60, 24);
            Employees_List_Datagrid.Location = new Point(30, 56);
            Employees_List_Datagrid.Name = "Employees_List_Datagrid";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(46, 60, 24);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10.5F);
            dataGridViewCellStyle4.ForeColor = SystemColors.Window;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            Employees_List_Datagrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            Employees_List_Datagrid.RowHeadersVisible = false;
            Employees_List_Datagrid.SelectionMode = DataGridViewSelectionMode.CellSelect;
            Employees_List_Datagrid.Size = new Size(918, 498);
            Employees_List_Datagrid.TabIndex = 11;
            Employees_List_Datagrid.CellContentClick += Employees_List_Datagrid_CellContentClick;
            // 
            // employee_id
            // 
            employee_id.DataPropertyName = "employee_id";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(223, 232, 215);
            dataGridViewCellStyle2.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            employee_id.DefaultCellStyle = dataGridViewCellStyle2;
            employee_id.HeaderText = "Employee ID";
            employee_id.Name = "employee_id";
            // 
            // firstname
            // 
            firstname.DataPropertyName = "first_name";
            firstname.HeaderText = "First Name";
            firstname.Name = "firstname";
            // 
            // lastname
            // 
            lastname.DataPropertyName = "last_name";
            lastname.HeaderText = "Last Name";
            lastname.Name = "lastname";
            // 
            // status
            // 
            status.DataPropertyName = "status";
            status.HeaderText = "Status";
            status.Name = "status";
            // 
            // work
            // 
            work.DataPropertyName = "Work";
            work.HeaderText = "Work";
            work.Name = "work";
            // 
            // rate
            // 
            rate.DataPropertyName = "Rate";
            rate.HeaderText = "Rate";
            rate.Name = "rate";
            // 
            // edit_button_image
            // 
            edit_button_image.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            edit_button_image.HeaderText = "";
            edit_button_image.Image = (Image)resources.GetObject("edit_button_image.Image");
            edit_button_image.Name = "edit_button_image";
            edit_button_image.Width = 5;
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
        private DataGridViewImageColumn edit_button_image;
    }
}