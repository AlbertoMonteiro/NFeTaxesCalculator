namespace NFeTaxesCalculator.Infra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Invoices",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Ammount = c.Decimal(nullable: false, precision: 20, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.InvoiceTaxes",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255, unicode: false),
                        TaxRate = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Ammount = c.Decimal(nullable: false, precision: 20, scale: 2),
                        Invoice_Id = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Invoices", t => t.Invoice_Id, cascadeDelete: true)
                .Index(t => t.Invoice_Id);
            
            CreateTable(
                "dbo.Taxes",
                c => new
                    {
                        Name = c.String(nullable: false, maxLength: 255, unicode: false),
                        TaxRate = c.Decimal(nullable: false, precision: 20, scale: 2),
                        Type = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Name);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.InvoiceTaxes", "Invoice_Id", "dbo.Invoices");
            DropIndex("dbo.InvoiceTaxes", new[] { "Invoice_Id" });
            DropTable("dbo.Taxes");
            DropTable("dbo.InvoiceTaxes");
            DropTable("dbo.Invoices");
        }
    }
}
