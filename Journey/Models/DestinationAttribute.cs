
namespace Journey.Models
{
    using System;
    using System.Collections.Generic;
    
    public class DestinationAttribute
    {
        public int DestinationAttributeId { get; set; }
        public double value { get; set; }
        public int AttributeTypeId { get; set; }
        public int DestinationId { get; set; }
    
        public virtual Destination Destination { get; set; }
        public virtual DesttinationAttributesType DesttinationAttributesType { get; set; }
    }
}
