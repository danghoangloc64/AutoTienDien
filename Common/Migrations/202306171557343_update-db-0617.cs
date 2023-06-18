namespace Common.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedb0617 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.InformationModels", "HanSuDung", c => c.DateTime(nullable: false));
            AddColumn("dbo.InformationModels", "LoaiTool", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.InformationModels", "LoaiTool");
            DropColumn("dbo.InformationModels", "HanSuDung");
        }
    }
}
