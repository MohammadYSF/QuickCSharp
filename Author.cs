public class Author : User
{
    private List<int> drafts = [];

    public Author(int id, string name) : base(id, name)
    {
    }

    public Draft CreateDraft(int draftId, string title, string text)
    {
        drafts.Add(draftId);
        return new Draft(draftId, title, text);
    }
    public Draft SetDraftToReadyForReview(Draft draft)
    {
        draft.UpdateStatus(DraftStatus.ReadyForReview);
        return draft;
    }
}
