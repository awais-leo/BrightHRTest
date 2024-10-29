using BrightHRTest.CheckOut;
using BrightHRTest.Model;
using NUnit;
using System.Runtime.CompilerServices;
using UnitTests.TestContext;
namespace UnitTests
{
    public class Tests
    {
        public ICheckout checkout;
        
        [SetUp]
        public void Setup()
        {
            TestSetup.BuildTestData();

            checkout = new Checkout(TestSetup.products, TestSetup.offers);
        }

        [Test]
        public void WhenScanCalled_WithEmptyItemSku_ThenReturnedZero()
        {
            checkout.Scan("");

            var response = checkout.GetTotalPrice();

            Assert.That(response, Is.Zero);
        }

        [Test,TestCaseSource(typeof(TestData), nameof(TestData.SingleItemsAndExpextedResults))]
        public void WhenScanCalled_WithSingleItem_ThenCorrectPriceReturned(string sku,int expectedPrice)
        {
            checkout.Scan(sku);

            var response = checkout.GetTotalPrice();

            Assert.That(response, Is.EqualTo(expectedPrice));
        }


        [Test, TestCaseSource(typeof(TestData), nameof(TestData.MultipleItemsAndExpextedResults))]
        public void WhenScanCalled_WithMultipleItem_ThenCorrectPriceReturned(string sku, int expectedPrice)
        {
            checkout.Scan(sku);

            var response = checkout.GetTotalPrice();

            Assert.That(response, Is.EqualTo(expectedPrice));
        }

        [Test, TestCaseSource(typeof(TestData), nameof(TestData.MultipleWithDiscountsItemsAndExpextedResults))]
        public void WhenScanCalled_WithMultipleItemAndDiscountedCombinations_ThenCorrectPriceReturned(string sku, int expectedPrice)
        {
            checkout.Scan(sku);

            var response = checkout.GetTotalPrice();

            Assert.That(response, Is.EqualTo(expectedPrice));
        }

        [Test,TestCase("EFGHI")]
        public void WhenScanCalled_WithUnknonwSKUs_ThenZeroReturned(string sku)
        {
            checkout.Scan(sku);
            
            var response = checkout.GetTotalPrice();

            Assert.That(response, Is.Zero);
        }
    }
}