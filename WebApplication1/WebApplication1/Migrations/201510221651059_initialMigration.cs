namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Blurbs",
                c => new
                    {
                        BlurbId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Summary = c.String(),
                        BookId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.BlurbId)
                .ForeignKey("dbo.Books", t => t.BookId, cascadeDelete: true)
                .Index(t => t.BookId);
            
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        BookId = c.Int(nullable: false, identity: true),
                        ImgUrl = c.String(),
                        Title = c.String(),
                        Summary = c.String(),
                        Author = c.String(),
                    })
                .PrimaryKey(t => t.BookId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Blurbs", "BookId", "dbo.Books");
            DropIndex("dbo.Blurbs", new[] { "BookId" });
            DropTable("dbo.Books");
            DropTable("dbo.Blurbs");
        }
    }
}
