using System;
using System.Collections.Generic;
using System.Text;
using Involved.Cv.Database.Migrations;

namespace Involved.Cv.Database.Seed
{
    public static class M002_UserSeed
    {
        public static void SeedDevData(this M002_User migration)
        {
            //1 user
            var insert = migration.Insert;
            insert.IntoTable("Employee").Row(new { FirstName = "Burak", LastName = "Ocbe", Email="dsds@", BirthDate= new DateTime(2011, 6, 10), Password = "cd", Street = "Ergens", StreetNumber = 1, Zipcode = 5858, Township = "Antwerpen",Description="ABCD",SkillLevelId = 1 });
            insert.IntoTable("Education").Row(new { Level = "Graduaat", Name = "Programmeren", Description = "2dejaar" });
            insert.IntoTable("Project").Row(new { Name = "IT-Case", Description = "Project school" });
            insert.IntoTable("ProgrammingLanguage").Row(new { Name = "C#", Description = "Skill" , Skill = "3"});
            insert.IntoTable("EmployeeEducation").Row(new { EducationId = 1, EmployeeId = 1});
            insert.IntoTable("EmployeeProject").Row(new { ProjectId = 1, EmployeeId = 1 });
            insert.IntoTable("EmployeeProgrammingLanguage").Row(new { ProgrammingLanguageId = 1, EmployeeId = 1 });

            //2 user
            insert.IntoTable("Employee").Row(new { FirstName = "Murat", LastName = "Keklik", Email = "dsds@", BirthDate = new DateTime(1998, 1, 1), Password = "cd", Street = "zuid", StreetNumber = 1, Zipcode = 2018, Township = "Antwerpen", Description = "ABCD", SkillLevelId = 2 });
        }
    }
}
