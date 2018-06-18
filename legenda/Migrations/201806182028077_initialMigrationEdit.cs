namespace legenda.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialMigrationEdit : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.ApplicationUsersToRoles", new[] { "ApplicationUser_Id" });
            DropColumn("dbo.ApplicationUsersToRoles", "ApplicationUserID");
            RenameColumn(table: "dbo.ApplicationUsersToRoles", name: "ApplicationUser_Id", newName: "ApplicationUserID");
            AlterColumn("dbo.ApplicationUsersToRoles", "ApplicationUserID", c => c.String(maxLength: 128));
            CreateIndex("dbo.ApplicationUsersToRoles", "ApplicationUserID");
        }
        
        public override void Down()
        {
            DropIndex("dbo.ApplicationUsersToRoles", new[] { "ApplicationUserID" });
            AlterColumn("dbo.ApplicationUsersToRoles", "ApplicationUserID", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.ApplicationUsersToRoles", name: "ApplicationUserID", newName: "ApplicationUser_Id");
            AddColumn("dbo.ApplicationUsersToRoles", "ApplicationUserID", c => c.Int(nullable: false));
            CreateIndex("dbo.ApplicationUsersToRoles", "ApplicationUser_Id");
        }
    }
}
