using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoSharingPlatform.Infrastructure.Data.Entities
{
    public class PhotoTag
    {
        // Foreign key to the photo
        public int PhotoId { get; set; }
        public Photo Photo { get; set; }

        // Foreign key to the tag
        public int TagId { get; set; }
        public Tag Tag { get; set; }
    }
}
