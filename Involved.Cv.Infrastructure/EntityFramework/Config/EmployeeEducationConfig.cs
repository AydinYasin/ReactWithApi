using Involved.Cv.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Involved.Cv.Infrastructure.EntityFramework.Config
{
    public class EmployeeEducationConfig : IEntityTypeConfiguration<EmployeeEducation>
    {
        public void Configure(EntityTypeBuilder<EmployeeEducation> builder)
        {
            var table = builder.ToTable("EmployeeEducation");
            table.HasKey("Id");
        }
    }
}