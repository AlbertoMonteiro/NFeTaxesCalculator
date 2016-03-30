using System.Data.Entity.ModelConfiguration;
using NFeTaxesCalculator.Domain;

namespace NFeTaxesCalculator.Infra.Mapping
{
    public class InvoiceTaxEntityTypeConfiguration : EntityTypeConfiguration<InvoiceTax>
    {
        public InvoiceTaxEntityTypeConfiguration()
        {
            HasKey(x => x.Id);

            Property(x => x.Ammount).HasPrecision(20, 2);
        }
    }
}