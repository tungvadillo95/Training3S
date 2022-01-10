using AutoMapper;
using DDDExample.Domain.DTOs.Respone.User;
using DDDExample.Domain.Infrastructure.Handler.Order.Commands;
using DDDExample.Domain.Infrastructure.Handler.User.Commands.CreateUser;
using DDDExample.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDDExample.Domain.Infrastructure.Mapper
{
    public class AppMapperConfiguration
    {
        public static List<Profile> RegisterMappings()
        {
            var cfg = new List<Profile>
            {
                // Thêm các MappingProfile khác vào đây
                new MappingProfile()
            };

            return cfg;
        }
    }
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Đưa hết các cấu hình bạn muốn map giữa các object vào đây
            // Thuộc tính FullName trong UserViewModel được kết hợp từ FirstName và LastName trong User
            CreateMap<User, UserDetail>().ForMember(dest => dest.RoleName, option => option.MapFrom(src => src.Role.RoleName));
            CreateMap<CreateUserCommand, User>().ForMember(dest => dest.Id, option => option.MapFrom(src => Guid.NewGuid()));
            CreateMap<CreateOrderCommand, Order>();
        }
    }
}
