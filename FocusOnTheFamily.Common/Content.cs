using System.Collections.Generic;

namespace FocusOnTheFamily.Models
{
    public class Content
    {
        public int ContentID { get; set; }
        public string Title { get; set; }
        public List<ContentStory> StoryContent { get; set; }
    }
}
