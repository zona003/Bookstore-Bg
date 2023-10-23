namespace Bookstore.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime PublisheDate { get; set; }
        public string BookGenre { get; set; }
        public int AuthorId { get; set; }

        public Author Author { get; set; }
    }
}
