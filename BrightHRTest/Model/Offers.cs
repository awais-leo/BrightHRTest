using BrightHRTest.Model.Interface;

namespace BrightHRTest.Model
{
    public class Offers : IOffers
    {
        public char SKU {  get; set; }
        public int OfferQuantity {  get; set; }
        public int OfferPrice { get; set; }

    }
}
