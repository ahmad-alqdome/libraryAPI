using System.ComponentModel.DataAnnotations;

namespace libraryAPI.Contract.Author
{
    public record AuthorRequest
    {
        public string Name { get; set; }
        public string Bio { get; set; } = string.Empty;
        public IFormFile AuthorPhoto { get; set; } 
    }
}
