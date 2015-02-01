namespace School.Data
{
    using System;
    using System.Linq;
    using School.Data.People;
    using School.Data.Interfaces;

    class SchoolClass : IDetails
    {
        private readonly string _textIdentifier;
        private Teacher[] _teachers;
        private string _details;

        public SchoolClass(string textIdentifier, Teacher[] teachers, string details = null)
        {
            this._textIdentifier = textIdentifier;
            this.Teachers = teachers;
            this.Details = details;
        }

        public string TextIdentifier
        {
            get { return this._textIdentifier; }
        }

        public Teacher[] Teachers
        {
            get { return this._teachers; }
            set { this._teachers = value; }
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
                "{0} {1}:\nTeachers:\n{2}",
                this.GetType().Name.ToUpper(),
                this.TextIdentifier,
                this.Teachers
                    .Aggregate<Teacher, string>
                        (null, (teacherNames, teacher) =>
                            teacherNames + string.Format(
                                "{0}\n",
                                teacher)))
                + ((this.Details != null)
                    ? string.Format(
                        "Class details: {0}\n",
                        this.Details)
                    : null);

            return output;
        }
    }
}
