using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace agri_connect_winforms_client
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();

            Shown += MenuForm_Shown;
        }

        private void sp_button_Click(object sender, EventArgs e)
        {
            SupplierProductForm supplierProductForm = new SupplierProductForm();
            supplierProductForm.Show();
            Hide();
        }

        private void st_button_Click(object sender, EventArgs e)
        {
            SupplierTransactionForm supplierTransactionForm = new SupplierTransactionForm();
            supplierTransactionForm.Show();
            Hide();
        }

        private void vp_button_Click(object sender, EventArgs e)
        {
            VendorProductForm vendorProductForm = new VendorProductForm();
            vendorProductForm.Show();
            Hide();
        }

        private void vt_button_Click(object sender, EventArgs e)
        {
            VendorTransactionForm vendorTransactionForm = new VendorTransactionForm();
            vendorTransactionForm.Show();
            Hide();
        }

        private void userButton_Click(object sender, EventArgs e)
        {
            UserForm userForm = new UserForm();
            userForm.Show();
            Hide();
        }

        private void MenuForm_Shown(object sender, EventArgs e)
        {

        }

        private void MenuForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Application.Exit();
        }

        private void MenuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Loginform loginForm = new Loginform();
            loginForm.Show();
        }
    }
}
