namespace Common.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedb3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.InformationModels", "DaKichHoat", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.InformationModels", "DaKichHoat");
        }
    }
}
