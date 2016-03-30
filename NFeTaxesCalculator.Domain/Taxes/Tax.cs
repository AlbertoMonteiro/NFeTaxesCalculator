namespace NFeTaxesCalculator.Domain.Taxes
{
    public abstract class Tax
    {
        public string Name { get; set; }
        public decimal TaxRate { get; set; }

        public abstract bool ShouldRetain(Invoice invoice);
    }
}