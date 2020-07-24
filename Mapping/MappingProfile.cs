using AutoMapper;
using Cars.Controllers.Resources;
using Cars.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Cars.Controllers.Resources.VehicleResources;

namespace Cars.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Make, MakeResources>();
            CreateMap<Model, ModelResource>();
            CreateMap<Feature, FeatureResources>();
            CreateMap<Vehicle, VehicleResources>()
                .ForMember(vr => vr.Contact, opt => opt
                .MapFrom(v => new ContactResources
                { Name = v.ContactName, Email = v.ContactEmail, Phone = v.ContactPhone }))
                .ForMember(vr => vr.Features, opt => opt.MapFrom(v => v.Features.Select(vf => vf.FeatureId)));

            CreateMap<VehicleResources, Vehicle>()
                .ForMember(v => v.ContactName , opt => opt.MapFrom(vr => vr.Contact.Name));
            CreateMap<VehicleResources, Vehicle>()
                .ForMember(v => v.ContactEmail, opt => opt.MapFrom(vr => vr.Contact.Email))

                .ForMember(v => v.ContactPhone, opt => opt.MapFrom(vr => vr.Contact.Phone))

               .ForMember(v => v.Features, opt => 
               opt.MapFrom(vr => vr.Features.Select(id =>  new VehicleFeature { FeatureId = id })));
        }
    }
}
