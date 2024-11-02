using libraryAPI.Data.Repositories;
using libraryAPI.Entities.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace libraryAPI.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class AuthorController : ControllerBase
    {
        private readonly IAuthorRepository _authorRepository;

        public AuthorController(IAuthorRepository authorRepository)
        {
            _authorRepository = authorRepository;
        }
        [HttpPost]
        public async Task<IActionResult> AddAsync([FromForm] AuthorRequest authorRequest)
        {
            var result  = await _authorRepository.AddAuthor(authorRequest);

            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            return Ok(await _authorRepository.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAsync(int id)
        {
            var author = await _authorRepository.GetById(id);
            return author is null  ? NotFound() :  Ok(author);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync(int id , [FromForm] AuthorRequest authorRequest)
        {
            // Retrieve the existing author
            var currentAuthor = await _authorRepository.GetById(id);
            if (currentAuthor is null)
            {
                return NotFound();
            }

            // Perform the update asynchronously
            var updatedAuthor = await _authorRepository.Update(id, authorRequest);

            return Ok(updatedAuthor);
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var author = await _authorRepository.DeleteById(id);
            
            return author != null ? Ok(author) : NotFound();
        }
    }
}
