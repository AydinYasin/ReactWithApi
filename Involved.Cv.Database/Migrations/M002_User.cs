using FluentMigrator;
using Involved.Cv.Database.Seed;



namespace Involved.Cv.Database.Migrations
{
    [Migration(2)]
    public class M002_User : Migration
    {
        public override void Up()
        {
            Alter.Table("Employee").AddColumn("IsAdmin").AsBoolean().WithDefaultValue(false).NotNullable();

            Create.Table("ProgrammingLanguage")
                .WithColumn("Id").AsInt32().Identity().PrimaryKey()
                .WithColumn("Name").AsString().NotNullable()
                .WithColumn("Description").AsString().NotNullable()
                .WithColumn("Skill").AsDouble().NotNullable();

            Create.Table("Project")
                .WithColumn("Id").AsInt32().Identity().PrimaryKey()
                .WithColumn("Name").AsString().NotNullable()
                .WithColumn("Description").AsString().NotNullable();

            Create.Table("Education")
                .WithColumn("Id").AsInt32().Identity().PrimaryKey()
                .WithColumn("Name").AsString().NotNullable()
                .WithColumn("Level").AsString().NotNullable()
                .WithColumn("Description").AsString(50).NotNullable();

            Create.Table("EmployeeEducation")
                .WithColumn("Id").AsInt32().Identity().PrimaryKey()
                .WithColumn("EmployeeId").AsInt32().ForeignKey("Employee", "Id")
                .WithColumn("EducationId").AsInt32().ForeignKey("Education", "Id");

            Create.Table("EmployeeProject")
                .WithColumn("Id").AsInt32().Identity().PrimaryKey()
                .WithColumn("EmployeeId").AsInt32().ForeignKey("Employee", "Id")
                .WithColumn("ProjectId").AsInt32().ForeignKey("Project", "Id");

            Create.Table("EmployeeProgrammingLanguage")
                .WithColumn("Id").AsInt32().Identity().PrimaryKey()
                .WithColumn("EmployeeId").AsInt32().ForeignKey("Employee", "Id")
                .WithColumn("ProgrammingLanguageId").AsInt32().ForeignKey("ProgrammingLanguage", "Id");

            this.SeedDevData();
        }
        public override void Down()
        {
            Delete.Table("ProgrammingLanguage");
            Delete.Table("Project");
            Delete.Table("Education");
            Delete.Column("IsAdmin").FromTable("Employee");
            Delete.Table("EmployeeEducation");
            Delete.Table("EmployeeProject");
            Delete.Table("EmployeeProgrammingLanguage");
        }
    }
}