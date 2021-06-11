using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Movie_Store_MVC_5.Dtos;
using Movie_Store_MVC_5.Models;

namespace Movie_Store_MVC_5.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<Movie, MoviesDto>();
            Mapper.CreateMap<MembershipType, MembershipTypeDto>();
            Mapper.CreateMap<Genre, GenreDto>();

            Mapper.CreateMap<CustomerDto, Customer>()
                .ForMember(c => c.Id, opt => opt.Ignore());

            Mapper.CreateMap<MoviesDto, Movie>()
                .ForMember(c => c.Id, opt => opt.Ignore());
        }
    }
}