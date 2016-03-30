namespace NFeTaxesCalculator.Domain
{
    public class InvoiceTax
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public decimal TaxRate { get; set; }
        public decimal Ammount { get; set; }

        protected bool Equals(InvoiceTax other) => Name == other.Name;

        public override bool Equals(object obj) => Equals(obj as InvoiceTax);

        public override int GetHashCode() => Name?.GetHashCode() ?? 0;
    }
}