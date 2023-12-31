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
            dgvCart = new DataGridView();
            rtbReceipt = new RichTextBox();
            label4 = new Label();
            label8 = new Label();
            lblTotalPriceGetter = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCart).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
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
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(311, 345);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Computer Components";
            // 
            // lblItemPriceGetter
            // 
            lblItemPriceGetter.AutoSize = true;
            lblItemPriceGetter.Location = new Point(95, 155);
            lblItemPriceGetter.Name = "lblItemPriceGetter";
            lblItemPriceGetter.Size = new Size(13, 15);
            lblItemPriceGetter.TabIndex = 39;
            lblItemPriceGetter.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 155);
            label7.Name = "label7";
            label7.Size = new Size(83, 15);
            label7.TabIndex = 38;
            label7.Text = "Price Per Item:";
            // 
            // lblItemIdGetter
            // 
            lblItemIdGetter.AutoSize = true;
            lblItemIdGetter.Location = new Point(60, 117);
            lblItemIdGetter.Name = "lblItemIdGetter";
            lblItemIdGetter.Size = new Size(12, 15);
            lblItemIdGetter.TabIndex = 37;
            lblItemIdGetter.Text = "/";
            // 
            // btnCheckOut
            // 
            btnCheckOut.Location = new Point(6, 307);
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
            label6.Location = new Point(6, 117);
            label6.Name = "label6";
            label6.Size = new Size(48, 15);
            label6.TabIndex = 36;
            label6.Text = "Item ID:";
            // 
            // lblStocksChecker
            // 
            lblStocksChecker.AutoSize = true;
            lblStocksChecker.Location = new Point(107, 190);
            lblStocksChecker.Name = "lblStocksChecker";
            lblStocksChecker.Size = new Size(12, 15);
            lblStocksChecker.TabIndex = 35;
            lblStocksChecker.Text = "/";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 190);
            label5.Name = "label5";
            label5.Size = new Size(95, 15);
            label5.TabIndex = 34;
            label5.Text = "Stocks Available:";
            // 
            // btnAddToCart
            // 
            btnAddToCart.Location = new Point(6, 269);
            btnAddToCart.Name = "btnAddToCart";
            btnAddToCart.Size = new Size(299, 32);
            btnAddToCart.TabIndex = 32;
            btnAddToCart.Text = "Add To Cart";
            btnAddToCart.UseVisualStyleBackColor = true;
            btnAddToCart.Click += btnAddToCart_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 19);
            label3.Name = "label3";
            label3.Size = new Size(89, 15);
            label3.TabIndex = 23;
            label3.Text = "Select Category";
            // 
            // cbCategoryName
            // 
            cbCategoryName.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCategoryName.FormattingEnabled = true;
            cbCategoryName.Location = new Point(6, 37);
            cbCategoryName.Name = "cbCategoryName";
            cbCategoryName.Size = new Size(299, 23);
            cbCategoryName.TabIndex = 22;
            cbCategoryName.SelectedIndexChanged += cbCategoryName_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 229);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 21;
            label2.Text = "Quantity";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 63);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 20;
            label1.Text = "Select item";
            // 
            // nudQuantity
            // 
            nudQuantity.Location = new Point(67, 227);
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
            cbItemName.Location = new Point(6, 81);
            cbItemName.Name = "cbItemName";
            cbItemName.Size = new Size(299, 23);
            cbItemName.TabIndex = 10;
            cbItemName.Tag = "";
            cbItemName.SelectedIndexChanged += cbItemName_SelectedIndexChanged;
            // 
            // dgvCart
            // 
            dgvCart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCart.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvCart.Location = new Point(12, 363);
            dgvCart.Name = "dgvCart";
            dgvCart.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCart.Size = new Size(579, 141);
            dgvCart.TabIndex = 33;
            // 
            // rtbReceipt
            // 
            rtbReceipt.Location = new Point(329, 31);
            rtbReceipt.Name = "rtbReceipt";
            rtbReceipt.Size = new Size(262, 326);
            rtbReceipt.TabIndex = 11;
            rtbReceipt.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(329, 9);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 34;
            label4.Text = "Receipt:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(137, 229);
            label8.Name = "label8";
            label8.Size = new Size(64, 15);
            label8.TabIndex = 40;
            label8.Text = "Total Price:";
            // 
            // lblTotalPriceGetter
            // 
            lblTotalPriceGetter.AutoSize = true;
            lblTotalPriceGetter.Location = new Point(207, 229);
            lblTotalPriceGetter.Name = "lblTotalPriceGetter";
            lblTotalPriceGetter.Size = new Size(13, 15);
            lblTotalPriceGetter.TabIndex = 41;
            lblTotalPriceGetter.Text = "0";
            // 
            // frmPointOfSales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(603, 516);
            Controls.Add(label4);
            Controls.Add(rtbReceipt);
            Controls.Add(groupBox1);
            Controls.Add(dgvCart);
            Name = "frmPointOfSales";
            Text = "Point Of Sales";
            Load += frmPointOfSales_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCart).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBox1;
        private ComboBox cbItemName;
        private Label label1;
        private NumericUpDown nudQuantity;
        private Label label2;
        private Button btnCheckOut;
        private RichTextBox rtbReceipt;
        private Button btnAddToCart;
        private Label label3;
        private ComboBox cbCategoryName;
        private DataGridView dgvCart;
        private Label label4;
        private Label label5;
        private Label lblStocksChecker;
        private Label label6;
        private Label lblItemIdGetter;
        private Label lblItemPriceGetter;
        private Label label7;
        private Label lblTotalPriceGetter;
        private Label label8;
    }
}