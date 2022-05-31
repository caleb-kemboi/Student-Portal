namespace Student_Portal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class student : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.student",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Course = c.String(nullable: false),
                        Unit = c.String(nullable: false),
                        AttachId = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.student");
        }
    }
}
