namespace Human_Student_Worker.Data
{
    using System;

    abstract class Human
    {
        private string _firstName;
        private string _lastName;

        protected Human(string name)
        {
            this.Name = name;
        }

        protected string Name
        {
            get
            {
                var fullName = string.Format(
                    "{0} {1}",
                    this._firstName,
                    this._lastName);

                return fullName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException();
                }
                else if (!value.Contains(" "))
                {
                    throw new ArgumentException("Not full name!");
                }

                var fullName = value.Split(' ');

                this._firstName = fullName[0];
                this._lastName = fullName[1];
            }
        }

        public string FirstName
        {
            get { return this._firstName; }
        }

        public string LastName
        {
            get { return this._lastName; }
        }

        public override string ToString()
        {
            var output = string.Format(
                "{0} - Name: {1}; ",
                this.GetType().Name.ToUpper(),
                this.Name);

            return output;
        }
    }
}
