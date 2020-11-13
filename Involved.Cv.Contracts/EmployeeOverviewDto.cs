using System;
using System.Collections.Generic;

namespace Involved.Cv.Contracts.Employee
{
    public class EmployeeOverviewDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Skill { get; set; }
        public string Township { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }
        public List<ProgramLanguageDto> SkillOverviews { get; set; }
    }
}