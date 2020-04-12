

namespace Journey.Models
{
    using System;
    using System.Collections.Generic;
    
    public  class DestinationComment
    {
        public int DestinationCommentId { get; set; }
        public string Description { get; set; }
        public int DestinationId { get; set; }
        public int UserId { get; set; }
        public byte IsDeleted { get; set; }
        public Nullable<System.DateTime> CeatedAt { get; set; }
        public Nullable<System.DateTime> ModifiedAt { get; set; }
    
        public virtual Destination Destination { get; set; }
    }
}
