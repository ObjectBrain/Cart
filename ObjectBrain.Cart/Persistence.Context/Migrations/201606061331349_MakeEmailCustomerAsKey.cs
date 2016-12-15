namespace Data.Context.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MakeEmailCustomerAsKey : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Orders", "CustomerId", "dbo.Customers");
            DropIndex("dbo.Orders", new[] { "CustomerId" });
            DropPrimaryKey("dbo.Customers");
            AddColumn("dbo.Orders", "CustomerEmail", c => c.String(maxLength: 128));
            AlterColumn("dbo.Customers", "Email", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Customers", new[] { "Id", "Email" });
            CreateIndex("dbo.Orders", new[] { "CustomerId", "CustomerEmail" });
            AddForeignKey("dbo.Orders", new[] { "CustomerId", "CustomerEmail" }, "dbo.Customers", new[] { "Id", "Email" });
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", new[] { "CustomerId", "CustomerEmail" }, "dbo.Customers");
            DropIndex("dbo.Orders", new[] { "CustomerId", "CustomerEmail" });
            DropPrimaryKey("dbo.Customers");
            AlterColumn("dbo.Customers", "Email", c => c.String());
            DropColumn("dbo.Orders", "CustomerEmail");
            AddPrimaryKey("dbo.Customers", "Id");
            CreateIndex("dbo.Orders", "CustomerId");
            AddForeignKey("dbo.Orders", "CustomerId", "dbo.Customers", "Id", cascadeDelete: true);
        }
    }
}
