using agri_connect_backend.Data;
using agri_connect_backend.Interfaces;
using agri_connect_backend.Models;

namespace agri_connect_backend.Repository
{
    public class VendorProductRepository : IVendorProductRepository
    {
        private readonly DataContext _context;

        public VendorProductRepository(DataContext context)
        {
            _context = context;
        }

        public bool CreateVendorProduct(VendorProduct vendorProduct)
        {
            _context.Add(vendorProduct);
            return Save();
        }

        public bool DeleteVendorProduct(VendorProduct vendorProduct)
        {
            _context.Remove(vendorProduct);
            return Save();
        }

        public VendorProduct GetVendorProduct(int id)
        {
            return _context.VendorProducts.Where(vp => vp.Id == id).FirstOrDefault();
        }

        public ICollection<VendorProduct> GetVendorProducts()
        {
            return _context.VendorProducts.ToList();
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }

        public bool UpdateVendorProduct(VendorProduct vendorProduct)
        {
            _context.Update(vendorProduct);
            return Save();
        }

        public bool VendorProductExists(int id)
        {
            return _context.VendorProducts.Any(vp => vp.Id == id);
        }
    }
}
