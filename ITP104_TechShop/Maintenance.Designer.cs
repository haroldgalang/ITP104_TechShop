namespace ITP104_TechShop
{
    partial class frmMaintenance
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
            btnSetUser = new Button();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            groupBox1 = new GroupBox();
            button6 = new Button();
            button5 = new Button();
            btnShowTblUser = new Button();
            btnShowTblCategory = new Button();
            dgvMaintenance = new DataGridView();
            groupBox2 = new GroupBox();
            label4 = new Label();
            txtCategoryName = new TextBox();
            button2 = new Button();
            button3 = new Button();
            button7 = new Button();
            groupBox3 = new GroupBox();
            label2 = new Label();
            txtItemName = new TextBox();
            textBox5 = new TextBox();
            txtBasePrice = new TextBox();
            button8 = new Button();
            button9 = new Button();
            btnShowTblItems = new Button();
            button11 = new Button();
            groupBox4 = new GroupBox();
            label3 = new Label();
            txtSupplierName = new TextBox();
            txtSupplierAddress = new TextBox();
            txtSupplierContact = new TextBox();
            button12 = new Button();
            button13 = new Button();
            btnShowTblSuppliers = new Button();
            button15 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMaintenance).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // btnSetUser
            // 
            btnSetUser.Location = new Point(6, 155);
            btnSetUser.Name = "btnSetUser";
            btnSetUser.Size = new Size(59, 26);
            btnSetUser.TabIndex = 1;
            btnSetUser.Text = "Set User";
            btnSetUser.UseVisualStyleBackColor = true;
            btnSetUser.Click += btnSetUser_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(6, 110);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(204, 23);
            txtPassword.TabIndex = 5;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(6, 69);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Username";
            txtUsername.Size = new Size(204, 23);
            txtUsername.TabIndex = 6;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button6);
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(txtUsername);
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Controls.Add(btnSetUser);
            groupBox1.Controls.Add(btnShowTblUser);
            groupBox1.Location = new Point(12, 220);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(219, 187);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Set Users";
            // 
            // button6
            // 
            button6.Location = new Point(71, 155);
            button6.Name = "button6";
            button6.Size = new Size(74, 26);
            button6.TabIndex = 9;
            button6.Text = "Set User";
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(151, 155);
            button5.Name = "button5";
            button5.Size = new Size(59, 26);
            button5.TabIndex = 8;
            button5.Text = "Set User";
            button5.UseVisualStyleBackColor = true;
            // 
            // btnShowTblUser
            // 
            btnShowTblUser.Location = new Point(0, 22);
            btnShowTblUser.Name = "btnShowTblUser";
            btnShowTblUser.Size = new Size(118, 26);
            btnShowTblUser.TabIndex = 7;
            btnShowTblUser.Text = "Show Table";
            btnShowTblUser.UseVisualStyleBackColor = true;
            btnShowTblUser.Click += btnShowTblUser_Click;
            // 
            // btnShowTblCategory
            // 
            btnShowTblCategory.Location = new Point(0, 22);
            btnShowTblCategory.Name = "btnShowTblCategory";
            btnShowTblCategory.Size = new Size(118, 26);
            btnShowTblCategory.TabIndex = 7;
            btnShowTblCategory.Text = "Show Table";
            btnShowTblCategory.UseVisualStyleBackColor = true;
            btnShowTblCategory.Click += btnShowTblCategory_Click;
            // 
            // dgvMaintenance
            // 
            dgvMaintenance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMaintenance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMaintenance.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvMaintenance.Location = new Point(242, 220);
            dgvMaintenance.Name = "dgvMaintenance";
            dgvMaintenance.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMaintenance.Size = new Size(451, 187);
            dgvMaintenance.TabIndex = 16;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtCategoryName);
            groupBox2.Controls.Add(btnShowTblCategory);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(button7);
            groupBox2.Location = new Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(219, 187);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "Set Item Category";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 69);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 17;
            label4.Text = "Category ID: ";
            // 
            // txtCategoryName
            // 
            txtCategoryName.Location = new Point(6, 98);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.PlaceholderText = "Category Name";
            txtCategoryName.Size = new Size(204, 23);
            txtCategoryName.TabIndex = 10;
            // 
            // button2
            // 
            button2.Location = new Point(71, 155);
            button2.Name = "button2";
            button2.Size = new Size(74, 26);
            button2.TabIndex = 9;
            button2.Text = "Set User";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(151, 155);
            button3.Name = "button3";
            button3.Size = new Size(59, 26);
            button3.TabIndex = 8;
            button3.Text = "Set User";
            button3.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(6, 155);
            button7.Name = "button7";
            button7.Size = new Size(59, 26);
            button7.TabIndex = 1;
            button7.Text = "Set User";
            button7.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(txtItemName);
            groupBox3.Controls.Add(textBox5);
            groupBox3.Controls.Add(txtBasePrice);
            groupBox3.Controls.Add(button8);
            groupBox3.Controls.Add(button9);
            groupBox3.Controls.Add(btnShowTblItems);
            groupBox3.Controls.Add(button11);
            groupBox3.Location = new Point(242, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(219, 187);
            groupBox3.TabIndex = 13;
            groupBox3.TabStop = false;
            groupBox3.Text = "Set Items";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 51);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 14;
            label2.Text = "Item ID: ";
            // 
            // txtItemName
            // 
            txtItemName.Location = new Point(6, 69);
            txtItemName.Name = "txtItemName";
            txtItemName.PlaceholderText = "Item Name";
            txtItemName.Size = new Size(204, 23);
            txtItemName.TabIndex = 13;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(6, 98);
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "Category ID";
            textBox5.Size = new Size(204, 23);
            textBox5.TabIndex = 12;
            // 
            // txtBasePrice
            // 
            txtBasePrice.Location = new Point(6, 127);
            txtBasePrice.Name = "txtBasePrice";
            txtBasePrice.PlaceholderText = "Base Price";
            txtBasePrice.Size = new Size(204, 23);
            txtBasePrice.TabIndex = 11;
            // 
            // button8
            // 
            button8.Location = new Point(71, 156);
            button8.Name = "button8";
            button8.Size = new Size(74, 26);
            button8.TabIndex = 9;
            button8.Text = "Set User";
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Location = new Point(151, 156);
            button9.Name = "button9";
            button9.Size = new Size(59, 26);
            button9.TabIndex = 8;
            button9.Text = "Set User";
            button9.UseVisualStyleBackColor = true;
            // 
            // btnShowTblItems
            // 
            btnShowTblItems.Location = new Point(0, 22);
            btnShowTblItems.Name = "btnShowTblItems";
            btnShowTblItems.Size = new Size(118, 26);
            btnShowTblItems.TabIndex = 7;
            btnShowTblItems.Text = "Show Table";
            btnShowTblItems.UseVisualStyleBackColor = true;
            btnShowTblItems.Click += btnShowTblItems_Click;
            // 
            // button11
            // 
            button11.Location = new Point(6, 156);
            button11.Name = "button11";
            button11.Size = new Size(59, 26);
            button11.TabIndex = 1;
            button11.Text = "Set User";
            button11.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label3);
            groupBox4.Controls.Add(txtSupplierName);
            groupBox4.Controls.Add(txtSupplierAddress);
            groupBox4.Controls.Add(txtSupplierContact);
            groupBox4.Controls.Add(button12);
            groupBox4.Controls.Add(button13);
            groupBox4.Controls.Add(btnShowTblSuppliers);
            groupBox4.Controls.Add(button15);
            groupBox4.Location = new Point(474, 12);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(219, 187);
            groupBox4.TabIndex = 15;
            groupBox4.TabStop = false;
            groupBox4.Text = "Set Suppliers";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 51);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 14;
            label3.Text = "Supplier ID: ";
            // 
            // txtSupplierName
            // 
            txtSupplierName.Location = new Point(6, 69);
            txtSupplierName.Name = "txtSupplierName";
            txtSupplierName.PlaceholderText = "Supplier Name";
            txtSupplierName.Size = new Size(204, 23);
            txtSupplierName.TabIndex = 13;
            // 
            // txtSupplierAddress
            // 
            txtSupplierAddress.Location = new Point(6, 98);
            txtSupplierAddress.Name = "txtSupplierAddress";
            txtSupplierAddress.PlaceholderText = "Supplier Address";
            txtSupplierAddress.Size = new Size(204, 23);
            txtSupplierAddress.TabIndex = 12;
            // 
            // txtSupplierContact
            // 
            txtSupplierContact.Location = new Point(6, 127);
            txtSupplierContact.Name = "txtSupplierContact";
            txtSupplierContact.PlaceholderText = "Supplier Contact Number";
            txtSupplierContact.Size = new Size(204, 23);
            txtSupplierContact.TabIndex = 11;
            // 
            // button12
            // 
            button12.Location = new Point(71, 156);
            button12.Name = "button12";
            button12.Size = new Size(74, 26);
            button12.TabIndex = 9;
            button12.Text = "Set User";
            button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            button13.Location = new Point(151, 156);
            button13.Name = "button13";
            button13.Size = new Size(59, 26);
            button13.TabIndex = 8;
            button13.Text = "Set User";
            button13.UseVisualStyleBackColor = true;
            // 
            // btnShowTblSuppliers
            // 
            btnShowTblSuppliers.Location = new Point(0, 22);
            btnShowTblSuppliers.Name = "btnShowTblSuppliers";
            btnShowTblSuppliers.Size = new Size(118, 26);
            btnShowTblSuppliers.TabIndex = 7;
            btnShowTblSuppliers.Text = "Show Table";
            btnShowTblSuppliers.UseVisualStyleBackColor = true;
            btnShowTblSuppliers.Click += btnShowTblSuppliers_Click;
            // 
            // button15
            // 
            button15.Location = new Point(6, 156);
            button15.Name = "button15";
            button15.Size = new Size(59, 26);
            button15.TabIndex = 1;
            button15.Text = "Set User";
            button15.UseVisualStyleBackColor = true;
            // 
            // frmMaintenance
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(702, 416);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(dgvMaintenance);
            Controls.Add(groupBox1);
            Name = "frmMaintenance";
            Text = "Maintenance";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMaintenance).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnSetUser;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private GroupBox groupBox1;
        private Button btnShowTblCategory;
        private DataGridView dgvMaintenance;
        private Button button6;
        private Button button5;
        private GroupBox groupBox2;
        private Button button2;
        private Button button3;
        private Button btnShowTblUser;
        private Button button7;
        private GroupBox groupBox3;
        private Button button8;
        private Button button9;
        private Button btnShowTblItems;
        private Button button11;
        private TextBox txtCategoryName;
        private TextBox txtItemName;
        private TextBox textBox5;
        private TextBox txtBasePrice;
        private Label label2;
        private Label label4;
        private GroupBox groupBox4;
        private Label label3;
        private TextBox txtSupplierName;
        private TextBox txtSupplierAddress;
        private TextBox txtSupplierContact;
        private Button button12;
        private Button button13;
        private Button btnShowTblSuppliers;
        private Button button15;
    }
}