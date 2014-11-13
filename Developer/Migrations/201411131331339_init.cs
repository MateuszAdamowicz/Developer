namespace Developer.Models.EntityModels
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Flat",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Location = c.String(),
                        Area = c.String(),
                        Storey = c.String(),
                        TechnicalCondition = c.String(),
                        Rooms = c.String(),
                        Heating = c.String(),
                        Rent = c.String(),
                        Ownership = c.String(),
                        PricePerMeter = c.String(),
                        ToLet = c.Boolean(nullable: false),
                        Title = c.String(),
                        Description = c.String(),
                        Details = c.String(),
                        City = c.String(),
                        Price = c.String(),
                        CreatedAt = c.DateTime(),
                        Worker_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Worker", t => t.Worker_Id)
                .Index(t => t.Worker_Id);
            
            CreateTable(
                "dbo.Worker",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Email = c.String(),
                        CreatedAt = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.House",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Location = c.String(),
                        LandArea = c.String(),
                        UsableArea = c.String(),
                        TechnicalCondition = c.String(),
                        Rooms = c.String(),
                        Heating = c.String(),
                        Rent = c.String(),
                        Ownership = c.String(),
                        PricePerMeter = c.String(),
                        ToLet = c.String(),
                        Title = c.String(),
                        Description = c.String(),
                        Details = c.String(),
                        City = c.String(),
                        Price = c.String(),
                        CreatedAt = c.DateTime(),
                        Worker_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Worker", t => t.Worker_Id)
                .Index(t => t.Worker_Id);
            
            CreateTable(
                "dbo.Land",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Area = c.String(),
                        Ownership = c.String(),
                        Title = c.String(),
                        Description = c.String(),
                        Details = c.String(),
                        City = c.String(),
                        Price = c.String(),
                        CreatedAt = c.DateTime(),
                        Worker_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Worker", t => t.Worker_Id)
                .Index(t => t.Worker_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Land", "Worker_Id", "dbo.Worker");
            DropForeignKey("dbo.House", "Worker_Id", "dbo.Worker");
            DropForeignKey("dbo.Flat", "Worker_Id", "dbo.Worker");
            DropIndex("dbo.Land", new[] { "Worker_Id" });
            DropIndex("dbo.House", new[] { "Worker_Id" });
            DropIndex("dbo.Flat", new[] { "Worker_Id" });
            DropTable("dbo.Land");
            DropTable("dbo.House");
            DropTable("dbo.Worker");
            DropTable("dbo.Flat");
        }
    }
}
