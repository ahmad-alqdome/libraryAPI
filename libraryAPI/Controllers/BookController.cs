using libraryAPI.Contract.Book;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace libraryAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        //private readonly IBookRepository _bookRepository;

        //public BookController(IBookRepository bookRepository)
        //{
        //    _bookRepository = bookRepository;
        //}

        //[HttpPost]
        //public async Task<IActionResult> AddAsync([FromForm]BookRequest bookRequest)
        //{
        //    var books = await _bookRepository.Add(bookRequest);
        //    return Ok(books);
        //}
        //[HttpGet]
        //public async Task<IActionResult> GetAllAsync()
        //{
        //    var book = await _bookRepository.GetAll();
        //    return book is null ? NoContent():Ok(book);
        //}
        //[HttpGet("{id}")]
        //public async Task<IActionResult> GetByIdAsync(int id )
        //{
        //    var book = await _bookRepository.GetById(id);
        //   return book is null ?NoContent() : Ok(book);
        //}
        //[HttpPut("{id}")]
        //public async Task<IActionResult> UpdateAsync(int id , [FromForm] BookRequest bookRequest)
        //{
        //    var newBook = await _bookRepository.Update(id, bookRequest);
        //   return newBook is null ? BadRequest("The Update is invaild") : Ok(newBook);
        //}  

        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteAsync(int id )
        //{
        //    var newBook = await _bookRepository.DeleteById(id);
        //    return newBook is null ? BadRequest("The Delete is invaild") : Ok(newBook);
        //}

    }
}
