using System;
using System.Linq;
using System.Text.RegularExpressions;
using NFeTaxesCalculator.Domain.Repositories;
using NFeTaxesCalculator.Domain.Taxes;
using NSubstitute;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace NFeTaxesCalculator.Domain.Tests
{
    [Binding]
    public class InvoiceTaxesSteps
    {
        private Invoice _invoice;
        private Tax _tax;

        [Given(@"a Invoice with a ammount of (.*) reais")]
        public void GivenAInvoiceWithAAmmountOfReais(decimal p0) => _invoice = new Invoice() { Ammount = p0 };

        [When(@"I setup taxes")]
        public void WhenISetupTaxes()
        {
            var taxRepository = Substitute.For<ITaxRepository>();
            var taxes = new[] { _tax }.AsQueryable();
            taxRepository.List().Returns(taxes);
            _invoice.SetupTaxes(taxRepository);
        }

        [Given(@"""(.*)"" tax rate is (.*)%")]
        public void GivenTaxRateIs(string p0, decimal p1)
        {
            var type = typeof(Tax);
            _tax = Activator.CreateInstance(type.Assembly.GetType(Regex.Replace(type.FullName, "Tax$", p0))) as Tax;
            _tax.TaxRate = p1;
        }

        [Then(@"the ""(.*)"" should be added")]
        public void ThenTheShouldBeAdded(string p0) => CollectionAssert.Contains(_invoice.Taxes, new InvoiceTax { Name = p0 });

        [Then(@"the ""(.*)"" should not be added")]
        public void ThenTheShouldNotBeAdded(string p0) => CollectionAssert.DoesNotContain(_invoice.Taxes, new InvoiceTax { Name = p0 });
    }
}
