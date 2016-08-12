using System;
using System.Collections.Generic;
using FocusOnTheFamily.Models;

namespace FocusOnTheFamily.Domain.Interfaces
{
    public interface IProductProcessor
    {
        List<Models.Product> GetProducts();
        Models.Product GetProduct(Guid? id);
        void DeleteProductDetail(int productDetailID);
        void UpdateProductDetail(ProductDetail productDetail);
        void UpdateProduct(Models.Product product);
    }
}
