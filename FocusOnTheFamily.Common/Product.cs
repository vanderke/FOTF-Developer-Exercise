using System.Collections.Generic;

namespace FocusOnTheFamily.Models
{
    public class Product
    {
        public System.Guid ProductID { get; set; }
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public short QtyAvail { get; set; }
        public string Authors { get; set; }
        public string ImagePath { get; set; }
        public List<ProductDetail> ProductDetails { get; set; }
    }
}
