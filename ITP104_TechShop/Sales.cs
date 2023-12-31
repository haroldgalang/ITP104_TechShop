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
    public partial class frmSales : Form
    {
        String con;
        public frmSales()
        {
            InitializeComponent();
            con = "Server=localhost;Database=db_TechShop; User = root; Password =1234; ";
            MySqlConnection connection = new MySqlConnection(con);
        }

        private void frmSales_Load(object sender, EventArgs e)
        {
            MySqlConnection connection = null;
            try
            {
                connection = new MySqlConnection(con);
                connection.Open();
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "CALL showInventory();";
                MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adap.Fill(ds);
                dgvSales.DataSource = ds.Tables[0].DefaultView;
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain frm = new frmMain();
            frm.ShowDialog();
            this.Close();
        }
    }
}
