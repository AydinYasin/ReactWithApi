using System;
using System.Collections.Generic;

namespace Involved.Cv.Domain
{
    public class Employee
    {
        public int Id { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }  
        public string Email { get; set; }
        public DateTime BirthDate { get; private set; }  
        public string Password { get; private set; }
        public string Street { get; private set; }
        public int StreetNumber { get; private set; }
        public int Zipcode { get; private set; }
        public string Township { get; private set; }
        public string Description { get; private set; }
        public bool IsAdmin { get; set; }
        public int? SkillLevelId { get; private set; }
        public SkillLevel SkillLevel { get; set; }
        public ICollection<EmployeeEducation> EmployeeEducations { get; private set; }
        public ICollection<EmployeeProgrammingLanguage> EmployeeProgrammingLanguages { get; private set; }
        public ICollection<EmployeeProject> EmployeeProjects { get; private set; }


    }
}