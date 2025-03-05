using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoSharingPlatform.Infrastructure.Data.Entities
{
    public class Album
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string? Description { get; set; }

        // Foreign key to the photographer (User)
        public string PhotographerId { get; set; }
        public ApplicationUser Photographer { get; set; }

        // Navigation property to photos in the album
        public ICollection<Photo> Photos { get; set; } = new List<Photo>();
    }
}
