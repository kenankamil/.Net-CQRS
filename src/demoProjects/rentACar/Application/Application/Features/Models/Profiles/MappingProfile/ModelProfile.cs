using Application.Features.Models.Dtos;
using Application.Features.Models.Models;
using AutoMapper;
using Core.Persistence.Paging;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Models.Profiles.MappingProfile
{
    public class ModelProfile : Profile
    {
        public ModelProfile()
        {
            CreateMap<Model, ModelListDto>().ForMember(m => m.BrandName, opt => opt.MapFrom(m => m.Brand.Name)).ReverseMap();
            CreateMap<IPaginate<Model>, ModelListModel>().ReverseMap();
        }
    }
}
