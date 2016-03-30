namespace NFeTaxesCalculator.Domain.Taxes
{
    public class COFINS : Tax
    {
        public COFINS()
        {
            Name = nameof(COFINS);
        }

        public override bool ShouldRetain(Invoice invoice) => invoice?.Ammount > 5000m;
    }
}