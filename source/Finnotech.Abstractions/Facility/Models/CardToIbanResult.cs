using Finnotech.Abstractions.Core;

namespace Finnotech.Abstractions.Facility.Models
{
    public partial class CardToIbanResult
    {
        public string Iban { get; set; }

        public string BankName { get; set; }

        public string Deposit { get; set; }

        public string Card { get; set; }

        public string DepositStatus { get; set; }

        public string DepositDescription { get; set; }

        public string DepositComment { get; set; }

        public DepositOwner[] DepositOwners { get; set; }

        public string AlertCode { get; set; }
    }
}
