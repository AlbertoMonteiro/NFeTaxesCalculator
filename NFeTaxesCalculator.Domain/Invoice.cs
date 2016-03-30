using System.Collections.Generic;
using System.Linq;
using NFeTaxesCalculator.Domain.Repositories;

namespace NFeTaxesCalculator.Domain
{
    public class Invoice
    {
        public long Id { get; set; }
        public decimal Ammount { get; set; }
        public virtual IList<InvoiceTax> Taxes { get; set; }

        public void SetupTaxes(ITaxRepository taxRepository)
        {
            var taxes = taxRepository.List().ToList();

            Taxes = taxes.Where(tax => tax.ShouldRetain(this))
                .Select(tax => new InvoiceTax { Name = tax.Name, TaxRate = tax.TaxRate, Ammount = Ammount * tax.TaxRate / 100 })
                .ToList();
        }
    }
}
