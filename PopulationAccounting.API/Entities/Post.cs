namespace PopulationAccounting.API.Entities
{
    public class Post
    {
        public Guid Id { get; set; }
        public string RequiredSkills { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int Salary {  get; set; }

        public ICollection<AppointmentToWorkplace> AppointmentToWorkplaces { get; set; } = new List<AppointmentToWorkplace>();
    }
}
