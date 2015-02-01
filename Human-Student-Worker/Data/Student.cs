namespace Human_Student_Worker.Data
{
    class Student : Human
    {
        private uint _facultyNumber;

        public Student(string name, uint facultyNumber)
            :base(name)
        {
            this.FacultyNumber = facultyNumber;
        }

        public uint FacultyNumber
        {
            get { return this._facultyNumber; }
            set { this._facultyNumber = value; }
        }

        public override string ToString()
        {
            var output = string.Format(
                "Faculty Number: {0}; ",
                this.FacultyNumber);

            return base.ToString() + output;
        }
    }
}
