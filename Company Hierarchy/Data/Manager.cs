namespace Company_Hierarchy.Data
{
    using System.Linq;
    using Company_Hierarchy.Data.Enums;
    using Company_Hierarchy.Data.Interfaces;

    class Manager : Employee, IManager
    {
        private Employee[] _employees;
        public Manager(string name, byte id, decimal salary, Departments department, Employee[] employees)
            : base(name, id, salary, department)
        {
            this.Employees = employees;
        }

        public Employee[] Employees
        {
            get { return this._employees; }
            set { this._employees = value; }
        }

        public override string ToString()
        {
            var output = string.Format(
                "Employees:\n{0}",
                (this.Employees != null)
                    ? this.Employees
                        .Aggregate<Employee, string>
                            (null, (employees, employee) =>
                                employees + string.Format(
                                    "{0}\n",
                                    employee))
                    : "No employees.");

            return base.ToString() + output;
        }

    }
}
