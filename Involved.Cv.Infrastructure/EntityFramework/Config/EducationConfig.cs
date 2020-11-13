using Involved.Cv.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Involved.Cv.Infrastructure.EntityFramework.Config
{
    public class EducationConfig : IEntityTypeConfiguration<Education>
    {
        public void Configure(EntityTypeBuilder<Education> builder)
        {
            var table = builder.ToTable("Education");
            table.HasKey("Id");

            table.HasMany(_ => _.EmployeeEducations)
                .WithOne(_ => _.Education)
                .HasForeignKey(_ => _.EducationId);
        }
    }
}