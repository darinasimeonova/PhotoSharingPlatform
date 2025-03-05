using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PhotoSharingPlatform.Infrastructure.Data.Entities;

namespace PhotoSharingPlatform.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    // DbSet properties for each table
    public DbSet<Photo> Photos { get; set; }
    public DbSet<Album> Albums { get; set; }
    public DbSet<Comment> Comments { get; set; }
    public DbSet<Like> Likes { get; set; }
    public DbSet<Tag> Tags { get; set; }
    public DbSet<PhotoTag> PhotoTags { get; set; }
    public DbSet<BlogPost> BlogPosts { get; set; }
    public DbSet<ContactMessage> ContactMessages { get; set; }
}
