namespace eUseControl.BusinessLogic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserContext1 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.UserDbTables", newName: "UsersDbTables");
            AddColumn("dbo.UsersDbTables", "Level", c => c.Int(nullable: false));
            AlterColumn("dbo.UsersDbTables", "Password", c => c.String(nullable: false, maxLength: 40));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.UsersDbTables", "Password", c => c.String(nullable: false));
            DropColumn("dbo.UsersDbTables", "Level");
            RenameTable(name: "dbo.UsersDbTables", newName: "UserDbTables");
        }
    }
}
