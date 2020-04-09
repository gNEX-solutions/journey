

namespace Journey.Models
{
    using System;
    using System.Collections.Generic;
    
    public  class NearbyDestinationSuggestion
    {
        public int NearbyDestinationSuggestionId { get; set; }
        public string SuggestedDestinationName { get; set; }
        public int DestinationId { get; set; }
    
        public virtual Destination Destination { get; set; }
    }
}
