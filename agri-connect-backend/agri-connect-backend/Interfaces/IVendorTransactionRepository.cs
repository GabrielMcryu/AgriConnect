using agri_connect_backend.Models;

namespace agri_connect_backend.Interfaces
{
    public interface IVendorTransactionRepository
    {
        ICollection<VendorTransaction> GetVendorTransactions();
        VendorTransaction GetVendorTransaction(int id);
        bool VendorTransactionExists(int id);
        bool CreateVendorTransaction(VendorTransaction vendorTransaction);
        bool Save();
    }
}
