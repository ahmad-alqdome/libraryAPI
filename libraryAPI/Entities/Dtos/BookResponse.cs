namespace libraryAPI.Entities.Dtos
{
    public record BookResponse
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string AuthorName { get; set; }
        public string  CategoryName{ get; set; }
        public string  BookPhoto { get; set; }
        public int PublishedYear { get; set; }
        public string ISBN { get; set; }
        public int Quantity { get; set; }
    }
}
