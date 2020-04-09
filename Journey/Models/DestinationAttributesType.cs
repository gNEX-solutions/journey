
namespace Journey.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DestinationAttributesType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DestinationAttributesType()
        {
            this.DestinationAttributes = new HashSet<DestinationAttribute>();
        }
    
        public int DestinationAttributesTypeId { get; set; }
        public string AttributeTypeName { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DestinationAttribute> DestinationAttributes { get; set; }
    }
}
