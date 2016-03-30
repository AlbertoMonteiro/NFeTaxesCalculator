using System.Data.Entity;
using NFeTaxesCalculator.Infra.Migrations;

namespace NFeTaxesCalculator.Infra
{
    public sealed class NFeTaxesCalculatorDbConfigurator : DbConfiguration
    {
        public NFeTaxesCalculatorDbConfigurator()
        {
            var migrator = new MigrateDatabaseToLatestVersion<NFeTaxesCalculatorContext, Configuration>();
            SetDatabaseInitializer(migrator);
        }
    }
}