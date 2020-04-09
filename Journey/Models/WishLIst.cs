

namespace Journey.Models
{
    using System;
    using System.Collections.Generic;
    
    public class WishLIst
    {
        public int WishListId { get; set; }
        public int DestinationId { get; set; }
        public int UserId { get; set; }
        public Nullable<System.DateTime> CreatedAt { get; set; }
        public Nullable<System.DateTime> ModifiedAt { get; set; }
        public Nullable<byte> IsDeleted { get; set; }
    
        public virtual Destination Destination { get; set; }
        public virtual User User { get; set; }
    }
}
