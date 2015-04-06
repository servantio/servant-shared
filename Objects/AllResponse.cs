using System;
using System.Collections.Generic;
using System.Linq;

namespace Servant.Shared.Objects
{
    public class AllResponse
    {
        public Guid InstallationGuid { get; set; }
        public List<IisSite> Sites { get; set; }
        public List<ApplicationPool> ApplicationPools { get; set; }
        public List<Certificate> Certificates { get; set; }
        public List<string> FrameworkVersions { get; set; }
        public ApplicationPool DefaultApplicationPool { get; set; }
        public List<string> InstalledModules { get; set; }
    }
}