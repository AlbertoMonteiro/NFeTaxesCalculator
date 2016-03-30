using System.Data.Entity.ModelConfiguration;
using NFeTaxesCalculator.Domain.Taxes;

namespace NFeTaxesCalculator.Infra.Mapping
{
    public class TaxEntityTypeConfiguration : EntityTypeConfiguration<Tax>
    {
        public TaxEntityTypeConfiguration()
        {
            HasKey(x => x.Name);

            Property(x => x.TaxRate).HasPrecision(20, 2);

            Map<PIS>(m => m.Requires("Type").HasValue("PIS"));
            Map<COFINS>(m => m.Requires("Type").HasValue("COFINS"));
            Map<CSLL>(m => m.Requires("Type").HasValue("CSLL"));
            Map<IR>(m => m.Requires("Type").HasValue("IR"));
        }
    }
}