namespace Company_Hierarchy.Data
{
    using System;
    using Company_Hierarchy.Data.Interfaces;

    abstract class Person : IPerson
    {
        private string _firstName;
        private string _lastName;
        private byte _id;

        protected Person(string name, byte id)
        {
            this.Name = name;
            this.Id = id;
        }

        public byte Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        private string Name
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
                "{0}\nName: {1:000}\nID: {2}\n",
                this.GetType().Name.ToUpper(),
                this.Name,
                this.Id);

            return output;
        }
    }
}
