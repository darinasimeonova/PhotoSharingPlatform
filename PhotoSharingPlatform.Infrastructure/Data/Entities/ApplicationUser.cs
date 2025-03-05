using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoSharingPlatform.Infrastructure.Data.Entities
{
    public class ApplicationUser : IdentityUser
    {
        // Additional fields can be added here if needed
        public string? ProfilePicture { get; set; }
        public string? Bio { get; set; }
    }
}
