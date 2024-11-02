using AutoMapper;
using libraryAPI.Entities.Dtos;
using libraryAPI.Entities.Model;
using Microsoft.EntityFrameworkCore;

namespace libraryAPI.Data.Repositories
{
    public class CategoyRepository : ICategoyRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public CategoyRepository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<CategoryDto> Add(CategoryDto categoryDto)
        {
            var category = _mapper.Map<Category>(categoryDto);
            await _context.Categories.AddAsync(category);
            await _context.SaveChangesAsync();
            return categoryDto;
        }

        public Task<CategoryDto> DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IList<CategoryDto>> GetAll()
        {
            var cat = await _context.Categories.AsNoTracking().ToListAsync();
            var Categories = _mapper.Map<IList<CategoryDto>>(cat);
           return  Categories;
        }

        public Task<CategoryDto> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<CategoryDto> Update(int id, CategoryDto authorRequest)
        {
            throw new NotImplementedException();
        }
    }
}
