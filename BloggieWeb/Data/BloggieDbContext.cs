using BloggieWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace BloggieWeb.Data
{
	public class BloggieDbContext : DbContext
	{
		public DbSet<BlogPost> BlogPosts { get; set; }
		public DbSet<Tag> Tags { get; set; }
		public BloggieDbContext(DbContextOptions options) : base(options) { }
		
	}
}
