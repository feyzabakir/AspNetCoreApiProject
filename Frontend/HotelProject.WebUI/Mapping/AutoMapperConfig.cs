﻿using AutoMapper;
using HotelProject.EntityLayer.Concrete;
using HotelProject.WebUI.Dtos.AboutDto;
using HotelProject.WebUI.Dtos.LoginDto;
using HotelProject.WebUI.Dtos.RegisterDto;
using HotelProject.WebUI.Dtos.ServiceDto;
using HotelProject.WebUI.Dtos.StaffDto;
using HotelProject.WebUI.Dtos.SubscribeDto;
using HotelProject.WebUI.Dtos.TestimonialDto;

namespace HotelProject.WebUI.Mapping
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<ResultServiceDto, Service>().ReverseMap();
            CreateMap<UpdateServiceDto, Service>().ReverseMap();
            CreateMap<CreateServiceDto, Service>().ReverseMap();

            CreateMap<CreateNewUserDto, AppUser>().ReverseMap();
            CreateMap<LoginUserDto, AppUser>().ReverseMap();

            CreateMap<ResultAboutDto, About>().ReverseMap();
            CreateMap<UpdateAboutDto, About>().ReverseMap();

            CreateMap<ResultTestimonialDto, Testimonial>().ReverseMap();

            CreateMap<ResultStaffDto, Staff>().ReverseMap();

            CreateMap<CreateSubscribeDto, Subscribe>().ReverseMap();
        }
    }
}
