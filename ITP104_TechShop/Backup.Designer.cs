namespace ITP104_TechShop
{
    partial class frmBackup
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
            btnBack = new Button();
            btnBackup = new Button();
            btnRestore = new Button();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Location = new Point(12, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(148, 30);
            btnBack.TabIndex = 18;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnBackup
            // 
            btnBackup.Location = new Point(12, 48);
            btnBackup.Name = "btnBackup";
            btnBackup.Size = new Size(148, 30);
            btnBackup.TabIndex = 19;
            btnBackup.Text = "Backup";
            btnBackup.UseVisualStyleBackColor = true;
            btnBackup.Click += btnBackup_Click;
            // 
            // btnRestore
            // 
            btnRestore.Location = new Point(12, 84);
            btnRestore.Name = "btnRestore";
            btnRestore.Size = new Size(148, 30);
            btnRestore.TabIndex = 20;
            btnRestore.Text = "Restore";
            btnRestore.UseVisualStyleBackColor = true;
            btnRestore.Click += btnRestore_Click;
            // 
            // frmBackup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(176, 129);
            Controls.Add(btnRestore);
            Controls.Add(btnBackup);
            Controls.Add(btnBack);
            Name = "frmBackup";
            Text = "Backup";
            ResumeLayout(false);
        }

        #endregion

        private Button btnBack;
        private Button btnBackup;
        private Button btnRestore;
    }
}