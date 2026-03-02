using PopulationAccounting.API.Enums;

namespace PopulationAccounting.API.Entities
{
    public class CitizenRequest
    {
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set;}
        public RequestStatus Status { get; set; }
        public string Description { get; set; } = null!;
        public RequestType RequestType { get; set; }
        public string Data { get; set; } = null!;
        public Guid CitizenId { get; set; }

        public Guid UserId { get; set; }
        public Citizen Citizen { get; set; } = null!;
        public User User { get; set; } = null!;

    }
}
