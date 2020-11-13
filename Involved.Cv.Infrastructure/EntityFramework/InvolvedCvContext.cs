using Involved.Cv.Domain;
using Microsoft.EntityFrameworkCore;

namespace Involved.Cv.Infrastructure.EntityFramework
{
    public interface IInvolvedCvContext
    {
        DbSet<Employee> Employees { get; }
        DbSet<SkillLevel> EmployeeSkillLevels { get; }
        DbSet<Education> Educations { get; }
        DbSet<EmployeeEducation> EmployeeEducations { get; }
        DbSet<EmployeeProgrammingLanguage> EmployeeProgrammingLanguages { get; }
        DbSet<EmployeeProject> EmployeeProjects { get; }
        DbSet<ProgrammingLanguage> ProgrammingLanguages { get; }
        DbSet<Project> Projects { get; }
        DbSet<SkillLevel> Skill { get; }
    }
    public class InvolvedCvContext : DbContext, IInvolvedCvContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<SkillLevel> EmployeeSkillLevels { get; set;}
        public DbSet<Education> Educations { get; set; }
        public DbSet<EmployeeEducation> EmployeeEducations { get; set; }
        public DbSet<EmployeeProgrammingLanguage> EmployeeProgrammingLanguages { get; set; }
        public DbSet<EmployeeProject> EmployeeProjects { get; set; }
        public DbSet<ProgrammingLanguage> ProgrammingLanguages { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<SkillLevel> Skill { get; set; }

        public InvolvedCvContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var entityTypeConfigurationRegistration = new EntityTypeConfigurationRegistration(modelBuilder);
            entityTypeConfigurationRegistration.Register(GetType().Assembly);
        }

    }
}