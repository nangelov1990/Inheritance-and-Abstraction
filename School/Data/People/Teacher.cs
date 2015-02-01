namespace School.Data.People
{
    using System;
    using System.Linq;
    using School.Data.Interfaces;

    class Teacher : Person, IDetails
    {
        private string _details;
        private Discipline[] _disciplines;

        public Teacher(string name, Discipline[] disciplines)
            :base(name)
        {
            this.Disciplines = disciplines;
        }

        public Discipline[] Disciplines
        {
            get { return this._disciplines; }
            set { this._disciplines = value; }
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


        public override string ToString()
        {
            var output = string.Format(
                "Disciplines:\n{0}",
                this.Disciplines
                    .Aggregate<Discipline, string>
                        (null, (disciplineNames, discipline)
                            => disciplineNames + string.Format(
                                "{0}\n",
                                discipline)))
                + ((this.Details != null)
                    ? string.Format(
                        "Teacher details: {0}\n",
                        this.Details)
                    : null);

            return base.ToString() + output;
        }
    }
}
