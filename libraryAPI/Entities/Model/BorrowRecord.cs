using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace libraryAPI.Entities.Model
{
    public class BorrowRecord
    {
        [Key]
        public int RecordId { get; set; }

        // Foreign Key to Books
        [ForeignKey("Book")]
        public int BookId { get; set; }
        public Book Book { get; set; }

        // Foreign Key to Members
        [ForeignKey("Member")]
        public int MemberId { get; set; }
        public Member Member { get; set; }

        [Required]
        public DateTime BorrowDate { get; set; }

        public DateTime? ReturnDate { get; set; }
    }
}
