namespace Finnotech.Abstractions.Oak.Models
{
    public class TransferInquiryResult
    {
        public string TransferStatus { get; set; }

        public long TransactionAmount { get; set; }

        public string SourceNumber { get; set; }

        public string DestinationNumber { get; set; }

        public long InquiryDate { get; set; }

        public string InquiryTime { get; set; }

        public long InquirySequence { get; set; }

        public string TransferTrackId { get; set; }
    }
}
