using System.ComponentModel.DataAnnotations;

namespace libraryAPI.Entities.Model
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Required]
        [MaxLength(100)]
        public string CategoryName { get; set; }

        // Relationship: one Category can have multiple Members
        public ICollection<Member> Members { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}
