using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoSharingPlatform.Infrastructure.Data.Entities
{
    public class Tag
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        // Navigation property to photos with this tag
        public ICollection<PhotoTag> PhotoTags { get; set; } = new List<PhotoTag>();
    }
}
