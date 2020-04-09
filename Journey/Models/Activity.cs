

namespace Journey.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    public  class Activity
    {
        public int ActivityId { get; set; }

        [Column(TypeName = "text")]
        public string Description { get; set; }

      
        public string ActivityImageUrl { get; set; }
        public int DestinationId { get; set; }

       
        public bool IsDeleted { get; set; }

        public Nullable<System.DateTime> CreatedAt { get; set; }

       
        public Nullable<System.DateTime> ModifiedAt { get; set; }
    
        public virtual Destination Destination { get; set; }
    }
}
