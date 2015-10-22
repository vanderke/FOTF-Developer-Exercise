using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Db
{
    /// <summary>
    /// Class representing a blurb about a product
    /// </summary>
    public class Blurb
    {
        /// <summary>
        /// Gets or sets the id
        /// </summary>
        [Key]
        public int BlurbId { get; set; }

        /// <summary>
        /// Gets or sets the title of the blurb
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the summary of the blurb
        /// </summary>
        public string Summary { get; set; }

        /// <summary>
        /// Gets or sets the book id
        /// </summary>
        public int BookId { get; set; }
    }
}