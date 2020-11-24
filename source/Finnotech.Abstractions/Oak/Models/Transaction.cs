using System;

namespace Finnotech.Abstractions.Oak.Models
{
    public partial class Transaction
    {
        public string TransactionId { get; set; }

        public string TransactionDate { get; set; }

        public string TraceId { get; set; }

        public long Amount { get; set; }

        public string SenderName { get; set; }

        public string SenderIban { get; set; }

        public string SenderBank { get; set; }

        public string ReceiverIban { get; set; }

        public string ReceiverName { get; set; }

        public string Comment { get; set; }

        public string PayaCycle { get; set; }

        public string CycleTime { get; set; }

        public string PayId { get; set; }

        public string ReturnCausality { get; set; }

        public string ReturnId { get; set; }

        public string Rejected { get; set; }

        public DateTimeOffset AdDate { get; set; }
    }
}