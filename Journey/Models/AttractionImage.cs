

namespace Journey.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class AttractionImage
    {
        public int AttractionImageId { get; set; }
        public string AttractionImageCaption { get; set; }
        public string AttractionImageUrl { get; set; }
        public int AttractionId { get; set; }
    
        public virtual Attraction Attraction { get; set; }
    }
}
