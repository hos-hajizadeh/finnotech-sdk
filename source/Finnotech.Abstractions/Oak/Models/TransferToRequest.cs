using System;

namespace Finnotech.Abstractions.Oak.Models
{
    public class TransferToRequest
    {
        public long Amount { get; set; }

        public string Description { get; set; }

        public string DestinationFirstname { get; set; }

        public string DestinationLastname { get; set; }

        public string DestinationNumber { get; set; }

        public long PaymentNumber { get; set; }

        public long Deposit { get; set; }

        public string SourceFirstName { get; set; }

        public string SourceLastName { get; set; }

        public long SourceNid { get; set; }

        public long OtpCode { get; set; }

        public Guid TransferId { get; set; }
    }
}
