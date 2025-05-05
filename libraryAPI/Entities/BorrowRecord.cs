using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace libraryAPI.Entities
{
    public class BorrowRecord
    {
        public int RecordId { get; set; }

        public int BookId { get; set; }
        public Book Book { get; set; }

        public DateTime BorrowDate { get; set; }

        public DateTime? ReturnDate { get; set; }
    }
}
