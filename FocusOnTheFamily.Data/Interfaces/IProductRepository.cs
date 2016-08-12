using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FocusOnTheFamily.Data.Interfaces
{
    public interface IProductRepository
    {
        List<Models.Product> GetProducts();
        Models.Product GetProducts(Guid? id);
        void DeleteProductDetail(int productDetailID);
        void UpdateProductDetail(Models.ProductDetail productDetail);
        void UpdateProduct(Models.Product product);
    }
}
