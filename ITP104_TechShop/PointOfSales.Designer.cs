namespace ITP104_TechShop
{
    partial class frmPointOfSales
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
            groupBox1 = new GroupBox();
            dgvCart = new DataGridView();
            lblTotalPriceGetter = new Label();
            label8 = new Label();
            lblItemPriceGetter = new Label();
            label7 = new Label();
            lblItemIdGetter = new Label();
            btnCheckOut = new Button();
            label6 = new Label();
            lblStocksChecker = new Label();
            label5 = new Label();
            btnAddToCart = new Button();
            label3 = new Label();
            cbCategoryName = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            nudQuantity = new NumericUpDown();
            cbItemName = new ComboBox();
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
            label4 = new Label();
            label9 = new Label();
            panel5 = new Panel();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvCart);
            groupBox1.Controls.Add(lblTotalPriceGetter);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(lblItemPriceGetter);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(lblItemIdGetter);
            groupBox1.Controls.Add(btnCheckOut);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(lblStocksChecker);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(btnAddToCart);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(cbCategoryName);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(nudQuantity);
            groupBox1.Controls.Add(cbItemName);
            groupBox1.Location = new Point(37, 39);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(677, 298);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Computer Components";
            // 
            // dgvCart
            // 
            dgvCart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCart.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvCart.Location = new Point(667, 288);
            dgvCart.Name = "dgvCart";
            dgvCart.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCart.Size = new Size(10, 10);
            dgvCart.TabIndex = 33;
            dgvCart.Visible = false;
            // 
            // lblTotalPriceGetter
            // 
            lblTotalPriceGetter.AutoSize = true;
            lblTotalPriceGetter.Location = new Point(417, 112);
            lblTotalPriceGetter.Name = "lblTotalPriceGetter";
            lblTotalPriceGetter.Size = new Size(13, 15);
            lblTotalPriceGetter.TabIndex = 41;
            lblTotalPriceGetter.Text = "0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(335, 112);
            label8.Name = "label8";
            label8.Size = new Size(64, 15);
            label8.TabIndex = 40;
            label8.Text = "Total Price:";
            // 
            // lblItemPriceGetter
            // 
            lblItemPriceGetter.AutoSize = true;
            lblItemPriceGetter.Location = new Point(424, 36);
            lblItemPriceGetter.Name = "lblItemPriceGetter";
            lblItemPriceGetter.Size = new Size(13, 15);
            lblItemPriceGetter.TabIndex = 39;
            lblItemPriceGetter.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(335, 36);
            label7.Name = "label7";
            label7.Size = new Size(83, 15);
            label7.TabIndex = 38;
            label7.Text = "Price Per Item:";
            // 
            // lblItemIdGetter
            // 
            lblItemIdGetter.AutoSize = true;
            lblItemIdGetter.Location = new Point(68, 157);
            lblItemIdGetter.Name = "lblItemIdGetter";
            lblItemIdGetter.Size = new Size(12, 15);
            lblItemIdGetter.TabIndex = 37;
            lblItemIdGetter.Text = "/";
            // 
            // btnCheckOut
            // 
            btnCheckOut.Location = new Point(21, 234);
            btnCheckOut.Name = "btnCheckOut";
            btnCheckOut.Size = new Size(299, 32);
            btnCheckOut.TabIndex = 10;
            btnCheckOut.Text = "Checkout";
            btnCheckOut.UseVisualStyleBackColor = true;
            btnCheckOut.Click += btnCheckOut_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 157);
            label6.Name = "label6";
            label6.Size = new Size(48, 15);
            label6.TabIndex = 36;
            label6.Text = "Item ID:";
            // 
            // lblStocksChecker
            // 
            lblStocksChecker.AutoSize = true;
            lblStocksChecker.Location = new Point(115, 206);
            lblStocksChecker.Name = "lblStocksChecker";
            lblStocksChecker.Size = new Size(12, 15);
            lblStocksChecker.TabIndex = 35;
            lblStocksChecker.Text = "/";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 206);
            label5.Name = "label5";
            label5.Size = new Size(95, 15);
            label5.TabIndex = 34;
            label5.Text = "Stocks Available:";
            // 
            // btnAddToCart
            // 
            btnAddToCart.Location = new Point(356, 234);
            btnAddToCart.Name = "btnAddToCart";
            btnAddToCart.Size = new Size(299, 32);
            btnAddToCart.TabIndex = 32;
            btnAddToCart.Text = "Add To Cart";
            btnAddToCart.UseVisualStyleBackColor = true;
            btnAddToCart.Visible = false;
            btnAddToCart.Click += btnAddToCart_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 36);
            label3.Name = "label3";
            label3.Size = new Size(89, 15);
            label3.TabIndex = 23;
            label3.Text = "Select Category";
            // 
            // cbCategoryName
            // 
            cbCategoryName.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCategoryName.FormattingEnabled = true;
            cbCategoryName.Location = new Point(14, 54);
            cbCategoryName.Name = "cbCategoryName";
            cbCategoryName.Size = new Size(299, 23);
            cbCategoryName.TabIndex = 22;
            cbCategoryName.SelectedIndexChanged += cbCategoryName_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(335, 206);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 21;
            label2.Text = "Quantity";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 94);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 20;
            label1.Text = "Select item";
            // 
            // nudQuantity
            // 
            nudQuantity.Location = new Point(394, 204);
            nudQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(64, 23);
            nudQuantity.TabIndex = 15;
            nudQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nudQuantity.ValueChanged += nudQuantity_ValueChanged;
            // 
            // cbItemName
            // 
            cbItemName.DropDownStyle = ComboBoxStyle.DropDownList;
            cbItemName.FormattingEnabled = true;
            cbItemName.Location = new Point(14, 112);
            cbItemName.Name = "cbItemName";
            cbItemName.Size = new Size(299, 23);
            cbItemName.TabIndex = 10;
            cbItemName.Tag = "";
            cbItemName.SelectedIndexChanged += cbItemName_SelectedIndexChanged;
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
            btnHome.TabIndex = 42;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnBack_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(33, 33, 33);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(btnHome);
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
            panel1.TabIndex = 21;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(0, 137, 123);
            panel4.Location = new Point(0, 106);
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
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label9);
            panel3.Location = new Point(176, 1);
            panel3.Name = "panel3";
            panel3.Size = new Size(107, 99);
            panel3.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(3, 45);
            label4.Name = "label4";
            label4.Size = new Size(69, 17);
            label4.TabIndex = 1;
            label4.Text = "Tech Shop";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(1, 27);
            label9.Name = "label9";
            label9.Size = new Size(103, 18);
            label9.TabIndex = 0;
            label9.Text = "GamersUnite";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(33, 33, 33);
            panel5.Controls.Add(groupBox1);
            panel5.Location = new Point(142, 138);
            panel5.Name = "panel5";
            panel5.Size = new Size(741, 369);
            panel5.TabIndex = 29;
            // 
            // frmPointOfSales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(66, 66, 66);
            ClientSize = new Size(883, 556);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel5);
            Name = "frmPointOfSales";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Point Of Sales";
            Load += frmPointOfSales_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCart).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private ComboBox cbItemName;
        private Label label1;
        private NumericUpDown nudQuantity;
        private Label label2;
        private Button btnCheckOut;
        private Button btnAddToCart;
        private Label label3;
        private ComboBox cbCategoryName;
        private DataGridView dgvCart;
        private Label label5;
        private Label lblStocksChecker;
        private Label label6;
        private Label lblItemIdGetter;
        private Label lblItemPriceGetter;
        private Label label7;
        private Label lblTotalPriceGetter;
        private Label label8;
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
        private Label label4;
        private Label label9;
        private Panel panel4;
        private Panel panel5;
    }
}