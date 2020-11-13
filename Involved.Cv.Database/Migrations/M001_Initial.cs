using FluentMigrator;
using Involved.Cv.Database.Seed;

namespace Involved.Cv.Database.Migrations
{
    [Migration(1)]
    public class M001_Initial : Migration
    {
        public override void Up()
        {
            Create.Table("SkillLevel")
                .WithColumn("Id").AsInt32().Identity().PrimaryKey()
                .WithColumn("Name").AsString(50).NotNullable()
                .WithColumn("Description").AsString(50).NotNullable();

            Create.Table("Employee")
                .WithColumn("Id").AsInt32().Identity().PrimaryKey()
                .WithColumn("FirstName").AsString(50).NotNullable()
                .WithColumn("LastName").AsString(50).NotNullable()
                .WithColumn("Email").AsString().NotNullable()
                .WithColumn("BirthDate").AsDate().NotNullable()
                .WithColumn("Password").AsString(50).NotNullable()
                .WithColumn("Street").AsString(50).NotNullable()
                .WithColumn("StreetNumber").AsInt32().NotNullable()
                .WithColumn("Zipcode").AsInt32().NotNullable()
                .WithColumn("Township").AsString(50).NotNullable()
                .WithColumn("Description").AsString().NotNullable()
                .WithColumn("SkillLevelId").AsInt32().NotNullable().ForeignKey("SkillLevel", "Id");


            this.SeedDevData();
            
        }

        public override void Down()
        {
            Delete.Table("Employee");
            Delete.Table("SkillLevel");
        }
    }
}