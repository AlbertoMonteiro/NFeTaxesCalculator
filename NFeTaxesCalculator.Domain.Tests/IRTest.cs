using NFeTaxesCalculator.Domain.Taxes;
using NUnit.Framework;

namespace NFeTaxesCalculator.Domain.Tests
{
    [TestFixture]
    public class IRTest
    {
        [Test]
        public void IRShouldRetainWhenTaxAmmoutIsGreaterThan10()
        {
            var ir = new IR() { TaxRate = 11 };
            Assert.IsTrue(ir.ShouldRetain(new Invoice { Ammount = 100m }));
        }

        [Test]
        public void IRShouldNotRetainWhenTaxAmmoutIsLessThanOrEqualsTo10()
        {
            var ir = new IR() { TaxRate = 1 };
            Assert.IsFalse(ir.ShouldRetain(new Invoice { Ammount = 100.00m }));
        }
    }
}