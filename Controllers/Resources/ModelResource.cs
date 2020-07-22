using Cars.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Cars.Controllers.Resources
{

    public class ModelResource
    {
        public int Id { get; set; }
      
        public string Name { get; set; }
       
    }
}
