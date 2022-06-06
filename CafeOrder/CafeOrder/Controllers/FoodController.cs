using CafeOrder.Data;
using CafeOrder.Interfaces;
using CafeOrder.Modals;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CafeOrder.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FoodController : Controller
    {
        private readonly IFoodRepository _foodRepository;

        public FoodController(IFoodRepository foodRepository)
        {
            _foodRepository = foodRepository;
        }

        [HttpGet]
        public async Task<ActionResult<List<Food>>> GetFoods()
        {
            var foods = await _foodRepository.GetFoods();
            return Ok(foods);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Food>> GetFood(int id)
        {
            var foods = await _foodRepository.GetFoodById(id);
            return Ok(foods);
        }

        [HttpGet("category")]
        public async Task<ActionResult<List<FoodCategory>>> GetFoodCategory()
        {
            var foods = await _foodRepository.GetFoodCategory();
            return Ok(foods);
        }

        [HttpGet("region")]
        public async Task<ActionResult<List<FoodCategory>>> GetFoodRegion()
        {
            var foods = await _foodRepository.GetFoodRegion();
            return Ok(foods);
        } 
    }
}

