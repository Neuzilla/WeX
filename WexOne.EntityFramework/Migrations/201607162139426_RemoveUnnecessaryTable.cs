namespace WexOne.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveUnnecessaryTable : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.NZ_QRTexts");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.NZ_QRTexts",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Text = c.String(maxLength: 2000),
                    })
                .PrimaryKey(t => t.Id);
            
        }
    }
}
