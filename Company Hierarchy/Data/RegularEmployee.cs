namespace Company_Hierarchy.Data
{
    using Company_Hierarchy.Data.Enums;

    abstract class RegularEmployee : Employee
    {
        protected RegularEmployee(string name, byte id, decimal salary, Departments department)
            :base(name, id, salary, department)
        {
        }
    }
}
