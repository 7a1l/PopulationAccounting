namespace PopulationAccounting.API.Entities
{
    public class AuditLog
    {
        public Guid Id { get; set; }
        public string Action { get; set; } = null!;
        public string EntityName { get; set; } = null!;
        public Guid EntityId { get; set; }
        public string OldValues { get; set; } = null!;
        public string? NewValues { get; set; }
        public DateTime Time { get; set; }
        public string Device {  get; set; } = null!;
        public string IPAddress { get; set; } = null!;
        public Guid UserId { get; set; }
        public User User { get; set; }

    }
}
