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
    public partial class SupplierTransactionForm : Form
    {
        private ISupplierTransaction iSupplierTransaction;
        private DataTable transactionsTable;

        public SupplierTransactionForm()
        {
            InitializeComponent();
        }

        private void SupplierTransactionForm_Load(object sender, EventArgs e)
        {
            TcpChannel channel = new TcpChannel();
            ChannelServices.RegisterChannel(channel, false);

            iSupplierTransaction = (ISupplierTransaction)Activator.GetObject(
                typeof(ISupplierTransaction), "tcp://localhost:12345/SupplierTransaction");

            ListSupplierTransactions();
        }

        private void ListSupplierTransactions()
        {
            transactionsTable = new DataTable();
            transactionsTable.Columns.Add("ID", typeof(int));
            transactionsTable.Columns.Add("Supplier", typeof(string));
            transactionsTable.Columns.Add("Product", typeof(string));
            transactionsTable.Columns.Add("Quantity", typeof(int));
            transactionsTable.Columns.Add("Cost", typeof(int));
            transactionsTable.Columns.Add("Date", typeof(DateTime));

            List<SupplierTransactionDto> supplierTransactions = iSupplierTransaction.GetSupplierTransactions();
            foreach (var supplierTransaction in supplierTransactions)
            {
                transactionsTable.Rows.Add(supplierTransaction.Id, supplierTransaction.SupplierName, supplierTransaction.ProductName, supplierTransaction.ProductQuantity, supplierTransaction.Cost, supplierTransaction.TransactionDate);
            }

            dataGridView1.DataSource = transactionsTable;

            dataGridView1.Columns["Date"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void GetSupplierTransactionButton_Click(object sender, EventArgs e)
        {

        }

        private void GetAllTransactionsButton_Click(object sender, EventArgs e)
        {
            ListSupplierTransactions();
        }
    }
}
