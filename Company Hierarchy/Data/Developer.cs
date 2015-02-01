namespace Company_Hierarchy.Data
{
    using System.Linq;
    using Company_Hierarchy.Data.Interfaces;
    using Company_Hierarchy.Data.Enums;

    class Developer : RegularEmployee, IDeveloper
    {
        private Project[] _projects;
        public Developer(string name, byte id, decimal salary, Departments department, Project[] project)
            : base(name, id, salary, department)
        {
            this.Projects = project;
        }

        public Project[] Projects
        {
            get { return this._projects; }
            set { this._projects = value; }
        }

        public void CloseProject(Project project)
        {
            project.ProjectState = ProjectStates.Closed;
        }

        public override string ToString()
        {
            var output = string.Format(
                "Projects:\n{0}",
                (this.Projects != null)
                    ? this.Projects
                        .Aggregate<Project, string>
                            (null, (projects, project) =>
                                projects + string.Format(
                                    "{0}\n",
                                    project))
                    : "No project.");

            return base.ToString() + output;
        }
    }
}
