namespace Finnotech.Abstractions.Facility.Models
{
    public class NidVerificationResult
    {
        public string NationalCode { get; set; }

        public string BirthDate { get; set; }

        public string Status { get; set; }

        public string FullName { get; set; }

        public long FullNameSimilarity { get; set; }

        public string FirstName { get; set; }

        public long FirstNameSimilarity { get; set; }

        public string LastName { get; set; }

        public long LastNameSimilarity { get; set; }

        public string FatherName { get; set; }

        public long FatherNameSimilarity { get; set; }

        public string DeathStatus { get; set; }

        public string Gender { get; set; }

        public long GenderSimilarity { get; set; }

        public string Description { get; set; }
    }
}
