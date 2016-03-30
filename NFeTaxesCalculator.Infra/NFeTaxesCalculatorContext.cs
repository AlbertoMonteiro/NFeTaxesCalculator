using System.Data.Entity;
using NFeTaxesCalculator.Domain;
using NFeTaxesCalculator.Domain.Taxes;

namespace NFeTaxesCalculator.Infra
{
    public class NFeTaxesCalculatorContext : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.AddFromAssembly(typeof(NFeTaxesCalculatorContext).Assembly);

            modelBuilder.Properties<string>().Configure(p => p.IsRequired().HasColumnType("varchar").HasMaxLength(255));
        }

        public DbSet<Tax> Taxes { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
    }
}
