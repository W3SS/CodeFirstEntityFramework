namespace DatabaseStore.EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class notSure : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.OrderLists", "OrderId", "dbo.Orders");
            DropForeignKey("dbo.OrderLists", "ProductId", "dbo.Products");
            DropIndex("dbo.OrderLists", new[] { "ProductId" });
            DropIndex("dbo.OrderLists", new[] { "OrderId" });
            RenameColumn(table: "dbo.OrderLists", name: "OrderId", newName: "Order_Id");
            RenameColumn(table: "dbo.OrderLists", name: "ProductId", newName: "Product_Id");
            AlterColumn("dbo.OrderLists", "Product_Id", c => c.Int());
            AlterColumn("dbo.OrderLists", "Order_Id", c => c.Int());
            CreateIndex("dbo.OrderLists", "Order_Id");
            CreateIndex("dbo.OrderLists", "Product_Id");
            AddForeignKey("dbo.OrderLists", "Order_Id", "dbo.Orders", "Id");
            AddForeignKey("dbo.OrderLists", "Product_Id", "dbo.Products", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderLists", "Product_Id", "dbo.Products");
            DropForeignKey("dbo.OrderLists", "Order_Id", "dbo.Orders");
            DropIndex("dbo.OrderLists", new[] { "Product_Id" });
            DropIndex("dbo.OrderLists", new[] { "Order_Id" });
            AlterColumn("dbo.OrderLists", "Order_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.OrderLists", "Product_Id", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.OrderLists", name: "Product_Id", newName: "ProductId");
            RenameColumn(table: "dbo.OrderLists", name: "Order_Id", newName: "OrderId");
            CreateIndex("dbo.OrderLists", "OrderId");
            CreateIndex("dbo.OrderLists", "ProductId");
            AddForeignKey("dbo.OrderLists", "ProductId", "dbo.Products", "Id", cascadeDelete: true);
            AddForeignKey("dbo.OrderLists", "OrderId", "dbo.Orders", "Id", cascadeDelete: true);
        }
    }
}
