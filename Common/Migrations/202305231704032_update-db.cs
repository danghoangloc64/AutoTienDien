namespace Common.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.InformationModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TenKey = c.String(),
                        KeyKhachHang = c.String(),
                        Key = c.String(),
                        DangSuDung = c.Boolean(nullable: false),
                        Deleted = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        UpdatedDate = c.DateTime(nullable: false),
                        UpdatedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.InformationModels");
        }
    }
}
