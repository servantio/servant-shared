using Servant.Shared.Objects.Enums;

namespace Servant.Shared.Objects
{
    public class Binding
    {
        public Binding()
        {
            IpAddress = "*";
        }

        public Protocol Protocol
        {
            get { return CertificateThumbprint != null ? Protocol.https : Protocol.http; }
            set { }
        }

        public string Hostname { get; set; }
        public int Port { get; set; }
        public int ServerId { get; set; }
        public string IpAddress { get; set; }
        public string CertificateName { get; set; }
        public string CertificateThumbprint { get; set; }
        public override string ToString()
        {
            return Protocol + "://" + (string.IsNullOrWhiteSpace(Hostname) ? "*" : Hostname) + ":" + Port;
        }

        public string ToIisBindingInformation()
        {
            return string.Format( "{0}:{1}:{2}", IpAddress, Port, Hostname);
        }
    }
}