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

        public async Task<CategoryDto> DeleteById(int id)
        {
            var item =await  _context.Categories.FindAsync(id);
            var categoryDt=_mapper.Map<CategoryDto>(item);
            return  categoryDt;
        }

        public async Task<IList<CategoryDto>> GetAll()
        {
            var cat = await _context.Categories.AsNoTracking().ToListAsync();
            var Categories = _mapper.Map<IList<CategoryDto>>(cat);
           return  Categories;
        }

   

        public async Task<CategoryDto> Update(int id, CategoryDto categoryDto)
        {
            // Retrieve the existing author by ID
            var existingCategory = await _context.Categories.FindAsync(id);
            if (existingCategory == null)
            {
                throw new KeyNotFoundException("Author not found");
            }

            // Map the updated values from authorRequest to the existing author
            _mapper.Map(categoryDto, existingCategory);

            // Save the changes to the database
            await _context.SaveChangesAsync();

            // Map the updated entity to AuthorResponse
            var categoryResponse = _mapper.Map<CategoryDto>(existingCategory);

            return categoryResponse;
        }
    }
}
