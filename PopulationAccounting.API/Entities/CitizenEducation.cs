namespace PopulationAccounting.API.Entities
{
    public class CitizenEducation
    {
        public Guid EducationId { get; set; }
        public Guid CitizenId { get; set; }
        public DateTime AppointmentDate { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public Education Education { get; set; } = null!;
        public Citizen Citizen { get; set; } = null!;

    }
}
