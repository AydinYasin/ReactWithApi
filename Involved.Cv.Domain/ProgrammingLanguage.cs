using System.Collections.Generic;

namespace Involved.Cv.Domain
{
    public class ProgrammingLanguage
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public double Skill { get; private set; }
        public ICollection<EmployeeProgrammingLanguage> EmployeeProgrammingLanguages { get; private set; }
    }
}