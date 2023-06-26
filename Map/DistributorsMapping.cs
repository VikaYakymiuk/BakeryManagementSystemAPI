using AutoMapper;
using BakeryManagementSystemBLL.DTOs.ResponseDTOs.DistributorsDTOs;
using BakeryManagementSystemDAL.Entities;

namespace BakeryManagementSystemAPI.AutoMapper
{
    public class DistributorsMapping : Profile
    {
        public DistributorsMapping() 
        {
            CreateMap<Distributors, GetDistributorsDTO>();
        }
    }
}
