namespace agri_connect_backend.Models
{
    public class VendorTransaction
    {
        public int Id { get; set; }
        public string VendorName { get; set; }
        public string ProductName { get; set; }
        public int ProductQuantity { get; set; }
        public int Cost { get; set; }
        public DateTime TransactionDate { get; set; }
    }
}
