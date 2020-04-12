

namespace Journey.Models
{
    using System;
    using System.Collections.Generic;
    
    public  class DestinationCatogary
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DestinationCatogary()
        {
            this.Destinations = new HashSet<Destination>();
        }
    
        public int DestinationCatogaryId { get; set; }
        public string CatagoryName { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Destination> Destinations { get; set; }
    }
}
