using Involved.Cv.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Involved.Cv.Infrastructure.EntityFramework.Config
{
    public class EmployeeProgrammingLanguageConfig : IEntityTypeConfiguration<EmployeeProgrammingLanguage>
    {
        public void Configure(EntityTypeBuilder<EmployeeProgrammingLanguage> builder)
        {
            var table = builder.ToTable("EmployeeProgrammingLanguage");
            table.HasKey("Id");
        }
    }
}