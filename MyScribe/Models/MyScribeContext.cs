using Microsoft.EntityFrameworkCore;

namespace MyScribe.Models
{
  public class MyScribeContext : DbContext
  {
    public DbSet<Board> Boards { get; set; }
    public DbSet<Post> Posts { get; set; }
    public MyScribeContext(DbContextOptions options) : base(options) { }
  }
}