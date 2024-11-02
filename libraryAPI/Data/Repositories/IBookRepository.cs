using libraryAPI.Entities.Dtos;

namespace libraryAPI.Data.Repositories
{
    public interface IBookRepository
    {

        Task<BookRequest> Add(BookRequest author);
        Task<IList<BookResponse>> GetAll();
        Task<BookResponse> GetById(int id);
        Task<BookResponse> Update(int id, BookRequest authorRequest);
        Task<BookResponse> DeleteById(int id);

    }
}
