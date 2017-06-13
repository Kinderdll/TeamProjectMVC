namespace TeamProjectMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Orders", "UserID", "dbo.Users");
            DropPrimaryKey("dbo.Users");
            AddColumn("dbo.Users", "userID", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Users", "memberID", c => c.Int());
            AddColumn("dbo.Users", "companyID", c => c.Int());
            AddColumn("dbo.Users", "individualID", c => c.Int());
            AddPrimaryKey("dbo.Users", "userID");
            AddForeignKey("dbo.Orders", "UserID", "dbo.Users", "userID", cascadeDelete: true);
            DropColumn("dbo.Users", "ID");
            DropColumn("dbo.Users", "IsAMember");
            DropColumn("dbo.Users", "GuestID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "GuestID", c => c.Int());
            AddColumn("dbo.Users", "IsAMember", c => c.Boolean(nullable: false));
            AddColumn("dbo.Users", "ID", c => c.Int(nullable: false));
            DropForeignKey("dbo.Orders", "UserID", "dbo.Users");
            DropPrimaryKey("dbo.Users");
            DropColumn("dbo.Users", "individualID");
            DropColumn("dbo.Users", "companyID");
            DropColumn("dbo.Users", "memberID");
            DropColumn("dbo.Users", "userID");
            AddPrimaryKey("dbo.Users", "ID");
            AddForeignKey("dbo.Orders", "UserID", "dbo.Users", "ID", cascadeDelete: true);
        }
    }
}
