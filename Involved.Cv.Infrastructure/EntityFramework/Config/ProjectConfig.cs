using Involved.Cv.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Involved.Cv.Infrastructure.EntityFramework.Config
{
    public class ProjectConfig : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            var table = builder.ToTable("Project");
            table.HasKey("Id");

            table.HasMany(_ => _.EmployeeProjects)
                .WithOne(_ => _.Project)
                .HasForeignKey(_ => _.ProjectId);
        }
    }
}