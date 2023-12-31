using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
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
            if (lblStocksChecker.Text == "Out Of Stock")
            {
                MessageBox.Show("Can't Checkout out of stock items");
            }
            else
            {
                String sentInfo = "";
                MySqlConnection connection = new MySqlConnection(con);
                MySqlCommand command = connection.CreateCommand();
                command.Connection = connection;
                nudQuantity.Value = 1;
                MySqlCommand cmd = connection.CreateCommand();
                connection.Open();
                try
                {
                    command.CommandText = "SELECT IF(ISNULL(MAX(last_insert_id(receipt_ID))),'0',MAX(last_insert_id(receipt_ID))) AS 'getId' FROM tblSales";
                    MySqlDataReader dr = command.ExecuteReader();
                    while (dr.Read())
                    {
                        sentInfo = dr["getId"].ToString();
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
                    decimal quantityGetter = decimal.Parse(nudQuantity.Text, CultureInfo.InvariantCulture);
                    decimal stocksGetter = decimal.Parse(lblStocksChecker.Text, CultureInfo.InvariantCulture);

                    stocksGetter = stocksGetter - quantityGetter;
                    command.CommandText = "INSERT INTO tblSales VALUES('" + IdIncrement + "',curdate() ,'" + lblItemIdGetter.Text + "', '" + nudQuantity.Text + "', '" + lblTotalPriceGetter.Text + "');";
                    command.ExecuteNonQuery();
                    lblStocksChecker.Text = stocksGetter.ToString();
                    MessageBox.Show("Item added successfully");

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
            nudQuantity.Minimum = 1;
            nudQuantity.Value = 1;
            try
            {
                decimal QuantityDecimal = decimal.Parse(tblQuantity, CultureInfo.InvariantCulture);
                nudQuantity.Maximum = QuantityDecimal;
            }
            catch (FormatException)
            {
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

        private void nudQuantity_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                double priceDecimal = double.Parse(lblItemPriceGetter.Text, CultureInfo.InvariantCulture);
                double quantityDecimal = double.Parse(nudQuantity.Text, CultureInfo.InvariantCulture);

                double totalPrice = priceDecimal * quantityDecimal;
                lblTotalPriceGetter.Text = totalPrice.ToString();
            }
            catch (FormatException)
            {
            }
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            /*String sentInfo = "";
            MySqlConnection connection = new MySqlConnection(con);
            connection.Open();
            MySqlCommand command = connection.CreateCommand();
            command.Connection = connection;
            try
            {
                command.CommandText = "CALL tingen('" + lblItemIdGetter.Text + "');";
                MySqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    sentInfo = dr["isMatch"].ToString();
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

            if (lblStocksChecker.Text == "Out Of Stock")
            {
                MessageBox.Show("Can't add out of stock items");
            }
            else
            {
                MySqlCommand cmd = connection.CreateCommand();

                if (sentInfo == "1")
                {
                    connection.Open();
                    try
                    {
                        String getTotalPrice = "", getQuantity = "";
                        command.CommandText = "SELECT cart_TotalPrice,cart_Quantity FROM tblCart WHERE cart_itemID = '" + lblItemIdGetter.Text + "'; SELECT * FROM tblInventory;";
                        MySqlDataReader dr = command.ExecuteReader();
                        while (dr.Read())
                        {
                            getTotalPrice = dr["cart_TotalPrice"].ToString();
                            getQuantity = dr["cart_Quantity"].ToString();
                        }
                        dr.Close();
                        decimal totalPriceGetter = decimal.Parse(lblTotalPriceGetter.Text, CultureInfo.InvariantCulture);
                        decimal totalPrice = decimal.Parse(getTotalPrice, CultureInfo.InvariantCulture);
                        decimal quantityGetter = decimal.Parse(nudQuantity.Text, CultureInfo.InvariantCulture);
                        decimal quantity = decimal.Parse(getQuantity, CultureInfo.InvariantCulture);
                        decimal stocksGetter = decimal.Parse(lblStocksChecker.Text, CultureInfo.InvariantCulture);

                        totalPriceGetter = totalPriceGetter + totalPrice;
                        quantity = quantityGetter + quantity;
                        stocksGetter = stocksGetter - quantityGetter;

                        command.CommandText = "UPDATE tblCart SET cart_item = '" + cbItemName.Text + "',cart_itemCategory = '" + cbCategoryName.Text + "',cart_itemPrice = '" + lblItemPriceGetter.Text + "', cart_Quantity = '" + quantity + "',cart_TotalPrice = '" + totalPriceGetter + "' WHERE cart_itemID = '" + lblItemIdGetter.Text + "';";
                        command.ExecuteNonQuery();
                        lblStocksChecker.Text = stocksGetter.ToString();
                        MessageBox.Show("Item added successfully");
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
                else
                {
                    connection.Open();
                    try
                    {
                        command.CommandText = "SELECT * FROM tblInventory;";
                        decimal quantityGetter = decimal.Parse(nudQuantity.Text, CultureInfo.InvariantCulture);
                        decimal stocksGetter = decimal.Parse(lblStocksChecker.Text, CultureInfo.InvariantCulture);

                        stocksGetter = stocksGetter - quantityGetter;
                        command.CommandText = "INSERT INTO tblCart VALUES('" + lblItemIdGetter.Text + "', '" + cbItemName.Text + "','" + cbCategoryName.Text + "', '" + lblItemPriceGetter.Text + "', '" + nudQuantity.Text + "', '" + lblTotalPriceGetter.Text + "');";
                        command.ExecuteNonQuery();
                        lblStocksChecker.Text = stocksGetter.ToString();
                        MessageBox.Show("Item added successfully");
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
                cmd.CommandText = "SELECT * FROM tblCart";
                MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adap.Fill(ds);
                dgvCart.DataSource = ds.Tables[0].DefaultView;
                nudQuantity.Minimum = 1;
                nudQuantity.Value = 1;
            }*/
        }
    }
}
