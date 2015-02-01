namespace Company_Hierarchy.Data.Interfaces
{
    using Company_Hierarchy.Data.Enums;

    interface IEmployee
    {
        decimal Salary { get; set; }
        Departments Department { get; set; }
    }
}
