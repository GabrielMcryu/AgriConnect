﻿using agri_connect_backend.Models;
using System.ComponentModel;

namespace agri_connect_backend.Interfaces
{
    public interface ISupplierProductRepository
    {
        ICollection<SupplierProduct> GetSupplierProducts();
        SupplierProduct GetSupplierProduct(int id);
        bool CreateSupplierProduct(SupplierProduct supplierProduct);
        bool UpdateSupplierProduct(SupplierProduct supplierProduct);
        bool DeleteSupplierProduct(SupplierProduct supplierProduct); 
        bool SupplierProductExists(int id);
        bool Save();
    }
}
