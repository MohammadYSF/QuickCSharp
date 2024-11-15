public class Draft
{
    public override string ToString()
    {
        return string.Format("draft#{0}:{1}_status:{2}", id, title, status);
    }
    public int id;
    public string title { get; private set; } = string.Empty;
    public string text { get; private set; } = string.Empty;
    public DraftStatus status { get; private set; } = DraftStatus.None;
    public Draft(int id, string title, string text)
    {
        this.id = id;
        this.text = text;
        this.title = title;
    }
    public void UpdateStatus(DraftStatus status)
    {
        this.status = status;
    }
    public Draft Update(string title, string text)
    {
        this.title = title;
        this.text = text;
        return this;
    }
}
