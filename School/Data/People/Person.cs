namespace School.Data.People
{
    using System;
    using School.Data.Interfaces;

    abstract class Person : IName
    {
        private string _name;

        public Person(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get { return this._name; }
            set
            {
                if (value != null && value.Length < 1)
                {
                    throw new ArgumentException(
                        "Name cannot be empty!");
                }

                this._name = value;
            }
        }


        public override string ToString()
        {
            var output = string.Format(
                "{0}\nName: {1}\n",
                this.GetType().Name.ToUpper(),
                this.Name);

            return output;
        }
    }
}
