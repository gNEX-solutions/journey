

namespace Journey.Models
{
    using System;
    using System.Collections.Generic;
    
    public class Attraction
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Attraction()
        {
            this.AttractionImages = new HashSet<AttractionImage>();
        }
    
        public int AttractionId { get; set; }
        public string AttractionName { get; set; }
        public string ShortDescription { get; set; }
        public Nullable<byte> IsPublished { get; set; }
        public int DestinationId { get; set; }
        public Nullable<int> CreatedUserId { get; set; }
        public byte IsDeleted { get; set; }
        public byte IsModified { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AttractionImage> AttractionImages { get; set; }
        public virtual Destination Destination { get; set; }
    }
}
