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
            btnUpdateUser = new Button();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            groupBox1 = new GroupBox();
            btnDeleteUser = new Button();
            btnAddUser = new Button();
            btnShowTblUser = new Button();
            btnShowTblCategory = new Button();
            dgvUsers = new DataGridView();
            groupBox2 = new GroupBox();
            btnDeleteCatergory = new Button();
            lblCategoryID = new Label();
            txtCategoryName = new TextBox();
            btnAddCategory = new Button();
            btnEditCategory = new Button();
            button2 = new Button();
            groupBox3 = new GroupBox();
            button3 = new Button();
            lblItemID = new Label();
            txtItemName = new TextBox();
            textBox5 = new TextBox();
            txtBasePrice = new TextBox();
            btnShowTblItems = new Button();
            button8 = new Button();
            button11 = new Button();
            groupBox4 = new GroupBox();
            button4 = new Button();
            lblSupplierID = new Label();
            txtSupplierName = new TextBox();
            txtSupplierAddress = new TextBox();
            txtSupplierContact = new TextBox();
            btnShowTblSuppliers = new Button();
            button15 = new Button();
            btnBack = new Button();
            dgvItemCategory = new DataGridView();
            dgvItems = new DataGridView();
            dgvSuppliers = new DataGridView();
            lblCategoryIdGetter = new Label();
            lblItemIdGetter = new Label();
            label3 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItemCategory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvItems).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSuppliers).BeginInit();
            SuspendLayout();
            // 
            // btnUpdateUser
            // 
            btnUpdateUser.Location = new Point(6, 155);
            btnUpdateUser.Name = "btnUpdateUser";
            btnUpdateUser.Size = new Size(59, 26);
            btnUpdateUser.TabIndex = 1;
            btnUpdateUser.Text = "Edit";
            btnUpdateUser.UseVisualStyleBackColor = true;
            btnUpdateUser.Click += btnUpdateUser_Click;
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
            groupBox1.Controls.Add(btnDeleteUser);
            groupBox1.Controls.Add(btnAddUser);
            groupBox1.Controls.Add(txtUsername);
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Controls.Add(btnUpdateUser);
            groupBox1.Controls.Add(btnShowTblUser);
            groupBox1.Location = new Point(9, 277);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(219, 187);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Set Users";
            // 
            // btnDeleteUser
            // 
            btnDeleteUser.Location = new Point(151, 155);
            btnDeleteUser.Name = "btnDeleteUser";
            btnDeleteUser.Size = new Size(59, 26);
            btnDeleteUser.TabIndex = 20;
            btnDeleteUser.Text = "Delete";
            btnDeleteUser.UseVisualStyleBackColor = true;
            btnDeleteUser.Click += btnDeleteUser_Click_1;
            // 
            // btnAddUser
            // 
            btnAddUser.Location = new Point(71, 155);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(74, 26);
            btnAddUser.TabIndex = 9;
            btnAddUser.Text = "+";
            btnAddUser.UseVisualStyleBackColor = true;
            btnAddUser.Click += btnAddUser_Click;
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
            // dgvUsers
            // 
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvUsers.Location = new Point(239, 277);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.Size = new Size(451, 187);
            dgvUsers.TabIndex = 16;
            dgvUsers.CellClick += dgvUsers_CellClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblCategoryIdGetter);
            groupBox2.Controls.Add(btnDeleteCatergory);
            groupBox2.Controls.Add(lblCategoryID);
            groupBox2.Controls.Add(txtCategoryName);
            groupBox2.Controls.Add(btnShowTblCategory);
            groupBox2.Controls.Add(btnAddCategory);
            groupBox2.Controls.Add(btnEditCategory);
            groupBox2.Location = new Point(9, 69);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(219, 187);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "Set Item Category";
            // 
            // btnDeleteCatergory
            // 
            btnDeleteCatergory.Location = new Point(151, 155);
            btnDeleteCatergory.Name = "btnDeleteCatergory";
            btnDeleteCatergory.Size = new Size(59, 26);
            btnDeleteCatergory.TabIndex = 18;
            btnDeleteCatergory.Text = "Delete";
            btnDeleteCatergory.UseVisualStyleBackColor = true;
            btnDeleteCatergory.Click += btnDeleteCatergory_Click;
            // 
            // lblCategoryID
            // 
            lblCategoryID.AutoSize = true;
            lblCategoryID.Location = new Point(6, 69);
            lblCategoryID.Name = "lblCategoryID";
            lblCategoryID.Size = new Size(75, 15);
            lblCategoryID.TabIndex = 17;
            lblCategoryID.Text = "Category ID: ";
            lblCategoryID.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtCategoryName
            // 
            txtCategoryName.Location = new Point(6, 98);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.PlaceholderText = "Category Name";
            txtCategoryName.Size = new Size(204, 23);
            txtCategoryName.TabIndex = 10;
            // 
            // btnAddCategory
            // 
            btnAddCategory.Location = new Point(71, 155);
            btnAddCategory.Name = "btnAddCategory";
            btnAddCategory.Size = new Size(74, 26);
            btnAddCategory.TabIndex = 9;
            btnAddCategory.Text = "+";
            btnAddCategory.UseVisualStyleBackColor = true;
            btnAddCategory.Click += btnAddCategory_Click;
            // 
            // btnEditCategory
            // 
            btnEditCategory.Location = new Point(6, 155);
            btnEditCategory.Name = "btnEditCategory";
            btnEditCategory.Size = new Size(59, 26);
            btnEditCategory.TabIndex = 1;
            btnEditCategory.Text = "Edit";
            btnEditCategory.UseVisualStyleBackColor = true;
            btnEditCategory.Click += btnEditCategory_Click;
            // 
            // button2
            // 
            button2.Location = new Point(71, 156);
            button2.Name = "button2";
            button2.Size = new Size(74, 26);
            button2.TabIndex = 9;
            button2.Text = "+";
            button2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lblItemIdGetter);
            groupBox3.Controls.Add(button3);
            groupBox3.Controls.Add(lblItemID);
            groupBox3.Controls.Add(txtItemName);
            groupBox3.Controls.Add(textBox5);
            groupBox3.Controls.Add(txtBasePrice);
            groupBox3.Controls.Add(btnShowTblItems);
            groupBox3.Controls.Add(button8);
            groupBox3.Controls.Add(button11);
            groupBox3.Location = new Point(239, 69);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(219, 187);
            groupBox3.TabIndex = 13;
            groupBox3.TabStop = false;
            groupBox3.Text = "Set Items";
            // 
            // button3
            // 
            button3.Location = new Point(154, 155);
            button3.Name = "button3";
            button3.Size = new Size(59, 26);
            button3.TabIndex = 19;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            // 
            // lblItemID
            // 
            lblItemID.AutoSize = true;
            lblItemID.Location = new Point(6, 51);
            lblItemID.Name = "lblItemID";
            lblItemID.Size = new Size(51, 15);
            lblItemID.TabIndex = 14;
            lblItemID.Text = "Item ID: ";
            lblItemID.TextAlign = ContentAlignment.MiddleRight;
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
            // button8
            // 
            button8.Location = new Point(71, 156);
            button8.Name = "button8";
            button8.Size = new Size(77, 26);
            button8.TabIndex = 9;
            button8.Text = "+";
            button8.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            button11.Location = new Point(6, 156);
            button11.Name = "button11";
            button11.Size = new Size(59, 26);
            button11.TabIndex = 1;
            button11.Text = "Edit";
            button11.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label3);
            groupBox4.Controls.Add(button4);
            groupBox4.Controls.Add(lblSupplierID);
            groupBox4.Controls.Add(txtSupplierName);
            groupBox4.Controls.Add(txtSupplierAddress);
            groupBox4.Controls.Add(button2);
            groupBox4.Controls.Add(txtSupplierContact);
            groupBox4.Controls.Add(btnShowTblSuppliers);
            groupBox4.Controls.Add(button15);
            groupBox4.Location = new Point(471, 69);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(219, 187);
            groupBox4.TabIndex = 15;
            groupBox4.TabStop = false;
            groupBox4.Text = "Set Suppliers";
            // 
            // button4
            // 
            button4.Location = new Point(151, 155);
            button4.Name = "button4";
            button4.Size = new Size(59, 26);
            button4.TabIndex = 19;
            button4.Text = "Delete";
            button4.UseVisualStyleBackColor = true;
            // 
            // lblSupplierID
            // 
            lblSupplierID.AutoSize = true;
            lblSupplierID.Location = new Point(6, 51);
            lblSupplierID.Name = "lblSupplierID";
            lblSupplierID.Size = new Size(70, 15);
            lblSupplierID.TabIndex = 14;
            lblSupplierID.Text = "Supplier ID: ";
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
            button15.Text = "Edit";
            button15.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(542, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(148, 30);
            btnBack.TabIndex = 17;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // dgvItemCategory
            // 
            dgvItemCategory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvItemCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItemCategory.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvItemCategory.Location = new Point(239, 277);
            dgvItemCategory.Name = "dgvItemCategory";
            dgvItemCategory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvItemCategory.Size = new Size(451, 187);
            dgvItemCategory.TabIndex = 18;
            dgvItemCategory.Visible = false;
            dgvItemCategory.CellClick += dgvItemCategory_CellClick;
            // 
            // dgvItems
            // 
            dgvItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItems.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvItems.Location = new Point(239, 277);
            dgvItems.Name = "dgvItems";
            dgvItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvItems.Size = new Size(451, 187);
            dgvItems.TabIndex = 19;
            dgvItems.Visible = false;
            dgvItems.CellClick += dgvItems_CellClick;
            // 
            // dgvSuppliers
            // 
            dgvSuppliers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSuppliers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSuppliers.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvSuppliers.Location = new Point(239, 277);
            dgvSuppliers.Name = "dgvSuppliers";
            dgvSuppliers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSuppliers.Size = new Size(451, 187);
            dgvSuppliers.TabIndex = 20;
            dgvSuppliers.Visible = false;
            dgvSuppliers.CellClick += dgvSuppliers_CellClick;
            // 
            // lblCategoryIdGetter
            // 
            lblCategoryIdGetter.AutoSize = true;
            lblCategoryIdGetter.Location = new Point(87, 69);
            lblCategoryIdGetter.Name = "lblCategoryIdGetter";
            lblCategoryIdGetter.Size = new Size(12, 15);
            lblCategoryIdGetter.TabIndex = 19;
            lblCategoryIdGetter.Text = "/";
            // 
            // lblItemIdGetter
            // 
            lblItemIdGetter.AutoSize = true;
            lblItemIdGetter.Location = new Point(63, 51);
            lblItemIdGetter.Name = "lblItemIdGetter";
            lblItemIdGetter.Size = new Size(12, 15);
            lblItemIdGetter.TabIndex = 20;
            lblItemIdGetter.Text = "/";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(82, 51);
            label3.Name = "label3";
            label3.Size = new Size(12, 15);
            label3.TabIndex = 21;
            label3.Text = "/";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // frmMaintenance
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(702, 476);
            Controls.Add(dgvSuppliers);
            Controls.Add(dgvItems);
            Controls.Add(dgvItemCategory);
            Controls.Add(btnBack);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(dgvUsers);
            Controls.Add(groupBox1);
            Name = "frmMaintenance";
            Text = "Maintenance";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItemCategory).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvItems).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSuppliers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnUpdateUser;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private GroupBox groupBox1;
        private Button btnShowTblCategory;
        private DataGridView dgvUsers;
        private Button btnAddUser;
        private GroupBox groupBox2;
        private Button button2;
        private Button btnShowTblUser;
        private Button btnEditCategory;
        private GroupBox groupBox3;
        private Button button8;
        private Button btnShowTblItems;
        private Button button11;
        private TextBox txtCategoryName;
        private TextBox txtItemName;
        private TextBox textBox5;
        private TextBox txtBasePrice;
        private Label lblItemID;
        private Label lblCategoryID;
        private GroupBox groupBox4;
        private Label lblSupplierID;
        private TextBox txtSupplierName;
        private TextBox txtSupplierAddress;
        private TextBox txtSupplierContact;
        private Button btnAddCategory;
        private Button btnShowTblSuppliers;
        private Button button15;
        private Button btnBack;
        private Button btnDeleteUser;
        private Button btnDeleteCatergory;
        private Button button3;
        private Button button4;
        private DataGridView dgvItemCategory;
        private DataGridView dgvItems;
        private DataGridView dgvSuppliers;
        private Label lblCategoryIdGetter;
        private Label lblItemIdGetter;
        private Label label3;
    }
}