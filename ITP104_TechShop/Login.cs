using MySqlConnector;
using System.Data;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace ITP104_TechShop
{
    public partial class frmLogin : Form
    {
        String con;
        public frmLogin()
        {
            InitializeComponent();
            con = "Server=localhost;Database=db_TechShop; User = root; Password =1234; ";
            MySqlConnection connection = new MySqlConnection(con);
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            String sentInfo = "";
            MySqlConnection connection = new MySqlConnection(con);
            connection.Open();
            MySqlCommand command = connection.CreateCommand();
            command.Connection = connection;
            try
            {
                command.CommandText = "CALL userLogin('"+ txtUsername.Text +"', '"+ txtPassword.Text +"');";
                MySqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    sentInfo = dr["isMatch"].ToString()!;
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

            if (sentInfo == "1")
            {
                MessageBox.Show("Successfully Logged In");
                main_form();
            } 
            else
            {
                MessageBox.Show("Wrong Username or Password please try again");
            }
        }

        private void main_form()
        {
            this.Hide();
            frmMain frm = new frmMain();
            frm.ShowDialog();
            this.Close();
        }
    }
}
