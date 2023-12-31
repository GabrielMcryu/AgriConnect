﻿using agri_connect_backend.Models;

namespace agri_connect_backend.Interfaces
{
    public interface ISupplierTransactionRepository
    {
        ICollection<SupplierTransaction> GetSupplierTransactions();
        ICollection<SupplierTransaction> GetSupplierTransactionsBySupplierName(string supplierName);
        SupplierTransaction GetSupplierTransaction(int id);
        bool SupplierTransactionExists(int id);
        bool CreateSupplierTransaction(SupplierTransaction supplierTransaction);
        bool Save();
    }
}
