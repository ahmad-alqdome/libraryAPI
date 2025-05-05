using libraryAPI.Contract.Author;
using libraryAPI.Contract.Book;
using libraryAPI.Contract.Category;
using libraryAPI.Entities;

namespace libraryAPI.Mappig
{
    public class ApplicationAutoMapper
    { }
}
//        : Profile
//    {
//        public ApplicationAutoMapper()
//        {
//            // Mapping from AuthorRequest to Author
//            CreateMap<AuthorRequest, Author>()
//                .ForMember(dest => dest.AuthorPhoto, opt => opt.MapFrom(src => ConvertToByteArray(src.AuthorPhoto)));


//            CreateMap<Author, AuthorResponse>()
//                .ForMember(dest => dest.AuthorPhotoBase64, opt => opt.MapFrom(src => src.AuthorPhoto != null ? Convert.ToBase64String(src.AuthorPhoto) : null))
//                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.AuthorId));

//            CreateMap<CategoryDto, Category>()
//                .ForMember(dest=>dest.CategoryId , opt=>opt.MapFrom(src=>src.CategoryId));
//            CreateMap<Category, CategoryDto>();
                
//            CreateMap<BookRequest, Book>()
//                .ForMember(dest =>dest.BookPhoto , opt => opt.MapFrom(src => ConvertToByteArray(src.BookPhoto)));


//            CreateMap<Book, BookResponse>()
//              .ForMember(dest => dest.BookPhoto, opt => opt.MapFrom(src => src.BookPhoto != null ? Convert.ToBase64String(src.BookPhoto) : null))
//              .ForMember(dest => dest.AuthorName, opt => opt.MapFrom(src => src.Author.Name))
//              .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.Category.CategoryName));
//        }

//        private static byte[] ConvertToByteArray(IFormFile file)
//        {
//            if (file == null)
//                return null;

//            using var ms = new MemoryStream();
//            file.CopyTo(ms);
//            return ms.ToArray();
//        }
//    }
//}
