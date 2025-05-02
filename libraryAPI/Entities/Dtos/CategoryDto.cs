using libraryAPI.Entities.Model;
using System.ComponentModel.DataAnnotations;

namespace libraryAPI.Entities.Dtos
{
    public record CategoryDto
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
