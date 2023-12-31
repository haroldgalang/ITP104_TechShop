namespace ITP104_TechShop
{
    partial class frmDelivery
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
            dgvDelivery = new DataGridView();
            dateTimePicker1 = new DateTimePicker();
            nudQuantity = new NumericUpDown();
            label1 = new Label();
            lblItemName = new Label();
            lblItemIdGetter = new Label();
            label4 = new Label();
            label5 = new Label();
            btnDeliver = new Button();
            label6 = new Label();
            btnHome = new Button();
            panel1 = new Panel();
            panel4 = new Panel();
            btnMaintenance = new Button();
            btnLogout = new Button();
            btnDbBackup = new Button();
            btnDelivery = new Button();
            btnInventoryMonitoring = new Button();
            btnSalesMonitoring = new Button();
            btnPointOfSales = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            label2 = new Label();
            label3 = new Label();
            panel5 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvDelivery).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // dgvDelivery
            // 
            dgvDelivery.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDelivery.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDelivery.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvDelivery.Location = new Point(158, 289);
            dgvDelivery.Name = "dgvDelivery";
            dgvDelivery.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDelivery.Size = new Size(711, 201);
            dgvDelivery.TabIndex = 0;
            dgvDelivery.CellClick += dgvDelivery_CellClick;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(69, 74);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(195, 23);
            dateTimePicker1.TabIndex = 2;
            // 
            // nudQuantity
            // 
            nudQuantity.Location = new Point(92, 111);
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(172, 23);
            nudQuantity.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(19, 17);
            label1.Name = "label1";
            label1.Size = new Size(100, 17);
            label1.TabIndex = 5;
            label1.Text = "Selected Item:";
            // 
            // lblItemName
            // 
            lblItemName.AutoEllipsis = true;
            lblItemName.AutoSize = true;
            lblItemName.Font = new Font("Century Gothic", 9.75F);
            lblItemName.ForeColor = Color.White;
            lblItemName.Location = new Point(125, 17);
            lblItemName.Name = "lblItemName";
            lblItemName.Size = new Size(14, 17);
            lblItemName.TabIndex = 6;
            lblItemName.Text = "/";
            // 
            // lblItemIdGetter
            // 
            lblItemIdGetter.AutoSize = true;
            lblItemIdGetter.Font = new Font("Century Gothic", 9.75F);
            lblItemIdGetter.ForeColor = Color.White;
            lblItemIdGetter.Location = new Point(83, 46);
            lblItemIdGetter.Name = "lblItemIdGetter";
            lblItemIdGetter.Size = new Size(14, 17);
            lblItemIdGetter.TabIndex = 7;
            lblItemIdGetter.Text = "/";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9.75F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(19, 77);
            label4.Name = "label4";
            label4.Size = new Size(44, 17);
            label4.TabIndex = 8;
            label4.Text = "Date:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9.75F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(19, 115);
            label5.Name = "label5";
            label5.Size = new Size(67, 17);
            label5.TabIndex = 9;
            label5.Text = "Quantity:";
            // 
            // btnDeliver
            // 
            btnDeliver.BackColor = Color.FromArgb(0, 137, 123);
            btnDeliver.FlatAppearance.BorderSize = 0;
            btnDeliver.FlatStyle = FlatStyle.Flat;
            btnDeliver.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeliver.ForeColor = Color.White;
            btnDeliver.Location = new Point(292, 74);
            btnDeliver.Name = "btnDeliver";
            btnDeliver.Size = new Size(224, 60);
            btnDeliver.TabIndex = 10;
            btnDeliver.Text = "Deliver";
            btnDeliver.UseVisualStyleBackColor = false;
            btnDeliver.Click += btnDeliver_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 9.75F);
            label6.ForeColor = Color.White;
            label6.Location = new Point(19, 46);
            label6.Name = "label6";
            label6.Size = new Size(58, 17);
            label6.TabIndex = 11;
            label6.Text = "Item ID:";
            // 
            // btnHome
            // 
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Century Gothic", 9F);
            btnHome.ForeColor = Color.White;
            btnHome.Location = new Point(0, 57);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(142, 43);
            btnHome.TabIndex = 18;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnBack_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(33, 33, 33);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(btnMaintenance);
            panel1.Controls.Add(btnHome);
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
            panel1.TabIndex = 21;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(0, 137, 123);
            panel4.Location = new Point(0, 155);
            panel4.Name = "panel4";
            panel4.Size = new Size(10, 43);
            panel4.TabIndex = 24;
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
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 137, 123);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(142, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(741, 10);
            panel2.TabIndex = 22;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 137, 123);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(176, 1);
            panel3.Name = "panel3";
            panel3.Size = new Size(107, 99);
            panel3.TabIndex = 23;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(1, 27);
            label3.Name = "label3";
            label3.Size = new Size(103, 18);
            label3.TabIndex = 0;
            label3.Text = "GamersUnite";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(33, 33, 33);
            panel5.Controls.Add(label1);
            panel5.Controls.Add(lblItemName);
            panel5.Controls.Add(label6);
            panel5.Controls.Add(btnDeliver);
            panel5.Controls.Add(lblItemIdGetter);
            panel5.Controls.Add(nudQuantity);
            panel5.Controls.Add(label5);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(dateTimePicker1);
            panel5.Location = new Point(142, 138);
            panel5.Name = "panel5";
            panel5.Size = new Size(741, 369);
            panel5.TabIndex = 27;
            // 
            // frmDelivery
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(66, 66, 66);
            ClientSize = new Size(883, 556);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(dgvDelivery);
            Controls.Add(panel5);
            Name = "frmDelivery";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Delivery";
            Load += frmDelivery_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDelivery).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvDelivery;
        private DateTimePicker dateTimePicker1;
        private NumericUpDown nudQuantity;
        private Label label1;
        private Label lblItemName;
        private Label lblItemIdGetter;
        private Label label4;
        private Label label5;
        private Button btnDeliver;
        private Label label6;
        private Button btnHome;
        private Panel panel1;
        private Button btnMaintenance;
        private Button btnLogout;
        private Button btnDbBackup;
        private Button btnDelivery;
        private Button btnInventoryMonitoring;
        private Button btnSalesMonitoring;
        private Button btnPointOfSales;
        private Panel panel2;
        private Panel panel3;
        private Label label2;
        private Label label3;
        private Panel panel4;
        private Panel panel5;
    }
}