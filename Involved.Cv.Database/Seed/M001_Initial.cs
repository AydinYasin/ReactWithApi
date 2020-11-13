using Involved.Cv.Database.Migrations;

namespace Involved.Cv.Database.Seed
{
    public static class M001_InitialSeed
    {
        public static void SeedDevData(this M001_Initial migration)
        {
            var insert = migration.Insert;
            insert.IntoTable("SkillLevel").Row(new { Name = "Junior", Description = "_" });
            insert.IntoTable("SkillLevel").Row(new { Name = "Medior", Description = "_" });
            insert.IntoTable("SkillLevel").Row(new { Name = "Senior", Description = "_" });
        }
    }
}