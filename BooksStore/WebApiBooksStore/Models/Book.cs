
namespace WebApiBooksStore.Models
{
    public class Book
    {

        public int Id { get; set; }

        public string Chapter { get; set; }

        public string Title { get; set; }

        public string Name { get; set; }

        public string Author { get; set; }

        public string Summary { get; set; }

        public decimal Price { get; set; }
    }
}