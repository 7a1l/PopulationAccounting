using PopulationAccounting.API.Enums;

namespace PopulationAccounting.API.Entities
{
    public class Registration
    {
        public Guid Id { get; set; }
        public string Status { get; set; } = null!;
        public DateOnly RegistrarionDate { get; set; }
        public RegistrationType RegistrationType { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set;}
        public DateOnly? EndDate { get; set; }
        public Guid PassportId { get; set; }
        public Guid AddressId { get; set; }
        public Address Address { get; set; } = null!;
        public Passport Passport { get; set; } = null!;

    }
}
