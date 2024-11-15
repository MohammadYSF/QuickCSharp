public class Post
{

    public int Id;
    public string Title { get; private set; } = string.Empty;
    public string Text { get; private set; } = string.Empty;
    public Post(int id, string title, string text)
    {
        this.Id = id;
        this.Title = title;
        this.Text = text;
    }
    private List<Comment> comments = [];
    private HashSet<Rate> rates = [];
    public void Rate(int user, int rate)
    {
        var postRate = new Rate(user, rate);
        _ = rates.Add(postRate);
    }
    public void Comment(int user, string text)
    {
        this.comments.Add(new Comment(user, text));
    }
}
