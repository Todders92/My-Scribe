using System.Collections.Generic;
namespace MyScribe.Models
{
  public class Board
  {
    public Board()
     {
      this.Posts = new HashSet<Post>();
    }
    public int BoardId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string BannerImage { get; set; }
    public ApplicationUser User { get; set; }
    public ICollection<Post> Posts {get;set;}
  }
}