namespace SkoolMgmt.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNameToApplcationUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Name", c => c.String(nullable: false, maxLength: 100));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Name");
        }
    }
}
