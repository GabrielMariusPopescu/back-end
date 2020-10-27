using ExploreCalifornia.Models;
using Microsoft.EntityFrameworkCore;

namespace ExploreCalifornia.Entities
{
    public sealed class BlogDataContext : DbContext
    {
        public BlogDataContext(DbContextOptions<BlogDataContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<BlogPost> Posts { get; set; }
    }
}
