public class Article
{
    public string title { get; set; }

    public string description { get; set; }

    public string url { get; set; }

    public string cover_image { get; set; }

    public int comments_count { get; set; }

    public string[] tag_list { get; set; }

    public User user { get; set; }
}