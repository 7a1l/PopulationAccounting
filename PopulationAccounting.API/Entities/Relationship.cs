using PopulationAccounting.API.Enums;

namespace PopulationAccounting.API.Entities
{
    public class Relationship
    {
        public Guid Id { get; set; }
        public KinshipType KinshipType { get; set; }
        public RelationshipType RelatioshipType { get; set; }
        public DateTime CreatedAt { get; set; }
        public Guid FamilyId { get; set; }
        public Guid Citizen1Id { get; set; }
        public Guid Citizen2Id { get; set; }
        public Citizen Citizen { get; set; } = null!;
        public Family Family { get; set; } = null!;

    }
}
