using System.Data.Entity.ModelConfiguration;
using NFeTaxesCalculator.Domain;

namespace NFeTaxesCalculator.Infra.Mapping
{
    public class InvoiceEntityTypeConfiguration : EntityTypeConfiguration<Invoice>
    {
        public InvoiceEntityTypeConfiguration()
        {
            HasKey(x => x.Id);

            Property(x => x.Ammount).HasPrecision(20, 2);

            HasMany(x => x.Taxes).WithRequired().WillCascadeOnDelete();
        }
    }
}