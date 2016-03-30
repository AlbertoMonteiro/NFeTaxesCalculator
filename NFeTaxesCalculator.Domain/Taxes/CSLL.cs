namespace NFeTaxesCalculator.Domain.Taxes
{
    public class CSLL : Tax
    {
        public CSLL()
        {
            Name = nameof(CSLL);
        }

        public override bool ShouldRetain(Invoice invoice) => invoice?.Ammount > 5000m;
    }
}