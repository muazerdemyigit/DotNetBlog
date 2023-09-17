﻿using AutoMapper;
using Blog.Entity.DTOs.Users;
using Blog.Entity.Entities;

namespace Blog.Service.AutoMapper.Users
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<AppUser, UserDto>().ReverseMap();
            CreateMap<AppUser, UserAddDto>().ReverseMap();
        }
    }
}
