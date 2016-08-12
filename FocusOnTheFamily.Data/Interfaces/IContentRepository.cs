using System.Collections.Generic;
using System;
using FocusOnTheFamily.Models;

namespace FocusOnTheFamily.Data.Interfaces
{
    public interface IContentRepository
    {
        Models.Content GetPageContent(int pageContentID);
        List<Models.Content> GetContents();
        void UpdateContent(Models.Content content);
        void DeleteContentStory(int ContentStoryID);
        void UpdateContentStory(Models.ContentStory story);
    }
}
