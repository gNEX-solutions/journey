namespace Journey.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Admin
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Admin()
        {
            this.UserFeedbacks = new HashSet<UserFeedback>();
        }
    
        public int AdminId { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string ProfilePictureUrl { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserFeedback> UserFeedbacks { get; set; }
    }
}
