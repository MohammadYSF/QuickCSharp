public class User
{
    public int id{ get; private set; }
    public string name { get; private set; } = string.Empty;
    public User(int id, string name)
    {
        this.id = id;
        this.name = name;
    }
    private Dictionary<int, PostBookmark> bookmarkedPosts = [];
    public void BookmarkPost(int post, string title, DateTime bookmarkDateTime)
    {
        if (bookmarkedPosts.ContainsKey(post)) return;
        bookmarkedPosts.TryAdd(post, new PostBookmark(post, bookmarkDateTime, title));
    }
    public void RemovePostFromBookMark(int post)
    {
        _ = bookmarkedPosts.Remove(id);
    }
    public void MarkAsReadBookmarkedPost(int post)
    {
        bool flag = bookmarkedPosts.TryGetValue(post, out PostBookmark p);
        if (flag)
        {
            if (bookmarkedPosts.ContainsKey(post))
            {
                _ = bookmarkedPosts[post] = new PostBookmark(post, p.bookmarkedDateTime, p.title, true);
            }
        }
    }
    public override string ToString()
    {
        return string.Format("user#{0}:{1}", id, name);
    }
}
