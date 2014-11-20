namespace Developer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update6 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Worker", "Photo", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Worker", "Photo");
        }
    }
}
