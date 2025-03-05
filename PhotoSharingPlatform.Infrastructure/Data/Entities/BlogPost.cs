using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoSharingPlatform.Infrastructure.Data.Entities
{
    public class BlogPost
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Content { get; set; }

        public DateTime PublishDate { get; set; } = DateTime.UtcNow;

        // Foreign key to the author (User)
        public string AuthorId { get; set; }
        public ApplicationUser Author { get; set; }
    }
}
