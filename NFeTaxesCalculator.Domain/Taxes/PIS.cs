namespace NFeTaxesCalculator.Domain.Taxes
{
    public class PIS : Tax
    {
        public PIS()
        {
            Name = nameof(PIS);
        }

        public override bool ShouldRetain(Invoice invoice) => invoice?.Ammount > 5000m;
    }
}