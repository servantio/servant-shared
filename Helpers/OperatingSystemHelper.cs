using System;
using System.Linq;
using System.Management;

namespace Servant.Shared.Helpers
{
    public static class OperatingSystemHelper
    {
        public static string GetOsVersion()
        {
            var name = (from x in new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_OperatingSystem").Get().OfType<ManagementObject>()
                        select x.GetPropertyValue("Caption")).First();
            return name != null ? name.ToString() : "Unknown";
        }
    }
}