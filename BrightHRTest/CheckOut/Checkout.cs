using BrightHRTest.Model.Interface;

namespace BrightHRTest.CheckOut
{
    public class Checkout : ICheckout
    {
        private readonly IEnumerable<IProduct> products;
        private readonly IEnumerable<IOffers> offers;

       public char[] scannedItems;

        public Checkout(IEnumerable<IProduct> products, IEnumerable<IOffers> offers)
        {
            this.products = products;
            this.offers = offers;
            scannedItems = Array.Empty<char>();
        }

        public void Scan(string item)
        {
            if (string.IsNullOrEmpty(item))
                return;

            scannedItems = item.ToCharArray().Where(scannedSKU => products.Any(product => product.SKU == scannedSKU)).ToArray();

        }

        public int GetTotalPrice()
        {
            if (scannedItems.Length == 0) return 0;

            var total = scannedItems.Sum(item => products.Single(x=>x.SKU == item).Price);

            var totalDiscount = offers.Sum(discount => CalculateDiscount(discount, scannedItems));
            return total - totalDiscount;
        }
      
        private int CalculateDiscount(IOffers offers, char[] scannedItems)
        {
            int itemCount = scannedItems.Count(item => item == offers.SKU);
            return (itemCount / offers.OfferQuantity) * offers.OfferPrice;
        }

       
    }
}
