using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Cars.Controllers.Resources;
using Cars.Models;
using Cars.Persistence;
using Microsoft.AspNetCore.Mvc;

namespace Cars.Controllers
{
    [Route("/api/vehicles")]
    public class VehiclesController : Controller
    {
        private readonly CarsDbContext context;
        private readonly IMapper mapper;

        public VehiclesController(CarsDbContext context , IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }
        [HttpPost]
        
        public async Task<IActionResult> CreateVehicle ([FromBody] VehicleResources vehicleResources)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var model = await context.Models.FindAsync(vehicleResources.ModelId);

            if(model == null)
            {
                ModelState.AddModelError("ModelId", "Invalid ModelId");
                return BadRequest(ModelState);
            }

            var vehicle = mapper.Map<VehicleResources, Vehicle>(vehicleResources);
            vehicle.LastUpdate = DateTime.Now;
            context.Vehicles.Add(vehicle);
           await context.SaveChangesAsync();
           var result = mapper.Map<Vehicle, VehicleResources>(vehicle);
            return Ok(result);
        }
     }
}