namespace ITP104_TechShop
{
    partial class frmMain
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
            btnMaintenance = new Button();
            btnDelivery = new Button();
            btnInventoryMonitoring = new Button();
            btnPointOfSales = new Button();
            btnSalesMonitoring = new Button();
            btnLogout = new Button();
            btnDbBackup = new Button();
            panel1 = new Panel();
            panel5 = new Panel();
            label3 = new Label();
            label4 = new Label();
            panel4 = new Panel();
            button1 = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            label2 = new Label();
            label1 = new Label();
            label7 = new Label();
            panel6 = new Panel();
            label6 = new Label();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // btnMaintenance
            // 
            btnMaintenance.FlatAppearance.BorderSize = 0;
            btnMaintenance.FlatStyle = FlatStyle.Flat;
            btnMaintenance.Font = new Font("Century Gothic", 9F);
            btnMaintenance.ForeColor = Color.White;
            btnMaintenance.Location = new Point(0, 302);
            btnMaintenance.Name = "btnMaintenance";
            btnMaintenance.Size = new Size(142, 43);
            btnMaintenance.TabIndex = 0;
            btnMaintenance.Text = "Maintenance";
            btnMaintenance.UseVisualStyleBackColor = true;
            btnMaintenance.Click += btnMaintenance_Click;
            // 
            // btnDelivery
            // 
            btnDelivery.FlatAppearance.BorderSize = 0;
            btnDelivery.FlatStyle = FlatStyle.Flat;
            btnDelivery.Font = new Font("Century Gothic", 9F);
            btnDelivery.ForeColor = Color.White;
            btnDelivery.Location = new Point(0, 155);
            btnDelivery.Name = "btnDelivery";
            btnDelivery.Size = new Size(142, 43);
            btnDelivery.TabIndex = 1;
            btnDelivery.Text = "Delivery";
            btnDelivery.UseVisualStyleBackColor = true;
            btnDelivery.Click += btnDelivery_Click;
            // 
            // btnInventoryMonitoring
            // 
            btnInventoryMonitoring.FlatAppearance.BorderSize = 0;
            btnInventoryMonitoring.FlatStyle = FlatStyle.Flat;
            btnInventoryMonitoring.Font = new Font("Century Gothic", 9F);
            btnInventoryMonitoring.ForeColor = Color.White;
            btnInventoryMonitoring.Location = new Point(0, 253);
            btnInventoryMonitoring.Name = "btnInventoryMonitoring";
            btnInventoryMonitoring.Size = new Size(142, 43);
            btnInventoryMonitoring.TabIndex = 2;
            btnInventoryMonitoring.Text = "Inventory";
            btnInventoryMonitoring.UseVisualStyleBackColor = true;
            btnInventoryMonitoring.Click += btnInventoryMonitoring_Click;
            // 
            // btnPointOfSales
            // 
            btnPointOfSales.FlatAppearance.BorderSize = 0;
            btnPointOfSales.FlatStyle = FlatStyle.Flat;
            btnPointOfSales.Font = new Font("Century Gothic", 9F);
            btnPointOfSales.ForeColor = Color.White;
            btnPointOfSales.Location = new Point(0, 106);
            btnPointOfSales.Name = "btnPointOfSales";
            btnPointOfSales.Size = new Size(142, 43);
            btnPointOfSales.TabIndex = 3;
            btnPointOfSales.Text = "Point Of Sales";
            btnPointOfSales.UseVisualStyleBackColor = true;
            btnPointOfSales.Click += btnPointOfSales_Click;
            // 
            // btnSalesMonitoring
            // 
            btnSalesMonitoring.FlatAppearance.BorderSize = 0;
            btnSalesMonitoring.FlatStyle = FlatStyle.Flat;
            btnSalesMonitoring.Font = new Font("Century Gothic", 9F);
            btnSalesMonitoring.ForeColor = Color.White;
            btnSalesMonitoring.Location = new Point(0, 204);
            btnSalesMonitoring.Name = "btnSalesMonitoring";
            btnSalesMonitoring.Size = new Size(142, 43);
            btnSalesMonitoring.TabIndex = 4;
            btnSalesMonitoring.Text = "Sales";
            btnSalesMonitoring.UseVisualStyleBackColor = true;
            btnSalesMonitoring.Click += btnSalesMonitoring_Click;
            // 
            // btnLogout
            // 
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.IndianRed;
            btnLogout.Location = new Point(0, 513);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(142, 43);
            btnLogout.TabIndex = 18;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnDbBackup
            // 
            btnDbBackup.FlatAppearance.BorderSize = 0;
            btnDbBackup.FlatStyle = FlatStyle.Flat;
            btnDbBackup.Font = new Font("Century Gothic", 9F);
            btnDbBackup.ForeColor = Color.White;
            btnDbBackup.Location = new Point(0, 351);
            btnDbBackup.Name = "btnDbBackup";
            btnDbBackup.Size = new Size(142, 43);
            btnDbBackup.TabIndex = 19;
            btnDbBackup.Text = "Database Backup";
            btnDbBackup.UseVisualStyleBackColor = true;
            btnDbBackup.Click += btnDbBackup_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(33, 33, 33);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnMaintenance);
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(btnDbBackup);
            panel1.Controls.Add(btnDelivery);
            panel1.Controls.Add(btnInventoryMonitoring);
            panel1.Controls.Add(btnSalesMonitoring);
            panel1.Controls.Add(btnPointOfSales);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(142, 556);
            panel1.TabIndex = 20;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(0, 137, 123);
            panel5.Controls.Add(label3);
            panel5.Controls.Add(label4);
            panel5.Location = new Point(142, 172);
            panel5.Name = "panel5";
            panel5.Size = new Size(741, 260);
            panel5.TabIndex = 23;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(49, 130);
            label3.Name = "label3";
            label3.Size = new Size(205, 44);
            label3.TabIndex = 1;
            label3.Text = "Tech Shop";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(34, 43);
            label4.Name = "label4";
            label4.Size = new Size(432, 77);
            label4.TabIndex = 0;
            label4.Text = "GamersUnite";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(0, 137, 123);
            panel4.Location = new Point(0, 57);
            panel4.Name = "panel4";
            panel4.Size = new Size(10, 43);
            panel4.TabIndex = 23;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 9F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(0, 57);
            button1.Name = "button1";
            button1.Size = new Size(142, 43);
            button1.TabIndex = 20;
            button1.Text = "Home";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 137, 123);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(142, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(741, 10);
            panel2.TabIndex = 21;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 137, 123);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(176, 1);
            panel3.Name = "panel3";
            panel3.Size = new Size(107, 99);
            panel3.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 45);
            label2.Name = "label2";
            label2.Size = new Size(69, 17);
            label2.TabIndex = 1;
            label2.Text = "Tech Shop";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(1, 27);
            label1.Name = "label1";
            label1.Size = new Size(103, 18);
            label1.TabIndex = 0;
            label1.Text = "GamersUnite";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(315, 38);
            label7.Name = "label7";
            label7.Size = new Size(162, 32);
            label7.TabIndex = 29;
            label7.Text = "Homepage";
            // 
            // panel6
            // 
            panel6.BackColor = Color.Firebrick;
            panel6.Controls.Add(label6);
            panel6.Location = new Point(688, 172);
            panel6.Name = "panel6";
            panel6.Size = new Size(107, 191);
            panel6.TabIndex = 23;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(28, 6);
            label6.Name = "label6";
            label6.Size = new Size(50, 162);
            label6.TabIndex = 0;
            label6.Text = "C\r\nH\r\nE\r\nC\r\nK\r\nO\r\nU\r\nT\r\nNOW!";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(66, 66, 66);
            ClientSize = new Size(883, 556);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(label7);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main";
            Load += main_Load;
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMaintenance;
        private Button btnDelivery;
        private Button btnInventoryMonitoring;
        private Button btnPointOfSales;
        private Button btnSalesMonitoring;
        private Button btnLogout;
        private Button btnDbBackup;
        private Panel panel1;
        private Button button1;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private Label label2;
        private Panel panel4;
        private Label label7;
        private Panel panel5;
        private Label label3;
        private Label label4;
        private Panel panel6;
        private Label label6;
    }
}