namespace PopulationAccounting.API.Entities
{
    public class Workplace
    {
        public Guid Id { get; set; }
        public Guid AddressId { get; set; }
        public string Name { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public string Description { get; set; } = null!;
        public ICollection<AppointmentToWorkplace> AppointmentToWorkplaces { get; set; } = new List<AppointmentToWorkplace>();
        public Address? Address { get; set; } = null!;

    }
}
