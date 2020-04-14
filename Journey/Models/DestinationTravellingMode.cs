

namespace Journey.Models
{
    using System;
    using System.Collections.Generic;
    
    public  class DestinationTravellingMode
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DestinationTravellingMode()
        {
            this.Destinations = new HashSet<Destination>();
        }
    
        public int DestinationTravellingModeId { get; set; }
        public string TravellingMode { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Destination> Destinations { get; set; }
    }
}
