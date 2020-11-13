using Involved.Cv.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Involved.Cv.Infrastructure.EntityFramework.Config
{
    public class EmployeeConfig : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            var table = builder.ToTable("Employee");
            table.HasKey("Id");

            table.HasOne(_ => _.SkillLevel)
                .WithMany(_ => _.Employees)
                .HasForeignKey(_ => _.SkillLevelId);

            table.HasMany(_ => _.EmployeeProgrammingLanguages)
                .WithOne(_ => _.Employee)
                .HasForeignKey(f => f.EmployeeId);


            table.HasMany(_ => _.EmployeeProjects)
                .WithOne(_ => _.Employee)
                .HasForeignKey(_ => _.EmployeeId);

            table.HasMany(_ => _.EmployeeEducations)
                .WithOne(_ => _.Employee)
                .HasForeignKey(_ => _.EmployeeId);
        }
    }
}