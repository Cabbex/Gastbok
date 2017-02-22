namespace Gastbok.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeTypeComment : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Comments", "TextData", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Comments", "TextData", c => c.Long(nullable: false));
        }
    }
}
