using BrightHRTest.Model;


namespace UnitTests.TestContext
{
    public static class TestSetup
    {
        public static  IEnumerable<Product> products;
        public static IEnumerable<Offers> offers;
        public static void BuildTestData()
        {
            products = new[]
            {
                new Product{SKU = 'A', Price = 50},
                new Product{SKU = 'B', Price = 30},
                new Product{SKU = 'C', Price = 20},
                new Product{SKU = 'D', Price = 15}
             };

          offers = new[]
           {
                new Offers{SKU = 'A', OfferQuantity = 3, OfferPrice = 20},
                new Offers{SKU = 'B', OfferQuantity = 2, OfferPrice = 15}
           };
        }
     
    }
}
