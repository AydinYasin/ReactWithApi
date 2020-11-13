namespace Involved.Cv.Domain
{
    public class EmployeeEducation
    {
        public int Id { get; private set; }
        public int? EmployeeId { get; private set; }
        public Employee Employee { get; set; }
        public int? EducationId { get; private set; }
        public Education Education { get; set; }
    }
}