using Involved.Cv.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Involved.Cv.Infrastructure.EntityFramework.Config
{
    public class EmployeeProjectConfig : IEntityTypeConfiguration<EmployeeProject>
    {
        public void Configure(EntityTypeBuilder<EmployeeProject> builder)
        {
            var table = builder.ToTable("EmployeeProject");
            table.HasKey("Id");
        }
    }
}