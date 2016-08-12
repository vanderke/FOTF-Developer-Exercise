using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FocusOnTheFamily.Data.Interfaces;
using FocusOnTheFamily.Data.Repositories;
using FocusOnTheFamily.Models;
using FocusOnTheFamily.Domain.Interfaces;

namespace FocusOnTheFamily.Domain.Processors
{
    public class ContentProcessor : IContentProcessor
    {
        private IContentRepository _repository;

        public ContentProcessor(IContentRepository repository)
        {
            _repository = repository;
        }

        public void DeleteContentStory(int ContentStoryID)
        {
            _repository.DeleteContentStory(ContentStoryID);
        }

        public List<Models.Content> GetContents()
        {
            List<Models.Content> contents = _repository.GetContents();

            return contents;
        }

        public Models.Content GetPageContent(int contentID)
        {
            Models.Content pageContent = _repository.GetPageContent(contentID);

            return pageContent;
        }

        public void UpdateContent(Models.Content content)
        {
            _repository.UpdateContent(content);
        }

        public void UpdateContentStory(Models.ContentStory story)
        {
            _repository.UpdateContentStory(story);
        }
    }
}
