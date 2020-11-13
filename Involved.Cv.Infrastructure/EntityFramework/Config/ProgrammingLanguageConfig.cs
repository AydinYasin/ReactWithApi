using Involved.Cv.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Involved.Cv.Infrastructure.EntityFramework.Config
{
    public class ProgrammingLanguageConfig : IEntityTypeConfiguration<ProgrammingLanguage>
    {
        public void Configure(EntityTypeBuilder<ProgrammingLanguage> builder)
        {
            var table = builder.ToTable("ProgrammingLanguage");
            table.HasKey("Id");

            table.HasMany(_ => _.EmployeeProgrammingLanguages)
                .WithOne(_ => _.ProgrammingLanguage)
                .HasForeignKey(_ => _.ProgrammingLanguageId);
        }
    }
}