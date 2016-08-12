using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FocusOnTheFamily.Domain.Processors;
using FocusOnTheFamily.Data.Interfaces;
using FakeItEasy;

namespace FocusOnTheFamily.Tests
{
    [TestClass]
    public class ContentProcessorTest
    {
        private ContentProcessor _contentProcessor;
        private IContentRepository _fakeContentRepository;

        [TestInitialize]
        public void Initialize()
        {
            _fakeContentRepository = A.Fake<IContentRepository>();
            _contentProcessor = new ContentProcessor(_fakeContentRepository);
        }

        [TestMethod]
        public void GetContent_Calls_Repository_GetContentWithID()
        {
            //  Arrange
            int id = 1;

            // Act
            _contentProcessor.GetPageContent(id);

            // Assert
            A.CallTo(() => _fakeContentRepository.GetPageContent(id)).MustHaveHappened();
            A.CallTo(() => _fakeContentRepository.GetContents()).MustNotHaveHappened();
        }

        [TestMethod]
        public void GetContent_Calls_Repository_GetContent()
        {
            //  Arrange
            //  Nothing to initialize

            //  Act
            _contentProcessor.GetContents();

            //  Assert
            A.CallTo(() => _fakeContentRepository.GetContents()).MustHaveHappened();
            A.CallTo(() => _fakeContentRepository.GetPageContent(1)).MustNotHaveHappened();
        }
    }
}
