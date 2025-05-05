using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;

namespace libraryAPI.Entities
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }

  
        public string AuthorId { get; set; }
        public ApplicationUser Author { get; set; }

        public string categoryId { get; set; }
        public Category Category { get; set; }

        public ICollection<BorrowRecord> BorrowRecord  { get; set; }


        public byte[] BookPhoto {  get; set; }

        public int PublishedYear { get; set; }

        public string ISBN { get; set; }

        public int Quantity { get; set; }

        
    }
}
