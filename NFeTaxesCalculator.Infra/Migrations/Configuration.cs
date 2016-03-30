using NFeTaxesCalculator.Domain.Taxes;

namespace NFeTaxesCalculator.Infra.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<NFeTaxesCalculatorContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(NFeTaxesCalculatorContext context)
        {
            context.Taxes.AddOrUpdate(t => t.Name, new IR { TaxRate = 1.5m },
                new PIS { TaxRate = 2m },
                new COFINS { TaxRate = 2.5m },
                new CSLL { TaxRate = 3m });
            context.SaveChanges();
        }
    }
}
