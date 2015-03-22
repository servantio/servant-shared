using System;

namespace Servant.Shared.Objects
{
    public class Deployment : BaseObject
    {
        public Guid Guid { get; set; }
        public int OrganizationId { get; set; }
        public int CreatedByUserId { get; set; }
        public int SiteIisId { get; set; }
        public string SiteName { get; set; }
        public string Url { get; set; }
        public bool RollbackOnError { get; set; }
        public bool WarmupAfterDeploy { get; set; }
        public string WarmupUrl { get; set; }
        public int? FarmId { get; set; }
        public int? ServerId { get; set; }
        public bool? Success { get; set; }
        public string Comment { get; set; }

    }
}