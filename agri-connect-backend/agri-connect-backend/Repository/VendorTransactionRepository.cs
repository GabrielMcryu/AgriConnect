using agri_connect_backend.Data;
using agri_connect_backend.Interfaces;
using agri_connect_backend.Models;

namespace agri_connect_backend.Repository
{
    public class VendorTransactionRepository : IVendorTransactionRepository
    {
        private readonly DataContext _context;

        public VendorTransactionRepository(DataContext context)
        {
            _context = context;
        }

        public bool CreateVendorTransaction(VendorTransaction vendorTransaction)
        {
            _context.Add(vendorTransaction);
            return Save();
        }

        public VendorTransaction GetVendorTransaction(int id)
        {
            return _context.VendorTransactions.Where(vt => vt.Id == id).FirstOrDefault();
        }

        public ICollection<VendorTransaction> GetVendorTransactions()
        {
            return _context.VendorTransactions.ToList();
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }

        public bool VendorTransactionExists(int id)
        {
            return _context.VendorTransactions.Any(vt => vt.Id == id);
        }
    }
}
