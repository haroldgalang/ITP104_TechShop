﻿namespace ITP104_TechShop
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
            lblTotalPriceGetter = new Label();
            label11 = new Label();
            lblItemPriceGetter = new Label();
            label10 = new Label();
            dgvCart = new DataGridView();
            label8 = new Label();
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
            label12 = new Label();
            label13 = new Label();
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
            groupBox1.Controls.Add(lblTotalPriceGetter);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(lblItemPriceGetter);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(dgvCart);
            groupBox1.Controls.Add(label8);
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
            groupBox1.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(37, 48);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(677, 270);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Choose Computer Components";
            // 
            // lblTotalPriceGetter
            // 
            lblTotalPriceGetter.AutoSize = true;
            lblTotalPriceGetter.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalPriceGetter.ForeColor = Color.White;
            lblTotalPriceGetter.Location = new Point(423, 154);
            lblTotalPriceGetter.Name = "lblTotalPriceGetter";
            lblTotalPriceGetter.Size = new Size(17, 20);
            lblTotalPriceGetter.TabIndex = 41;
            lblTotalPriceGetter.Text = "0";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.White;
            label11.Location = new Point(412, 154);
            label11.Name = "label11";
            label11.Size = new Size(17, 20);
            label11.TabIndex = 43;
            label11.Text = "$";
            // 
            // lblItemPriceGetter
            // 
            lblItemPriceGetter.AutoSize = true;
            lblItemPriceGetter.Font = new Font("Century Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblItemPriceGetter.ForeColor = Color.White;
            lblItemPriceGetter.Location = new Point(359, 27);
            lblItemPriceGetter.Name = "lblItemPriceGetter";
            lblItemPriceGetter.Size = new Size(35, 39);
            lblItemPriceGetter.TabIndex = 39;
            lblItemPriceGetter.Text = "0";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(335, 27);
            label10.Name = "label10";
            label10.Size = new Size(35, 39);
            label10.TabIndex = 42;
            label10.Text = "$";
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
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 9F);
            label8.ForeColor = Color.White;
            label8.Location = new Point(339, 156);
            label8.Name = "label8";
            label8.Size = new Size(73, 17);
            label8.TabIndex = 40;
            label8.Text = "Total Price:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 9F);
            label7.ForeColor = Color.White;
            label7.Location = new Point(339, 66);
            label7.Name = "label7";
            label7.Size = new Size(90, 17);
            label7.TabIndex = 38;
            label7.Text = "Price Per Item";
            // 
            // lblItemIdGetter
            // 
            lblItemIdGetter.AutoSize = true;
            lblItemIdGetter.Font = new Font("Century Gothic", 9F);
            lblItemIdGetter.ForeColor = Color.White;
            lblItemIdGetter.Location = new Point(73, 157);
            lblItemIdGetter.Name = "lblItemIdGetter";
            lblItemIdGetter.Size = new Size(13, 17);
            lblItemIdGetter.TabIndex = 37;
            lblItemIdGetter.Text = "/";
            // 
            // btnCheckOut
            // 
            btnCheckOut.BackColor = Color.FromArgb(0, 137, 123);
            btnCheckOut.FlatAppearance.BorderSize = 0;
            btnCheckOut.FlatStyle = FlatStyle.Flat;
            btnCheckOut.Location = new Point(335, 191);
            btnCheckOut.Name = "btnCheckOut";
            btnCheckOut.Size = new Size(299, 37);
            btnCheckOut.TabIndex = 10;
            btnCheckOut.Text = "Checkout";
            btnCheckOut.UseVisualStyleBackColor = false;
            btnCheckOut.Click += btnCheckOut_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 9F);
            label6.ForeColor = Color.White;
            label6.Location = new Point(14, 157);
            label6.Name = "label6";
            label6.Size = new Size(53, 17);
            label6.TabIndex = 36;
            label6.Text = "Item ID:";
            // 
            // lblStocksChecker
            // 
            lblStocksChecker.AutoSize = true;
            lblStocksChecker.Font = new Font("Century Gothic", 9F);
            lblStocksChecker.ForeColor = Color.White;
            lblStocksChecker.Location = new Point(131, 206);
            lblStocksChecker.Name = "lblStocksChecker";
            lblStocksChecker.Size = new Size(13, 17);
            lblStocksChecker.TabIndex = 35;
            lblStocksChecker.Text = "/";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(14, 206);
            label5.Name = "label5";
            label5.Size = new Size(111, 17);
            label5.TabIndex = 34;
            label5.Text = "Stocks Available:";
            // 
            // btnAddToCart
            // 
            btnAddToCart.BackColor = Color.FromArgb(0, 137, 123);
            btnAddToCart.FlatAppearance.BorderSize = 0;
            btnAddToCart.FlatStyle = FlatStyle.Flat;
            btnAddToCart.Location = new Point(508, 112);
            btnAddToCart.Name = "btnAddToCart";
            btnAddToCart.Size = new Size(126, 24);
            btnAddToCart.TabIndex = 32;
            btnAddToCart.Text = "Add To Cart";
            btnAddToCart.UseVisualStyleBackColor = false;
            btnAddToCart.Visible = false;
            btnAddToCart.Click += btnAddToCart_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(14, 34);
            label3.Name = "label3";
            label3.Size = new Size(106, 17);
            label3.TabIndex = 23;
            label3.Text = "Select Category";
            // 
            // cbCategoryName
            // 
            cbCategoryName.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCategoryName.FormattingEnabled = true;
            cbCategoryName.Location = new Point(14, 54);
            cbCategoryName.Name = "cbCategoryName";
            cbCategoryName.Size = new Size(299, 24);
            cbCategoryName.TabIndex = 22;
            cbCategoryName.SelectedIndexChanged += cbCategoryName_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(339, 115);
            label2.Name = "label2";
            label2.Size = new Size(59, 17);
            label2.TabIndex = 21;
            label2.Text = "Quantity";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(14, 92);
            label1.Name = "label1";
            label1.Size = new Size(77, 17);
            label1.TabIndex = 20;
            label1.Text = "Select item";
            // 
            // nudQuantity
            // 
            nudQuantity.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nudQuantity.Location = new Point(424, 113);
            nudQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(64, 22);
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
            cbItemName.Size = new Size(299, 24);
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
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.White;
            label12.Location = new Point(315, 38);
            label12.Name = "label12";
            label12.Size = new Size(184, 32);
            label12.TabIndex = 30;
            label12.Text = "Point of Sales";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.White;
            label13.Location = new Point(320, 72);
            label13.Name = "label13";
            label13.Size = new Size(297, 17);
            label13.TabIndex = 31;
            label13.Text = "Checkout items that is available in the shop.";
            // 
            // frmPointOfSales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(66, 66, 66);
            ClientSize = new Size(883, 556);
            Controls.Add(label13);
            Controls.Add(label12);
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
            PerformLayout();
        }

        #endregion
        private GroupBox groupBox1;
        private ComboBox cbItemName;
        private Label label1;
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
        private Label label10;
        private Label label11;
        public NumericUpDown nudQuantity;
        private Label label12;
        private Label label13;
    }
}