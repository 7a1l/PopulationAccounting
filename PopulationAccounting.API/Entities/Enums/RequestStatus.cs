namespace PopulationAccounting.API.Enums
{
    public enum RequestStatus
    {
        Pending,    // ожидает обработки
        Approved,   // одобрена
        Rejected,   // отклонена
        Cancelled   // отменена пользователем
    }
}
