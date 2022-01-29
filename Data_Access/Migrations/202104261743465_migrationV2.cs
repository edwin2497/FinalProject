namespace Data_Access.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migrationV2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Vehicles", "Year", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Vehicles", "Year", c => c.String(nullable: false, maxLength: 50));
        }
    }
}
