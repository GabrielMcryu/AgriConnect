using agri_connect_backend.Dto;
using agri_connect_backend.Models;
using AutoMapper;

namespace agri_connect_backend.Helper
{
    public class MappingProfiles : Profile
    {
       public MappingProfiles()
        {
            CreateMap<SupplierProduct, SupplierProductDto>();
            CreateMap<SupplierProductDto, SupplierProduct>();
            CreateMap<SupplierTransaction, SupplierTransactionDto>();
            CreateMap<SupplierTransactionDto, SupplierTransaction>();
        }
    }
}
