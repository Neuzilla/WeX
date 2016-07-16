namespace WexOne.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddWeChatEventLogsTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Wex_WeChatEventLogs",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        ToUserName = c.String(maxLength: 200),
                        FromUserName = c.String(maxLength: 200),
                        MsgType = c.String(maxLength: 100),
                        OriginalXml = c.String(),
                        CreationTime = c.DateTime(nullable: false),
                        CreatorUserId = c.Long(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Wex_WeChatEventLogs");
        }
    }
}
