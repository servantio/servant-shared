using System.Collections.Generic;
using Servant.Shared.Objects.Enums;

namespace Servant.Shared.Objects
{
    public class IisSite
    {
        public IisSite()
        {
            Bindings = new List<Binding>() { new Binding { IpAddress = "*" } };
            Applications = new List<SiteApplication>();
            LogFileDirectory = @"%SystemDrive%\inetpub\logs\LogFiles";
            SitePath = @"%SystemDrive%\inetpub\wwwroot";
        }

        public int ServerId { get; set; }
        public int IisId { get; set; }
        public string Name { get; set; }
        public string ApplicationPool { get; set; }
        public string SitePath { get; set; }
        public string LogFileDirectory { get; set; }
        public InstanceState SiteState { get; set; }
        public InstanceState ApplicationPoolState { get; set; }
        public List<Binding> Bindings { get; set; }
        public List<SiteApplication> Applications { get; set; }
    }
}