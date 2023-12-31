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
using static System.ComponentModel.Design.ObjectSelectorEditor;

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

        private void btnEditUser_Click(object sender, EventArgs e)
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
                cmd.CommandText = "CALL showItems()";
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

        private void dgvSuppliers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgvSuppliers.CurrentRow;
            if (dgvSuppliers.CurrentCell != null)
            {
                lblSupplierIdGetter.Text = row.Cells[0].Value.ToString();
                txtSupplierName.Text = row.Cells[1].Value.ToString();
                txtSupplierAddress.Text = row.Cells[2].Value.ToString();
                txtSupplierContact.Text = row.Cells[3].Value.ToString();
            }
        }

        private void dgvItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgvItems.CurrentRow;
            if (dgvItems.CurrentCell != null)
            {
                lblItemIdGetter.Text = row.Cells[0].Value.ToString();
                txtItemName.Text = row.Cells[1].Value.ToString();
                cbCategoryName.Text = row.Cells[3].Value.ToString();
                txtBasePrice.Text = row.Cells[4].Value.ToString();
            }
        }

        private void dgvItemCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgvItemCategory.CurrentRow;
            if (dgvItemCategory.CurrentCell != null)
            {
                lblCategoryIdGetter.Text = row.Cells[0].Value.ToString();
                txtCategoryName.Text = row.Cells[1].Value.ToString();
            }
        }

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgvUsers.CurrentRow;
            if (dgvUsers.CurrentCell != null)
            {
                txtUsername.Text = row.Cells[0].Value.ToString();
                txtPassword.Text = row.Cells[1].Value.ToString();
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
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
            String sentInfo = "";
            MySqlConnection connection = new MySqlConnection(con);
            connection.Open();
            MySqlCommand command = connection.CreateCommand();
            command.Connection = connection;
            try
            {
                command.CommandText = "SELECT MAX(last_insert_id(category_ID)) AS 'getId' FROM tblItemCategory;";
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
                command.CommandText = "INSERT INTO tblItemCategory VALUES('" + IdIncrement + "', '" + txtCategoryName.Text + "')";
                command.ExecuteNonQuery();
                showTblItemCategory();
                MessageBox.Show("Item Category is successfully added");
                lblCategoryIdGetter.Text = "/";
                txtCategoryName.Text = String.Empty;
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

        private void btnDeleteCatergory_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = null;
            try
            {
                connection = new MySqlConnection(con);
                connection.Open();
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "DELETE FROM tblItemCategory WHERE category_ID = '" + lblCategoryIdGetter.Text + "'";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Item Category ID: " + lblCategoryIdGetter.Text + " is successfully deleted");
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

        private void btnEditCategory_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = null;
            try
            {
                connection = new MySqlConnection(con);
                connection.Open();
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "UPDATE tblItemCategory SET category_Name = '" + txtCategoryName.Text + "' WHERE Category_ID = '" + lblCategoryIdGetter.Text + "'";
                cmd.ExecuteNonQuery();
                showTblItemCategory();
                MessageBox.Show("Item Category ID: " + lblCategoryIdGetter.Text + " is successfully updated");
                lblCategoryIdGetter.Text = "/";
                txtCategoryName.Text = String.Empty;
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

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            String sentInfo = "";
            MySqlConnection connection = new MySqlConnection(con);
            connection.Open();
            MySqlCommand command = connection.CreateCommand();
            command.Connection = connection;
            try
            {
                command.CommandText = "SELECT MAX(last_insert_id(item_ID)) AS 'getId' FROM tblItems;";
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
                command.CommandText = "INSERT INTO tblItems VALUES('" + IdIncrement + "', '" + txtItemName.Text + "', (SELECT category_ID FROM tblItemCategory WHERE category_Name = '" + cbCategoryName.Text + "'),'" + txtBasePrice.Text + "')";
                command.ExecuteNonQuery();
                showTblItems();
                MessageBox.Show("Item is successfully added");
                lblItemIdGetter.Text = "/";
                txtItemName.Text = String.Empty;
                cbCategoryName.Text = "Category Name";
                txtBasePrice.Text = String.Empty;
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

        private void btnEditItems_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = null;
            try
            {
                connection = new MySqlConnection(con);
                connection.Open();
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "CALL updateItem('" + txtItemName.Text + "', '" + cbCategoryName.Text + "', '" + txtBasePrice.Text + "', '" + lblItemIdGetter.Text + "')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Item Category ID: " + lblItemIdGetter.Text + " is successfully updated");
                lblItemIdGetter.Text = "/";
                txtItemName.Text = String.Empty;
                cbCategoryName.Text = "Category ID";
                txtBasePrice.Text = String.Empty;
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

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = null;
            try
            {
                connection = new MySqlConnection(con);
                connection.Open();
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "DELETE FROM tblItems WHERE item_ID = '" + lblItemIdGetter.Text + "'";
                cmd.ExecuteNonQuery();
                showTblItems();
                MessageBox.Show("Item ID: " + lblItemIdGetter.Text + " is successfully deleted");
                lblItemIdGetter.Text = "/";
                txtItemName.Text = String.Empty;
                cbCategoryName.Text = "Category ID";
                txtBasePrice.Text = String.Empty;
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

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            String sentInfo = "";
            MySqlConnection connection = new MySqlConnection(con);
            connection.Open();
            MySqlCommand command = connection.CreateCommand();
            command.Connection = connection;
            try
            {
                command.CommandText = "SELECT MAX(last_insert_id(supplier_ID)) AS 'getId' FROM tblSuppliers;";
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
                command.CommandText = "INSERT INTO tblSuppliers VALUES('" + IdIncrement + "', '" + txtSupplierName.Text + "', '" + txtSupplierAddress.Text + "','" + txtSupplierContact.Text + "' )";
                command.ExecuteNonQuery();
                showTblSuppliers();
                MessageBox.Show("Supplier is successfully added");
                lblSupplierIdGetter.Text = "/";
                txtSupplierName.Text = String.Empty;
                txtSupplierAddress.Text = String.Empty;
                txtSupplierContact.Text = String.Empty;
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

        private void btnDeleteSupplier_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = null;
            try
            {
                connection = new MySqlConnection(con);
                connection.Open();
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "DELETE FROM tblSuppliers WHERE supplier_ID = '" + lblSupplierIdGetter.Text + "'";
                cmd.ExecuteNonQuery();
                showTblSuppliers();
                MessageBox.Show("Supplier ID: " + lblSupplierIdGetter.Text + " is successfully deleted");
                lblSupplierIdGetter.Text = "/";
                txtSupplierName.Text = String.Empty;
                txtSupplierAddress.Text = String.Empty;
                txtSupplierContact.Text = String.Empty;
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

        private void btnEditSupplier_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = null;
            try
            {
                connection = new MySqlConnection(con);
                connection.Open();
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "UPDATE tblSuppliers SET supplier_Name = '" + txtSupplierName.Text + "',supplier_Address = '" + txtSupplierAddress.Text + "',supplier_ContactNum = '" + txtSupplierContact.Text + "' WHERE supplier_ID = '" + lblSupplierIdGetter.Text + "'";
                cmd.ExecuteNonQuery();
                showTblSuppliers();
                MessageBox.Show("Item Category ID: " + lblSupplierIdGetter.Text + " is successfully updated");
                lblSupplierIdGetter.Text = "/";
                txtSupplierName.Text = String.Empty;
                txtSupplierAddress.Text = String.Empty;
                txtSupplierContact.Text = String.Empty;
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

        private void frmMaintenance_Load(object sender, EventArgs e)
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
    }
}
