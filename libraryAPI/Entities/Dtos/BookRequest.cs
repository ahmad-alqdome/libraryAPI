using libraryAPI.Entities.Model;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace libraryAPI.Entities.Dtos
{
    public record BookRequest
    {
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public int CategoryId { get; set; }
        public IFormFile BookPhoto { get; set; }
        public int PublishedYear { get; set; }
        public string ISBN { get; set; }
        public int Quantity { get; set; }
    }
}
