using System.ComponentModel.DataAnnotations.Schema;

namespace Journey.Models
{
    using System;
    using System.Collections.Generic;
    public class User
    {
        //    public int Id { get; set; }
        //    [Column(TypeName = "varchar(MAX)")]
        //    public string Username { get; set; }
        //    [Column(TypeName = "varchar(MAX)")]
        //    public string Password { get; set; }
        //    [Column(TypeName = "varchar(MAX)")]
        //    public string RefreshToken { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            this.FollwedBies = new HashSet<FollwedBy>();
            this.UserFeedbacks = new HashSet<UserFeedback>();
            this.WishLIsts = new HashSet<WishLIst>();
        }

        public int Id { get; set; }


        public string Email { get; set; }
        public string Name { get; set; }
       // public Nullable<System.TimeSpan> Birthdate { get; set; }
       public DateTime BirthDate { get; set; }
        public string ProfilePictureUrl { get; set; }

        //[Column(TypeName = "varchar(MAX)")]
        public string Username { get; set; }

        //[Column(TypeName = "varchar(MAX)")]
        public string Password { get; set; }

        public byte IsDeleted { get; set; }

       // [Column(TypeName = "varchar(MAX)")]
        public string RefreshToken { get; set; }

        public Nullable<System.DateTime> CreatedAt { get; set; }
        public Nullable<System.DateTime> ModifiedAt { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FollwedBy> FollwedBies { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserFeedback> UserFeedbacks { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WishLIst> WishLIsts { get; set; }

        public virtual ICollection<Destination> CreatedDestinations { get; set; }
    }
}