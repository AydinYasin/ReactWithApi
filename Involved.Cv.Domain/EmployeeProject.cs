namespace Involved.Cv.Domain
{
    public class EmployeeProject
    {
        public int Id { get; private set; }
        public int? EmployeeId { get; private set; }
        public Employee Employee { get; set; }
        public int? ProjectId { get; private set; }
        public Project Project { get; set; }
    }
}