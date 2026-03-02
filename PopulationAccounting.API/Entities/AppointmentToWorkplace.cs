namespace PopulationAccounting.API.Entities
{
    public class AppointmentToWorkplace
    {
        public Guid Id { get; set; }
        
        public DateTime AppointmentDate { get; set; }
        public string Status { get; set; } = null!;
        public DateTime DesmissalDate { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public Guid CitizenId { get; set; }
        public Guid PostId { get; set; }
        public Guid WorkplaceId { get; set; }

        public Citizen Citizen { get; set; } = null!;
        public Post Post { get; set; } = null!;
        public Workplace Workplace { get; set; } = null!;
    }
}
