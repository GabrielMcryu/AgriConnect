using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shared_interfaces.DTO
{
    [Serializable]
    public class SupplierTransactionDto
    {
        public int Id { get; set; }
        public string SupplierName { get; set; }
        public string ProductName { get; set; }
        public int ProductQuantity { get; set; }
        public int Cost { get; set; }
        public DateTime TransactionDate { get; set; }
    }
}
