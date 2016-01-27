using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Db
{
    public class Book
    {
        /// <summary>
        /// Gets or sets the id of the book
        /// </summary>
        [Key]
        public int BookId { get; set; }

        /// <summary>
        /// Gets or sets a URL to the books image
        /// </summary>
        public string ImgUrl { get; set; }

        /// <summary>
        /// Gets or sets the title of the book
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the summary of the book
        /// </summary>
        public string Summary { get; set; }

        /// <summary>
        /// Gets or sets the author
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// Gets or sets the blurbs
        /// </summary>
        public virtual ICollection<Blurb> Blurbs { get; set; }
    }
}