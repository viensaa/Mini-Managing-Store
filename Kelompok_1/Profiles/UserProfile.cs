﻿using AutoMapper;
using Kelompok_1.Domain;
using Kelompok_1.DTO;

namespace Kelompok_1.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserDTO>();
            CreateMap<UserDTO, User>();
            CreateMap<UserCreateDTO, User>();

            //mapping untuk detail transaksi

            CreateMap<User, UserTransaksiDTO>();
            CreateMap<Cart, UserTransaksiDTO>();
            CreateMap<Transaksi, TransaksiDetailDTO>();
        }
    }
}
