namespace Finnotech.Abstractions.Facility.Models
{
    public class DepositOwnerVerificationResult
    {
        public string Nid { get; set; }

        public string Deposit { get; set; }

        public bool IsOwner { get; set; }
    }
}
