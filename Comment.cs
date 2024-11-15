public class Comment
{
    private HashSet<Rate> rates = [];
    private int user;
    private string text = string.Empty;
    private List<CommentReply> commentReplies = [];
    public Comment(int user, string text)
    {
        this.user = user;
        this.text = text;
    }
    public void Rate(int user, int rate)
    {
        var postRate = new Rate(user, rate);
        _ = rates.Add(postRate);
    }
    public void Reply(int user, string text)
    {
        this.commentReplies.Add(new CommentReply(user, text, this));
    }
}
