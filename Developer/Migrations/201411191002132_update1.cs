namespace Developer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Worker", "PhoneFirst", c => c.String());
            AddColumn("dbo.Worker", "PhoneSecond", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Worker", "PhoneSecond");
            DropColumn("dbo.Worker", "PhoneFirst");
        }
    }
}
