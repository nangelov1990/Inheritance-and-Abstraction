namespace School.Data
{
    using System;
    using System.Linq;
    using School.Data.People;
    using School.Data.Interfaces;

    class Discipline : IName, IDetails
    {
        private string _name;
        private byte _numberOfLectures;
        private Student[] _students;
        private string _details;

        public Discipline(string name, byte numberOfLectures, Student[] students, string details = null)
        {
            this.Name = name;
            this.NumberOfLectures = numberOfLectures;
            this.Students = students;
            this.Details = details;
        }

        public string Name
        {
            get { return this._name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException(
                        "Discipline name cannot be empty");
                }

                this._name = value;
            }
        }

        public byte NumberOfLectures
        {
            get { return this._numberOfLectures; }
            set { this._numberOfLectures = value; }
        }

        public Student[] Students
        {
            get { return this._students; }
            set { this._students = value; }
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
                    "{0}\nName: {1}\nNumber of lectures: {2}\nStudents:\n{3}",
                    this.GetType().Name.ToUpper(),
                    this.Name,
                    this.NumberOfLectures,
                    this.Students
                        .Aggregate<Student, string>
                            (null, (studentNames, student)
                                => studentNames + string.Format(
                                    "{0}\n",
                                    student)))
                + ((this.Details != null)
                    ? string.Format(
                        "Discipline details: {0}\n",
                        this.Details)
                    : null);

            return output;
        }
    }
}
