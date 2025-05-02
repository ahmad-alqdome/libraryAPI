namespace libraryAPI.Entities.Dtos
{
    public record AuthorResponse
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Bio { get; set; } = string.Empty;
        public string AuthorPhotoBase64 { get; set; }
    }
}
