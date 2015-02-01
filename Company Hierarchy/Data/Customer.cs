namespace Company_Hierarchy.Data
{
    using Company_Hierarchy.Data.Interfaces;

    class Customer : Person, ICustomer
    {
        private decimal _netPurchaseAmount;
        public Customer(string name, byte id, decimal netPurchaseAmount)
            : base(name, id)
        {
            this.NetPurchaseAmount = netPurchaseAmount;
        }

        public decimal NetPurchaseAmount
        {
            get { return this._netPurchaseAmount; }
            set { this._netPurchaseAmount = value; }
        }

        public override string ToString()
        {
            var output = string.Format(
                "Net purchase amount: {0}\n",
                this.NetPurchaseAmount);

            return base.ToString() + output;
        }

    }
}
