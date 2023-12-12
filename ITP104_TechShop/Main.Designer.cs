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
            SuspendLayout();
            // 
            // btnMaintenance
            // 
            btnMaintenance.Location = new Point(12, 12);
            btnMaintenance.Name = "btnMaintenance";
            btnMaintenance.Size = new Size(203, 52);
            btnMaintenance.TabIndex = 0;
            btnMaintenance.Text = "Maintenance";
            btnMaintenance.UseVisualStyleBackColor = true;
            btnMaintenance.Click += btnMaintenance_Click;
            // 
            // btnDelivery
            // 
            btnDelivery.Location = new Point(12, 70);
            btnDelivery.Name = "btnDelivery";
            btnDelivery.Size = new Size(203, 52);
            btnDelivery.TabIndex = 1;
            btnDelivery.Text = "Delivery";
            btnDelivery.UseVisualStyleBackColor = true;
            // 
            // btnInventoryMonitoring
            // 
            btnInventoryMonitoring.Location = new Point(12, 128);
            btnInventoryMonitoring.Name = "btnInventoryMonitoring";
            btnInventoryMonitoring.Size = new Size(203, 52);
            btnInventoryMonitoring.TabIndex = 2;
            btnInventoryMonitoring.Text = "Inventory Monitoring";
            btnInventoryMonitoring.UseVisualStyleBackColor = true;
            // 
            // btnPointOfSales
            // 
            btnPointOfSales.Location = new Point(232, 12);
            btnPointOfSales.Name = "btnPointOfSales";
            btnPointOfSales.Size = new Size(203, 52);
            btnPointOfSales.TabIndex = 3;
            btnPointOfSales.Text = "Point Of Sales";
            btnPointOfSales.UseVisualStyleBackColor = true;
            // 
            // btnSalesMonitoring
            // 
            btnSalesMonitoring.Location = new Point(232, 70);
            btnSalesMonitoring.Name = "btnSalesMonitoring";
            btnSalesMonitoring.Size = new Size(203, 52);
            btnSalesMonitoring.TabIndex = 4;
            btnSalesMonitoring.Text = "Sales Monitoring";
            btnSalesMonitoring.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(322, 186);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(113, 23);
            btnLogout.TabIndex = 18;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnDbBackup
            // 
            btnDbBackup.Location = new Point(232, 128);
            btnDbBackup.Name = "btnDbBackup";
            btnDbBackup.Size = new Size(203, 52);
            btnDbBackup.TabIndex = 19;
            btnDbBackup.Text = "Database Backup";
            btnDbBackup.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(445, 221);
            Controls.Add(btnDbBackup);
            Controls.Add(btnLogout);
            Controls.Add(btnSalesMonitoring);
            Controls.Add(btnPointOfSales);
            Controls.Add(btnInventoryMonitoring);
            Controls.Add(btnDelivery);
            Controls.Add(btnMaintenance);
            Name = "frmMain";
            Text = "Main";
            Load += main_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnMaintenance;
        private Button btnDelivery;
        private Button btnInventoryMonitoring;
        private Button btnPointOfSales;
        private Button btnSalesMonitoring;
        private Button btnLogout;
        private Button btnDbBackup;
    }
}