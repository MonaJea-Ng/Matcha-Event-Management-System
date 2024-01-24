namespace ADET_sample
{
    partial class Services_tab
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
            label_Packages = new Label();
            label_Addons = new Label();
            Packages_List_DataGrid = new DataGridView();
            Addons_List_DataGrid = new DataGridView();
            SaveAddonButton = new ADETADET_sample.RBButton();
            SavePackageBtn = new ADETADET_sample.RBButton();
            ((System.ComponentModel.ISupportInitialize)Packages_List_DataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Addons_List_DataGrid).BeginInit();
            SuspendLayout();
            // 
            // label_Packages
            // 
            label_Packages.AutoSize = true;
            label_Packages.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Packages.Location = new Point(26, 20);
            label_Packages.Name = "label_Packages";
            label_Packages.Size = new Size(157, 36);
            label_Packages.TabIndex = 2;
            label_Packages.Text = "Packages";
            label_Packages.Click += label1_Click;
            // 
            // label_Addons
            // 
            label_Addons.AutoSize = true;
            label_Addons.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Addons.Location = new Point(26, 305);
            label_Addons.Name = "label_Addons";
            label_Addons.Size = new Size(127, 36);
            label_Addons.TabIndex = 4;
            label_Addons.Text = "Addons";
            label_Addons.Click += label2_Click;
            // 
            // Packages_List_DataGrid
            // 
            Packages_List_DataGrid.AllowUserToResizeRows = false;
            Packages_List_DataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Packages_List_DataGrid.BackgroundColor = Color.FromArgb(223, 232, 215);
            Packages_List_DataGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            Packages_List_DataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Packages_List_DataGrid.GridColor = Color.FromArgb(46, 60, 24);
            Packages_List_DataGrid.Location = new Point(36, 70);
            Packages_List_DataGrid.Name = "Packages_List_DataGrid";
            Packages_List_DataGrid.RowHeadersWidth = 51;
            Packages_List_DataGrid.Size = new Size(876, 214);
            Packages_List_DataGrid.TabIndex = 5;
            Packages_List_DataGrid.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Addons_List_DataGrid
            // 
            Addons_List_DataGrid.AllowUserToResizeRows = false;
            Addons_List_DataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Addons_List_DataGrid.BackgroundColor = Color.FromArgb(223, 232, 215);
            Addons_List_DataGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            Addons_List_DataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Addons_List_DataGrid.GridColor = Color.FromArgb(46, 60, 24);
            Addons_List_DataGrid.Location = new Point(36, 353);
            Addons_List_DataGrid.Name = "Addons_List_DataGrid";
            Addons_List_DataGrid.RowHeadersWidth = 51;
            Addons_List_DataGrid.Size = new Size(876, 224);
            Addons_List_DataGrid.TabIndex = 6;
            // 
            // SaveAddonButton
            // 
            SaveAddonButton.BackColor = Color.FromArgb(46, 60, 24);
            SaveAddonButton.BackgroundColor = Color.FromArgb(46, 60, 24);
            SaveAddonButton.BorderColor = Color.PaleVioletRed;
            SaveAddonButton.BorderRadius = 8;
            SaveAddonButton.BorderSize = 0;
            SaveAddonButton.FlatAppearance.BorderSize = 0;
            SaveAddonButton.FlatStyle = FlatStyle.Flat;
            SaveAddonButton.ForeColor = Color.White;
            SaveAddonButton.ImageAlign = ContentAlignment.BottomCenter;
            SaveAddonButton.Location = new Point(599, 313);
            SaveAddonButton.Margin = new Padding(2);
            SaveAddonButton.Name = "SaveAddonButton";
            SaveAddonButton.Size = new Size(313, 32);
            SaveAddonButton.TabIndex = 11;
            SaveAddonButton.Text = "Save Addon Changes";
            SaveAddonButton.TextColor = Color.White;
            SaveAddonButton.UseVisualStyleBackColor = false;
            // 
            // SavePackageBtn
            // 
            SavePackageBtn.BackColor = Color.FromArgb(46, 60, 24);
            SavePackageBtn.BackgroundColor = Color.FromArgb(46, 60, 24);
            SavePackageBtn.BorderColor = Color.PaleVioletRed;
            SavePackageBtn.BorderRadius = 8;
            SavePackageBtn.BorderSize = 0;
            SavePackageBtn.FlatAppearance.BorderSize = 0;
            SavePackageBtn.FlatStyle = FlatStyle.Flat;
            SavePackageBtn.ForeColor = Color.White;
            SavePackageBtn.ImageAlign = ContentAlignment.BottomCenter;
            SavePackageBtn.Location = new Point(599, 28);
            SavePackageBtn.Margin = new Padding(2);
            SavePackageBtn.Name = "SavePackageBtn";
            SavePackageBtn.Size = new Size(313, 32);
            SavePackageBtn.TabIndex = 12;
            SavePackageBtn.Text = "Save Package Changes";
            SavePackageBtn.TextColor = Color.White;
            SavePackageBtn.UseVisualStyleBackColor = false;
            SavePackageBtn.Click += SavePackageBtn_Click;
            // 
            // Services_tab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(223, 232, 215);
            ClientSize = new Size(965, 605);
            Controls.Add(SavePackageBtn);
            Controls.Add(SaveAddonButton);
            Controls.Add(Addons_List_DataGrid);
            Controls.Add(Packages_List_DataGrid);
            Controls.Add(label_Addons);
            Controls.Add(label_Packages);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Services_tab";
            Text = "Services_tab";
            Load += Services_tab_Load;
            ((System.ComponentModel.ISupportInitialize)Packages_List_DataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)Addons_List_DataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_Packages;
        private Label label_Addons;
        private DataGridView Packages_List_DataGrid;
        private DataGridView Addons_List_DataGrid;
        private ADETADET_sample.RBButton SaveAddonButton;
        private ADETADET_sample.RBButton SavePackageBtn;
    }
}