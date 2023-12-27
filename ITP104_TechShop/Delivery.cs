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
            MySqlConnection connection = null;
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
            }
            catch (Exception z)
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

        private void dgvDelivery_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
            MySqlConnection connection = null;
            try
            {
                connection = new MySqlConnection(con);
                connection.Open();
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "CALL deliverStocks('" + lblItemIdGetter.Text + "', '" + nudQuantity.Text + "');";
                cmd.ExecuteNonQuery();
                MessageBox.Show(lblItemName.Text + " successfully delivered");
            }
            catch (Exception z)
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
