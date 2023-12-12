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
            SuspendLayout();
            // 
            // btnMaintenance
            // 
            btnMaintenance.Location = new Point(12, 95);
            btnMaintenance.Name = "btnMaintenance";
            btnMaintenance.Size = new Size(203, 52);
            btnMaintenance.TabIndex = 0;
            btnMaintenance.Text = "Maintenance";
            btnMaintenance.UseVisualStyleBackColor = true;
            btnMaintenance.Click += btnMaintenance_Click;
            // 
            // btnDelivery
            // 
            btnDelivery.Location = new Point(12, 153);
            btnDelivery.Name = "btnDelivery";
            btnDelivery.Size = new Size(203, 52);
            btnDelivery.TabIndex = 1;
            btnDelivery.Text = "Delivery";
            btnDelivery.UseVisualStyleBackColor = true;
            // 
            // btnInventoryMonitoring
            // 
            btnInventoryMonitoring.Location = new Point(12, 211);
            btnInventoryMonitoring.Name = "btnInventoryMonitoring";
            btnInventoryMonitoring.Size = new Size(203, 52);
            btnInventoryMonitoring.TabIndex = 2;
            btnInventoryMonitoring.Text = "Inventory Monitoring";
            btnInventoryMonitoring.UseVisualStyleBackColor = true;
            // 
            // btnPointOfSales
            // 
            btnPointOfSales.Location = new Point(12, 269);
            btnPointOfSales.Name = "btnPointOfSales";
            btnPointOfSales.Size = new Size(203, 52);
            btnPointOfSales.TabIndex = 3;
            btnPointOfSales.Text = "Point Of Sales";
            btnPointOfSales.UseVisualStyleBackColor = true;
            // 
            // btnSalesMonitoring
            // 
            btnSalesMonitoring.Location = new Point(12, 327);
            btnSalesMonitoring.Name = "btnSalesMonitoring";
            btnSalesMonitoring.Size = new Size(203, 52);
            btnSalesMonitoring.TabIndex = 4;
            btnSalesMonitoring.Text = "Sales Monitoring";
            btnSalesMonitoring.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(707, 391);
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
    }
}