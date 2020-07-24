using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Cars.Controllers.Resources;
using Cars.Models;
using Cars.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Cars.Controllers
{
    public class FeatureController : Controller
    {
        private readonly CarsDbContext context;
        private readonly IMapper mapper;

        public FeatureController(CarsDbContext context , IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }
        [HttpGet("/api/features")]
        public async Task<IEnumerable<FeatureResources>> getFeatures()
        {
            var features = await context.Features.ToListAsync();
            return mapper.Map<List<Feature>, List<FeatureResources>>(features);
        
    }
    }
  
}