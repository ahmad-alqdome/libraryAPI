using System.ComponentModel.DataAnnotations;

namespace libraryAPI.Entities.Model
{
    public class Member
    {
        [Key]
        public int MemberId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Phone]
        public string PhoneNumber { get; set; }

        [MaxLength(200)]
        public string Address { get; set; }

        // Relationship: one Member can have multiple BorrowRecords
        public ICollection<BorrowRecord> BorrowRecords { get; set; }
    }
}
