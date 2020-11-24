namespace Finnotech.Abstractions.Oak.Models
{
    public class TransferToResult
    {
        public long Amount { get; set; }

        public string Description { get; set; }

        public string DestinationFirstname { get; set; }

        public string DestinationLastname { get; set; }

        public string DestinationNumber { get; set; }

        public long InquiryDate { get; set; }

        public long InquirySequence { get; set; }

        public string InquiryTime { get; set; }

        public string Message { get; set; }

        public long PaymentNumber { get; set; }

        public string RefCode { get; set; }

        public string SourceFirstname { get; set; }

        public string SourceLastname { get; set; }

        public string SourceNumber { get; set; }

        public string Type { get; set; }
    }
}
