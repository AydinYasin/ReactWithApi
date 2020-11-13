using System.Collections.Generic;

namespace Involved.Cv.Domain
{
    public class Project
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public ICollection<EmployeeProject> EmployeeProjects { get; private set; }
    }
}