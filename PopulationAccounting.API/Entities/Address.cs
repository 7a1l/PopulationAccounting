using System.ComponentModel.DataAnnotations;
using PopulationAccounting.API.Utils;

namespace PopulationAccounting.API.Entities
{
    public class Address
    {
        public Guid Id { get; set; }

        public string City { get; set; } = null!;

        public string Street { get; set; } = null!;

        public string PostIndex { get; set; } = null!;

        public string HouseNumber { get; set; } = null!;

        public int? ApartmentNumber { get; set; }

        public Guid RegionId { get; set; }

        public Region Region { get; set; } = null!;
        public ICollection<Registration> Registrations { get; set; } = new List<Registration>();
        public ICollection<Passport> Passports { get; set; } = new List<Passport>();

        public ICollection<Workplace> Workplaces { get; set; } = new List<Workplace>();
        public ICollection<Citizen> Citizens { get; set; } = new List<Citizen>();

    }
}
