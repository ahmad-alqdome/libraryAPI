using System.ComponentModel.DataAnnotations;

namespace libraryAPI.Entities
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}
