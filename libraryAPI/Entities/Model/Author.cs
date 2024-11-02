using System.ComponentModel.DataAnnotations;

namespace libraryAPI.Entities.Model
{
    public class Author
    {
        [Key]
        public int AuthorId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(500)]
        public string Bio { get; set; } = string.Empty;

        public byte[] AuthorPhoto { get; set; } 

        // Relationship: one Author can have multiple Categories
        public ICollection<Category> Categories { get; set; }
        public ICollection<Book> Book { get; set; }
    }
}
