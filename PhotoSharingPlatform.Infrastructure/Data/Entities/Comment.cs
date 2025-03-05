using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoSharingPlatform.Infrastructure.Data.Entities
{
    public class Comment
    {
        public int Id { get; set; }

        [Required]
        public string Text { get; set; }

        public DateTime CommentDate { get; set; } = DateTime.UtcNow;

        // Foreign key to the photo
        public int PhotoId { get; set; }
        public Photo Photo { get; set; }

        // Foreign key to the user who made the comment
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
    }
}
