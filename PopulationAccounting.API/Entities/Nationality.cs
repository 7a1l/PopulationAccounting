namespace PopulationAccounting.API.Entities
{
    public class Nationality
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public string MainLanguage { get; set; } = null!;
        public ICollection<Citizen> Citizens { get; set; } = new List<Citizen>();

    }
}
