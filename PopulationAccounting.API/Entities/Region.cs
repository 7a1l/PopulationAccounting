using System.Collections.ObjectModel;

namespace PopulationAccounting.API.Entities
{
    public class Region
    {
        public Guid Id { get; set; }

        public string Country { get; set; } = null!;

        public double Square { get; set; }

        public string Capital { get; set; } = null!;

        public string Name { get; set; } = null!;

        public ICollection<Address> Addresses { get; set; } = new Collection<Address>();

    }
}
