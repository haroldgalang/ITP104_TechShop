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
    public partial class frmPointOfSales : Form
    {
        String con;
        public frmPointOfSales()
        {
            InitializeComponent();
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

        private void chkCpu_CheckedChanged(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(con);
            connection.Open();
            try
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "SELECT category_ID FROM tblItemCategory";
                MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adap.Fill(table);
                cbCategoryID.DataSource = new BindingSource(table, null);
                DataRow dr = table.NewRow();
                table.Rows.InsertAt(dr, 0);
                cbCategoryID.DataSource = table;
                cbCategoryID.DisplayMember = "category_ID";
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
