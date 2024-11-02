using libraryAPI.Entities.Dtos;

namespace libraryAPI.Data.Repositories
{
    public class BookRepository : IBookRepository
    {
        public Task<BookRequest> Add(BookRequest author)
        {
            throw new NotImplementedException();
        }

        public Task<BookResponse> DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IList<BookResponse>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<BookResponse> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<BookResponse> Update(int id, BookRequest authorRequest)
        {
            throw new NotImplementedException();
        }
    }
}
