namespace MyScribe.Models
{
  public class Post
  {
    public int PostId { get; set; }
    public int BoardId { get;set; }
    public string Title { get; set; }
    public string Body { get; set; }
    public string ImageSource { get; set; }
    public string Link { get; set; }
    // public virtual Board Board { get; set; }
  }
}