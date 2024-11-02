using libraryAPI.Data.Repositories;
using libraryAPI.Entities.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace libraryAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoyRepository _categoyRepository;

        public CategoryController(ICategoyRepository categoyRepository)
        {
            _categoyRepository = categoyRepository;
        }

        [HttpPost]
        public async Task<IActionResult> AddAsync([FromBody] CategoryDto categoryDto)
        {
            return Ok(await _categoyRepository.Add(categoryDto));

        }
        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            return Ok(await _categoyRepository.GetAll());

        }

    }
}
