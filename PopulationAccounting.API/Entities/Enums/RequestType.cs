namespace PopulationAccounting.API.Enums
{
    public enum RequestType
    {
        ChangeData,        // изменение данных
        ChangeAddress,     // смена адреса
        AddFamilyMember,   // добавление члена семьи
        PassportChange,    // изменение паспорта
        AddCitizen         // добавление гражданина (например, ребенок)
    }
}
