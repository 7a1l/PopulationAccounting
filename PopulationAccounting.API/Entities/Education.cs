namespace PopulationAccounting.API.Entities
{
    public class Education
    {
        public Guid Id { get; set; }
        public string Institution { get; set; } = null!;
        public string EducationDegree { get; set; } = null!;
        public string Speciality { get; set; } = null!;
        public int DiplomaCode { get; set; }
        public ICollection<CitizenEducation> CitizenEducations { get; set; } = new List<CitizenEducation>();

    }
}
