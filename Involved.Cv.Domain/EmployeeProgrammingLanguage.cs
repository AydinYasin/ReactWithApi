namespace Involved.Cv.Domain
{
    public class EmployeeProgrammingLanguage
    {
        public int Id { get; private set; }
        public int? EmployeeId { get; private set; }
        public Employee Employee { get; set; }
        public int? ProgrammingLanguageId { get; private set; }
        public ProgrammingLanguage ProgrammingLanguage { get; set; }
    }
}