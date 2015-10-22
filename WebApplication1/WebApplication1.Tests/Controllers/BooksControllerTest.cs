using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using WebApplication1.Controllers;
using WebApplication1.Db;

namespace WebApplication1.Tests.Controllers
{
    [TestClass]
    public class BooksControllerTest
    {
        [TestMethod]
        public void GetAllBooks_Empty()
        {
            // Arrange
            var mockBooks = DbTestHelper.CreateMockDbSet(new List<Book>());

            var db = new Moq.Mock<IDataModel>();
            db.Setup(o => o.Books).Returns(mockBooks.Object);

            var controller = new BooksController(db.Object);

            // Act
            var allBooks = controller.GetAllBooks();

            // Assert
            Assert.AreEqual(0, allBooks.Count());
        }

        [TestMethod]
        public void GetAllBooks_NotEmpty()
        {
            // Arrange
            var mockBooks = DbTestHelper.CreateMockDbSet(new List<Book>{ new Book { Title = "A Book"} });

            var db = new Moq.Mock<IDataModel>();
            db.Setup(o => o.Books).Returns(mockBooks.Object);

            var controller = new BooksController(db.Object);

            // Act
            var allBooks = controller.GetAllBooks();

            // Assert
            Assert.AreEqual(1, allBooks.Count());
            Assert.AreEqual("A Book", allBooks.First().Title);
        }

        [TestMethod]
        public void GetBook_NotExists()
        {
            // Arrange
            var mockBooks = DbTestHelper.CreateMockDbSet(new List<Book> { });
            mockBooks.Setup(m => m.Include("Blurbs")).Returns(mockBooks.Object);

            var db = new Moq.Mock<IDataModel>();
            db.Setup(o => o.Books).Returns(mockBooks.Object);
            
            var controller = new BooksController(db.Object);

            // Act
            var book = controller.GetBook(1);

            // Assert
            Assert.IsNull(book);
        }

        [TestMethod]
        public void GetBook_Exists()
        {
            // Arrange
            var mockBooks = DbTestHelper.CreateMockDbSet(new List<Book> { new Book { Title = "Book", BookId = 1}, new Book { Title = "Wrong Book", BookId = 2} });
            
            mockBooks.Setup(m => m.Include("Blurbs")).Returns(mockBooks.Object);

            var db = new Moq.Mock<IDataModel>();
            db.Setup(o => o.Books).Returns(mockBooks.Object);
            
            var controller = new BooksController(db.Object);

            // Act
            var book = controller.GetBook(1);

            // Assert
            Assert.IsNotNull(book);
            Assert.AreEqual("Book", book.Title);
        }
    }
}
