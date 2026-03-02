using PopulationAccounting.API.Enums;

namespace PopulationAccounting.API.Entities
{
    public class Citizen
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public string Surname { get; set; } = null!;
        public string Pattronymic { get; set; } = null!;
        public FamilyStatus FamilyStatus { get; set; }
        public DateOnly Birthdate { get; set; }
        public string PhotoUrl { get; set; } = null!;
        public GenderType Gender { get; set; }
        public DateTime Created_at { get; set; }
        public DateTime Updated_at { get; set;}
        public Guid NationalityId { get; set; }
        public Guid UserId { get; set; }
        public Guid AddressId { get; set; }
        public Nationality Nationality { get; set; } = null!;
        public User User { get; set; } = null!;
        public Address Address { get; set; } = null!;
        public ICollection<CitizenBenefit> CitizenBenefits { get; set; } = new List<CitizenBenefit>();
        public ICollection<CitizenEducation> CitizenEducations { get; set; } = new List<CitizenEducation>();
        public ICollection<CitizenRequest> CitizenRequests { get; set; } = new List<CitizenRequest>();
        public ICollection<AppointmentToWorkplace> AppointmentToWorkplaces { get; set; } = new List<AppointmentToWorkplace>();
        public ICollection<Passport> Passports { get; set; } = new List<Passport>();    
        public ICollection<Relationship> Relationships { get; set; } = new List<Relationship>();

        public ICollection<Document> Documents { get; set; } = new List<Document>();
    }
}
