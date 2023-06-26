using AutoMapper;
using BakeryManagementSystemBLL.DTOs.RequestDTOs.CustomersDTOs;
using BakeryManagementSystemBLL.DTOs.ResponseDTOs.CustomersDTOs;
using BakeryManagementSystemDAL.Entities;

namespace BakeryManagementSystemAPI.AutoMapper
{
    public class CustomersMapping : Profile
    {
        public CustomersMapping()
        {
            CreateMap<Customers, GetCustomersDTO>()
                .ForMember(dest => dest.FullName, opt => opt.MapFrom(src => $"{src.FirstName} {src.LastName}"));

            CreateMap<InsertCustomersDTO, Customers>();

            CreateMap<UpdateCustomersDTO, Customers>();

            CreateMap<InsertCustomersDTO, GetCustomersDTO>()
                .ForMember(dest => dest.FullName, opt => opt.MapFrom(src => $"{src.FirstName} {src.LastName}"));
        }
    }
}
