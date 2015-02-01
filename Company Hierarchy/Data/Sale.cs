namespace Company_Hierarchy.Data
{
    using System;
    using Company_Hierarchy.Data.Interfaces;

    class Sale : ISale
    {
        private string _productName;
        private DateTime _date;
        private decimal _price;
        public Sale(string productName, DateTime date, decimal price)
        {
            this.ProductName = productName;
            this.Date = date;
            this.Price = price;
        }

        public string ProductName
        {
            get { return this._productName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(
                        "value",
                        "Product name cannot be empty!");
                }

                this._productName = value;
            }
        }

        public DateTime Date
        {
            get { return this._date; }
            set { this._date = value; }
        }

        public decimal Price
        {
            get { return this._price; }
            set { this._price = value; }
        }

        public override string ToString()
        {
            var output = string.Format(
                "{0} - Name: {1}; Date: {2}; Price: {3}\n",
                this.GetType().Name.ToUpper(),
                this.ProductName,
                this.Date,
                this.Price);

            return output;
        }

    }
}
