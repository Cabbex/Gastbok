namespace Gastbok.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class checkmigration1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Comments", "User_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Comments", new[] { "User_Id" });
            AddColumn("dbo.Comments", "UserId", c => c.String());
            DropColumn("dbo.Comments", "User_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Comments", "User_Id", c => c.String(maxLength: 128));
            DropColumn("dbo.Comments", "UserId");
            CreateIndex("dbo.Comments", "User_Id");
            AddForeignKey("dbo.Comments", "User_Id", "dbo.AspNetUsers", "Id");
        }
    }
}
