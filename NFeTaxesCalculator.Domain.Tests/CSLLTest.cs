using NFeTaxesCalculator.Domain.Taxes;
using NUnit.Framework;

namespace NFeTaxesCalculator.Domain.Tests
{
    [TestFixture]
    public class CSLLTest
    {
        [Test]
        public void CSLLShouldRetainWhenInvoiceAmmoutIsGreaterThan5000()
        {
            var csll = new CSLL();
            Assert.IsTrue(csll.ShouldRetain(new Invoice { Ammount = 5000.01m }));
        }

        [Test]
        public void CSLLShouldNotRetainWhenInvoiceAmmoutIsLessThanOrEqualsTo5000()
        {
            var csll = new CSLL();
            Assert.IsFalse(csll.ShouldRetain(new Invoice { Ammount = 5000.00m }));
        }
    }
}