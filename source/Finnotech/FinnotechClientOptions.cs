namespace Finnotech
{
    public class FinnotechClientOptions
    {
        public static readonly FinnotechClientOptions ApiBeta = new FinnotechClientOptions
        {
            BaseUrl = "https://apibeta.finnotech.ir"
        };

        public static readonly FinnotechClientOptions SandboxBeta = new FinnotechClientOptions
        {
            BaseUrl = "https://sandboxbeta.finnotech.ir"
        };

        public string BaseUrl { get; set; }
    }
}
