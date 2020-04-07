namespace MyScribe.Models
{
  public class Post
  {
    public int PostId { get; set; }
    public int BoardId { get;set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string ImageSource { get; set; }
    public string Links { get; set; }
    public virtual Board Board { get; set; }
  }
}