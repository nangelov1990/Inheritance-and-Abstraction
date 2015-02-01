namespace Company_Hierarchy.Data
{
    using System;
    using Company_Hierarchy.Data.Interfaces;
    using Company_Hierarchy.Data.Enums;

    class Project : IProject
    {
        private string _projectName;
        private DateTime _date;
        private string _details;
        private ProjectStates _projectState;

        public Project(string projectName, DateTime startDate, string details, ProjectStates projectState)
        {
            this.ProjectName = projectName;
            this.StartDate = startDate;
            this.Details = details;
            this.ProjectState = projectState;
        }

        public string ProjectName
        {
            get { return this._projectName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(
                        "value",
                        "Project name cannot be empty!");
                }
                this._projectName = value;
            }
        }

        public DateTime StartDate
        {
            get { return this._date; }
            set { this._date = value; }
        }

        public string Details
        {
            get { return this._details; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(
                        "value",
                        "Details cannot be empty!");
                }
                this._details = value;
            }
        }

        public ProjectStates ProjectState
        {
            get { return this._projectState; }
            set { this._projectState = value; }
        }

        public override string ToString()
        {
            var output = string.Format(
                "{0} - Name: {1}; Date: {2}; Details: {3}; State: {4}\n",
                this.GetType().Name.ToUpper(),
                this.ProjectName,
                this.StartDate,
                this.Details,
                this.ProjectState.ToString().ToUpper());

            return output;
        }
    }
}
