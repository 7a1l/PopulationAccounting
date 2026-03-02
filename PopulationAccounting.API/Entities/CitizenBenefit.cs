namespace PopulationAccounting.API.Entities
{
    public class CitizenBenefit
    {
        public Guid BenefitId { get; set; }
        public Guid CitizenId { get; set; }
        public bool IsActive { get; set; }
        public DateTime AppointmentDate { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set;}

        public Benefit Benefit { get; set; } = null!;
        public Citizen Citizen { get; set; } = null!;

    }
}
