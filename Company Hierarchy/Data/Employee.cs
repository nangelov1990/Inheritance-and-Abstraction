namespace Company_Hierarchy.Data
{
    using Company_Hierarchy.Data.Interfaces;
    using Company_Hierarchy.Data.Enums;

    abstract class Employee : Person, IEmployee
    {
        private decimal _salary;
        private Departments _department;
        
        protected Employee(string name, byte id, decimal salary, Departments department)
            :base(name, id)
        {
            this.Salary = salary;
            this.Department = department;
        }

        public decimal Salary
        {
            get { return this._salary; }
            set { this._salary = value; }
        }

        public Departments Department
        {
            get { return this._department; }
            set { this._department = value; }
        }

        public override string ToString()
        {
            var output = string.Format(
                "Salary: {0}\nDepartment: {1}\n",
                this.Salary,
                this.Department);

            return base.ToString() + output;
        }
    }
}
