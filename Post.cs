using System.Text.Json;

public class Post
{
    public override string ToString()
    {
        return string.Format("post#{0}:{1}_____{2}\n\t{3} comments\n\t{4} rates\n\taverageRate: {5}", Id,
         Title, Text, comments.Count, rates.Count, AverageRate);
    }
    public int Id;
    public string Title { get; private set; } = string.Empty;
    public string Text { get; private set; } = string.Empty;
    public double AverageRate
    {
        get
        {
            if (rates.Count == 0)
            {
                return 0;
            }
            return rates.Average(a => a.rate);
        }
    }
    public List<Comment> comments { get; private set; } = [];
    public List<Rate> rates { get; private set; } = [];
    public Post(int id, string title, string text)
    {
        this.Id = id;
        this.Title = title;
        this.Text = text;
    }

    /// <exception cref="Exception">throws rate is not valid</exception>
    public void Rate(int user, int rate)
    {
        if (rate < 1 || rate > 5)
        {
            throw new Exception("rate is not valid");
        }
        var postRate = new Rate(user, rate);
        _ = rates.RemoveAll(a => a.user == user);
        rates.Add(postRate);
    }
    public void Comment(int user, string text)
    {
        this.comments.Add(new Comment(user, text));
    }
}
