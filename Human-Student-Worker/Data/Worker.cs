namespace Human_Student_Worker.Data
{
    using System;

    class Worker : Human
    {
        const byte WorkerWeenDuration = 5;

        private double _workHoursPerDay;
        private decimal _weekSalary;

        public Worker(string name, double workHoursPerDay, decimal weekSalary)
            : base(name)
        {
            this.WorkHoursPerDay = workHoursPerDay;
            this.WeekSalary = weekSalary;
        }

        public double WorkHoursPerDay
        {
            get { return this._workHoursPerDay; }
            set { this._workHoursPerDay = value; }
        }

        public decimal WeekSalary
        {
            get { return this._weekSalary; }
            set { this._weekSalary = value; }
        }

        public decimal PaymentPerHour
        {
            get { return this.MoneyPerHour(this.WorkHoursPerDay, this.WeekSalary); }
        }

        public decimal MoneyPerHour(double workHoursPerDay, decimal weekSalary)
        {
            var output = weekSalary/(decimal)(workHoursPerDay * WorkerWeenDuration);

            return output;
        }

        public override string ToString()
        {
            var output = string.Format(
                "Week salary: {0}; Money per hour: {1:0.000}; ",
                this.WeekSalary,
                this.PaymentPerHour);

            return base.ToString() + output;
        }
    }
}
