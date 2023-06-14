using agri_connect_backend.Data;
using agri_connect_backend.Interfaces;
using agri_connect_backend.Models;

namespace agri_connect_backend.Repository
{
    public class SupplierProductRepository : ISupplierProductRepository
    {
        private readonly DataContext _context;

        public SupplierProductRepository(DataContext context)
        {
            _context = context;
        }

        public bool CreateSupplierProduct(SupplierProduct supplierProduct)
        {
            _context.Add(supplierProduct);
            return Save();
        }

        public bool DeleteSupplierProduct(SupplierProduct supplierProduct)
        {
            _context.Remove(supplierProduct);
            return Save();
        }

        public SupplierProduct GetSupplierProduct(int id)
        {
            return _context.SupplierProducts.Where(sp => sp.Id == id).FirstOrDefault();
        }

        public ICollection<SupplierProduct> GetSupplierProducts()
        {
            return _context.SupplierProducts.ToList();
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }

        public bool SupplierProductExists(int id)
        {
            return _context.SupplierProducts.Any(sp => sp.Id == id);   
        }

        public bool UpdateSupplierProduct(SupplierProduct supplierProduct)
        {
            _context.Update(supplierProduct);
            return Save();
        }
    }
}
