using AutoMapper;
using MovieRental.Entities;
using MovieRental.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieRental.Web.Mappings
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

        [Obsolete]
        protected override void Configure()
        {
            CreateMap<MovieViewModel, Movie>()
                //.ForMember(m => m.Image, map => map.Ignore())
                .ForMember(m => m.Genre, map => map.Ignore());
        }
    }
}