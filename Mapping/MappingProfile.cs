using AutoMapper;
using Cars.Controllers.Resources;
using Cars.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Cars.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Make, MakeResources>();
            CreateMap<Model, ModelResource>();
            CreateMap<Feature, FeatureResources>();

        }
    }
}
