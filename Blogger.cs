public class Blogger : User
{
    public Blogger(int id, string name) : base(id, name)
    {
    }

    public Post ConvertDraftToPost(Draft draft){
        if (draft.status == DraftStatus.ReadyForReview){
            return new Post(draft.id, draft.title, draft.text);
        }
        throw new Exception("");
    }
    public Draft SetDraftToReadyForSEO(Draft draft)
    {
        draft.UpdateStatus(DraftStatus.ReadyForSEO);
        return draft;
    }
}
