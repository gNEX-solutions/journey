

namespace Journey.Models
{
    using System;
    using System.Collections.Generic;
    
    public class PopularityType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PopularityType()
        {
            this.DestinationPopularities = new HashSet<DestinationPopularity>();
        }
    
        public int PopularityTypeId { get; set; }
        public string Name { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DestinationPopularity> DestinationPopularities { get; set; }
    }
}
