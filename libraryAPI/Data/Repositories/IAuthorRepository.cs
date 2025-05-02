using libraryAPI.Entities.Dtos;

namespace libraryAPI.Data.Repositories
{
    public interface IAuthorRepository
    {
        Task<AuthorRequest> Add(AuthorRequest author);
        Task<IList<AuthorResponse>> GetAll();
        Task<AuthorResponse> GetById(int id);
        Task<AuthorResponse> Update(int id, AuthorRequest authorRequest); 
        Task<AuthorResponse> DeleteById(int id);
        

    }
}
