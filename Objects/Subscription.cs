using System;

namespace Servant.Shared.Objects
{
    public class Subscription
    {
        public string Name { get; set; }
        public int? MaxServers { get; set; }
        public decimal Price { get; set; }
        public bool Trial { get; set; }
        public DateTime? NextPeriod { get; set; }
        public bool MaxServersReached { get; set; }
        public bool UnderCancellation { get; set; }
    }
}
