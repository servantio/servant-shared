namespace Servant.Shared.Enums
{
    public enum SiteResult
    {
        Success,
        Failed,
        BindingAlreadyInUse,
        NameAlreadyInUse,
        UnknownSiteId,
        SiteNameNotFound,
        ValidationError
    }
}