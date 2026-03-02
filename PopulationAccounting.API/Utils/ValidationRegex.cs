namespace PopulationAccounting.API.Utils
{
    public static class ValidationRegex
    {
        public const string PhoneNumber = @"^\+?\d{10,15}$";
        public const string PassportSeries = @"^[A-Z]{2}\d{6}$";
        public const string PostIndex = @"^\d{5}$";
        public const string Email = @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$";
    }
}
