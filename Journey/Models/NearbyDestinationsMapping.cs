

namespace Journey.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public  class NearbyDestinationsMapping
    {
       
        public int DestinationId { get; set; }

      
        public int NearbyDestinationId { get; set; }
    
        public virtual Destination Destination { get; set; }
    }
}
