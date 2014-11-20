namespace Developer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Photo", "Flat_Id", c => c.Int());
            AddColumn("dbo.Photo", "House_Id", c => c.Int());
            AddColumn("dbo.Photo", "Land_Id", c => c.Int());
            CreateIndex("dbo.Photo", "Flat_Id");
            CreateIndex("dbo.Photo", "House_Id");
            CreateIndex("dbo.Photo", "Land_Id");
            AddForeignKey("dbo.Photo", "Flat_Id", "dbo.Flat", "Id");
            AddForeignKey("dbo.Photo", "House_Id", "dbo.House", "Id");
            AddForeignKey("dbo.Photo", "Land_Id", "dbo.Land", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Photo", "Land_Id", "dbo.Land");
            DropForeignKey("dbo.Photo", "House_Id", "dbo.House");
            DropForeignKey("dbo.Photo", "Flat_Id", "dbo.Flat");
            DropIndex("dbo.Photo", new[] { "Land_Id" });
            DropIndex("dbo.Photo", new[] { "House_Id" });
            DropIndex("dbo.Photo", new[] { "Flat_Id" });
            DropColumn("dbo.Photo", "Land_Id");
            DropColumn("dbo.Photo", "House_Id");
            DropColumn("dbo.Photo", "Flat_Id");
        }
    }
}
