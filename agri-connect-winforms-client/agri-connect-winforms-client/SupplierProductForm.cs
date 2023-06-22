using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using shared_interfaces;
using shared_interfaces.DTO;

namespace agri_connect_winforms_client
{
    public partial class SupplierProductForm : Form
    {
        private ISupplierProduct isupplierProduct;
        private DataTable productsTable;

        public SupplierProductForm()
        {
            InitializeComponent();
        }

        private void SupplierProductForm_Load(object sender, EventArgs e)
        {
            TcpChannel channel = new TcpChannel();
            ChannelServices.RegisterChannel(channel, false);

            isupplierProduct = (ISupplierProduct)Activator.GetObject(
                typeof(ISupplierProduct), "tcp://localhost:12345/SupplierProduct");

            ListSupplierProducts();

        }

        private void ListSupplierProducts()
        {
            productsTable = new DataTable();
            productsTable.Columns.Add("ID", typeof(int));
            productsTable.Columns.Add("Name", typeof(string));
            productsTable.Columns.Add("Price", typeof(int));

            List<SupplierProductDto> supplierProducts = isupplierProduct.GetSupplierProducts();
            foreach (var supplierProduct in supplierProducts)
            {
                productsTable.Rows.Add(supplierProduct.Id, supplierProduct.Name, supplierProduct.Price);
            }

            dataGridView1.DataSource = productsTable;
        }

        private void addSupplierProductButton_Click(object sender, EventArgs e)
        {
            SupplierProductDto supplierProduct = new SupplierProductDto();

            supplierProduct.Name = nameField.Text;
            supplierProduct.Price = int.Parse(priceField.Text);

            isupplierProduct.AddSupplierProduct(supplierProduct);

            MessageBox.Show("Product added successfully");

            ListSupplierProducts();
        }
    }
}
