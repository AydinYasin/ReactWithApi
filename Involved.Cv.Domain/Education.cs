using System.Collections.Generic;

namespace Involved.Cv.Domain
{
    public class Education
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Level { get; private set; }
        public string Description { get; private set; }
        public ICollection<EmployeeEducation> EmployeeEducations { get; private set; }
    }
}