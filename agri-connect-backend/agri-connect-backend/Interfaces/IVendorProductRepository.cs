using agri_connect_backend.Models;

namespace agri_connect_backend.Interfaces
{
    public interface IVendorProductRepository
    {
        ICollection<VendorProduct> GetVendorProducts();
        VendorProduct GetVendorProduct(int id);
        bool CreateVendorProduct(VendorProduct vendorProduct);
        bool UpdateVendorProduct(VendorProduct vendorProduct);
        bool DeleteVendorProduct(VendorProduct vendorProduct);
        bool VendorProductExists(int id);
        bool Save();
    }
}
