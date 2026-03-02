using PopulationAccounting.API.Enums;

namespace PopulationAccounting.API.Entities
{
    public class Role
    {
        public Guid Id { get; set; }
        public RoleName RoleName { get; set; }
        public string Description { get; set; } = null!;

        public ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>();
    }
}
