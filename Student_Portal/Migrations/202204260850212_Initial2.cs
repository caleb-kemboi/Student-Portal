namespace Student_Portal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tb_unitpicker",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CourseName = c.String(nullable: false),
                        UnitName = c.String(),
                        AttachId = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.tb_unitpicker");
        }
    }
}
