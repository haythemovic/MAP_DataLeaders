namespace PIDEV_MAP.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MyMig5 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Requests", "requiredProfile", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Requests", "requiredProfile", c => c.String());
        }
    }
}
