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
            ((System.ComponentModel.ISupportInitialize)dgvDelivery).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            SuspendLayout();
            // 
            // dgvDelivery
            // 
            dgvDelivery.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDelivery.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDelivery.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvDelivery.Location = new Point(12, 178);
            dgvDelivery.Name = "dgvDelivery";
            dgvDelivery.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDelivery.Size = new Size(550, 160);
            dgvDelivery.TabIndex = 0;
            dgvDelivery.CellContentClick += dgvDelivery_CellContentClick;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(12, 92);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 2;
            // 
            // nudQuantity
            // 
            nudQuantity.Location = new Point(11, 149);
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(120, 23);
            nudQuantity.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 5;
            label1.Text = "Selected Item:";
            // 
            // lblItemName
            // 
            lblItemName.AutoEllipsis = true;
            lblItemName.AutoSize = true;
            lblItemName.Location = new Point(99, 9);
            lblItemName.Name = "lblItemName";
            lblItemName.Size = new Size(12, 15);
            lblItemName.TabIndex = 6;
            lblItemName.Text = "/";
            // 
            // lblItemIdGetter
            // 
            lblItemIdGetter.AutoSize = true;
            lblItemIdGetter.Location = new Point(66, 42);
            lblItemIdGetter.Name = "lblItemIdGetter";
            lblItemIdGetter.Size = new Size(12, 15);
            lblItemIdGetter.TabIndex = 7;
            lblItemIdGetter.Text = "/";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 74);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 8;
            label4.Text = "Date:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 131);
            label5.Name = "label5";
            label5.Size = new Size(56, 15);
            label5.TabIndex = 9;
            label5.Text = "Quantity:";
            // 
            // btnDeliver
            // 
            btnDeliver.Location = new Point(137, 147);
            btnDeliver.Name = "btnDeliver";
            btnDeliver.Size = new Size(77, 25);
            btnDeliver.TabIndex = 10;
            btnDeliver.Text = "Deliver";
            btnDeliver.UseVisualStyleBackColor = true;
            btnDeliver.Click += btnDeliver_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 42);
            label6.Name = "label6";
            label6.Size = new Size(48, 15);
            label6.TabIndex = 11;
            label6.Text = "Item ID:";
            // 
            // frmDelivery
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(574, 348);
            Controls.Add(label6);
            Controls.Add(btnDeliver);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(lblItemIdGetter);
            Controls.Add(lblItemName);
            Controls.Add(label1);
            Controls.Add(nudQuantity);
            Controls.Add(dateTimePicker1);
            Controls.Add(dgvDelivery);
            Name = "frmDelivery";
            Text = "Delivery";
            Load += frmDelivery_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDelivery).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
    }
}