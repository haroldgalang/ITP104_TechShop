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
    }
}
