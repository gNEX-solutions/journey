

namespace Journey.Models
{
    using System;
    using System.Collections.Generic;
    
    public  class Activity
    {
        public int ActivityId { get; set; }
        public string Description { get; set; }
        public string ActivityImageUrl { get; set; }
        public int DestinationId { get; set; }
        public Nullable<byte> IsDeleted { get; set; }
        public Nullable<System.DateTime> CreatedAt { get; set; }
        public Nullable<System.DateTime> ModifiedAt { get; set; }
    
        public virtual Destination Destination { get; set; }
    }
}
