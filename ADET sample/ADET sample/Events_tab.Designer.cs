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
            label1 = new Label();
            AddEventButton = new ADETADET_sample.RBButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(221, 29);
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
            AddEventButton.Location = new Point(12, 573);
            AddEventButton.Margin = new Padding(2);
            AddEventButton.Name = "AddEventButton";
            AddEventButton.Size = new Size(958, 30);
            AddEventButton.TabIndex = 9;
            AddEventButton.Text = "Add Event";
            AddEventButton.TextColor = Color.White;
            AddEventButton.UseVisualStyleBackColor = false;
            AddEventButton.Click += AddEventButton_Click;
            // 
            // Events_tab
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(223, 232, 215);
            ClientSize = new Size(981, 614);
            Controls.Add(AddEventButton);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Events_tab";
            Text = "Events_tab";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ADETADET_sample.RBButton AddEventButton;
    }
}