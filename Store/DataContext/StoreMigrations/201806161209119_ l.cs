namespace Store.DataContext.StoreMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CartItems",
                c => new
                    {
                        CartId = c.Int(nullable: false, identity: true),
                        ArticleName = c.String(),
                        Price = c.Double(nullable: false),
                        Quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CartId);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerId = c.Int(nullable: false, identity: true),
                        Firstname = c.String(nullable: false),
                        Lastname = c.String(nullable: false),
                        PostCode = c.String(nullable: false),
                        City = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Phonenumber = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.CustomerId);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ArticleId = c.Int(nullable: false, identity: true),
                        ArticleName = c.String(),
                        Description = c.String(maxLength: 200),
                        Price = c.Double(nullable: false),
                        Image = c.String(),
                        Stock = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ArticleId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Products");
            DropTable("dbo.Customers");
            DropTable("dbo.CartItems");
        }
    }
}
