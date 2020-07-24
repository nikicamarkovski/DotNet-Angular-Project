using Cars.Models;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace Cars.Controllers.Resources
{
    public partial class VehicleResources
    {

        public int Id { get; set; }
        public int ModelId { get; set; }
       
        public bool IsRegistered { get; set; }
        public ContactResources Contact { get; set; }

        
        public ICollection<int> Features { get; set; }

        public VehicleResources()
        {
            Features = new Collection<int>(); 
        }
    }
}
