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
            btnEditUser = new Button();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            groupBox1 = new GroupBox();
            btnDeleteUser = new Button();
            btnAddUser = new Button();
            btnShowTblUser = new Button();
            btnShowTblCategory = new Button();
            dgvUsers = new DataGridView();
            groupBox2 = new GroupBox();
            lblCategoryIdGetter = new Label();
            btnDeleteCatergory = new Button();
            lblCategoryID = new Label();
            txtCategoryName = new TextBox();
            btnAddCategory = new Button();
            btnEditCategory = new Button();
            btnAddSupplier = new Button();
            groupBox3 = new GroupBox();
            cbCategoryName = new ComboBox();
            lblItemIdGetter = new Label();
            btnDeleteItem = new Button();
            lblItemID = new Label();
            txtItemName = new TextBox();
            txtBasePrice = new TextBox();
            btnShowTblItems = new Button();
            btnAddItem = new Button();
            btnEditItems = new Button();
            groupBox4 = new GroupBox();
            lblSupplierIdGetter = new Label();
            btnDeleteSupplier = new Button();
            lblSupplierID = new Label();
            txtSupplierName = new TextBox();
            txtSupplierAddress = new TextBox();
            txtSupplierContact = new TextBox();
            btnShowTblSuppliers = new Button();
            btnEditSupplier = new Button();
            btnHome = new Button();
            dgvItemCategory = new DataGridView();
            dgvItems = new DataGridView();
            dgvSuppliers = new DataGridView();
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
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItemCategory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvItems).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSuppliers).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // btnEditUser
            // 
            btnEditUser.Location = new Point(6, 155);
            btnEditUser.Name = "btnEditUser";
            btnEditUser.Size = new Size(59, 26);
            btnEditUser.TabIndex = 1;
            btnEditUser.Text = "Edit";
            btnEditUser.UseVisualStyleBackColor = true;
            btnEditUser.Click += btnEditUser_Click;
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
            groupBox1.Controls.Add(btnEditUser);
            groupBox1.Controls.Add(btnShowTblUser);
            groupBox1.Location = new Point(190, 357);
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
            btnDeleteUser.Click += btnDeleteUser_Click;
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
            dgvUsers.Location = new Point(420, 357);
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
            groupBox2.Location = new Point(190, 149);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(219, 187);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "Set Item Category";
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
            // btnAddSupplier
            // 
            btnAddSupplier.Location = new Point(71, 156);
            btnAddSupplier.Name = "btnAddSupplier";
            btnAddSupplier.Size = new Size(74, 26);
            btnAddSupplier.TabIndex = 9;
            btnAddSupplier.Text = "+";
            btnAddSupplier.UseVisualStyleBackColor = true;
            btnAddSupplier.Click += btnAddSupplier_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(cbCategoryName);
            groupBox3.Controls.Add(lblItemIdGetter);
            groupBox3.Controls.Add(btnDeleteItem);
            groupBox3.Controls.Add(lblItemID);
            groupBox3.Controls.Add(txtItemName);
            groupBox3.Controls.Add(txtBasePrice);
            groupBox3.Controls.Add(btnShowTblItems);
            groupBox3.Controls.Add(btnAddItem);
            groupBox3.Controls.Add(btnEditItems);
            groupBox3.Location = new Point(420, 149);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(219, 187);
            groupBox3.TabIndex = 13;
            groupBox3.TabStop = false;
            groupBox3.Text = "Set Items";
            // 
            // cbCategoryName
            // 
            cbCategoryName.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCategoryName.ForeColor = SystemColors.InfoText;
            cbCategoryName.FormattingEnabled = true;
            cbCategoryName.Location = new Point(6, 98);
            cbCategoryName.Name = "cbCategoryName";
            cbCategoryName.Size = new Size(204, 23);
            cbCategoryName.TabIndex = 21;
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
            // btnDeleteItem
            // 
            btnDeleteItem.Location = new Point(154, 155);
            btnDeleteItem.Name = "btnDeleteItem";
            btnDeleteItem.Size = new Size(59, 26);
            btnDeleteItem.TabIndex = 19;
            btnDeleteItem.Text = "Delete";
            btnDeleteItem.UseVisualStyleBackColor = true;
            btnDeleteItem.Click += btnDeleteItem_Click;
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
            // btnAddItem
            // 
            btnAddItem.Location = new Point(71, 156);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(77, 26);
            btnAddItem.TabIndex = 9;
            btnAddItem.Text = "+";
            btnAddItem.UseVisualStyleBackColor = true;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // btnEditItems
            // 
            btnEditItems.Location = new Point(6, 156);
            btnEditItems.Name = "btnEditItems";
            btnEditItems.Size = new Size(59, 26);
            btnEditItems.TabIndex = 1;
            btnEditItems.Text = "Edit";
            btnEditItems.UseVisualStyleBackColor = true;
            btnEditItems.Click += btnEditItems_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(lblSupplierIdGetter);
            groupBox4.Controls.Add(btnDeleteSupplier);
            groupBox4.Controls.Add(lblSupplierID);
            groupBox4.Controls.Add(txtSupplierName);
            groupBox4.Controls.Add(txtSupplierAddress);
            groupBox4.Controls.Add(btnAddSupplier);
            groupBox4.Controls.Add(txtSupplierContact);
            groupBox4.Controls.Add(btnShowTblSuppliers);
            groupBox4.Controls.Add(btnEditSupplier);
            groupBox4.Location = new Point(652, 149);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(219, 187);
            groupBox4.TabIndex = 15;
            groupBox4.TabStop = false;
            groupBox4.Text = "Set Suppliers";
            // 
            // lblSupplierIdGetter
            // 
            lblSupplierIdGetter.AutoSize = true;
            lblSupplierIdGetter.Location = new Point(82, 51);
            lblSupplierIdGetter.Name = "lblSupplierIdGetter";
            lblSupplierIdGetter.Size = new Size(12, 15);
            lblSupplierIdGetter.TabIndex = 21;
            lblSupplierIdGetter.Text = "/";
            lblSupplierIdGetter.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnDeleteSupplier
            // 
            btnDeleteSupplier.Location = new Point(151, 155);
            btnDeleteSupplier.Name = "btnDeleteSupplier";
            btnDeleteSupplier.Size = new Size(59, 26);
            btnDeleteSupplier.TabIndex = 19;
            btnDeleteSupplier.Text = "Delete";
            btnDeleteSupplier.UseVisualStyleBackColor = true;
            btnDeleteSupplier.Click += btnDeleteSupplier_Click;
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
            // btnEditSupplier
            // 
            btnEditSupplier.Location = new Point(6, 156);
            btnEditSupplier.Name = "btnEditSupplier";
            btnEditSupplier.Size = new Size(59, 26);
            btnEditSupplier.TabIndex = 1;
            btnEditSupplier.Text = "Edit";
            btnEditSupplier.UseVisualStyleBackColor = true;
            btnEditSupplier.Click += btnEditSupplier_Click;
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
            btnHome.TabIndex = 17;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnBack_Click;
            // 
            // dgvItemCategory
            // 
            dgvItemCategory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvItemCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItemCategory.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvItemCategory.Location = new Point(420, 357);
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
            dgvItems.Location = new Point(420, 357);
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
            dgvSuppliers.Location = new Point(420, 357);
            dgvSuppliers.Name = "dgvSuppliers";
            dgvSuppliers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSuppliers.Size = new Size(451, 187);
            dgvSuppliers.TabIndex = 20;
            dgvSuppliers.Visible = false;
            dgvSuppliers.CellClick += dgvSuppliers_CellClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(33, 33, 33);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(btnMaintenance);
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(btnDbBackup);
            panel1.Controls.Add(btnDelivery);
            panel1.Controls.Add(btnInventoryMonitoring);
            panel1.Controls.Add(btnSalesMonitoring);
            panel1.Controls.Add(btnPointOfSales);
            panel1.Controls.Add(btnHome);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(142, 556);
            panel1.TabIndex = 21;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(0, 137, 123);
            panel4.Location = new Point(0, 302);
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
            panel3.Controls.Add(label1);
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
            // frmMaintenance
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(66, 66, 66);
            ClientSize = new Size(883, 556);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(dgvSuppliers);
            Controls.Add(dgvItems);
            Controls.Add(dgvItemCategory);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(dgvUsers);
            Controls.Add(groupBox1);
            Name = "frmMaintenance";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Maintenance";
            Load += frmMaintenance_Load;
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
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnEditUser;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private GroupBox groupBox1;
        private Button btnShowTblCategory;
        private DataGridView dgvUsers;
        private Button btnAddUser;
        private GroupBox groupBox2;
        private Button btnAddSupplier;
        private Button btnShowTblUser;
        private Button btnEditCategory;
        private GroupBox groupBox3;
        private Button btnAddItem;
        private Button btnShowTblItems;
        private Button btnEditItems;
        private TextBox txtCategoryName;
        private TextBox txtItemName;
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
        private Button btnEditSupplier;
        private Button btnHome;
        private Button btnDeleteUser;
        private Button btnDeleteCatergory;
        private Button btnDeleteItem;
        private Button btnDeleteSupplier;
        private DataGridView dgvItemCategory;
        private DataGridView dgvItems;
        private DataGridView dgvSuppliers;
        private Label lblCategoryIdGetter;
        private Label lblItemIdGetter;
        private Label lblSupplierIdGetter;
        private ComboBox cbCategoryName;
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
        private Label label1;
        private Panel panel4;
    }
}