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
    public partial class frmDelivery : Form
    {
        String con;
        public frmDelivery()
        {
            InitializeComponent();
            con = "Server=localhost;Database=db_TechShop; User = root; Password =1234; ";
            MySqlConnection connection = new MySqlConnection(con);
        }

        private void frmDelivery_Load(object sender, EventArgs e)
        {
            String sentInfo = "";
            MySqlConnection connection = new MySqlConnection(con);
            connection.Open();
            MySqlCommand command = connection.CreateCommand();
            command.Connection = connection;
            try
            {
                command.CommandText = "SELECT now() AS DateNow;";
                MySqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    sentInfo = dr["DateNow"].ToString()!;
                }
                dr.Close();
            }
            catch (Exception z)
            {
                MessageBox.Show(z.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            connection.Open();
            try
            {
                connection = new MySqlConnection(con);
                connection.Open();
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "CALL showDeliveryItems();";
                MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adap.Fill(ds);
                dgvDelivery.DataSource = ds.Tables[0].DefaultView;
                showDeliveryTable();
                lblDate.Text = sentInfo;
            }
            catch (Exception z)
            {
                MessageBox.Show(z.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void dgvDelivery_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgvDelivery.CurrentRow;
            if (dgvDelivery.CurrentCell != null)
            {
                lblItemIdGetter.Text = row.Cells[0].Value.ToString();
                lblItemName.Text = row.Cells[1].Value.ToString();
            }
        }

        private void btnDeliver_Click(object sender, EventArgs e)
        {
            String sentInfo = "";
            MySqlConnection connection = new MySqlConnection(con);
            connection.Open();
            MySqlCommand command = connection.CreateCommand();
            command.Connection = connection;
            try
            {
                command.CommandText = "SELECT MAX(last_insert_id(delivery_ID)) AS 'getId' FROM tblDelivery;";
                MySqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    sentInfo = dr["getId"].ToString()!;
                }
                dr.Close();
            }
            catch (Exception z)
            {
                MessageBox.Show(z.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            connection.Open();
            try
            {
                int IdIncrement = int.Parse(sentInfo);
                IdIncrement++;
                command.CommandText = "CALL deliverStocks('" + lblItemIdGetter.Text + "', '" + nudQuantity.Text + "'); CALL insertDelivery('" + IdIncrement + "','" + lblItemIdGetter.Text + "','" + nudQuantity.Text + "');";
                command.ExecuteNonQuery();
                MessageBox.Show(lblItemName.Text + " successfully delivered");
                showDeliveryTable();
            }
            catch (Exception z)
            {
                MessageBox.Show(z.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
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
        private void btnDbBackup_Click(object sender, EventArgs e)
        {
            backup_form();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            home_form();
        }

        private void home_form()
        {
            this.Hide();
            frmMain frm = new frmMain();
            frm.ShowDialog();
            this.Close();
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
        private void backup_form()
        {
            this.Hide();
            frmBackup frm = new frmBackup();
            frm.ShowDialog();
            this.Close();
        }
        private void showDeliveryTable()
        {
            MySqlConnection connection = null!;
            try
            {
                connection = new MySqlConnection(con);
                connection.Open();
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "SELECT * FROM tblDelivery;";
                MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adap.Fill(ds);
                dgvDeliveryTable.DataSource = ds.Tables[0].DefaultView;
            }
            catch (Exception)
            {
                MessageBox.Show("Connection Problem");
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
    }
}
