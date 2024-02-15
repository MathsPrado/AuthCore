using AuthCoreAPI.Model;
using AutoMapper;
using System;

namespace AuthCoreAPI.DTOs.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<UserDTO, User>();
        } 
    }
}
