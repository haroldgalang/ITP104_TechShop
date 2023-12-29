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
    }
}
