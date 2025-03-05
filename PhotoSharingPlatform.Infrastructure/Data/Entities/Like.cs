using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoSharingPlatform.Infrastructure.Data.Entities
{
    public class Like
    {
        public int Id { get; set; }

        public DateTime LikeDate { get; set; } = DateTime.UtcNow;

        // Foreign key to the photo
        public int PhotoId { get; set; }
        public Photo Photo { get; set; }

        // Foreign key to the user who liked the photo
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
    }
}
