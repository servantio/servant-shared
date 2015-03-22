using System;
using Servant.Shared.Objects.Enums;

namespace Servant.Shared.Objects
{
    public class DeploymentResponse : BaseObject
    {
        public int DeploymentId { get; set; }
        public Guid InstallationGuid { get; set; }
        public bool Success { get; set; }
        public string Message { get; set; }
        public DeploymentResponseType Type { get; set; }
    }
}