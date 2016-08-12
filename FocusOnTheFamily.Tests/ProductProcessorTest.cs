using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FakeItEasy;
using FocusOnTheFamily.Domain.Processors;
using FocusOnTheFamily.Data.Interfaces;

namespace FocusOnTheFamily.Tests
{
    [TestClass]
    public class ProductProcessorTest
    {
        private ProductProcessor _productProcessor;
        private IProductRepository _fakeProductRepository;

        [TestInitialize]
        public void Initialize()
        {
            _fakeProductRepository = A.Fake<IProductRepository>();
            _productProcessor = new ProductProcessor(_fakeProductRepository);
        }


        [TestMethod]
        public void GetProduct_Calls_Repository_GetProducts_WithID()
        {
            //  Arrange
            Guid id = Guid.Empty;

            //  Act
            _productProcessor.GetProduct(id);

            // Assert
            A.CallTo(() => _fakeProductRepository.GetProducts(id)).MustHaveHappened();
        }

        [TestMethod]
        public void GetProducts_Calls_Repository_GetProducts()
        {
            //  Arrange
            //Nothing

            // Act
            _productProcessor.GetProducts();

            // Assert
            A.CallTo(() => _fakeProductRepository.GetProducts()).MustHaveHappened();
        }
    }
}
