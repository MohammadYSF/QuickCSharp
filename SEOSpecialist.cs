class SEOSpecialist : User
{
    public SEOSpecialist(int id, string name) : base(id, name)
    {
    }
    public void DoSEO(Draft draft, string newDraftTitle, string newDraftText)
    {
        if (draft.status == DraftStatus.ReadyForSEO)
        {
            draft.Update(newDraftTitle, newDraftText);
            draft.UpdateStatus(DraftStatus.ReadyForReview);
        }
        else if (draft.status == DraftStatus.ReadyForReview)
        {
            //do nothing : seo is already done
        }
        else
        {
            throw new Exception("");

        }
    }
}