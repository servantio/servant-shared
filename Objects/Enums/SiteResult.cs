namespace Servant.Shared.Objects.Enums
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