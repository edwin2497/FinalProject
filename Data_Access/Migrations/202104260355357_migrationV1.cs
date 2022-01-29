namespace Data_Access.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migrationV1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Administratives",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IsAdmin = c.Boolean(nullable: false),
                        Name = c.String(nullable: false, maxLength: 50),
                        FirstLastName = c.String(nullable: false, maxLength: 50),
                        SecondLastName = c.String(nullable: false, maxLength: 50),
                        CardId = c.Int(nullable: false),
                        Password = c.String(nullable: false, maxLength: 50),
                        Email = c.String(nullable: false, maxLength: 250),
                        Phone = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        FirstLastName = c.String(nullable: false, maxLength: 50),
                        SecondLastName = c.String(nullable: false, maxLength: 50),
                        CardId = c.Int(nullable: false),
                        Password = c.String(nullable: false, maxLength: 50),
                        Email = c.String(nullable: false, maxLength: 250),
                        Phone = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Service_Type",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Description = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Services",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Cost = c.Int(nullable: false),
                        ServiceType = c.Int(nullable: false),
                        IdCustomer = c.Int(nullable: false),
                        VehicleId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.IdCustomer, cascadeDelete: true)
                .ForeignKey("dbo.Service_Type", t => t.ServiceType, cascadeDelete: true)
                .ForeignKey("dbo.Vehicles", t => t.VehicleId, cascadeDelete: true)
                .Index(t => t.ServiceType)
                .Index(t => t.IdCustomer)
                .Index(t => t.VehicleId);
            
            CreateTable(
                "dbo.Vehicles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Brand = c.String(nullable: false, maxLength: 50),
                        Model = c.String(nullable: false, maxLength: 50),
                        Year = c.String(nullable: false, maxLength: 50),
                        Plate = c.String(nullable: false, maxLength: 50),
                        Type = c.Int(nullable: false),
                        IdCustomer = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.IdCustomer, cascadeDelete: false)
                .ForeignKey("dbo.Vehicle_Type", t => t.Type, cascadeDelete: true)
                .Index(t => t.Type)
                .Index(t => t.IdCustomer);
            
            CreateTable(
                "dbo.Vehicle_Type",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Description = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Services", "VehicleId", "dbo.Vehicles");
            DropForeignKey("dbo.Vehicles", "Type", "dbo.Vehicle_Type");
            DropForeignKey("dbo.Vehicles", "IdCustomer", "dbo.Customers");
            DropForeignKey("dbo.Services", "ServiceType", "dbo.Service_Type");
            DropForeignKey("dbo.Services", "IdCustomer", "dbo.Customers");
            DropIndex("dbo.Vehicles", new[] { "IdCustomer" });
            DropIndex("dbo.Vehicles", new[] { "Type" });
            DropIndex("dbo.Services", new[] { "VehicleId" });
            DropIndex("dbo.Services", new[] { "IdCustomer" });
            DropIndex("dbo.Services", new[] { "ServiceType" });
            DropTable("dbo.Vehicle_Type");
            DropTable("dbo.Vehicles");
            DropTable("dbo.Services");
            DropTable("dbo.Service_Type");
            DropTable("dbo.Customers");
            DropTable("dbo.Administratives");
        }
    }
}
