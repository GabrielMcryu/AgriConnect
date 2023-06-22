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
        }

        private void sp_button_Click(object sender, EventArgs e)
        {
            SupplierProductForm supplierProductForm = new SupplierProductForm();
            supplierProductForm.Show();
        }

        private void st_button_Click(object sender, EventArgs e)
        {
            SupplierTransactionForm supplierTransactionForm = new SupplierTransactionForm();
            supplierTransactionForm.Show();
        }
    }
}
