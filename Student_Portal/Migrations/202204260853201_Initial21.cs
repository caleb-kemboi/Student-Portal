namespace Student_Portal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial21 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.tb_unitpicker", "UnitName", c => c.String(nullable: false));
            AlterColumn("dbo.tb_unitpicker", "AttachId", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.tb_unitpicker", "AttachId", c => c.String());
            AlterColumn("dbo.tb_unitpicker", "UnitName", c => c.String());
        }
    }
}
