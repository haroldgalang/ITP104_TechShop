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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void main_Load(object sender, EventArgs e)
        {

        }

        private void btnMaintenance_Click(object sender, EventArgs e)
        {
            maintenance_form();
        }
        private void maintenance_form()
        {
            this.Hide();
            frmMaintenance frm = new frmMaintenance();
            frm.ShowDialog();
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            login_form();
        }
        private void login_form()
        {
            this.Hide();
            frmLogin frm = new frmLogin();
            frm.ShowDialog();
            this.Close();
        }

        private void btnPointOfSales_Click(object sender, EventArgs e)
        {
            pointofsales_form();
        }
        private void pointofsales_form()
        {
            this.Hide();
            frmPointOfSales frm = new frmPointOfSales();
            frm.ShowDialog();
            this.Close();
        }
    }
}
