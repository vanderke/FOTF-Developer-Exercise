namespace FocusOnTheFamily.Models
{
    public class ProductDetail
    {
        public int ProductDetailID { get; set; }
        public System.Guid ProductID { get; set; }
        public string DetailTitle { get; set; }
        public string DetailSummary { get; set; }
        public short DisplayOrder { get; set; }
    }
}
