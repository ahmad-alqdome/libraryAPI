using FluentValidation;
using libraryAPI.Entities.Dtos;

namespace libraryAPI.Validation
{
    public class AuthorRequestValidator :AbstractValidator<AuthorRequest>
    {
        private const long MaxFileSize = 5 * 1024 * 1024; // 5 MB
        private readonly string[] AllowedFileTypes = { ".jpg", ".jpeg", ".png" };

        public AuthorRequestValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Author name is required.");

            RuleFor(x => x.Bio)
                .NotNull().WithMessage("Author bio cannot be null.");

            RuleFor(x => x.AuthorPhoto)
                .NotNull().WithMessage("No file uploaded.")
                .Must(BeValidSize).WithMessage($"File size exceeds {MaxFileSize / (1024 * 1024)} MB limit.")
                .Must(BeValidType).WithMessage("Unsupported file format. Only JPEG and PNG are allowed.");
        }

        private bool BeValidSize(IFormFile file)
        {
            return file.Length <= MaxFileSize;
        }

        private bool BeValidType(IFormFile file)
        {
            var extension = Path.GetExtension(file.FileName).ToLower();
            return AllowedFileTypes.Contains(extension);
        }
    }
}
