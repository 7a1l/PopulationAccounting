namespace PopulationAccounting.API.Entities
{
    public class Benefit
    {
        public Guid Id { get; set; }
        public string BenefitType { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Conditions { get; set; } = null!;
        public int Pay {  get; set; }
        public ICollection<CitizenBenefit> CitizenBenefits { get; set; } = new List<CitizenBenefit>();

    }
}
