namespace PopulationAccounting.API.Entities
{
    public class Document
    {
        public Guid Id { get; set; }
        public string Type { get; set; } = null!;
        public string FilePath {  get; set; } = null!;
        public string Status { get; set; } = null!;
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public Guid CitizenId { get; set; }
        public Citizen Citizen { get; set; } = null!;

    }
}
