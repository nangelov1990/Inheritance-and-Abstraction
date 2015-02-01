namespace Company_Hierarchy.Data.Interfaces
{
    using System;
    using Company_Hierarchy.Data.Enums;

    interface IProject
    {
        string ProjectName { get; set; }
        DateTime StartDate { get; set; }
        string Details { get; set; }
        ProjectStates ProjectState { get; set; }
    }
}
