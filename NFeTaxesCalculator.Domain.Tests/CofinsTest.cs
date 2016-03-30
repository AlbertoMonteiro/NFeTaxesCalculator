using NFeTaxesCalculator.Domain.Taxes;
using NUnit.Framework;

namespace NFeTaxesCalculator.Domain.Tests
{
    [TestFixture]
    public class CofinsTest
    {
        [Test]
        public void COFINSShouldRetainWhenInvoiceAmmoutIsGreaterThan5000()
        {
            var cofins = new COFINS();
            Assert.IsTrue(cofins.ShouldRetain(new Invoice { Ammount = 5000.01m }));
        }

        [Test]
        public void COFINSShouldNotRetainWhenInvoiceAmmoutIsLessThanOrEqualsTo5000()
        {
            var cofins = new COFINS();
            Assert.IsFalse(cofins.ShouldRetain(new Invoice { Ammount = 5000.00m }));
        }
    }
}