﻿using shared_interfaces.DTO;
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
        SupplierProductDto GetSupplierProduct(int Id);
        void AddSupplierProduct(SupplierProductDto supplierProductDto);
        void UpdateSupplierProduct(SupplierProductDto supplierProductDto);
        void DeleteSupplierProduct(int Id);
    }

    public interface ISupplierTransaction
    {
        List<SupplierTransactionDto> GetSupplierTransactions();
        SupplierTransactionDto GetSupplierTransaction(int Id);
    }

    public interface IVendorProduct
    {
        List<VendorProductDto> GetVendorProducts();
        VendorProductDto GetVendorProduct(int Id);
        void AddVendorProduct(VendorProductDto vendorProductDto);
        void UpdateVendorproduct(VendorProductDto vendorProductDto);
        void DeleteVendorProduct(int Id);
    }

    public interface IVendorTransaction
    {
        List<VendorTransactionDto> GetVendorTransactions();
        VendorTransactionDto GetVendorTransaction(int Id);
    }

    public interface IUser
    {
        List<UserDto> GetUsers();
        UserDto GetUserById(int Id);
        UserDto GetUserByUsername(string username);
        void UpdateUser(UserDto userDto);
        void DeleteUser(int Id);
        bool AuthenticateUser(string username, string password);
        void CreateUser(UserDto userDto);
    }
}
