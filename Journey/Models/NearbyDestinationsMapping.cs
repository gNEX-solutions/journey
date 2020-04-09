

namespace Journey.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public  class NearbyDestinationsMapping
    {
        [Key , Column(Order = 0)]
        public int DestinationId { get; set; }

        [Key, Column(Order = 0)]
        public int NearbyDestinationId { get; set; }
    
        public virtual Destination Destination { get; set; }
    }
}
