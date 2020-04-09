namespace eUseControl.BusinessLogic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserContext : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserDbTables",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(nullable: false, maxLength: 30),
                        Password = c.String(nullable: false),
                        Email = c.String(nullable: false, maxLength: 30),
                        Info = c.String(nullable: false, maxLength: 300),
                        RegisterDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UserDbTables");
        }
    }
}
