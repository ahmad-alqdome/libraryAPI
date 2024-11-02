using libraryAPI.Entities.Model;
using System.ComponentModel.DataAnnotations;

namespace libraryAPI.Entities.Dtos
{
    public class CategoryDto
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
