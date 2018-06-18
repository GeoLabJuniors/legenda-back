namespace legenda.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removeModelsMigration : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ApplicationUsersToRoles", "ApplicationUserID", "dbo.AspNetUsers");
            DropForeignKey("dbo.ApplicationUsersToRoles", "RoleID", "dbo.UserRoles");
            DropIndex("dbo.ApplicationUsersToRoles", new[] { "ApplicationUserID" });
            DropIndex("dbo.ApplicationUsersToRoles", new[] { "RoleID" });
            DropTable("dbo.ApplicationUsersToRoles");
            DropTable("dbo.UserRoles");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.UserRoles",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.ApplicationUsersToRoles",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ApplicationUserID = c.String(maxLength: 128),
                        RoleID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateIndex("dbo.ApplicationUsersToRoles", "RoleID");
            CreateIndex("dbo.ApplicationUsersToRoles", "ApplicationUserID");
            AddForeignKey("dbo.ApplicationUsersToRoles", "RoleID", "dbo.UserRoles", "ID", cascadeDelete: true);
            AddForeignKey("dbo.ApplicationUsersToRoles", "ApplicationUserID", "dbo.AspNetUsers", "Id");
        }
    }
}
