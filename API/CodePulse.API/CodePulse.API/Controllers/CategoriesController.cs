using CodePulse.API.Data;
using CodePulse.API.Models.Domain;
using CodePulse.API.Models.DTO;
using CodePulse.API.Repositories.Implementation;
using Microsoft.AspNetCore.Mvc;

namespace CodePulse.API.Controllers
{
    // https://localhost:7243/api/categories
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly CategoryRepository _categoryRepository;

        public CategoriesController(CategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        //
        [HttpPost]
        public async Task<IActionResult> CreateCategory(CreateCategoryRequestDto request)
        {
            // Map DTO to Domain Model
            var category = new Category
            {
                Name = request.Name,
                UrlHandle = request.UrlHandle
            };

            await _categoryRepository.CreateAsync(category);

            // domain model to DTO
            var response = new CategoryDto()
            {
                Id = category.Id,
                Name = category.Name,
                UrlHandle = category.UrlHandle
            };

            return Ok(response);
        }
    }
}
