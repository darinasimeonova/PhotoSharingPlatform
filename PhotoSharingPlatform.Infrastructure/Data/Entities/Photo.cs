using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoSharingPlatform.Infrastructure.Data.Entities
{
    public class Photo
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public string? Description { get; set; }

        [Required]
        public string FilePath { get; set; } // Path to the uploaded photo

        public DateTime UploadDate { get; set; } = DateTime.UtcNow;

        // Foreign key to the photographer (User)
        public string PhotographerId { get; set; }
        public ApplicationUser Photographer { get; set; }

        // Foreign key to the album (optional)
        public int? AlbumId { get; set; }
        public Album? Album { get; set; }

        // Navigation properties
        public ICollection<Comment> Comments { get; set; } = new List<Comment>();
        public ICollection<Like> Likes { get; set; } = new List<Like>();
        public ICollection<PhotoTag> PhotoTags { get; set; } = new List<PhotoTag>();
    }
}
