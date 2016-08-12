namespace FocusOnTheFamily.Models
{
    public class ContentStory
    {
        public int ContentStoryID { get; set; }
        public int ContentID { get; set; }
        public string StoryTitle { get; set; }
        public string StoryText { get; set; }
        public string ImagePath { get; set; }
        public System.Guid RelatedProductID { get; set; }
        public short displayOrder { get; set; }
    }
}