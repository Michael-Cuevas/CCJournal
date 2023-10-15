using Application.Meals;
using AutoMapper;
using Domain;
using System.Diagnostics;

namespace Application.Core
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Meal, Meal>();
            CreateMap<Meal, MealDto>()
                .ForMember(dest => dest.MealItems, opt => opt.MapFrom(src => src.MealItems));
            CreateMap<MealItem, MealItemDto>(); ; // This should be a generic mapping for Meal to MealDto
            CreateMap<MealItem, MealItem>();
        }
    }
}