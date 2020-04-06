using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MyScribe.Models
{
  public class MyScribeContext :  IdentityDbContext<ApplicationUser>
  {
    public DbSet<Board> Boards { get; set; }
    public DbSet<Post> Posts { get; set; }
    public MyScribeContext(DbContextOptions options) : base(options) { }

    // protected override void OnModelCreating(ModelBuilder builder)
    //   {
    //     Builder.Entity<Boards>()
    //     {
    //       .HasData(
    //         new Board {BoardId = 1, UserId = 1 Name = "ThoughtBoard", Description = "this is an example board to demonstrate what your ScriBoards can look like!", BannerImage="http://d1hkwj6qq9t78x.cloudfront.net/static/ui/longphoto-clockone-001b.jpg"}
    //       )
    //     }
    //     Builder.Entity<ApplicationUser>()
    //     {
    //       .HasData(
    //         new ApplicationUser {UserId= "1", Email=""}
    //       )
    //     }
    // }
  }
}