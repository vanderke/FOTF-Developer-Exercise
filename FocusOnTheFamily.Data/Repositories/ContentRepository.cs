using System;
using System.Collections.Generic;
using System.Linq;
using FocusOnTheFamily.Data.Interfaces;

namespace FocusOnTheFamily.Data.Repositories
{
    public class ContentRepository : IContentRepository
    {
        private FocusOnTheFamilyEntities _dataContext;

        public ContentRepository()
        {
            _dataContext = new FocusOnTheFamilyEntities();
        }

        #region Public Methods
        public Models.Content GetPageContent(int contentID)
        {
            Content content = _dataContext.Contents.Where(p => p.ContentID == contentID).FirstOrDefault();
            List<ContentStory> contentStories = _dataContext.ContentStories.Where(p => p.ContentID == contentID).ToList();
            Models.Content pageContent = ConvertContentToDTO(content, contentStories);

            return pageContent;
        }

        public List<Models.Content> GetContents()
        {
            List<Models.Content> contents = new List<Models.Content>();
            List<Content> contentEntities = _dataContext.Contents.ToList();

            foreach(Content c in contentEntities)
            {
                List<ContentStory> contentStories = _dataContext.ContentStories.Where(p => p.ContentID == c.ContentID).ToList();
                contents.Add(ConvertContentToDTO(c, contentStories));
            }

            return contents;
        }

        public void UpdateContent(Models.Content content)
        {
            Content entityContent = _dataContext.Contents.Where(p => p.ContentID == content.ContentID).FirstOrDefault();
            if (entityContent == null)
                entityContent = new Content();

            entityContent.Title = content.Title;

            _dataContext.SaveChanges();
        }

        public void DeleteContentStory(int ContentStoryID)
        {
            ContentStory entityStory = _dataContext.ContentStories.Where(p => p.ContentStoryID == ContentStoryID).FirstOrDefault();
            if (entityStory != null)
            {
                _dataContext.ContentStories.Remove(entityStory);
                _dataContext.SaveChanges();
            }
        }

        public void UpdateContentStory(Models.ContentStory story)
        {
            bool isInsert = false;
            ContentStory entityStory = _dataContext.ContentStories.Where(p => p.ContentStoryID == story.ContentStoryID).FirstOrDefault();
            if (entityStory == null)
            {
                entityStory = new ContentStory()
                {
                    ContentID = story.ContentID,
                };
                isInsert = true;
            }

            entityStory.displayOrder = story.displayOrder;
            entityStory.ImagePath = story.ImagePath;
            entityStory.RelatedProductID = story.RelatedProductID;
            entityStory.StoryText = story.StoryText;
            entityStory.StoryTitle = story.StoryTitle;

            if (isInsert == true)
                _dataContext.ContentStories.Add(entityStory);

            _dataContext.SaveChanges();
        }
        #endregion

        #region Private Methods
        private static Models.Content ConvertContentToDTO(Content content, List<ContentStory> contentStories)
        {
            Models.Content contentDTO = new Models.Content();
            contentDTO.ContentID = content.ContentID;
            contentDTO.Title = content.Title;
            contentDTO.StoryContent = new List<Models.ContentStory>();
            foreach (ContentStory story in contentStories)
            {
                contentDTO.StoryContent.Add(new Models.ContentStory()
                {
                    StoryTitle = story.StoryTitle,
                    StoryText = story.StoryText,
                    ImagePath = story.ImagePath,
                    RelatedProductID = story.RelatedProductID.GetValueOrDefault(),
                    ContentStoryID = story.ContentStoryID,
                    displayOrder = story.displayOrder
                });
            }

            return contentDTO;
        }
        #endregion
    }
}
