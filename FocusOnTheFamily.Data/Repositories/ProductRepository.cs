using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FocusOnTheFamily.Data.Interfaces;

namespace FocusOnTheFamily.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private FocusOnTheFamilyEntities _dataContext;

        public ProductRepository()
        {
            _dataContext = new FocusOnTheFamilyEntities();
        }

        #region Public Methods
        public List<Models.Product> GetProducts()
        {
            List<Product> products = _dataContext.Products.ToList();
            List<Models.Product> productsDTO = new List<Models.Product>();

            foreach (Product p in products)
            {
                productsDTO.Add(ConvertProductToDTO(p));
            }

            return productsDTO;
        }

        public Models.Product GetProducts(Guid? id)
        {
            Product product = _dataContext.Products.Where(p => p.ProductID == id).FirstOrDefault();
            Models.Product productDTO = ConvertProductToDTO(product);

            return productDTO;
        }

        public void DeleteProductDetail(int productDetailID)
        {
            ProductDetail entityDetail = _dataContext.ProductDetails.Where(p => p.ProductDetailID == productDetailID).FirstOrDefault();
            if (entityDetail != null)
            {
                _dataContext.ProductDetails.Remove(entityDetail);
                _dataContext.SaveChanges();
            }
        }

        public void UpdateProductDetail(Models.ProductDetail productDetail)
        {
            bool isInsert = false;
            ProductDetail entityDetail = _dataContext.ProductDetails.Where(p => p.ProductDetailID == productDetail.ProductDetailID).FirstOrDefault();
            if (entityDetail == null)
            {
                entityDetail = new ProductDetail()
                {
                    ProductID = productDetail.ProductID,
                };
                isInsert = true;
            }

            entityDetail.DetailSummary = productDetail.DetailSummary;
            entityDetail.DetailTitle = productDetail.DetailTitle;
            entityDetail.DisplayOrder = productDetail.DisplayOrder;

            if (isInsert == true)
                _dataContext.ProductDetails.Add(entityDetail);

            _dataContext.SaveChanges();
        }

        public void UpdateProduct(Models.Product product)
        {
            bool isInsert = false;
            Product entityProduct = _dataContext.Products.Where(p => p.ProductID == product.ProductID).FirstOrDefault();
            if (entityProduct == null)
            {
                entityProduct = new Product();
                isInsert = true;
            }

            entityProduct.ImagePath = product.ImagePath;
            entityProduct.Authors = product.Authors;
            entityProduct.Description = product.Description;
            entityProduct.ISBN = product.ISBN;
            entityProduct.Price = product.Price;
            entityProduct.QtyAvail = product.QtyAvail;
            entityProduct.Summary = product.Summary;
            entityProduct.Title = product.Title;

            if (isInsert == true)
                _dataContext.Products.Add(entityProduct);

            _dataContext.SaveChanges();
        }
        #endregion

        #region Private Methods
        private Models.Product ConvertProductToDTO(Product product)
        {
            List<ProductDetail> productDetails = _dataContext.ProductDetails.Where(p => p.ProductID == product.ProductID).ToList();

            Models.Product productDTO = new Models.Product()
            {
                Authors = product.Authors,
                Description = product.Description,
                ISBN = product.ISBN,
                Price = product.Price,
                ProductID = product.ProductID,
                QtyAvail = product.QtyAvail,
                Summary = product.Summary,
                Title = product.Title,
                ImagePath = product.ImagePath,
                ProductDetails = new List<Models.ProductDetail>()
            };
            foreach (ProductDetail pd in productDetails)
            {
                productDTO.ProductDetails.Add(new Models.ProductDetail()
                {
                    DetailSummary = pd.DetailSummary,
                    DetailTitle = pd.DetailTitle,
                    DisplayOrder = pd.DisplayOrder,
                    ProductDetailID = pd.ProductDetailID,
                    ProductID = pd.ProductID
                });
            }

            return productDTO;
        }
        #endregion
    }
}
