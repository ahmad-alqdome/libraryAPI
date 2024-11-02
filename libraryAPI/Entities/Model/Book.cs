using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;

namespace libraryAPI.Entities.Model
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }

        [Required]
        [MaxLength(200)]
        public string Title { get; set; }

        // Foreign Key to Author
        [ForeignKey("Author")]
        public int AuthorId { get; set; }
        public Author Author { get; set; }

        // Foreign Key to Category
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public ICollection<BorrowRecord> BorrowRecord  { get; set; }


        public byte[] BookPhoto {  get; set; }

        public int PublishedYear { get; set; }

        [MaxLength(13)]
        public string ISBN { get; set; }

        [Required]
        public int Quantity { get; set; }

        
    }
}
