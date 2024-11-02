using libraryAPI.Entities.Dtos;

namespace libraryAPI.Data.Repositories
{
    public interface ICategoyRepository
    {
        Task<CategoryDto> Add(CategoryDto author);
        Task<IList<CategoryDto>> GetAll();
        Task<CategoryDto> GetById(int id);
        Task<CategoryDto> Update(int id, CategoryDto authorRequest);
        Task<CategoryDto> DeleteById(int id);

    }
}
