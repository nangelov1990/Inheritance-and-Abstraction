namespace Company_Hierarchy.Data.Interfaces
{
    interface IDeveloper
    {
        Project[] Projects { get; set; }

        void CloseProject(Project project);
    }
}
