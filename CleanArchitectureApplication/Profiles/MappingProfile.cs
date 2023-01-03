using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoMapper;
using CleanArchitectureApplication.Repositories.Features.Categories.Queries.GetCategoriesList;
using CleanArchitectureApplication.Repositories.Features.Categories.Queries.GetCategoriesListWithEvents;
using CleanArchitectureApplication.Repositories.Features.Events.Commands.CreateEvent;
using CleanArchitectureApplication.Repositories.Features.Events.GetEventDetail;
using CleanArchitectureApplication.Repositories.Features.Events.Queries;
using CleanArchitectureDomain.Entities;

namespace CleanArchitectureApplication.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<EventEntity, EventListVM>().ReverseMap();
            CreateMap<EventEntity, EventDetailVM>().ReverseMap();
            CreateMap<CategoryEntity, CategoryDTO>();
            CreateMap<CategoryEntity, CategoryListVM>();
            CreateMap<CategoryEntity, CategoryEventListVM>();
            CreateMap<EventEntity, CreateEventCommand>().ReverseMap();
        }
    }
}
