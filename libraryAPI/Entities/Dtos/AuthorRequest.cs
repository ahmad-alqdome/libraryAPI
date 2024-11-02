using libraryAPI.Entities.Model;
using System.ComponentModel.DataAnnotations;

namespace libraryAPI.Entities.Dtos
{
    public class AuthorRequest
    {
        public string Name { get; set; }
        public string Bio { get; set; } = string.Empty;
        public IFormFile AuthorPhoto { get; set; } 
    }
}
