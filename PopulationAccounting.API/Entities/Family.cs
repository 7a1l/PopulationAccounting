namespace PopulationAccounting.API.Entities
{
    public class Family
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public ICollection<Relationship> Relationships { get; set; } = new List<Relationship>();

    }
}
