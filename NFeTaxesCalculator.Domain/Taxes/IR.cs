namespace NFeTaxesCalculator.Domain.Taxes
{
    public class IR : Tax
    {
        public IR()
        {
            Name = nameof(IR);
        }

        public override bool ShouldRetain(Invoice invoice) => invoice?.Ammount * (TaxRate / 100) > 10m;
    }
}