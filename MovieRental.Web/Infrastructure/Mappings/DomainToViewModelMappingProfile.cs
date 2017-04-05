using AutoMapper;
using MovieRental.Entities;
using MovieRental.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieRental.Web.Mappings
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }

        [Obsolete("Create a constructor and configure inside of your profile's constructor instead. Will be removed in 6.0")]
        protected override void Configure()
        {
            CreateMap<Movie, MovieViewModel>()
                .ForMember(vm => vm.Genre, map => map.MapFrom(m => m.Genre.Name))
                .ForMember(vm => vm.GenreId, map => map.MapFrom(m => m.Genre.Id))
                .ForMember(vm => vm.IsAvailable, map => map.MapFrom(m => m.Stocks.Any(s => s.IsAvailable)))
                .ForMember(vm => vm.NumberOfStocks, map => map.MapFrom(m => m.Stocks.Count))
                .ForMember(vm => vm.Image, map => map.MapFrom(m => string.IsNullOrEmpty(m.Image) == true ? "unknown.jpg" : m.Image));

            CreateMap<Genre, GenreViewModel>()
                .ForMember(vm => vm.NumberOfMovies, map => map.MapFrom(g => g.Movies.Count()));
            // code omitted
            CreateMap<Customer, CustomerViewModel>();

            CreateMap<Stock, StockViewModel>();

            CreateMap<Rental, RentalViewModel>();
        }
    }
}