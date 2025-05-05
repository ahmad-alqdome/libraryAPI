using Microsoft.AspNetCore.Identity;

namespace libraryAPI.Entities
{
    public class ApplicationUser:IdentityUser
    {
        public string FullName { set; get; }
        public string NormalizeFullName => FullName.ToUpper();

        public bool IsDisabled { get; set; }

        public ICollection<Book> Books { get; set; }

    }
}
