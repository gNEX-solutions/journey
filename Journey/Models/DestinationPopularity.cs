

namespace Journey.Models
{
    using System;
    using System.Collections.Generic;
    
    public  class DestinationPopularity
    {
        public int DestinationPopularityId { get; set; }
        public int TypeId { get; set; }
        public int DestinationId { get; set; }
        public double value { get; set; }
    
        public virtual Destination Destination { get; set; }
        public virtual PopularityType PopularityType { get; set; }
    }
}
