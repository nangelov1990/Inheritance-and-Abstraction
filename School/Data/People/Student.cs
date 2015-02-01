namespace School.Data.People
{
    using System;
    using School.Data.Interfaces;

    class Student : Person, IDetails
    {
        private string _details;
        private readonly byte _uniqueClassNumber;

        public Student(string name, byte classNumber, string details = null)
            :base(name)
        {
            this._uniqueClassNumber = classNumber;
            this.Details = details;
        }

        public string Details
        {
            get { return this._details; }
            set
            {
                if (value != null && value.Length < 1)
                {
                    throw new ArgumentException(
                        "Details cannot be empty!");
                }

                this._details = value;
            }
        }

        public byte UniqueClassNumber
        {
            get { return this._uniqueClassNumber; }
        }

        public override string ToString()
        {
            var output = string.Format(
                    "Class number: {0}\n",
                    this.UniqueClassNumber)
                + ((this.Details != null)
                    ? string.Format(
                        "Student details: {0}\n",
                        this.Details)
                    : null);

            return base.ToString() + output;
        }
    }
}
