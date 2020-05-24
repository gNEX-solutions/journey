

namespace Journey.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public  class FollwedBy
    {

       
        public int UserId { get; set; }

       
        public int FollowedByUserId { get; set; }
    
        public virtual User User { get; set; }
    }
}
