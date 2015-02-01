namespace Company_Hierarchy.Data
{
    using System.Linq;
    using Company_Hierarchy.Data.Enums;
    using Company_Hierarchy.Data.Interfaces;

    class SalesEmployee : RegularEmployee, ISalesEmployee
    {
        private Sale[] _sales;
        public SalesEmployee(string name, byte id, decimal salary, Departments department, Sale[] sales)
            : base(name, id, salary, department)
        {
            this.Sales = sales;
        }

        public Sale[] Sales
        {
            get { return this._sales; }
            set { this._sales = value; }
        }

        public override string ToString()
        {
            var output = string.Format(
                "Sales:\n{0}",
                (this.Sales != null)
                    ? this.Sales
                        .Aggregate<Sale, string>
                            (null, (sales, sale) =>
                                sales + string.Format(
                                    "{0}\n",
                                    sale))
                    : "No sales.");

            return base.ToString() + output;
        }
    }
}
