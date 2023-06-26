using AutoMapper;
using BakeryManagementSystemBLL.DTOs.ResponseDTOs.ProductsDTOs;
using BakeryManagementSystemDAL.Entities;

namespace BakeryManagementSystemAPI.AutoMapper
{
    public class ProductsMapping : Profile
    {
        public ProductsMapping() 
        {
            CreateMap<Products, GetProductsDTO>();      
        }
    }
}
