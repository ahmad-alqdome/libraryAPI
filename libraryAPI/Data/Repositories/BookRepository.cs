using AutoMapper;
using libraryAPI.Entities.Dtos;
using libraryAPI.Entities.Model;
using Microsoft.EntityFrameworkCore;

namespace libraryAPI.Data.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public BookRepository(IMapper mapper, ApplicationDbContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        public async Task<BookRequest> Add(BookRequest bookRequest)
        {
            var book = _mapper.Map<Book>(bookRequest);
            await _context.Books.AddAsync(book);
            await _context.SaveChangesAsync();
            return bookRequest;
        }

        public async Task<IList<BookResponse>> GetAll()
        {
            var books = await _context.Books
                        .Include(b => b.Author) // Include the Author details
                        .Include(b=>b.Category)
                        .AsNoTracking()
                        .ToListAsync();

            return _mapper.Map<IList<BookResponse>>(books);

          
        }

        public async Task<BookResponse> GetById(int id)
        {
            var book = await _context.Books.Include(b => b.Author) // Include the Author details
 .Include(b => b.Category)
 .AsNoTracking().FirstOrDefaultAsync(x=>x.BookId == id);

            var bookResponse = _mapper.Map<BookResponse>(book);

            return bookResponse ;
        }


        public async Task<BookResponse> Update(int id, BookRequest bookRequest)
        {
            var newBook = _mapper.Map<Book>(bookRequest);
            var book =await  _context.Books.FindAsync(id);
            book=newBook;

            _context.Books.Update(book);
            await _context.SaveChangesAsync();

            return await GetById(id) ;
        
        }
        public async Task<BookResponse> DeleteById(int id)
        {
            var book =await  _context.Books.FindAsync(id);
            _context.Books.Remove(book);    
            _context.SaveChanges();
            
            return await GetById(id);
        }
    }
}
