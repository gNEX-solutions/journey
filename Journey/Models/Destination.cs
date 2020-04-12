
namespace Journey.Models
{
    using System;
    using System.Collections.Generic;
    
    public  class Destination
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Destination()
        {
            this.Activities = new HashSet<Activity>();
            this.Attractions = new HashSet<Attraction>();
            this.DestinationAttributes = new HashSet<DestinationAttribute>();
            this.DestinationComments = new HashSet<DestinationComment>();
            this.DestinationImages = new HashSet<DestinationImage>();
            this.DestinationPopularities = new HashSet<DestinationPopularity>();
            this.NearbyDestinationsMappings = new HashSet<NearbyDestinationsMapping>();
            this.NearbyDestinationSuggestions = new HashSet<NearbyDestinationSuggestion>();
            this.UserFeedbacks = new HashSet<UserFeedback>();
            this.WishLIsts = new HashSet<WishLIst>();
        }
    
        public int DestinationId { get; set; }
        public string DestinationName { get; set; }
        public string ShortDescription { get; set; }
        public Nullable<System.TimeSpan> EnjoyableTime { get; set; }
        public string AdditonalInformation { get; set; }
        public Nullable<System.DateTime> VisitedOn { get; set; }
        public Nullable<byte> IsPublished { get; set; }
        public Nullable<int> CatagoryId { get; set; }
        public string CreatedUserId { get; set; }

        public User user { get; set; }
        public Nullable<int> TravellingModeId { get; set; }
        public Nullable<int> AdminId { get; set; }

        public Admin Admin { get; set; }
        public byte IsDeleted { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Activity> Activities { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Attraction> Attractions { get; set; }
        public virtual DestinationCatogary DestinationCatogary { get; set; }
        public virtual DestinationTravellingMode DestinationTravellingMode { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DestinationAttribute> DestinationAttributes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DestinationComment> DestinationComments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DestinationImage> DestinationImages { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DestinationPopularity> DestinationPopularities { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NearbyDestinationsMapping> NearbyDestinationsMappings { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NearbyDestinationSuggestion> NearbyDestinationSuggestions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserFeedback> UserFeedbacks { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WishLIst> WishLIsts { get; set; }
    }
}
