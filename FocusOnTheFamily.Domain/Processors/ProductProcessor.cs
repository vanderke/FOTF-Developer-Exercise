using FocusOnTheFamily.Data.Interfaces;
using FocusOnTheFamily.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FocusOnTheFamily.Models;
using FocusOnTheFamily.Domain.Interfaces;

namespace FocusOnTheFamily.Domain.Processors
{
    public class ProductProcessor : IProductProcessor
    {
        private IProductRepository _productRepository;

        public ProductProcessor(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public void DeleteProductDetail(int productDetailID)
        {
            _productRepository.DeleteProductDetail(productDetailID);
        }

        public Models.Product GetProduct(Guid? id)
        {
            Models.Product productDTO = _productRepository.GetProducts(id);

            return productDTO;
        }

        public List<Models.Product> GetProducts()
        {
            List<Models.Product> productsDTO = _productRepository.GetProducts();

            return productsDTO;
        }

        public void UpdateProduct(Models.Product product)
        {
            _productRepository.UpdateProduct(product);
        }

        public void UpdateProductDetail(Models.ProductDetail productDetail)
        {
            _productRepository.UpdateProductDetail(productDetail);
        }
    }
}
