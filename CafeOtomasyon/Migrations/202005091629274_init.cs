namespace CafeOtomasyon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bills",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BillNo = c.String(),
                        CustomerNameSurname = c.String(),
                        Piece = c.Int(nullable: false),
                        TotalPiece = c.Int(nullable: false),
                        TotalPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PaymentId = c.Int(nullable: false),
                        DrinkId = c.Int(),
                        FoodId = c.Int(),
                        TableId = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Drinks", t => t.DrinkId)
                .ForeignKey("dbo.Foods", t => t.FoodId)
                .ForeignKey("dbo.Payments", t => t.PaymentId, cascadeDelete: true)
                .ForeignKey("dbo.Tables", t => t.TableId, cascadeDelete: true)
                .Index(t => t.PaymentId)
                .Index(t => t.DrinkId)
                .Index(t => t.FoodId)
                .Index(t => t.TableId);
            
            CreateTable(
                "dbo.Drinks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CategoryId = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Foods",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CategoryId = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.Payments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Tables",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TableNo = c.String(),
                        CustomerArriving = c.DateTime(nullable: false),
                        CustomerLeaving = c.DateTime(),
                        IsRezervation = c.Boolean(nullable: false),
                        DrinkId = c.Int(),
                        FoodId = c.Int(),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Drinks", t => t.DrinkId)
                .ForeignKey("dbo.Foods", t => t.FoodId)
                .Index(t => t.DrinkId)
                .Index(t => t.FoodId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tables", "FoodId", "dbo.Foods");
            DropForeignKey("dbo.Tables", "DrinkId", "dbo.Drinks");
            DropForeignKey("dbo.Bills", "TableId", "dbo.Tables");
            DropForeignKey("dbo.Bills", "PaymentId", "dbo.Payments");
            DropForeignKey("dbo.Foods", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.Bills", "FoodId", "dbo.Foods");
            DropForeignKey("dbo.Drinks", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.Bills", "DrinkId", "dbo.Drinks");
            DropIndex("dbo.Tables", new[] { "FoodId" });
            DropIndex("dbo.Tables", new[] { "DrinkId" });
            DropIndex("dbo.Foods", new[] { "CategoryId" });
            DropIndex("dbo.Drinks", new[] { "CategoryId" });
            DropIndex("dbo.Bills", new[] { "TableId" });
            DropIndex("dbo.Bills", new[] { "FoodId" });
            DropIndex("dbo.Bills", new[] { "DrinkId" });
            DropIndex("dbo.Bills", new[] { "PaymentId" });
            DropTable("dbo.Tables");
            DropTable("dbo.Payments");
            DropTable("dbo.Foods");
            DropTable("dbo.Categories");
            DropTable("dbo.Drinks");
            DropTable("dbo.Bills");
        }
    }
}
