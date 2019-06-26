using AutoMapper;
using RegistrationLoginAPI.Entities;
using RegistrationLoginAPI.Repositories;

namespace RegistrationLoginAPI.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, UserDTO>();
            CreateMap<UserDTO, User>();
        }
    }
}