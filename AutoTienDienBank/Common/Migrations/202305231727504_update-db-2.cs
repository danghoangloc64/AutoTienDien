namespace Common.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedb2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.InformationModels", "SerialNumber", c => c.String());
            DropColumn("dbo.InformationModels", "KeyKhachHang");
        }
        
        public override void Down()
        {
            AddColumn("dbo.InformationModels", "KeyKhachHang", c => c.String());
            DropColumn("dbo.InformationModels", "SerialNumber");
        }
    }
}
