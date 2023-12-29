using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ITP104_TechShop
{
    public partial class frmPointOfSales : Form
    {
        String con;
        public frmPointOfSales()
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

        private void btnCheckOut_Click(object sender, EventArgs e)
        {

        }

        private void frmPointOfSales_Load(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(con);
            connection.Open();
            try
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "SELECT * FROM tblItemCategory";
                MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adap.Fill(table);
                cbCategoryName.DataSource = new BindingSource(table, null);
                DataRow dr = table.NewRow();
                table.Rows.InsertAt(dr, 0);
                cbCategoryName.DataSource = table;
                cbCategoryName.DisplayMember = "category_Name";
                showTblCart();
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

        private void cbCategoryName_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(con);
            connection.Open();
            try
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "CALL displayItemsInCb('" + cbCategoryName.Text + "');";
                MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adap.Fill(table);
                cbItemName.DataSource = new BindingSource(table, null);
                DataRow dr = table.NewRow();
                table.Rows.InsertAt(dr, 0);
                cbItemName.DataSource = table;
                cbItemName.DisplayMember = "item_Name";
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

        private void cbItemName_SelectedIndexChanged(object sender, EventArgs e)
        {
            String tblItemID = "", tblItemBasePrice = "", tblQuantity = "";
            MySqlConnection connection = new MySqlConnection(con);
            MySqlCommand cmd = new MySqlCommand("CALL selectedItem('" + cbItemName.Text + "');");
            cmd.CommandType = CommandType.Text;
            cmd.Connection = connection;
            try
            {
                connection.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    tblItemID = dr["item_ID"].ToString();
                    tblItemBasePrice = dr["item_BasePrice"].ToString();
                    tblQuantity = dr["quantity"].ToString();
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
            lblItemIdGetter.Text = tblItemID;
            lblItemPriceGetter.Text = tblItemBasePrice;
            lblStocksChecker.Text = tblQuantity;
            decimal value = decimal.Parse(tblQuantity, CultureInfo.InvariantCulture);
            nudQuantity.Maximum = value;

        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = null;
            try
            {
                connection = new MySqlConnection(con);
                connection.Open();
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "INSERT INTO tblItems VALUES('" + lblItemIdGetter.Text + "', '" + cbItemName.Text + "', '" + cbCategoryName.Text + "', '" + lblItemPriceGetter.Text + "', '" + nudQuantity.Text + "')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Item Category ID: " + lblItemIdGetter.Text + " is successfully updated");
                lblItemIdGetter.Text = "/";
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
        private void showTblCart()
        {
            MySqlConnection connection = null;
            try
            {
                connection = new MySqlConnection(con);
                connection.Open();
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "CALL createCart();";
                MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adap.Fill(ds);
                dgvCart.DataSource = ds.Tables[0].DefaultView;
            }
            catch (MySqlException)
            {
                
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
