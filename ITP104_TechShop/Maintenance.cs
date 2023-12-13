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
    public partial class frmMaintenance : Form
    {
        String con;
        public frmMaintenance()
        {
            InitializeComponent();
            con = "Server=localhost;Database=db_TechShop; User = root; Password =1234; ";
            MySqlConnection connection = new MySqlConnection(con);
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = null;
            try
            {
                connection = new MySqlConnection(con);
                connection.Open();
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "UPDATE tblUsers SET password = '" + txtPassword.Text + "' WHERE username = '" + txtUsername.Text + "'";
                cmd.ExecuteNonQuery();
                MessageBox.Show(txtUsername.Text + " is successfully updated");
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

        private void btnShowTblCategory_Click(object sender, EventArgs e)
        {
            showTblItemCategory();
            dgvUsers.Visible = false;
            dgvItemCategory.Visible = true;
            dgvSuppliers.Visible = false;
            dgvItems.Visible = false;
        }

        private void btnShowTblUser_Click(object sender, EventArgs e)
        {
            showTblUsers();
            dgvUsers.Visible = true;
            dgvItemCategory.Visible = false;
            dgvSuppliers.Visible = false;
            dgvItems.Visible = false;
        }

        private void btnShowTblItems_Click(object sender, EventArgs e)
        {
            showTblItems();
            dgvUsers.Visible = false;
            dgvItemCategory.Visible = false;
            dgvSuppliers.Visible = false;
            dgvItems.Visible = true;
        }

        private void btnShowTblSuppliers_Click(object sender, EventArgs e)
        {
            showTblSuppliers();
            dgvUsers.Visible = false;
            dgvItemCategory.Visible = false;
            dgvSuppliers.Visible = true;
            dgvItems.Visible = false;
        }

        private void showTblUsers()
        {
            MySqlConnection connection = null;
            try
            {
                connection = new MySqlConnection(con);
                connection.Open();
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "Select * From tblUsers";
                MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adap.Fill(ds);
                dgvUsers.DataSource = ds.Tables[0].DefaultView;
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
        private void showTblItemCategory()
        {
            MySqlConnection connection = null;
            try
            {
                connection = new MySqlConnection(con);
                connection.Open();
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "Select * From tblItemCategory";
                MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adap.Fill(ds);
                dgvItemCategory.DataSource = ds.Tables[0].DefaultView;
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
        private void showTblSuppliers()
        {
            MySqlConnection connection = null;
            try
            {
                connection = new MySqlConnection(con);
                connection.Open();
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "Select * From tblSuppliers";
                MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adap.Fill(ds);
                dgvSuppliers.DataSource = ds.Tables[0].DefaultView;
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
        private void showTblItems()
        {
            MySqlConnection connection = null;
            try
            {
                connection = new MySqlConnection(con);
                connection.Open();
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "Select * From tblItems";
                MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adap.Fill(ds);
                dgvItems.DataSource = ds.Tables[0].DefaultView;
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

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(con);
            connection.Open();
            MySqlCommand command = connection.CreateCommand();
            command.Connection = connection;
            try
            {
                command.CommandText = "INSERT INTO tblUsers VALUES('" + txtUsername.Text + "', '" + txtPassword.Text + "')";
                command.ExecuteNonQuery();
                showTblUsers();
                MessageBox.Show("User is successfully added");
                txtUsername.Text = String.Empty;
                txtPassword.Text = String.Empty;
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain frm = new frmMain();
            frm.ShowDialog();
            this.Close();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {

        }

        private void dgvSuppliers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvItemCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgvUsers.CurrentRow;
            if (dgvUsers.CurrentCell != null)
            {
                txtUsername.Text = row.Cells[0].Value.ToString();
                txtPassword.Text = row.Cells[1].Value.ToString();
            }
        }

        private void btnDeleteUser_Click_1(object sender, EventArgs e)
        {
            MySqlConnection connection = null;
            try
            {
                connection = new MySqlConnection(con);
                connection.Open();
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "DELETE FROM tblUsers WHERE username = '" + txtUsername.Text + "'";
                cmd.ExecuteNonQuery();
                MessageBox.Show(txtUsername.Text + " is successfully deleted");
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

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(con);
            connection.Open();
            MySqlCommand command = connection.CreateCommand();
            command.Connection = connection;
            
            try
            {
                long idIncrement = command.LastInsertedId;
                idIncrement++;
                command.CommandText = "INSERT INTO tblItemCategory VALUES('" + idIncrement + "','" + txtCategoryName.Text + "')";
                command.ExecuteNonQuery();
                showTblUsers();
                MessageBox.Show("User is successfully added");
                txtUsername.Text = String.Empty;
                txtPassword.Text = String.Empty;
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








//cmd.ExecuteNonQuery();
//int long = cmd.LastInsertedId;