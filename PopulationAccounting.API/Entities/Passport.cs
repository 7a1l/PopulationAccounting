namespace PopulationAccounting.API.Entities
{
    public class Passport
    {
        public Guid Id { get; set; }
        public int Series {  get; set; }
        public int Number {  get; set; }
        public DateOnly DateOfIssue { get; set; }
        public string Status { get; set; } = null!;
        public string MilitaryDuty { get; set; } = null!;
        public string IssuedBy { get; set; } = null!;
        public string DepartmentCode { get; set; } = null!;
        public DateTime UpdatedAt { get; set; }
        public Guid CitizenId { get; set; }
        public Guid AddressId { get; set; }
        public Citizen Citizen { get; set; } = null!;
        public Address Address { get; set; } = null!;
        public ICollection<Registration> Registrations { get; set; } = new List<Registration>();

    }
}
