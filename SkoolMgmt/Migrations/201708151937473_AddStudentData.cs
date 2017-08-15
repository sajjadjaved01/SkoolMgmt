namespace SkoolMgmt.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddStudentData : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentId = c.Int(nullable: false, identity: true),
                        EnrollmentNum = c.String(nullable: false, maxLength: 10),
                        Name = c.String(nullable: false, maxLength: 100),
                        FatherName = c.String(nullable: false, maxLength: 100),
                        FatherCNIC = c.String(nullable: false, maxLength: 20),
                        FatherOcc = c.String(maxLength: 20),
                        Gender = c.String(nullable: false),
                        DOB = c.DateTime(nullable: false),
                        UserName = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        Email = c.String(),
                        Phone = c.String(nullable: false, maxLength: 14),
                        EnrollmentDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.StudentId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Students");
        }
    }
}
