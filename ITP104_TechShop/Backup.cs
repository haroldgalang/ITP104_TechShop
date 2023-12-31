using Microsoft.VisualBasic.Devices;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITP104_TechShop
{
    public partial class frmBackup : Form
    {
        String con;
        public frmBackup()
        {
            InitializeComponent();
            con = "Server=localhost;Database=db_TechShop; User = root; Password =1234; ";
            MySqlConnection connection = new MySqlConnection(con);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain frm = new frmMain();
            frm.ShowDialog();
            this.Close();
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            string sSelectedFolder, filePathName;
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                sSelectedFolder = fbd.SelectedPath;
                filePathName = System.IO.Path.Combine(sSelectedFolder,
                "ThisIsTheBackUpFile" +
                DateTime.Now.Month.ToString("00") +
                DateTime.Now.Day.ToString("00") + ".bak");
                BackupRestore(filePathName, "Backup");
            }
            else
            {
                sSelectedFolder = string.Empty;
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            string filePathName;
            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.Filter = "All Files (*.bak)|*.bak";
            choofdlog.FilterIndex = 1;
            choofdlog.Multiselect = true;
            if (choofdlog.ShowDialog() == DialogResult.OK)
            {
                filePathName = choofdlog.FileName;
                BackupRestore(filePathName, "Restore");
            }
            else
            {
                filePathName = string.Empty;
            }
        }

        public void BackupRestore(String path, String toDo)
        {
            MySqlConnection conn = new MySqlConnection(con);
            MySqlCommand cmd = new MySqlCommand();
            MySqlBackup mb = new MySqlBackup(cmd);
            try
            {
                cmd.Connection = conn;
                conn.Open();

                if (toDo.Equals("Backup"))
                {
                    mb.ExportToFile(path);
                }
                else
                {
                    mb.ImportFromFile(path);
                }
                MessageBox.Show("Database " + toDo + " successfully\n" +
                path);
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void btnMaintenance_Click(object sender, EventArgs e)
        {
            maintenance_form();
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            login_form();
        }
        private void btnPointOfSales_Click(object sender, EventArgs e)
        {
            pointofsales_form();
        }
        private void btnDelivery_Click(object sender, EventArgs e)
        {
            delivery_form();
        }
        private void btnInventoryMonitoring_Click(object sender, EventArgs e)
        {
            inventory_form();
        }
        private void btnSalesMonitoring_Click(object sender, EventArgs e)
        {
            sales_form();
        }

        private void login_form()
        {
            this.Hide();
            frmLogin frm = new frmLogin();
            frm.ShowDialog();
            this.Close();
        }
        private void maintenance_form()
        {
            this.Hide();
            frmMaintenance frm = new frmMaintenance();
            frm.ShowDialog();
            this.Close();
        }
        private void pointofsales_form()
        {
            this.Hide();
            frmPointOfSales frm = new frmPointOfSales();
            frm.ShowDialog();
            this.Close();
        }
        private void inventory_form()
        {
            this.Hide();
            frmInventory frm = new frmInventory();
            frm.ShowDialog();
            this.Close();
        }
        private void delivery_form()
        {
            this.Hide();
            frmDelivery frm = new frmDelivery();
            frm.ShowDialog();
            this.Close();
        }
        private void sales_form()
        {
            this.Hide();
            frmSales frm = new frmSales();
            frm.ShowDialog();
            this.Close();
        }    
    }
}
