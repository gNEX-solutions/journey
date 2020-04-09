

namespace Journey.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public  class FollwedBy
    {

        [Key, Column(Order = 0)] 
        public int UserId { get; set; }

        [Key, Column(Order = 1)] 
        public int FollowedByUserId { get; set; }
    
        public virtual User User { get; set; }
    }
}
