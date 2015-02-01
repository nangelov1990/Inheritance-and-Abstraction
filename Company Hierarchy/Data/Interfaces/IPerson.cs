namespace Company_Hierarchy.Data.Interfaces
{
    interface IPerson
    {
        byte Id { get; set; }
        string FirstName { get; }
        string LastName { get; }
    }
}
