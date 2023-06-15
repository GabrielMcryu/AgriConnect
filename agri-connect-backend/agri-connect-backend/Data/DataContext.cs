using agri_connect_backend.Models;
using Microsoft.EntityFrameworkCore;

namespace agri_connect_backend.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<SupplierProduct> SupplierProducts { get; set; }
        public DbSet<SupplierTransaction> SupplierTransactions { get; set; }
        public DbSet<VendorProduct> VendorProducts { get; set; }
        public DbSet<VendorTransaction> VendorTransactions { get; set; }
    }
}
