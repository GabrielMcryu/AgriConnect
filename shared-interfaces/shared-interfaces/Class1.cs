using shared_interfaces.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shared_interfaces
{

    public interface ISupplierProduct
    {
        List<SupplierProductDto> GetSupplierProducts();
        void AddSupplierProduct(SupplierProductDto supplierProductDto);
        void UpdateSupplierProduct(SupplierProductDto supplierProductDto);
        void DeleteSupplierProduct(int Id);
    }

    public interface ISupplierTransaction
    {

    }

    public interface IVendorProduct
    {

    }

    public interface IVendorTransaction
    {

    }
}
