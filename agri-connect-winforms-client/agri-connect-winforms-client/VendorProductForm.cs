using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using shared_interfaces;
using shared_interfaces.DTO;

namespace agri_connect_winforms_client
{
    public partial class VendorProductForm : Form
    {
        private IVendorProduct iVendorProduct;
        private DataTable productsTable;
        private TcpChannel channel;

        public VendorProductForm()
        {
            InitializeComponent();
        }

        private void VendorProductForm_Load(object sender, EventArgs e)
        {
            channel = new TcpChannel();
            ChannelServices.RegisterChannel(channel, false);

            iVendorProduct = (IVendorProduct)Activator.GetObject(
                typeof(IVendorProduct), "tcp://localhost:12345/VendorProduct");

            ListVendorProducts();
        }

        private void VendorProductForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ChannelServices.UnregisterChannel(channel);
            MenuForm menuForm = new MenuForm();
            menuForm.Show();
        }

        private void ListVendorProducts()
        {
            productsTable = new DataTable();
            productsTable.Columns.Add("ID", typeof(int));
            productsTable.Columns.Add("Name", typeof(string));
            productsTable.Columns.Add("Price", typeof(int));

            List<VendorProductDto> vendorProducts = iVendorProduct.GetVendorProducts();
            foreach (var vendorProduct in vendorProducts)
            {
                productsTable.Rows.Add(vendorProduct.Id, vendorProduct.Name, vendorProduct.Price);
            }

            dataGridView1.DataSource = productsTable;
        }

        private void ListVendorProduct(int Id)
        {
            productsTable = new DataTable();
            productsTable.Columns.Add("ID", typeof(int));
            productsTable.Columns.Add("Name", typeof(string));
            productsTable.Columns.Add("Price", typeof(int));

            VendorProductDto vendorProduct = iVendorProduct.GetVendorProduct(Id);

            productsTable.Rows.Add(vendorProduct.Id, vendorProduct.Name, vendorProduct.Price);

            dataGridView1.DataSource = productsTable;
        }

        private void GetAllVendorProductsButton_Click(object sender, EventArgs e)
        {
            ListVendorProducts();
        }

        private void GetVendorProductButton_Click(object sender, EventArgs e)
        {
            int vendorProductId = int.Parse(idField.Text);
            ListVendorProduct(vendorProductId);
        }

        private void AddVendorProductButton_Click(object sender, EventArgs e)
        {
            VendorProductDto vendorProduct = new VendorProductDto();
            vendorProduct.Name = nameField.Text;
            vendorProduct.Price = int.Parse(priceField.Text);

            iVendorProduct.AddVendorProduct(vendorProduct);

            MessageBox.Show("Product added successfully");

            ListVendorProducts();
        }

        private void UpdateVendorProductButton_Click(object sender, EventArgs e)
        {
            VendorProductDto vendorProduct = new VendorProductDto();

            vendorProduct.Id = int.Parse(idField.Text);
            vendorProduct.Name = nameField.Text;
            vendorProduct.Price = int.Parse(priceField.Text);

            iVendorProduct.UpdateVendorproduct(vendorProduct);

            MessageBox.Show("Product updated successfully");

            ListVendorProducts();
        }

        private void DeleteVendorProductButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete?", "Delete Document", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int vendorProductId = int.Parse(idField.Text);

                iVendorProduct.DeleteVendorProduct(vendorProductId);

                MessageBox.Show("Product delete successfully");

                ListVendorProducts();
            }
        }
    }
}
