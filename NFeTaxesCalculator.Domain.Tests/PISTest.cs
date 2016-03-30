using NFeTaxesCalculator.Domain.Taxes;
using NUnit.Framework;

namespace NFeTaxesCalculator.Domain.Tests
{
    [TestFixture]
    public class PISTest
    {
        [Test]
        public void PISShouldRetainWhenInvoiceAmmoutIsGreaterThan5000()
        {
            var pis = new PIS();
            Assert.IsTrue(pis.ShouldRetain(new Invoice { Ammount = 5000.01m }));
        }

        [Test]
        public void PISShouldNotRetainWhenInvoiceAmmoutIsLessThanOrEqualsTo5000()
        {
            var pis = new PIS();
            Assert.IsFalse(pis.ShouldRetain(new Invoice { Ammount = 5000.00m }));
        }
    }
}