using AutoMapper;
using libraryAPI.Entities.Dtos;
using libraryAPI.Entities.Model;
using Microsoft.EntityFrameworkCore;

namespace libraryAPI.Data.Repositories
{
    public class AuthorRepository : IAuthorRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public AuthorRepository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<AuthorRequest> Add(AuthorRequest authorRequest)
        {
            try
            {

                var author = _mapper.Map<Author>(authorRequest);
                // إضافة الكائن   إلى قاعدة البيانات
                await _context.Authors.AddAsync(author);
                await _context.SaveChangesAsync();
            return authorRequest;
            }
            catch (Exception ex)
            {
                throw;
            }

        }


        public async Task<IList<AuthorResponse>> GetAll()
        {
            var authorMapper =  await _context.Authors.ToListAsync();
            var author = _mapper.Map<IList<AuthorResponse>>(authorMapper);

            return author;

        }

        public async Task<AuthorResponse> GetById(int id)
        {
            var authorMapper = await _context.Authors.FindAsync(id);
            if (authorMapper == null)
                return null;
            var author = _mapper.Map<AuthorResponse>(authorMapper);

            return author; 
        }

        public async Task<AuthorResponse> Update(int id, AuthorRequest authorRequest)
        {
            // Retrieve the existing author by ID
            var existingAuthor = await _context.Authors.FindAsync(id);
            if (existingAuthor == null)
            {
                throw new KeyNotFoundException("Author not found");
            }

            // Map the updated values from authorRequest to the existing author
            _mapper.Map(authorRequest, existingAuthor);

            // Save the changes to the database
            await _context.SaveChangesAsync();

            // Map the updated entity to AuthorResponse
            var authorResponse = _mapper.Map<AuthorResponse>(existingAuthor);

            return authorResponse;
        }
        public async Task<AuthorResponse> DeleteById(int id)
        {
            var isExist = await _context.Authors.FindAsync(id);

            if (isExist == null)
                return null;

            _context.Authors.Remove(isExist);
           await _context.SaveChangesAsync();
            var author = _mapper.Map<AuthorResponse>(isExist);

            return author;


        }
    }
}
