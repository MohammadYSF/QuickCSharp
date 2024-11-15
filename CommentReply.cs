public class CommentReply : Comment
{
    private Comment parentComment;
    public CommentReply(int user, string text, Comment parentComment) : base(user, text)
    {
        this.parentComment = parentComment;
    }
}
