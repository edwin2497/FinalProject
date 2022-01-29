namespace Data_Access.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migrationV3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Audits",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                        FirstLastName = c.String(maxLength: 50),
                        SecondLastName = c.String(maxLength: 50),
                        CardId = c.Int(nullable: false),
                        Password = c.String(maxLength: 50),
                        Email = c.String(maxLength: 250),
                        Phone = c.Int(nullable: false),
                        IsAdmin = c.Boolean(nullable: false),
                        Cost = c.Int(nullable: false),
                        ServiceType = c.Int(nullable: false),
                        IdCustomer = c.Int(nullable: false),
                        VehicleId = c.Int(nullable: false),
                        Description = c.String(maxLength: 100),
                        Brand = c.String(maxLength: 50),
                        Model = c.String(maxLength: 50),
                        Year = c.Int(nullable: false),
                        Plate = c.String(maxLength: 50),
                        Type = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Audits");
        }
    }
}
