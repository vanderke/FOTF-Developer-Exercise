using System;
using System.Collections.Generic;
using FocusOnTheFamily.Models;

namespace FocusOnTheFamily.Domain.Interfaces
{
    public interface IContentProcessor
    {
        Models.Content GetPageContent(int contentID);
        List<Models.Content> GetContents();
        void UpdateContent(Models.Content content);
        void DeleteContentStory(int ContentStoryID);
        void UpdateContentStory(ContentStory story);
    }
}
