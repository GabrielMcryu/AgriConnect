using agri_connect_backend.Data;
using agri_connect_backend.Interfaces;
using agri_connect_backend.Models;

namespace agri_connect_backend.Repository
{
    public class SupplierTransactionRepository : ISupplierTransactionRepository
    {
        private readonly DataContext _context;

        public SupplierTransactionRepository(DataContext context)
        {
            _context = context;
        }

        public bool CreateSupplierTransaction(SupplierTransaction supplierTransaction)
        {
            _context.Add(supplierTransaction);
            return Save();
        }

        public SupplierTransaction GetSupplierTransaction(int id)
        {
            return _context.SupplierTransactions.Where(st => st.Id == id).FirstOrDefault();
        }

        public ICollection<SupplierTransaction> GetSupplierTransactions()
        {
            return _context.SupplierTransactions.ToList();
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }

        public bool SupplierTransactionExists(int id)
        {
            return _context.SupplierTransactions.Any(st => st.Id == id);
        }
    }
}
