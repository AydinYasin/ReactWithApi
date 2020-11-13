using Involved.Cv.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Involved.Cv.Infrastructure.EntityFramework.Config
{
    public class SkillLevelConfig : IEntityTypeConfiguration<SkillLevel>
    {
        public void Configure(EntityTypeBuilder<SkillLevel> builder)
        {
            var table = builder.ToTable("SkillLevel");
            table.HasKey("Id");

            table.HasMany(_ => _.Employees)
                .WithOne(_ => _.SkillLevel)
                .HasForeignKey(_ => _.SkillLevelId);
        }
    }
}