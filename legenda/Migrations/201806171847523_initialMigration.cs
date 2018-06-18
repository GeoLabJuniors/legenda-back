namespace legenda.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Abouts",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Content = c.String(maxLength: 500),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.ApplicationUsersToRoles",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ApplicationUserID = c.Int(nullable: false),
                        RoleID = c.Int(nullable: false),
                        ApplicationUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationUser_Id)
                .ForeignKey("dbo.UserRoles", t => t.RoleID, cascadeDelete: true)
                .Index(t => t.RoleID)
                .Index(t => t.ApplicationUser_Id);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Firstname = c.String(maxLength: 50),
                        Lastname = c.String(maxLength: 50),
                        Biography = c.String(maxLength: 500),
                        UserMail = c.String(maxLength: 50),
                        ImageID = c.Int(),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Images", t => t.ImageID)
                .Index(t => t.ImageID)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Images",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Path = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ApplicationUserID = c.Int(nullable: false),
                        ImageID = c.Int(),
                        Title = c.String(nullable: false, maxLength: 100),
                        Date = c.DateTime(nullable: false),
                        Text = c.String(nullable: false),
                        ApplicationUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationUser_Id)
                .ForeignKey("dbo.Images", t => t.ImageID)
                .Index(t => t.ImageID)
                .Index(t => t.ApplicationUser_Id);
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.UserRoles",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Brochures",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Path = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Competitions",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Description = c.String(maxLength: 500),
                        Rules = c.String(maxLength: 500),
                        Topic = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Contacts",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                        Addresses = c.String(maxLength: 200),
                        Mails = c.String(maxLength: 200),
                        Mobiles = c.String(maxLength: 200),
                        FBPage = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        InitialUserID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.InitialUsers", t => t.InitialUserID, cascadeDelete: true)
                .Index(t => t.InitialUserID);
            
            CreateTable(
                "dbo.InitialUsers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ApplicationUserId = c.String(maxLength: 128),
                        BirthDate = c.DateTime(nullable: false),
                        Address = c.String(nullable: false, maxLength: 50),
                        Mobile = c.String(nullable: false, maxLength: 9),
                        School = c.String(nullable: false, maxLength: 50),
                        Faculty = c.String(nullable: false, maxLength: 50),
                        SchoolYear = c.Int(nullable: false),
                        HowFound = c.String(nullable: false, maxLength: 500),
                        WhyParticipate = c.String(nullable: false, maxLength: 500),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationUserId)
                .Index(t => t.ApplicationUserId);
            
            CreateTable(
                "dbo.Works",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        InitialUserID = c.Int(nullable: false),
                        SeasonID = c.Int(nullable: false),
                        Title = c.String(nullable: false, maxLength: 50),
                        Topic = c.String(nullable: false, maxLength: 50),
                        Path = c.String(nullable: false, maxLength: 100),
                        User_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.InitialUsers", t => t.InitialUserID, cascadeDelete: true)
                .ForeignKey("dbo.Seasons", t => t.SeasonID, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.User_ID)
                .Index(t => t.InitialUserID)
                .Index(t => t.SeasonID)
                .Index(t => t.User_ID);
            
            CreateTable(
                "dbo.Seasons",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Year = c.Int(nullable: false),
                        MainImageID = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 100),
                        Description = c.String(nullable: false, maxLength: 500),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Images", t => t.MainImageID, cascadeDelete: true)
                .Index(t => t.MainImageID);
            
            CreateTable(
                "dbo.InitialUsersToSeasons",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        InitialUserID = c.Int(nullable: false),
                        SeasonID = c.Int(nullable: false),
                        CompetitionPosition = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Seasons", t => t.SeasonID, cascadeDelete: true)
                .ForeignKey("dbo.InitialUsers", t => t.InitialUserID, cascadeDelete: true)
                .Index(t => t.InitialUserID)
                .Index(t => t.SeasonID);
            
            CreateTable(
                "dbo.JuriesToSeasons",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        JuryID = c.Int(nullable: false),
                        SeasonID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Juries", t => t.JuryID, cascadeDelete: true)
                .ForeignKey("dbo.Seasons", t => t.SeasonID, cascadeDelete: true)
                .Index(t => t.JuryID)
                .Index(t => t.SeasonID);
            
            CreateTable(
                "dbo.Juries",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ApplicationUserID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationUserID)
                .Index(t => t.ApplicationUserID);
            
            CreateTable(
                "dbo.SeasonsToImages",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        SeasonID = c.Int(nullable: false),
                        ImageID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Images", t => t.ImageID, cascadeDelete: false)
                .ForeignKey("dbo.Seasons", t => t.SeasonID, cascadeDelete: false)
                .Index(t => t.SeasonID)
                .Index(t => t.ImageID);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.Works", "User_ID", "dbo.Users");
            DropForeignKey("dbo.Users", "InitialUserID", "dbo.InitialUsers");
            DropForeignKey("dbo.Works", "SeasonID", "dbo.Seasons");
            DropForeignKey("dbo.SeasonsToImages", "SeasonID", "dbo.Seasons");
            DropForeignKey("dbo.SeasonsToImages", "ImageID", "dbo.Images");
            DropForeignKey("dbo.Seasons", "MainImageID", "dbo.Images");
            DropForeignKey("dbo.JuriesToSeasons", "SeasonID", "dbo.Seasons");
            DropForeignKey("dbo.JuriesToSeasons", "JuryID", "dbo.Juries");
            DropForeignKey("dbo.Juries", "ApplicationUserID", "dbo.AspNetUsers");
            DropForeignKey("dbo.InitialUsersToSeasons", "InitialUserID", "dbo.InitialUsers");
            DropForeignKey("dbo.InitialUsersToSeasons", "SeasonID", "dbo.Seasons");
            DropForeignKey("dbo.Works", "InitialUserID", "dbo.InitialUsers");
            DropForeignKey("dbo.InitialUsers", "ApplicationUserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.ApplicationUsersToRoles", "RoleID", "dbo.UserRoles");
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Posts", "ImageID", "dbo.Images");
            DropForeignKey("dbo.Posts", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUsers", "ImageID", "dbo.Images");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.ApplicationUsersToRoles", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.SeasonsToImages", new[] { "ImageID" });
            DropIndex("dbo.SeasonsToImages", new[] { "SeasonID" });
            DropIndex("dbo.Juries", new[] { "ApplicationUserID" });
            DropIndex("dbo.JuriesToSeasons", new[] { "SeasonID" });
            DropIndex("dbo.JuriesToSeasons", new[] { "JuryID" });
            DropIndex("dbo.InitialUsersToSeasons", new[] { "SeasonID" });
            DropIndex("dbo.InitialUsersToSeasons", new[] { "InitialUserID" });
            DropIndex("dbo.Seasons", new[] { "MainImageID" });
            DropIndex("dbo.Works", new[] { "User_ID" });
            DropIndex("dbo.Works", new[] { "SeasonID" });
            DropIndex("dbo.Works", new[] { "InitialUserID" });
            DropIndex("dbo.InitialUsers", new[] { "ApplicationUserId" });
            DropIndex("dbo.Users", new[] { "InitialUserID" });
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.Posts", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.Posts", new[] { "ImageID" });
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AspNetUsers", new[] { "ImageID" });
            DropIndex("dbo.ApplicationUsersToRoles", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.ApplicationUsersToRoles", new[] { "RoleID" });
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.SeasonsToImages");
            DropTable("dbo.Juries");
            DropTable("dbo.JuriesToSeasons");
            DropTable("dbo.InitialUsersToSeasons");
            DropTable("dbo.Seasons");
            DropTable("dbo.Works");
            DropTable("dbo.InitialUsers");
            DropTable("dbo.Users");
            DropTable("dbo.Contacts");
            DropTable("dbo.Competitions");
            DropTable("dbo.Brochures");
            DropTable("dbo.UserRoles");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.Posts");
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.Images");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.ApplicationUsersToRoles");
            DropTable("dbo.Abouts");
        }
    }
}
