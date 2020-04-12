

namespace Journey.Models
{
    using System;
    using System.Collections.Generic;
    
    public class UserFeedback
    {
        public int UserFeedbackId { get; set; }
        public byte Rating { get; set; }
        public string Comment { get; set; }
        public Nullable<int> DestinationID { get; set; }
        public Nullable<int> UserId { get; set; }
        public Nullable<int> AdminId { get; set; }
    
        public virtual Admin Admin { get; set; }
        public virtual Destination Destination { get; set; }
        public virtual User User { get; set; }
    }
}
