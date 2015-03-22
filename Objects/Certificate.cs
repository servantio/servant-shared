namespace Servant.Shared.Objects
{
    public class Certificate
    {
        public byte[] Hash { get; set; }
        public string Thumbprint { get; set; }
        public string Name { get; set; }
        public int ServerId { get; set; }
    }
}