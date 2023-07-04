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
    public partial class VendorTransactionForm : Form
    {
        private IVendorTransaction iVendorTransaction;
        private DataTable transactionsTable;
        private TcpChannel channel;

        public VendorTransactionForm()
        {
            InitializeComponent();
        }

        private void VendorTransactionForm_Load(object sender, EventArgs e)
        {
            channel = new TcpChannel();
            ChannelServices.RegisterChannel(channel, false);

            iVendorTransaction = (IVendorTransaction)Activator.GetObject(
                typeof(IVendorTransaction), "tcp://localhost:12345/VendorTransaction");

            ListVendorTransactions();
        }

        private void VendorTransactionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ChannelServices.UnregisterChannel(channel);
            MenuForm menuForm = new MenuForm();
            menuForm.Show();
        }

        private void ListVendorTransactions()
        {
            transactionsTable = new DataTable();
            transactionsTable.Columns.Add("ID", typeof(int));
            transactionsTable.Columns.Add("Vendor", typeof(string));
            transactionsTable.Columns.Add("Product", typeof(string));
            transactionsTable.Columns.Add("Quantity", typeof(int));
            transactionsTable.Columns.Add("Cost", typeof(int));
            transactionsTable.Columns.Add("Date", typeof(DateTime));

            List<VendorTransactionDto> vendorTransactions = iVendorTransaction.GetVendorTransactions();
            foreach (var vendorTransaction in vendorTransactions)
            {
                transactionsTable.Rows.Add(vendorTransaction.Id, vendorTransaction.VendorName, vendorTransaction.ProductName, vendorTransaction.ProductQuantity, vendorTransaction.Cost, vendorTransaction.TransactionDate);
            }

            dataGridView1.DataSource = transactionsTable;

            dataGridView1.Columns["Date"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void ListVendorTransaction(int Id)
        {
            transactionsTable = new DataTable();
            transactionsTable.Columns.Add("ID", typeof(int));
            transactionsTable.Columns.Add("Vendor", typeof(string));
            transactionsTable.Columns.Add("Product", typeof(string));
            transactionsTable.Columns.Add("Quantity", typeof(int));
            transactionsTable.Columns.Add("Cost", typeof(int));
            transactionsTable.Columns.Add("Date", typeof(DateTime));

            VendorTransactionDto vendorTransaction = iVendorTransaction.GetVendorTransaction(Id);

            transactionsTable.Rows.Add(vendorTransaction.Id, vendorTransaction.VendorName, vendorTransaction.ProductName, vendorTransaction.ProductQuantity, vendorTransaction.Cost, vendorTransaction.TransactionDate);

            dataGridView1.DataSource = transactionsTable;
        }

        private void GetAllVendorTransactionsButton_Click(object sender, EventArgs e)
        {
            ListVendorTransactions();
        }

        private void GetVendorTransactionButton_Click(object sender, EventArgs e)
        {
            int vendorTransactionId = int.Parse(idField.Text);
            ListVendorTransaction(vendorTransactionId);
        }
    }
}
