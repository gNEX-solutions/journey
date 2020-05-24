

namespace Journey.Models
{
    using System;
    using System.Collections.Generic;
    
    public  class DestinationImage
    {
        public int DestinationImageId { get; set; }
        public string Url { get; set; }
        public string ImageCaption { get; set; }
        public int DestinationId { get; set; }
    
        public virtual Destination Destination { get; set; }
    }
}
